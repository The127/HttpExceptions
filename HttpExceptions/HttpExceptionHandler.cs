using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HttpExceptions
{
    public static class ServiceExtension
    {
        public static IApplicationBuilder UseHttpExceptions(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseExceptionHandler(a => a.Run(async context =>
            {
                var webHostEnvironment = applicationBuilder.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature?.Error;

                var responseDto = new ErrorResponseDto
                {
                    HttpErrorCode = exception switch
                    {
                        HttpException httpException => (int) httpException.HttpStatusCode,
                        NotImplementedException => (int) HttpStatusCode.NotImplemented,
                        _ => (int) HttpStatusCode.InternalServerError
                    },
                    Description = exception switch
                    {
                        HttpException httpException => !string.IsNullOrWhiteSpace(httpException.Message) ? exception.Message : null,
                        _ => webHostEnvironment.IsDevelopment() ? exception?.Message : null,
                    },
                };

                if (webHostEnvironment.IsDevelopment())
                    responseDto.StackTrace = exception?.StackTrace;

                context.Response.StatusCode = responseDto.HttpErrorCode;
                await context.Response.WriteAsJsonAsync(responseDto);
            }));
            return applicationBuilder;
        }
    }
}
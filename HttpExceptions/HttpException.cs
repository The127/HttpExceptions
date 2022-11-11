using System.Net;

namespace HttpExceptions
{
    public class HttpException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; }

        public HttpException(HttpStatusCode httpStatusCode, string? message = null)
            : base(message)
        {
            HttpStatusCode = httpStatusCode;   
        }
    }

    public class HttpBadRequestException : HttpException
    {
        public HttpBadRequestException(string? message = null) : base(HttpStatusCode.BadRequest, message) { }
    }

    public class HttpUnauthorizedException : HttpException
    {
        public HttpUnauthorizedException(string? message = null) : base(HttpStatusCode.Unauthorized, message) { }
    }

    public class HttpPaymentRequiredException : HttpException
    {
        public HttpPaymentRequiredException(string? message = null) : base(HttpStatusCode.PaymentRequired, message) { }
    }

    public class HttpForbiddenException : HttpException
    {
        public HttpForbiddenException(string? message = null) : base(HttpStatusCode.Forbidden, message) { }
    }

    public class HttpNotFoundException : HttpException
    {
        public HttpNotFoundException(string? message = null) : base(HttpStatusCode.NotFound, message) { }
    }

    public class HttpMethodNotAllowedException : HttpException
    {
        public HttpMethodNotAllowedException(string? message = null) : base(HttpStatusCode.MethodNotAllowed, message) { }
    }

    public class HttpNotAcceptableException : HttpException
    {
        public HttpNotAcceptableException(string? message = null) : base(HttpStatusCode.NotAcceptable, message) { }
    }

    public class HttpProxyAuthenticationRequiredException : HttpException
    {
        public HttpProxyAuthenticationRequiredException(string? message = null) : base(HttpStatusCode.ProxyAuthenticationRequired, message) { }
    }

    public class HttpRequestTimeoutException : HttpException
    {
        public HttpRequestTimeoutException(string? message = null) : base(HttpStatusCode.RequestTimeout, message) { }
    }

    public class HttpConflictException : HttpException
    {
        public HttpConflictException(string? message = null) : base(HttpStatusCode.Conflict, message) { }
    }

    public class HttpGoneException : HttpException
    {
        public HttpGoneException(string? message = null) : base(HttpStatusCode.Gone, message) { }
    }

    public class HttpInternalServerErrorException : HttpException
    {
        public HttpInternalServerErrorException(string? message = null) : base(HttpStatusCode.InternalServerError, message) { }
    }

    public class HttpBadGatewayException : HttpException
    {
        public HttpBadGatewayException(string? message = null) : base(HttpStatusCode.BadGateway, message) { }
    }

    public class HttpServiceUnavailableException : HttpException
    {
        public HttpServiceUnavailableException(string? message = null) : base(HttpStatusCode.ServiceUnavailable, message) { }
    }

    public class HttpGatewayTimeoutException : HttpException
    {
        public HttpGatewayTimeoutException(string? message = null) : base(HttpStatusCode.GatewayTimeout, message) { }
    }

    public class HttpHttpVersionNotSupportedException : HttpException
    {
        public HttpHttpVersionNotSupportedException(string? message = null) : base(HttpStatusCode.HttpVersionNotSupported, message) { }
    }

    public class HttpVariantAlsoNegotiatesException : HttpException
    {
        public HttpVariantAlsoNegotiatesException(string? message = null) : base(HttpStatusCode.VariantAlsoNegotiates, message) { }
    }

    public class HttpInsufficientStorageException : HttpException
    {
        public HttpInsufficientStorageException(string? message = null) : base(HttpStatusCode.InsufficientStorage, message) { }
    }

    public class HttpLoopDetectedException : HttpException
    {
        public HttpLoopDetectedException(string? message = null) : base(HttpStatusCode.LoopDetected, message) { }
    }

    public class HttpBandwidthLimitExceededException : HttpException
    {
        public HttpBandwidthLimitExceededException(string? message = null) : base((HttpStatusCode)509, message) { }
    }

    public class HttpNotExtendedException : HttpException
    {
        public HttpNotExtendedException(string? message = null) : base(HttpStatusCode.NotExtended, message) { }
    }

    public class HttpNetworkAuthenticationRequiredException : HttpException
    {
        public HttpNetworkAuthenticationRequiredException(string? message = null) : base(HttpStatusCode.NetworkAuthenticationRequired, message) { }
    }
}
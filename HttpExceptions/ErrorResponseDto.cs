namespace HttpExceptions
{
    public sealed class ErrorResponseDto
    {
        public int HttpErrorCode { get; set; }
        public string? Description { get; set; }
        public string? StackTrace { get; set; }
    }
}
namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int stausCode, string message, string details)
        {
            StausCode = stausCode;
            Message = message;
            Details = details;
        }

        public int StausCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}
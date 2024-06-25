namespace LockerFloorFinder.Service
{
    public class ApiResponseService<T>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string? Error { get; set; }
        public T Data { get; set; }

        public ApiResponseService(string status, string message, string? error, T data)
        {
            Status = status;
            Message = message;
            Error = error;
            Data = data;
        }
    }
}

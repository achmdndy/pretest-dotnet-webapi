using LockerFloorFinder.Service;

namespace LockerFloorFinder.Helpers
{
    public static class ResponseHelper
    {
        public static ApiResponseService<T> CreateResponse<T>(string status, string message, string? error, T data)
        {
            return new ApiResponseService<T>(status, message, error, data);
        }
    }
}

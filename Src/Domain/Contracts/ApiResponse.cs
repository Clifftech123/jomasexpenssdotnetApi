
namespace jomasexpenssdotnetApi.Src.Domain.Contract
{

    /// <summary>
    /// ApiResponse is a generic class used to standardize API responses.
    /// It contains properties for success status, message, and data.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public required T Data { get; set; }

        /// <summary>
        /// Creates a success response with data and an optional message.
        /// This method is used to return successful API responses with the provided data.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static ApiResponse<T> CreateSuccessResponse(T data, string message = "Operation successful")
        {
            return new ApiResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        /// <summary>
        /// Creates an error response with a message.
        /// This method is used to return error API responses with the provided message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static ApiResponse<T> CreateErrorResponse(string message)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Message = message,
                Data = default!
            };
        }

    }
}
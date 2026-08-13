namespace DMS.Application.Common.Responses
{
   public class Response
   {
      public bool IsSuccess { get; init; }
      public string? Message { get; init; }

      public static Response Success()
         => new()
         {
            IsSuccess = true
         };

      public static Response Failure(string message)
         => new()
         {
            IsSuccess = false,
            Message = message
         };
   }
   public class Response<T>
   {
      public bool IsSuccess { get; init; }
      public string? Message { get; init; }
      public T? Data {  get; init; }

      public static Response<T> Success(T data) => new() { IsSuccess = true, Data = data };

      public static Response<T> Failure(string message) => new() { IsSuccess = false, Message = message };
   }
}

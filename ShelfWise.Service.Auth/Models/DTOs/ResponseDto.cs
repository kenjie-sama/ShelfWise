namespace ShelfWise.Service.Auth.Models.DTOs
{
  public class ResponseDto
  {
    public object? Result { get; set; } = null;
    public bool IsSuccess { get; set; } = true;
    public string Message { get; set; } = string.Empty;

    public static ResponseDto Success(string message, object result) => new ResponseDto { Message = message, IsSuccess = true, Result = result };
    public static ResponseDto Fail(string message) => new ResponseDto { Message = message, IsSuccess = true, Result = null };
  }

  public class ResponseDto<T> : ResponseDto where T : class
  {
    public new T? Result
    {
      get => (T?)base.Result;
      set => base.Result = value;
    }
  }
}

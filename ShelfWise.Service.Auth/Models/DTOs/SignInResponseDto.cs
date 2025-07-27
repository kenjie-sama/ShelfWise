namespace ShelfWise.Service.Auth.Models.DTOs
{
  public class SignInResponseDto
  {
    public AccountDto Account { get; set; } = null;
    public string Token { get; set; } = "";
  }
}

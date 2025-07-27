namespace ShelfWise.Service.Auth.Models.DTOs
{
  public class SignUpRequestDto
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Role { get; set; }
  }
}

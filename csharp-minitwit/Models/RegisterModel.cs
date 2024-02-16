namespace csharp_minitwit.Models
{
    public class RegisterModel
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Password2 { get; set; }
    }
}
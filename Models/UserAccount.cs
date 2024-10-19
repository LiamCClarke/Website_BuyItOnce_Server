namespace BuyItOnce.Server.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

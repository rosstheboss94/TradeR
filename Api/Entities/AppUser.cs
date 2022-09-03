namespace Api.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Journal> Journals { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
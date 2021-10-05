using Microsoft.AspNetCore.Http;

namespace AccountManagement.Application.Contracts.Account
{
    public class CreateAccount
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public long RuleId { get; set; }
        public IFormFile ProfilePhoto { get; set; }
    }
}

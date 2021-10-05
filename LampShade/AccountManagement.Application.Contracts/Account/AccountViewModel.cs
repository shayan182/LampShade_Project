namespace AccountManagement.Application.Contracts.Account
{
    public class AccountViewModel
    {
        public long Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public long RuleId { get; set; }
        public string Rule { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
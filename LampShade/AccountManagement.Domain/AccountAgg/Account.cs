using _0_Framework.Domain;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public long RuleId { get; private set; }
        public string ProfilePhoto { get; private set; }

        public Account(string fullname, string username, string password, string mobile,
            long ruleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;
            RuleId = ruleId;
            ProfilePhoto = profilePhoto;
        }
        public void Edit(string fullname, string username,  string mobile,
                   long ruleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
            RuleId = ruleId;
            if(!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}

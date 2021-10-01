using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace CommentManagement.Application.Contracts.Comment
{
    public class AddComment
    {
       // [Required(ErrorMessage = ValidationMessages.IsRequired)] 
        public string Name { get; set; }
        //[Required(ErrorMessage = ValidationMessages.IsRequired)]
        //[EmailAddress(ErrorMessage = ValidationMessages.InvalidEmailFormat)]
        public string Email { get; set; }
        //[Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Message { get; set; }
        public string Website { get; set; }
        //[Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long OwnerRecordId { get; set; }
        //[Range(0, 3, ErrorMessage = ValidationMessages.IsRequired)]
        public int Type { get; set; }
        public long? ParentId { get; set; }
    }
}

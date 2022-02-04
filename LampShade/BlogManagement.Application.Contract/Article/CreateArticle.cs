using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Application.Contract.Article
{
    public class CreateArticle
    {
        [MaxLength(500, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [FileExtensionLimitation(new string[] { "image/jpeg", "image/png" }, ErrorMessage = ValidationMessages.InvalidFileFormat)]
        [MaxFileSize(3, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile Picture { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PublishDate { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        [MaxLength(100, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [MaxLength(150, ErrorMessage = ValidationMessages.MaxFileSize)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [MaxLength(1000, ErrorMessage = ValidationMessages.MaxFileSize)]
        public string CanonicalAddress { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get; set; }
    }
}

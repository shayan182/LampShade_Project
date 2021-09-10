using Microsoft.AspNetCore.Http;

namespace _0_Framework.Application
{
    public interface IFileUploader
    {
        string Uploader(IFormFile file , string path);
    }
}

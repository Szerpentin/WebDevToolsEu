using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebDevTools.Common.Models
{
    public class ImageResizeRequest
    {
        public IFormFile FormFile { get; set; }
        public int NewWidth { get; set; }
        public int NewHeight { get; set; }
    }
}

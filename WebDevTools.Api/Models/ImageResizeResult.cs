using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevTools.Api.Models
{
    public class ImageResizeResult
    {
        public MemoryStream ImageMemoryStream { get; set; }
        public string MimeType { get; set; }
    }
}

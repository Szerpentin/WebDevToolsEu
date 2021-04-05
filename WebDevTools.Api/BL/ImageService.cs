using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Threading.Tasks;
using WebDevTools.Api.Models;

namespace WebDevTools.Api.BL
{
    public class ImageService
    {
        public async Task<ImageResizeResult> Resize(Stream imageStream, int newWidth, int newHeight)
        {
            Image img = null;
            IImageFormat format;
            (img, format) = await Image.LoadWithFormatAsync(imageStream);
            img.Mutate(x => x.Resize(newWidth, newHeight));
            MemoryStream ms = new MemoryStream();
            img.Save(ms, format);
            return new ImageResizeResult { ImageMemoryStream = ms, MimeType = format.DefaultMimeType };
        }
    }
}


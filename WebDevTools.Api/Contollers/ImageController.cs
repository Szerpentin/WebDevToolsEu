using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebDevTools.Api.BL;
using WebDevTools.Common.Models;

namespace WebDevTools.Api.Contollers
{
    [Route("image")]
    public class ImageController : ApiController
    {
        [HttpPost]
        [Route("resize")]
        public async Task<ActionResult<byte[]>> Resize(ImageResizeRequest imageResizeRequest)
        {
            ImageService imageService = new ImageService();
            var iamgeResizeresult = await imageService.Resize(imageResizeRequest.FormFile.OpenReadStream(), imageResizeRequest.NewWidth, imageResizeRequest.NewHeight);

            return File(iamgeResizeresult.ImageMemoryStream.ToArray(), iamgeResizeresult.MimeType);
        }
    }
}

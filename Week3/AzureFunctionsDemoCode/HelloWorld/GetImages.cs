using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Azure.Storage.Blobs;
using System.Collections.Generic;
using Azure.Storage.Blobs.Specialized;

namespace HelloWorld
{
    public static class GetImages
    {
        [FunctionName("GetImages")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            [Blob("images-vc/temp.jpg", FileAccess.Write)] BlockBlobClient imageBlob,
            [Blob("images-tn-vc/temp.jpg", FileAccess.Write)] BlockBlobClient tnBlob,
            ILogger log)
        {
            var response = new ImageList();

            BlobContainerClient imageContainerClient = imageBlob.GetParentBlobContainerClient();
            foreach (var item in imageContainerClient.GetBlobs())
            {
                response.FullSizeImages.Add(String.Concat(imageContainerClient.Uri.ToString(),"/", item.Name));
            }

            BlobContainerClient tnContainerClient = tnBlob.GetParentBlobContainerClient();
            foreach (var item in tnContainerClient.GetBlobs())
            {
                response.ThumbnailImages.Add(String.Concat(tnContainerClient.Uri.ToString(),"/", item.Name));
            }

            return new OkObjectResult(response);
        }
    }
    public class ImageList
    {
        public List<string> FullSizeImages=new List<string>();
        public List<string> ThumbnailImages=new List<string>();
    }
}

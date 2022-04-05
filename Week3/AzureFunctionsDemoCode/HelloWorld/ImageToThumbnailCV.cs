using System;
using System.IO;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;


namespace HelloWorld
{
    public class ImageToThumbnailCV
    {
        [FunctionName("ImageToThumbnailCV")]
        public void Run([BlobTrigger("images-vc/{name}")]Stream myBlob, 
            string name,
            [Blob("images-tn-vc/{name}",FileAccess.Write)]Stream tnBlob,
            ILogger log)
        {
            //create authenticated CV Client
            string endpoint = System.Environment.GetEnvironmentVariable("endpoint");
            string subscriptionKey = System.Environment.GetEnvironmentVariable("subscriptionKey");

            ComputerVisionClient client =
             new ComputerVisionClient(new ApiKeyServiceClientCredentials(subscriptionKey))
             { Endpoint = endpoint };

            string sourceImageUrl = Path.Combine(System.Environment.GetEnvironmentVariable("containerPath"),name) ;

            log.LogInformation($"Source Image:{sourceImageUrl}");
            try
            {
                client.GenerateThumbnailAsync(180, 180, sourceImageUrl, smartCropping: true).Result.CopyToAsync(tnBlob);
            }
            catch (Exception)
            {

                using (Image image = Image.Load(myBlob))
                {
                    image.Mutate(x => x
                            .Resize(new ResizeOptions
                            {
                                Mode = ResizeMode.BoxPad,
                                Size = new Size(800)
                            }).BackgroundColor(new Rgba32(0, 0, 0)));

                    using (var ms = new MemoryStream())
                    {
                        image.Save(ms,new JpegEncoder());
                        client.GenerateThumbnailInStreamAsync(180, 180, ms, true).Result.CopyTo(tnBlob);
                    }
                    
                }

            }
            

            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
        

    }
}

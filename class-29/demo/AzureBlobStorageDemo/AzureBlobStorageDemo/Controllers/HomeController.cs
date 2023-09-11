using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using AzureBlobStorageDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureBlobStorageDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            BlobContainerClient blobContainerClient =
                new BlobContainerClient(_configuration.GetConnectionString("StorageAccount"), "images");

            // Create if images container not exist 
            await blobContainerClient.CreateIfNotExistsAsync();


            BlobClient blobClient = blobContainerClient.GetBlobClient(file.FileName);

            using var fileStream = file.OpenReadStream();

            BlobUploadOptions blobUploadOptions = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders { ContentType = file.ContentType }
            };

            if (!blobClient.Exists())
            {
                await blobClient.UploadAsync(fileStream, blobUploadOptions);
            }
           

            Document document = new Document()
            {
                Name = file.Name,
                Type = file.ContentType,
                Size = file.Length,
                Url = blobClient.Uri.ToString()
            };


            ///
            /// Save to the database
            /// name , price, url

            return View("Index", document);
        }












        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
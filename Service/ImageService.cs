using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using Service.Interfaces;

namespace Service;

public class ImageService : IImageService
{
    private readonly BlobContainerClient _imageContainer;

    public ImageService()
    {
        // I could not figure out how to add the conn string the proper way (returning null), so was forced to hardcode it.
        //string connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage")!;

        _imageContainer = new BlobContainerClient("UseDevelopmentStorage=true", "image");
    }

    public string GetUrl(string imageName)
    {
        BlobClient blob = _imageContainer.GetBlobClient(imageName);
        return blob.GenerateSasUri(BlobSasPermissions.Read, DateTimeOffset.UtcNow.AddHours(1)).ToString();
    }
}

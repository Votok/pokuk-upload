# pokuk-upload
Simple console app for azure pokuk gallery photos upload

Add **appsettings.json** file with the following keys:

- **LocalGalleryDirectory**: local gallery root directory path
- **GalleryJsonName**: gallery schema json file that is created localy and saved to azure blob
- **AzureContainerName**: name of the blob container where the photos are
- **AzureContainerUrl**: azure blob container base url
- **AzureStorageConnectionString**: azure storage connection string 

**Example:**
```sh
{
  "LocalGalleryDirectory": "./../../SomeGallery",
  "GalleryJsonName": "_gallery.json",
  "AzureContainerName": "somecontainer",
  "AzureContainerUrl": "https://somestorage.blob.core.windows.net/somecontainer/",
  "AzureStorageConnectionString": "DefaultEndpointsProtocol=https;AccountName=***storage;AccountKey=***;EndpointSuffix=***"
}
```

**Local gallery directory structure:**
Somegallery/
- 2017 
    - 20170107SomeEventName1
        - __Some Event Friendly Name.txt
        - photo1.jpg
        - photo2.jpg
        - ...
    - 20170613SomeEventName2
    - ...

- 2018
    - ...

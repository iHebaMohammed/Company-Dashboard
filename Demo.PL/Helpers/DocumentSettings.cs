using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Demo.PL.Helpers
{
    public static class DocumentSettings
    {
        public async static Task<string> UploadFile(IFormFile file , string folderName)
        {
            ///Steps Of Uploading file
            ///1. Get located foulder parh
            ///2. Get file name and make it uniqe
            ///3. Get file path
            ///4. Save file as stream ==> (Stream) is a Date Per Time

            //1.Get Located Folder Path:
            //string folderPath = "E:\\Repos\\Projects\\RouteDemoMVC\\Demo.PL\\wwwroot\\files\\images\\";
            //string folderPath = Directory.GetCurrentDirectory() + "\\wwwroot\\files\\" + folderName;
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);

            //2. Get File Name and make it uniqe
            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            //3. Get File Path
            string filePath = Path.Combine(folderPath , fileName);

            //4. Save File As Straem .. Stream is a Date Per Time
            using var fs = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fs);

            //5. Return File Name
            return fileName;
        }

        public static void DeleteFile(string fileName , string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
            if(File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}

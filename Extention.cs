using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConnectFrontToBack
{
    public static class Extention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
        public static bool MaxLengh(this IFormFile file, int kb)
        {
            return file.Length / 1024 >= kb;
        }
        public async static Task<string> SaveImage(this IFormFile file, string paths, string folder)
        {
            string path = Path.Combine(paths, folder);
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(path, fileName);
            using(FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}

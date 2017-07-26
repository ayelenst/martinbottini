using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Dashboard.Models
{
    public static class ImageHelper
    {
        public static string SaveImage(string folder, HttpPostedFileBase file, string serverMap)
        {
            var fileName = Path.GetFileName(file.FileName); //getting only file name(ex-ganesh.jpg)  
            var ext = Path.GetExtension(file.FileName); //getting the extension(ex-.jpg)  
            string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension      
            System.IO.Directory.CreateDirectory(Path.Combine(serverMap, folder));


            var path = Path.Combine(serverMap, folder, fileName);
            file.SaveAs(path);
            return Path.Combine(folder,fileName);
        }

        public static void DeleteImage(string path)
        {
            
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
}
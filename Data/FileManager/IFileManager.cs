using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Data.FileManager
{
    public interface IFileManager
    {
        FileStream ImageStream(string image);
        Task<string> UploadImage(IFormFile image);
        bool RemoveImage(string image);
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoSauce.MagicScaler;

namespace Fin.Data.FileManager
{
    public class FileManager : IFileManager
    {
        private string _imagePath;

        public FileManager(IConfiguration config)
        {
            _imagePath = config["Path:Images"];
        }

        public FileStream ImageStream(string image)
        {
            return new FileStream(Path.Combine(_imagePath, image), FileMode.Open, FileAccess.Read);
        }

        public bool RemoveImage(string image)
        {
            try
            {

                var file = Path.Combine(_imagePath, image);
                if (File.Exists(file))
                    File.Delete(file);
                return true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<string> UploadImage(IFormFile image)
        {
            try
            {
                var save_path = Path.Combine(_imagePath);
                if (Directory.Exists(save_path))
                {
                    Directory.CreateDirectory(save_path);

                }
                //var filename = image.FileName; error for internet explorer
                var mime = image.FileName.Substring(image.FileName.LastIndexOf('.'));
                var filename = $"img {DateTime.Now:dd-MM-yyyy-HH-mm-ss}{mime}";

                using (var fileStream = new FileStream(Path.Combine(save_path, filename), FileMode.Create, FileAccess.Write))

                {
                    await image.CopyToAsync(fileStream);
                    MagicImageProcessor.ProcessImage(image.OpenReadStream(),fileStream, ImageOptions());
                }

                

                return filename;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Eror";
            }
        }

        private ProcessImageSettings ImageOptions() => new ProcessImageSettings
        {
            Width = 700,
            Height = 500,
            ResizeMode = CropScaleMode.Crop,
            SaveFormat = FileFormat.Jpeg,
            JpegQuality = 100,
            JpegSubsampleMode = ChromaSubsampleMode.Subsample420,

        };
    }
}
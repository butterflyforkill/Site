using Fin.Data.FileManager;
using Fin.Data.FileManager.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public HomeController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;

        }
        public IActionResult Index(int pageNumber, string category)
        {
            if (pageNumber < 1)
                return RedirectToAction("Index", new { pageNumber = 1, category });

            var vm = _repo.GetAllPosts(pageNumber, category);
            return View(vm);
        }
        public IActionResult Post(int id)=> View(_repo.GetPost(id));

         public IActionResult Contacts()=>View(_repo.GetAllContacts());

         [HttpGet("/Image/{image}")]
         [ResponseCache(CacheProfileName ="Monthly")]
        public IActionResult Image(string image) =>new FileStreamResult(
            _fileManager.ImageStream(image),
            $"image/{image.Substring(image.LastIndexOf('.') + 1)}");

      
    }
}

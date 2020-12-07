using Fin.Data.FileManager.Repository;
using Fin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Controllers
{
    public class TalkFormController : Controller
    {
        private IRepository _repo;

        public TalkFormController(IRepository repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Index(TalkForm talkForm)
        {

            _repo.AddTalkForm(talkForm);

            await _repo.SaveChangesAsync();

            return RedirectToAction("Index", "Home");

        }
    }
}

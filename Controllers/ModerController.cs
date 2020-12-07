using Fin.Data.FileManager.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Controllers
{
    [Authorize(Roles = "Admin")]

    public class ModerController : Controller
    {
        private IRepository _repo;

        public ModerController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var talkForms = _repo.GetAllTalkForms();
            return View(talkForms);
        }
        public IActionResult FullTalkForm(int id)
        {
            var talkForm = _repo.GetTalkForm(id);

            return View(talkForm);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemoveTalkForm(id);

            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

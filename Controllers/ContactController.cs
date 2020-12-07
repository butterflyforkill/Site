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
    public class ContactController : Controller
    {
        private IRepository _repo;

        public ContactController(IRepository repo)
        {
            _repo = repo;
        }
        //Contacts

        [HttpGet]
        public IActionResult EditContact(int? id)
        {
            if (id == null)
            {
                return View(new Contact());
            }
            else
            {
                var contact = _repo.GetContact((int)id);

                return View(contact);


            }

        }
        [HttpPost]
        public async Task<IActionResult> EditContact(Contact contact)
        {

            if (contact.Id > 0)
                _repo.UpdateContact(contact);
            else

                _repo.AddContact(contact);

            if (await _repo.SaveChangesAsync())

                return RedirectToAction("Index","Panel");
            else


                return View(contact);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemoveContact(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index","Panel" );
        }
    }
}

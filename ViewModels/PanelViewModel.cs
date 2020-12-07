using Fin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.ViewModels
{
    public class PanelViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Contact> Contacts{ get; set; }
    }
}

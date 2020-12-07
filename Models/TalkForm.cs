using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Models
{
    public class TalkForm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Mail { get; set; }

        public string NameOfDoctor { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string Message { get; set; }
    }
}

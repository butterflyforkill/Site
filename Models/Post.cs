using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string Text { get; set; }
        public string Category { get; set; }

        public string Image { get; set; }
    }
}

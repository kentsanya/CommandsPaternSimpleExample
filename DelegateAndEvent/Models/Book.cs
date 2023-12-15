using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FullNameAuthor { get; set; }
        public string Description { get; set; }

        public int CountPage { get; set; }
    }
}

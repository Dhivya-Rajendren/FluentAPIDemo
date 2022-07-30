using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo.Models
{
    public class Book
    {
        public string BookCode { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public string SupplierId { get; set; }
    }
}

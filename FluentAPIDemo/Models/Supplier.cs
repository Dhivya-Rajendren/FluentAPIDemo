using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo.Models
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int IsActive { get; set; }
    }
}

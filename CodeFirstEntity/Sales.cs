using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity
{
    internal class Sales
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public int Amount {get; set;}
        public DateTime SellDate { get; set; }

        public Customer customers { get; set; }
        public Book books { get; set; }
    }
}

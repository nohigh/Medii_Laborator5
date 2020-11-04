using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nohai_Dragos_Lab5.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }
    }
}

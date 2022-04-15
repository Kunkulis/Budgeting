using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting
{
    public class BudgetModel
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
    }
}

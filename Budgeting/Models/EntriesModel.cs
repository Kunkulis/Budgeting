using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting.Models
{
    public class EntriesModel
    {
        public DateTime EntryDate { get; set; }
        public int EntryCategory { get; set; }
        public int EntrySubCategory { get; set; }
        public float EntryAmount { get; set; }
        public string EntryComment { get; set; }
    }
}

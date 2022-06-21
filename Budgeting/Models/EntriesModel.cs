using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting.Models
{
    public class EntriesModel
    {
        public bool Delete { get; set; } = false;
        public DateTime EntryDate { get; set; }
        public string EntryCategory { get; set; }
        public string EntrySubCategory { get; set; }
        public float EntryAmount { get; set; }
        public string EntryComment { get; set; }
    }
}

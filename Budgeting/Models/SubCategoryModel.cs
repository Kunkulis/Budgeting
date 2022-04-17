using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting
{
    public class SubCategoryModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string SubCategory { get; set; }
    }
}

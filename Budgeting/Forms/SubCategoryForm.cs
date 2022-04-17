using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting
{
    public partial class SubCategoryForm : Form
    {
        List<SubCategoryModel> subCategory = new List<SubCategoryModel>();
        List<CategoryModel> category = new List<CategoryModel>();
        public SubCategoryForm()
        {
            InitializeComponent();
            category = SqLiteDataAccess.LoadCategory();
            subCategory = SqLiteDataAccess.LoadSubCategory();

            var bindingCategory = new BindingList<CategoryModel>(category);
            var source = new BindingSource(bindingCategory, null);

            var bindingSubCategory = new BindingList<SubCategoryModel>(subCategory);
            var subSource = new BindingSource(bindingSubCategory, null);

            dgv_CategoryTempl.DataSource = source;
            dgv_SubCategory.DataSource = subSource;
        }

        private void bt_SaveSubCateg_Click(object sender, EventArgs e)
        {
            SqLiteDataAccess.SaveSubCategory(dgv_SubCategory);
        }
    }
}

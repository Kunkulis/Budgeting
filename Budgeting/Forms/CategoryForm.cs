using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Budgeting.Models;

namespace Budgeting
{
    public partial class CategoryForm : Form
    {
        List<CategoryModel> category = new List<CategoryModel>();
        MainForm _mainForm;
        public CategoryForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            category = SqLiteDataAccess.LoadCategory();
            var bindingCategory = new BindingList<CategoryModel>(category);
            var source = new BindingSource(bindingCategory,null);

            dgv_category.DataSource = source;            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            SqLiteDataAccess.SaveCategory(dgv_category);
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.PerformRefresh();
        }        
    }
}

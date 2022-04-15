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
    public partial class Form2 : Form
    {
        List<CategoryModel> category = new List<CategoryModel>();
        public Form2()
        {
            InitializeComponent();
            category = SqLiteDataAccess.LoadCategory();
            var bindingCategory = new BindingList<CategoryModel>(category);
            var source = new BindingSource(bindingCategory,null);

            dgv_category.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            SqLiteDataAccess.SaveEntry(dgv_category);
        }
    }
}

using System.ComponentModel;
using System.Data;
using System.Data.SQLite;

namespace Budgeting
{
    public partial class MainForm : Form
    {        
        List<BudgetModel> budgets = new List<BudgetModel>();
        List<CategoryModel> categories = new List<CategoryModel>();
        public MainForm()
        {
            InitializeComponent();
            PerformRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            budgets = SqLiteDataAccess.LoadBudget();
            var bindingBudgets = new BindingList<BudgetModel>(budgets);
            var source = new BindingSource(bindingBudgets,null);            

            //dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ent = new BudgetModel();

            ent.Date = DateTime.Now;
            ent.Amount = 0;
            ent.Category = "Test";
            ent.SubCategory = "SubTest";            

            SqLiteDataAccess.SaveEntry(ent);
        }

        private void bt_chngCetegory_Click(object sender, EventArgs e)
        {
            CategoryForm f2 = new CategoryForm(this);
            f2.ShowDialog();
        }

        private void bt_amendSubCategories_Click(object sender, EventArgs e)
        {
            SubCategoryForm f3 = new SubCategoryForm();
            f3.ShowDialog();
        }

        public void PerformRefresh()
        {
            this.categories = SqLiteDataAccess.LoadCategory();
            var categoryList = categories.Select(x => x.Category).ToList();
            var bindingCategory = new BindingSource();
            bindingCategory.DataSource = categoryList;

            cb_category.DataSource = bindingCategory.DataSource;
        }
    }
}

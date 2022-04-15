using System.ComponentModel;
using System.Data;
using System.Data.SQLite;

namespace Budgeting
{
    public partial class Form1 : Form
    {
        //List<BudgetModel> budgets= new List<BudgetModel>();
        List<BudgetModel> budgets = new List<BudgetModel>();
        public Form1()
        {
            InitializeComponent();
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
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}

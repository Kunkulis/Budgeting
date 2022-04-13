using System.Data;
using System.Data.SQLite;

namespace Budgeting
{
    public partial class Form1 : Form
    {
        List<BudgetModel> budgets= new List<BudgetModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            budgets = SqLiteDataAccess.LoadBudget();

            SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\Alvis\source\repos\Budgeting\DB\budget.db");
            conn.Open();
            var query = "SELECT * from test";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
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
    }
}

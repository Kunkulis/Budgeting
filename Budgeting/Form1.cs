using System.Data;
using System.Data.SQLite;

namespace Budgeting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\Alvis\source\repos\Budgeting\DB\budget.db");
            conn.Open();
            var query = "SELECT * from test";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }                
    }
}
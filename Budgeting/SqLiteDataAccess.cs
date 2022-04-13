using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Budgeting
{
    public class SqLiteDataAccess
    {
        public static List<BudgetModel> LoadBudget()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BudgetModel>("select * from test",new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveEntry (BudgetModel entry)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into test (Date, Category, SubCategory, Amount, Comment) values (@Date, @Category, @SubCategory, @Amount, @Comment)",entry);
            }
        }

        private static string LoadConnectionString (string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

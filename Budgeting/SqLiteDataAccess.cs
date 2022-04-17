using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                var output = cnn.Query<BudgetModel>("select * from test", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<SubCategoryModel> LoadSubCategory()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SubCategoryModel>("select * from SubCategory", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategory()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("select * from Category", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void SaveSubCategory(DataGridView dgv_SubCategory)
        {
            ClearDB("SubCategory");
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = cnn;
                    cnn.Open();
                    for (int i = 0; i < dgv_SubCategory.RowCount - 1; i++)
                    {
                        cmd.CommandText = $"INSERT INTO SubCategory (ID, ParentID, SubCategory) VALUES ({dgv_SubCategory.Rows[i].Cells["Id"].Value},{dgv_SubCategory.Rows[i].Cells["ParentId"].Value},'{dgv_SubCategory.Rows[i].Cells["SubCategory"].Value}')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void SaveCategory(DataGridView dgv_category)
        {
            ClearDB("Category");
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = cnn;
                    cnn.Open();                    
                    for (int i = 0; i < dgv_category.RowCount-1; i++)
                    {
                        cmd.CommandText= $"INSERT INTO Category (ID, Category) VALUES ({dgv_category.Rows[i].Cells["Id"].Value},'{dgv_category.Rows[i].Cells["Category"].Value}')";                                                                 
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void ClearDB(string db)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.CommandText = $"DELETE FROM {db}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveEntry(BudgetModel entry)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into test (Date, Category, SubCategory, Amount, Comment) values (@Date, @Category, @SubCategory, @Amount, @Comment)", entry);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

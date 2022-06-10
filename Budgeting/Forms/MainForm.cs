﻿using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using Budgeting.Models;

namespace Budgeting
{
    public partial class MainForm : Form
    {
        List<CategoryModel> categories = new List<CategoryModel>();
        List<SubCategoryModel> subCategories = new List<SubCategoryModel>();
        List<EntriesModel> entries = new List<EntriesModel>();
        public MainForm()
        {
            InitializeComponent();
            PerformRefresh();
            InitializeEntries();
        }

        private void InitializeEntries()
        {
            //TODO: Fix the binding
            entries = SqLiteDataAccess.LoadEntries();
            var bindingBudgets = new BindingList<EntriesModel>(entries);
            var source = new BindingSource(bindingBudgets, null);

            dgv_Entries.DataSource = source;
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

            UpdateSubCategory();
        }

        public void UpdateSubCategory()
        {
            var selected = categories.Where(x => x.Category == cb_category.SelectedItem).FirstOrDefault();

            this.subCategories = SqLiteDataAccess.LoadSubCategory();
            var subCategoryList = subCategories.Where(x => x.ParentId == selected.Id).Select(y => y.SubCategory).ToList();
            var bindingSubCategory = new BindingSource();
            bindingSubCategory.DataSource = subCategoryList;

            cb_subCategory.DataSource = bindingSubCategory.DataSource;
        }

        public void cb_category_SelectedIndexChanged(object sender, EventArgs e) => UpdateSubCategory();

        private void tb_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            var ent = new EntriesModel();

            ent.EntryAmount = float.Parse(tb_Amount.Text);
            ent.EntrySubCategory= subCategories.Where(x => x.SubCategory == cb_subCategory.SelectedItem).FirstOrDefault().Id;
            ent.EntryCategory=categories.Where(x => x.Category == cb_category.SelectedItem).FirstOrDefault().Id;
            ent.EntryComment = tb_Comment.Text;
            ent.EntryDate = dtp_EntrieDate.Value;

            SqLiteDataAccess.SaveEntry(ent);

            tb_Amount.Clear();
            tb_Comment.Clear();
        }
    }
}

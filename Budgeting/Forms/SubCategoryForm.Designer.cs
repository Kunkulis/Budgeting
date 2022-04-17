namespace Budgeting
{
    partial class SubCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_CategoryTempl = new System.Windows.Forms.DataGridView();
            this.dgv_SubCategory = new System.Windows.Forms.DataGridView();
            this.bt_SaveSubCateg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryTempl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CategoryTempl
            // 
            this.dgv_CategoryTempl.AllowUserToAddRows = false;
            this.dgv_CategoryTempl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CategoryTempl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CategoryTempl.Location = new System.Drawing.Point(412, 12);
            this.dgv_CategoryTempl.Name = "dgv_CategoryTempl";
            this.dgv_CategoryTempl.ReadOnly = true;
            this.dgv_CategoryTempl.RowHeadersVisible = false;
            this.dgv_CategoryTempl.RowTemplate.Height = 25;
            this.dgv_CategoryTempl.Size = new System.Drawing.Size(193, 317);
            this.dgv_CategoryTempl.TabIndex = 0;
            // 
            // dgv_SubCategory
            // 
            this.dgv_SubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SubCategory.Location = new System.Drawing.Point(12, 12);
            this.dgv_SubCategory.Name = "dgv_SubCategory";
            this.dgv_SubCategory.RowTemplate.Height = 25;
            this.dgv_SubCategory.Size = new System.Drawing.Size(363, 618);
            this.dgv_SubCategory.TabIndex = 1;
            // 
            // bt_SaveSubCateg
            // 
            this.bt_SaveSubCateg.Location = new System.Drawing.Point(682, 12);
            this.bt_SaveSubCateg.Name = "bt_SaveSubCateg";
            this.bt_SaveSubCateg.Size = new System.Drawing.Size(167, 63);
            this.bt_SaveSubCateg.TabIndex = 2;
            this.bt_SaveSubCateg.Text = "Save Changes";
            this.bt_SaveSubCateg.UseVisualStyleBackColor = true;
            this.bt_SaveSubCateg.Click += new System.EventHandler(this.bt_SaveSubCateg_Click);
            // 
            // SubCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 642);
            this.Controls.Add(this.bt_SaveSubCateg);
            this.Controls.Add(this.dgv_SubCategory);
            this.Controls.Add(this.dgv_CategoryTempl);
            this.Name = "SubCategoryForm";
            this.Text = "SubCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryTempl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SubCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_CategoryTempl;
        private DataGridView dgv_SubCategory;
        private Button bt_SaveSubCateg;
    }
}

namespace Budgeting
{
    partial class CategoryForm
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
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(33, 27);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowTemplate.Height = 25;
            this.dgv_category.Size = new System.Drawing.Size(348, 347);
            this.dgv_category.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Categories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_category);
            this.Name = "CategoryForm";
            this.Text = "Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_category;
        private Button button1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}

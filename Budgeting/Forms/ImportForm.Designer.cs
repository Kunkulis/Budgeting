namespace Budgeting.Forms
{
    partial class ImportForm
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
            this.dgv_excelImport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excelImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_excelImport
            // 
            this.dgv_excelImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_excelImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_excelImport.Location = new System.Drawing.Point(0, 0);
            this.dgv_excelImport.Name = "dgv_excelImport";
            this.dgv_excelImport.RowTemplate.Height = 25;
            this.dgv_excelImport.Size = new System.Drawing.Size(745, 647);
            this.dgv_excelImport.TabIndex = 0;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 647);
            this.Controls.Add(this.dgv_excelImport);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excelImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_excelImport;
    }
}

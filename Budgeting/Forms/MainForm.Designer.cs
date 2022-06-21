namespace Budgeting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Entries = new System.Windows.Forms.TabPage();
            this.dgv_Entries = new System.Windows.Forms.DataGridView();
            this.AddExpence = new System.Windows.Forms.TabPage();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.cb_subCategory = new System.Windows.Forms.ComboBox();
            this.bt_amendSubCategories = new System.Windows.Forms.Button();
            this.bt_chngCetegory = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dtp_EntrieDate = new System.Windows.Forms.DateTimePicker();
            this.lb_subCategory = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_comment = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bt_DeleteEntries = new System.Windows.Forms.Button();
            this.Entries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entries)).BeginInit();
            this.AddExpence.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1157, 615);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Entries
            // 
            this.Entries.Controls.Add(this.bt_DeleteEntries);
            this.Entries.Controls.Add(this.dgv_Entries);
            this.Entries.Location = new System.Drawing.Point(4, 24);
            this.Entries.Name = "Entries";
            this.Entries.Padding = new System.Windows.Forms.Padding(3);
            this.Entries.Size = new System.Drawing.Size(1157, 615);
            this.Entries.TabIndex = 2;
            this.Entries.Text = "Entries";
            this.Entries.UseVisualStyleBackColor = true;
            // 
            // dgv_Entries
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Entries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Entries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Entries.Location = new System.Drawing.Point(0, 47);
            this.dgv_Entries.Name = "dgv_Entries";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Entries.RowTemplate.Height = 25;
            this.dgv_Entries.Size = new System.Drawing.Size(1154, 568);
            this.dgv_Entries.TabIndex = 0;
            // 
            // AddExpence
            // 
            this.AddExpence.Controls.Add(this.tb_Comment);
            this.AddExpence.Controls.Add(this.tb_Amount);
            this.AddExpence.Controls.Add(this.cb_subCategory);
            this.AddExpence.Controls.Add(this.bt_amendSubCategories);
            this.AddExpence.Controls.Add(this.bt_chngCetegory);
            this.AddExpence.Controls.Add(this.cb_category);
            this.AddExpence.Controls.Add(this.statusStrip1);
            this.AddExpence.Controls.Add(this.dtp_EntrieDate);
            this.AddExpence.Controls.Add(this.lb_subCategory);
            this.AddExpence.Controls.Add(this.lb_amount);
            this.AddExpence.Controls.Add(this.lb_comment);
            this.AddExpence.Controls.Add(this.lb_category);
            this.AddExpence.Controls.Add(this.lb_date);
            this.AddExpence.Controls.Add(this.bt_Add);
            this.AddExpence.Location = new System.Drawing.Point(4, 24);
            this.AddExpence.Name = "AddExpence";
            this.AddExpence.Padding = new System.Windows.Forms.Padding(3);
            this.AddExpence.Size = new System.Drawing.Size(1157, 615);
            this.AddExpence.TabIndex = 0;
            this.AddExpence.Text = "Add Expence";
            this.AddExpence.UseVisualStyleBackColor = true;
            // 
            // tb_Comment
            // 
            this.tb_Comment.Location = new System.Drawing.Point(191, 234);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(200, 100);
            this.tb_Comment.TabIndex = 15;
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(191, 179);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(200, 23);
            this.tb_Amount.TabIndex = 14;
            this.tb_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Amount_KeyPress);
            // 
            // cb_subCategory
            // 
            this.cb_subCategory.FormattingEnabled = true;
            this.cb_subCategory.Location = new System.Drawing.Point(191, 131);
            this.cb_subCategory.Name = "cb_subCategory";
            this.cb_subCategory.Size = new System.Drawing.Size(200, 23);
            this.cb_subCategory.TabIndex = 13;
            // 
            // bt_amendSubCategories
            // 
            this.bt_amendSubCategories.Location = new System.Drawing.Point(986, 113);
            this.bt_amendSubCategories.Name = "bt_amendSubCategories";
            this.bt_amendSubCategories.Size = new System.Drawing.Size(141, 36);
            this.bt_amendSubCategories.TabIndex = 12;
            this.bt_amendSubCategories.Text = "Amend Sub-Categories";
            this.bt_amendSubCategories.UseVisualStyleBackColor = true;
            this.bt_amendSubCategories.Click += new System.EventHandler(this.bt_amendSubCategories_Click);
            // 
            // bt_chngCetegory
            // 
            this.bt_chngCetegory.Location = new System.Drawing.Point(1004, 60);
            this.bt_chngCetegory.Name = "bt_chngCetegory";
            this.bt_chngCetegory.Size = new System.Drawing.Size(124, 36);
            this.bt_chngCetegory.TabIndex = 11;
            this.bt_chngCetegory.Text = "Amend Categories";
            this.bt_chngCetegory.UseVisualStyleBackColor = true;
            this.bt_chngCetegory.Click += new System.EventHandler(this.bt_chngCetegory_Click);
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(191, 81);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(200, 23);
            this.cb_category.TabIndex = 10;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1151, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // dtp_EntrieDate
            // 
            this.dtp_EntrieDate.Location = new System.Drawing.Point(191, 35);
            this.dtp_EntrieDate.Name = "dtp_EntrieDate";
            this.dtp_EntrieDate.Size = new System.Drawing.Size(200, 23);
            this.dtp_EntrieDate.TabIndex = 8;
            // 
            // lb_subCategory
            // 
            this.lb_subCategory.AutoSize = true;
            this.lb_subCategory.Location = new System.Drawing.Point(39, 134);
            this.lb_subCategory.Name = "lb_subCategory";
            this.lb_subCategory.Size = new System.Drawing.Size(75, 15);
            this.lb_subCategory.TabIndex = 7;
            this.lb_subCategory.Text = "SubCategory";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(39, 182);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(51, 15);
            this.lb_amount.TabIndex = 6;
            this.lb_amount.Text = "Amount";
            // 
            // lb_comment
            // 
            this.lb_comment.AutoSize = true;
            this.lb_comment.Location = new System.Drawing.Point(39, 237);
            this.lb_comment.Name = "lb_comment";
            this.lb_comment.Size = new System.Drawing.Size(61, 15);
            this.lb_comment.TabIndex = 5;
            this.lb_comment.Text = "Comment";
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Location = new System.Drawing.Point(39, 89);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(55, 15);
            this.lb_category.TabIndex = 4;
            this.lb_category.Text = "Category";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(39, 43);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(31, 15);
            this.lb_date.TabIndex = 3;
            this.lb_date.Text = "Date";
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(1052, 21);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.AddExpence);
            this.tabControl1.Controls.Add(this.Entries);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // bt_DeleteEntries
            // 
            this.bt_DeleteEntries.Location = new System.Drawing.Point(1012, 6);
            this.bt_DeleteEntries.Name = "bt_DeleteEntries";
            this.bt_DeleteEntries.Size = new System.Drawing.Size(113, 35);
            this.bt_DeleteEntries.TabIndex = 1;
            this.bt_DeleteEntries.Text = "Delete Selected";
            this.bt_DeleteEntries.UseVisualStyleBackColor = true;
            this.bt_DeleteEntries.Click += new System.EventHandler(this.bt_DeleteEntries_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Budgetting";
            this.Entries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entries)).EndInit();
            this.AddExpence.ResumeLayout(false);
            this.AddExpence.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage4;
        private TabPage Entries;
        private TabPage AddExpence;
        private ComboBox cb_category;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private DateTimePicker dtp_EntrieDate;
        private Label lb_subCategory;
        private Label lb_amount;
        private Label lb_comment;
        private Label lb_category;
        private Label lb_date;
        private Button bt_Add;
        private TabControl tabControl1;
        private Button bt_chngCetegory;
        private Button bt_amendSubCategories;
        private ComboBox cb_subCategory;
        private TextBox tb_Amount;
        private TextBox tb_Comment;
        private DataGridView dgv_Entries;
        private Button bt_DeleteEntries;
    }
}

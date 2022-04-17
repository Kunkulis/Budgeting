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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AddExpence = new System.Windows.Forms.TabPage();
            this.bt_chngCetegory = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_subCategory = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_comment = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bt_amendSubCategories = new System.Windows.Forms.Button();
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1157, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AddExpence
            // 
            this.AddExpence.Controls.Add(this.bt_amendSubCategories);
            this.AddExpence.Controls.Add(this.bt_chngCetegory);
            this.AddExpence.Controls.Add(this.cb_category);
            this.AddExpence.Controls.Add(this.statusStrip1);
            this.AddExpence.Controls.Add(this.dateTimePicker1);
            this.AddExpence.Controls.Add(this.lb_subCategory);
            this.AddExpence.Controls.Add(this.lb_amount);
            this.AddExpence.Controls.Add(this.lb_comment);
            this.AddExpence.Controls.Add(this.lb_category);
            this.AddExpence.Controls.Add(this.lb_date);
            this.AddExpence.Controls.Add(this.button2);
            this.AddExpence.Location = new System.Drawing.Point(4, 24);
            this.AddExpence.Name = "AddExpence";
            this.AddExpence.Padding = new System.Windows.Forms.Padding(3);
            this.AddExpence.Size = new System.Drawing.Size(1157, 615);
            this.AddExpence.TabIndex = 0;
            this.AddExpence.Text = "Add Expence";
            this.AddExpence.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 8;
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
            this.lb_comment.Location = new System.Drawing.Point(39, 242);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1052, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.AddExpence);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 643);
            this.tabControl1.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Budgetting";
            this.AddExpence.ResumeLayout(false);
            this.AddExpence.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage AddExpence;
        private ComboBox cb_category;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private DateTimePicker dateTimePicker1;
        private Label lb_subCategory;
        private Label lb_amount;
        private Label lb_comment;
        private Label lb_category;
        private Label lb_date;
        private Button button2;
        private TabControl tabControl1;
        private Button bt_chngCetegory;
        private Button bt_amendSubCategories;
    }
}

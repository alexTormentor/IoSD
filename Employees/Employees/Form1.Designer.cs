namespace Employees
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorksFrom = new System.Windows.Forms.DateTimePicker();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Family = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteDtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.StatisticBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Отчество";
            // 
            // LastName
            // 
            this.LastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastName.Location = new System.Drawing.Point(0, 13);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(240, 20);
            this.LastName.TabIndex = 30;
            // 
            // Gender
            // 
            this.Gender.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.Gender.Location = new System.Drawing.Point(0, 13);
            this.Gender.Margin = new System.Windows.Forms.Padding(2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(240, 21);
            this.Gender.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Работает с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фамилия";
            // 
            // WorksFrom
            // 
            this.WorksFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorksFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.WorksFrom.Location = new System.Drawing.Point(0, 13);
            this.WorksFrom.Margin = new System.Windows.Forms.Padding(2);
            this.WorksFrom.Name = "WorksFrom";
            this.WorksFrom.Size = new System.Drawing.Size(240, 20);
            this.WorksFrom.TabIndex = 23;
            // 
            // BirthDate
            // 
            this.BirthDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(0, 13);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(240, 20);
            this.BirthDate.TabIndex = 22;
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameBox.Location = new System.Drawing.Point(0, 13);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(240, 20);
            this.NameBox.TabIndex = 21;
            // 
            // Family
            // 
            this.Family.Dock = System.Windows.Forms.DockStyle.Top;
            this.Family.Location = new System.Drawing.Point(0, 13);
            this.Family.Margin = new System.Windows.Forms.Padding(2);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(240, 20);
            this.Family.TabIndex = 20;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AutoSize = true;
            this.UpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdateBtn.Location = new System.Drawing.Point(0, 258);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(240, 23);
            this.UpdateBtn.TabIndex = 19;
            this.UpdateBtn.Text = "Редактировать";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.Update);
            // 
            // DeleteDtn
            // 
            this.DeleteDtn.AutoSize = true;
            this.DeleteDtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteDtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteDtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteDtn.Location = new System.Drawing.Point(0, 281);
            this.DeleteDtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDtn.Name = "DeleteDtn";
            this.DeleteDtn.Size = new System.Drawing.Size(240, 23);
            this.DeleteDtn.TabIndex = 18;
            this.DeleteDtn.Text = "Удалить";
            this.DeleteDtn.UseVisualStyleBackColor = false;
            this.DeleteDtn.Click += new System.EventHandler(this.Delete);
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddBtn.Location = new System.Drawing.Point(0, 304);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(240, 23);
            this.AddBtn.TabIndex = 17;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.Add);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGrid.Location = new System.Drawing.Point(240, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(475, 327);
            this.dataGrid.TabIndex = 16;
            this.dataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMouseDouble);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGridSelect);
            // 
            // StatisticBtn
            // 
            this.StatisticBtn.AutoSize = true;
            this.StatisticBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StatisticBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StatisticBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatisticBtn.Location = new System.Drawing.Point(0, 235);
            this.StatisticBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StatisticBtn.Name = "StatisticBtn";
            this.StatisticBtn.Size = new System.Drawing.Size(240, 23);
            this.StatisticBtn.TabIndex = 32;
            this.StatisticBtn.Text = "Статистика";
            this.StatisticBtn.UseVisualStyleBackColor = false;
            this.StatisticBtn.Click += new System.EventHandler(this.Statistic);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Family);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 39);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 38);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LastName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 39);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Gender);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 41);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BirthDate);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 41);
            this.panel5.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.WorksFrom);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 39);
            this.panel6.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(715, 327);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatisticBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteDtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker WorksFrom;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox Family;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteDtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button StatisticBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}


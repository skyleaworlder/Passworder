using System.Text.Json;
using System.Text.Json.Serialization;

namespace Passworder
{
    partial class Main
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
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.insertPasswordBtn = new System.Windows.Forms.Button();
            this.modifyPasswordBtn = new System.Windows.Forms.Button();
            this.deletePasswordBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.insertPasswordBtn);
            this.passwordGroupBox.Controls.Add(this.modifyPasswordBtn);
            this.passwordGroupBox.Controls.Add(this.deletePasswordBtn);
            this.passwordGroupBox.Controls.Add(this.panel1);
            this.passwordGroupBox.Location = new System.Drawing.Point(12, 12);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(776, 426);
            this.passwordGroupBox.TabIndex = 0;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
            this.passwordGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // insertPasswordBtn
            // 
            this.insertPasswordBtn.Location = new System.Drawing.Point(402, 378);
            this.insertPasswordBtn.Name = "insertPasswordBtn";
            this.insertPasswordBtn.Size = new System.Drawing.Size(113, 38);
            this.insertPasswordBtn.TabIndex = 3;
            this.insertPasswordBtn.Text = "新增";
            this.insertPasswordBtn.UseVisualStyleBackColor = true;
            this.insertPasswordBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // modifyPasswordBtn
            // 
            this.modifyPasswordBtn.Location = new System.Drawing.Point(524, 378);
            this.modifyPasswordBtn.Name = "modifyPasswordBtn";
            this.modifyPasswordBtn.Size = new System.Drawing.Size(113, 38);
            this.modifyPasswordBtn.TabIndex = 2;
            this.modifyPasswordBtn.Text = "修改";
            this.modifyPasswordBtn.UseVisualStyleBackColor = true;
            this.modifyPasswordBtn.Click += new System.EventHandler(this.modifyPasswordBtn_Click);
            // 
            // deletePasswordBtn
            // 
            this.deletePasswordBtn.Location = new System.Drawing.Point(645, 378);
            this.deletePasswordBtn.Name = "deletePasswordBtn";
            this.deletePasswordBtn.Size = new System.Drawing.Size(113, 38);
            this.deletePasswordBtn.TabIndex = 1;
            this.deletePasswordBtn.Text = "删除";
            this.deletePasswordBtn.UseVisualStyleBackColor = true;
            this.deletePasswordBtn.Click += new System.EventHandler(this.deletePasswordBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordDataGridView);
            this.panel1.Location = new System.Drawing.Point(19, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 343);
            this.panel1.TabIndex = 0;
            // 
            // passwordDataGridView
            // 
            this.passwordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passwordDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.passwordDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.passwordDataGridView.ColumnHeadersHeight = 29;
            this.passwordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.passwordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordDataGridView.Location = new System.Drawing.Point(0, 0);
            this.passwordDataGridView.Name = "passwordDataGridView";
            this.passwordDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.passwordDataGridView.RowHeadersVisible = false;
            this.passwordDataGridView.RowHeadersWidth = 51;
            this.passwordDataGridView.RowTemplate.Height = 29;
            this.passwordDataGridView.Size = new System.Drawing.Size(737, 343);
            this.passwordDataGridView.TabIndex = 0;
            this.passwordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "Title (Key)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PasswordHint";
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Password Hint (Value)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordGroupBox);
            this.Name = "Main";
            this.Text = "Passworder";
            this.passwordGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeData()
        {
            string filePath = @"D:\tmp\data.json";
            string json = File.ReadAllText(filePath);
            this.dataGridViewColumn = JsonSerializer.Deserialize<PasswordData>(json);
            this.passwordDataGridView.DataSource = this.dataGridViewColumn.Columns;
        }

        public bool InsertPasswordData(string title, string passwordHint)
        {
            PasswordColumnData data = this.dataGridViewColumn.Columns.Find(col => { return col.Title == title; });
            if (data != null)
            {
                return false;
            }

            // memory
            PasswordColumnData newData = new PasswordColumnData();
            newData.Title = title;
            newData.PasswordHint = passwordHint;
            this.dataGridViewColumn.Columns.Add(newData);

            // disk
            string filePath = @"D:\tmp\data.json";
            string content = JsonSerializer.Serialize<PasswordData>(dataGridViewColumn);
            File.WriteAllText(filePath, content);

            // reload
            this.InitializeData();
            return true;
        }

        public bool UpdatePasswordData(string originTitle, string title, string passwordHint)
        {
            PasswordColumnData data = this.dataGridViewColumn.Columns.Find(col => { return col.Title == originTitle; });
            if (data == null)
            {
                return false;
            }

            // memory
            foreach (var columnData in this.dataGridViewColumn.Columns)
            {
                if (columnData.Title == originTitle)
                {
                    columnData.Title = title;
                    columnData.PasswordHint = passwordHint;
                }
            }

            // disk
            string filePath = @"D:\tmp\data.json";
            string content = JsonSerializer.Serialize<PasswordData>(dataGridViewColumn);
            File.WriteAllText(filePath, content);

            // reload
            this.InitializeData();
            return true;
        }

        private bool DeletePasswordData(PasswordColumnData data)
        {
            // memory
            if (!this.dataGridViewColumn.Columns.Remove(data))
            {
                return false;
            }

            // disk
            string filePath = @"D:\tmp\data.json";
            string content = JsonSerializer.Serialize<PasswordData>(dataGridViewColumn);
            File.WriteAllText(filePath, content);

            // reload
            this.InitializeData();
            return true;
        }

        private GroupBox passwordGroupBox;
        private Panel panel1;
        private DataGridView passwordDataGridView;
        private Button insertPasswordBtn;
        private Button modifyPasswordBtn;
        private Button deletePasswordBtn;

        private PasswordData dataGridViewColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
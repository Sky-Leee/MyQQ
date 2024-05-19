namespace myqq
{
    partial class AddFriends
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.comboBox_age = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_tishi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "输入QQ号码/昵称查找";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(481, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "性别";
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Location = new System.Drawing.Point(61, 46);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(85, 28);
            this.comboBox_sex.TabIndex = 3;
            this.comboBox_sex.Text = "不限";
            // 
            // comboBox_age
            // 
            this.comboBox_age.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_age.FormattingEnabled = true;
            this.comboBox_age.Location = new System.Drawing.Point(212, 46);
            this.comboBox_age.Name = "comboBox_age";
            this.comboBox_age.Size = new System.Drawing.Size(85, 28);
            this.comboBox_age.TabIndex = 5;
            this.comboBox_age.Text = "不限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(169, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "年龄";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 364);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "QQ号码";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "昵称";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "年龄";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "添加方式";
            this.columnHeader5.Width = 170;
            // 
            // label_tishi
            // 
            this.label_tishi.AutoSize = true;
            this.label_tishi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tishi.ForeColor = System.Drawing.Color.Gray;
            this.label_tishi.Location = new System.Drawing.Point(331, 49);
            this.label_tishi.Name = "label_tishi";
            this.label_tishi.Size = new System.Drawing.Size(135, 20);
            this.label_tishi.TabIndex = 7;
            this.label_tishi.Text = "双击列表添加好友哦";
            this.label_tishi.Visible = false;
            // 
            // AddFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.label_tishi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_sex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddFriends";
            this.Text = "好友查找";
            this.Load += new System.EventHandler(this.AddFriends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.ComboBox comboBox_age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label_tishi;
    }
}
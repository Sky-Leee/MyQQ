namespace myqq
{
    partial class FindPwsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_change = new System.Windows.Forms.Button();
            this.label_yizhi = new System.Windows.Forms.Label();
            this.textBox_pwd2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_kong = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_yanz = new System.Windows.Forms.Button();
            this.textBox_pwdA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pwdQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QQ账号";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(135, 38);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(207, 21);
            this.textBox_user.TabIndex = 1;
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.Transparent;
            this.button_select.Location = new System.Drawing.Point(368, 36);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(69, 22);
            this.button_select.TabIndex = 2;
            this.button_select.Text = "查询";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_yanz);
            this.groupBox1.Controls.Add(this.textBox_pwdA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_pwdQ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QQ密保";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_change);
            this.groupBox2.Controls.Add(this.label_yizhi);
            this.groupBox2.Controls.Add(this.textBox_pwd2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label_kong);
            this.groupBox2.Controls.Add(this.textBox_pwd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(17, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 182);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新的密码";
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.Transparent;
            this.button_change.Enabled = false;
            this.button_change.Location = new System.Drawing.Point(87, 99);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(206, 30);
            this.button_change.TabIndex = 11;
            this.button_change.Text = "更改密码";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_yizhi
            // 
            this.label_yizhi.AutoSize = true;
            this.label_yizhi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_yizhi.ForeColor = System.Drawing.Color.Red;
            this.label_yizhi.Location = new System.Drawing.Point(300, 63);
            this.label_yizhi.Name = "label_yizhi";
            this.label_yizhi.Size = new System.Drawing.Size(105, 14);
            this.label_yizhi.TabIndex = 13;
            this.label_yizhi.Text = "两次密码不一致";
            this.label_yizhi.Visible = false;
            // 
            // textBox_pwd2
            // 
            this.textBox_pwd2.Enabled = false;
            this.textBox_pwd2.Location = new System.Drawing.Point(87, 60);
            this.textBox_pwd2.Name = "textBox_pwd2";
            this.textBox_pwd2.PasswordChar = '*';
            this.textBox_pwd2.Size = new System.Drawing.Size(207, 23);
            this.textBox_pwd2.TabIndex = 12;
            this.textBox_pwd2.Leave += new System.EventHandler(this.textBox_pwd2_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "确认密码";
            // 
            // label_kong
            // 
            this.label_kong.AutoSize = true;
            this.label_kong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_kong.ForeColor = System.Drawing.Color.Red;
            this.label_kong.Location = new System.Drawing.Point(300, 28);
            this.label_kong.Name = "label_kong";
            this.label_kong.Size = new System.Drawing.Size(91, 14);
            this.label_kong.TabIndex = 10;
            this.label_kong.Text = "密码不能为空";
            this.label_kong.Visible = false;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Enabled = false;
            this.textBox_pwd.Location = new System.Drawing.Point(87, 25);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(207, 23);
            this.textBox_pwd.TabIndex = 9;
            this.textBox_pwd.Leave += new System.EventHandler(this.textBox_pwd_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "新密码";
            // 
            // button_yanz
            // 
            this.button_yanz.BackColor = System.Drawing.Color.Transparent;
            this.button_yanz.Enabled = false;
            this.button_yanz.Location = new System.Drawing.Point(162, 126);
            this.button_yanz.Name = "button_yanz";
            this.button_yanz.Size = new System.Drawing.Size(206, 30);
            this.button_yanz.TabIndex = 7;
            this.button_yanz.Text = "验证";
            this.button_yanz.UseVisualStyleBackColor = false;
            this.button_yanz.Click += new System.EventHandler(this.button_yanz_Click);
            // 
            // textBox_pwdA
            // 
            this.textBox_pwdA.Enabled = false;
            this.textBox_pwdA.Location = new System.Drawing.Point(162, 92);
            this.textBox_pwdA.Name = "textBox_pwdA";
            this.textBox_pwdA.Size = new System.Drawing.Size(207, 26);
            this.textBox_pwdA.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的密保答案";
            // 
            // textBox_pwdQ
            // 
            this.textBox_pwdQ.Enabled = false;
            this.textBox_pwdQ.Location = new System.Drawing.Point(162, 44);
            this.textBox_pwdQ.Name = "textBox_pwdQ";
            this.textBox_pwdQ.Size = new System.Drawing.Size(207, 26);
            this.textBox_pwdQ.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "我的密保问题";
            // 
            // FindPwsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label1);
            this.Name = "FindPwsForm";
            this.Text = "找回密码";
            this.Load += new System.EventHandler(this.FindPwsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label_yizhi;
        private System.Windows.Forms.TextBox textBox_pwd2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_kong;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_yanz;
        private System.Windows.Forms.TextBox textBox_pwdA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pwdQ;
        private System.Windows.Forms.Label label2;
    }
}
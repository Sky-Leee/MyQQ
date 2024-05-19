namespace myqq
{
    partial class newQQForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_pict = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NickName = new System.Windows.Forms.TextBox();
            this.label_TiNickName = new System.Windows.Forms.Label();
            this.label_TiPwd = new System.Windows.Forms.Label();
            this.textBox_LoginPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_age = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton_men = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_TiPwdA = new System.Windows.Forms.Label();
            this.textBox_pwdA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_TiPwdQ = new System.Windows.Forms.Label();
            this.textBox_pwdQ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // label_pict
            // 
            this.label_pict.Image = global::myqq.Properties.Resources.gun1;
            this.label_pict.Location = new System.Drawing.Point(-9, -118);
            this.label_pict.Name = "label_pict";
            this.label_pict.Size = new System.Drawing.Size(350, 912);
            this.label_pict.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 35F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(394, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "欢迎注册QQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(396, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "每一天，乐在沟通。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 17F);
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "昵称";
            // 
            // textBox_NickName
            // 
            this.textBox_NickName.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_NickName.Location = new System.Drawing.Point(96, 31);
            this.textBox_NickName.Name = "textBox_NickName";
            this.textBox_NickName.Size = new System.Drawing.Size(189, 26);
            this.textBox_NickName.TabIndex = 5;
            this.textBox_NickName.Leave += new System.EventHandler(this.textBox_NickName_Leave);
            // 
            // label_TiNickName
            // 
            this.label_TiNickName.AutoSize = true;
            this.label_TiNickName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TiNickName.ForeColor = System.Drawing.Color.Red;
            this.label_TiNickName.Location = new System.Drawing.Point(314, 40);
            this.label_TiNickName.Name = "label_TiNickName";
            this.label_TiNickName.Size = new System.Drawing.Size(104, 16);
            this.label_TiNickName.TabIndex = 6;
            this.label_TiNickName.Text = "昵称不能为空";
            this.label_TiNickName.Visible = false;
            // 
            // label_TiPwd
            // 
            this.label_TiPwd.AutoSize = true;
            this.label_TiPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TiPwd.ForeColor = System.Drawing.Color.Red;
            this.label_TiPwd.Location = new System.Drawing.Point(314, 93);
            this.label_TiPwd.Name = "label_TiPwd";
            this.label_TiPwd.Size = new System.Drawing.Size(104, 16);
            this.label_TiPwd.TabIndex = 9;
            this.label_TiPwd.Text = "密码不能为空";
            this.label_TiPwd.Visible = false;
            // 
            // textBox_LoginPwd
            // 
            this.textBox_LoginPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_LoginPwd.Location = new System.Drawing.Point(96, 87);
            this.textBox_LoginPwd.Name = "textBox_LoginPwd";
            this.textBox_LoginPwd.Size = new System.Drawing.Size(189, 26);
            this.textBox_LoginPwd.TabIndex = 8;
            this.textBox_LoginPwd.Leave += new System.EventHandler(this.textBox_LoginPwd_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 17F);
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "密码";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_age);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton_men);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_TiPwd);
            this.groupBox1.Controls.Add(this.textBox_LoginPwd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_TiNickName);
            this.groupBox1.Controls.Add(this.textBox_NickName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(384, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // comboBox_age
            // 
            this.comboBox_age.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox_age.FormattingEnabled = true;
            this.comboBox_age.Location = new System.Drawing.Point(96, 192);
            this.comboBox_age.Name = "comboBox_age";
            this.comboBox_age.Size = new System.Drawing.Size(189, 24);
            this.comboBox_age.TabIndex = 14;
            this.comboBox_age.Text = "18";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 17F);
            this.label7.Location = new System.Drawing.Point(16, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "年龄";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton2.Location = new System.Drawing.Point(187, 139);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton_men
            // 
            this.radioButton_men.AutoSize = true;
            this.radioButton_men.Checked = true;
            this.radioButton_men.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton_men.Location = new System.Drawing.Point(96, 139);
            this.radioButton_men.Name = "radioButton_men";
            this.radioButton_men.Size = new System.Drawing.Size(42, 20);
            this.radioButton_men.TabIndex = 11;
            this.radioButton_men.TabStop = true;
            this.radioButton_men.Text = "男";
            this.radioButton_men.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 17F);
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "性别";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_TiPwdA);
            this.groupBox2.Controls.Add(this.textBox_pwdA);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_TiPwdQ);
            this.groupBox2.Controls.Add(this.textBox_pwdQ);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(384, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 160);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "密保";
            // 
            // label_TiPwdA
            // 
            this.label_TiPwdA.AutoSize = true;
            this.label_TiPwdA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TiPwdA.ForeColor = System.Drawing.Color.Red;
            this.label_TiPwdA.Location = new System.Drawing.Point(334, 93);
            this.label_TiPwdA.Name = "label_TiPwdA";
            this.label_TiPwdA.Size = new System.Drawing.Size(72, 16);
            this.label_TiPwdA.TabIndex = 9;
            this.label_TiPwdA.Text = "不能为空";
            this.label_TiPwdA.Visible = false;
            // 
            // textBox_pwdA
            // 
            this.textBox_pwdA.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_pwdA.Location = new System.Drawing.Point(124, 87);
            this.textBox_pwdA.Name = "textBox_pwdA";
            this.textBox_pwdA.Size = new System.Drawing.Size(189, 26);
            this.textBox_pwdA.TabIndex = 8;
            this.textBox_pwdA.Leave += new System.EventHandler(this.textBox_pwdA_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 17F);
            this.label11.Location = new System.Drawing.Point(16, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "密保答案";
            // 
            // label_TiPwdQ
            // 
            this.label_TiPwdQ.AutoSize = true;
            this.label_TiPwdQ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TiPwdQ.ForeColor = System.Drawing.Color.Red;
            this.label_TiPwdQ.Location = new System.Drawing.Point(334, 40);
            this.label_TiPwdQ.Name = "label_TiPwdQ";
            this.label_TiPwdQ.Size = new System.Drawing.Size(72, 16);
            this.label_TiPwdQ.TabIndex = 6;
            this.label_TiPwdQ.Text = "不能为空";
            this.label_TiPwdQ.Visible = false;
            // 
            // textBox_pwdQ
            // 
            this.textBox_pwdQ.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_pwdQ.Location = new System.Drawing.Point(124, 34);
            this.textBox_pwdQ.Name = "textBox_pwdQ";
            this.textBox_pwdQ.Size = new System.Drawing.Size(189, 26);
            this.textBox_pwdQ.TabIndex = 5;
            this.textBox_pwdQ.Leave += new System.EventHandler(this.textBox_pwdQ_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 17F);
            this.label13.Location = new System.Drawing.Point(16, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "密保问题";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(385, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "立即注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newQQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_pict);
            this.Controls.Add(this.label1);
            this.Name = "newQQForm";
            this.Text = "注册QQ账户";
            this.Load += new System.EventHandler(this.newQQForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_pict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NickName;
        private System.Windows.Forms.Label label_TiNickName;
        private System.Windows.Forms.Label label_TiPwd;
        private System.Windows.Forms.TextBox textBox_LoginPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton_men;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_TiPwdA;
        private System.Windows.Forms.TextBox textBox_pwdA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_TiPwdQ;
        private System.Windows.Forms.TextBox textBox_pwdQ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}
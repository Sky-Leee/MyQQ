namespace myqq
{
    partial class loadQQ
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.checkBox_zidong = new System.Windows.Forms.CheckBox();
            this.checkBox_jizhu = new System.Windows.Forms.CheckBox();
            this.label_findPwd = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.label_zhuce = new System.Windows.Forms.Label();
            this.pictureBox_touxiang = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_touxiang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_user.Location = new System.Drawing.Point(88, 206);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(289, 23);
            this.textBox_user.TabIndex = 5;
            this.textBox_user.Text = "QQ号码/手机/邮箱";
            this.textBox_user.Enter += new System.EventHandler(this.textBox_user_Enter);
            this.textBox_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_user_KeyDown);
            this.textBox_user.Leave += new System.EventHandler(this.textBox_user_Leave);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_pwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_pwd.Location = new System.Drawing.Point(88, 250);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(289, 23);
            this.textBox_pwd.TabIndex = 6;
            this.textBox_pwd.Text = "密码";
            this.textBox_pwd.Enter += new System.EventHandler(this.textBox_pwd_Enter);
            this.textBox_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pwd_KeyDown);
            this.textBox_pwd.Leave += new System.EventHandler(this.textBox_pwd_Leave);
            // 
            // checkBox_zidong
            // 
            this.checkBox_zidong.AutoSize = true;
            this.checkBox_zidong.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_zidong.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_zidong.Location = new System.Drawing.Point(88, 287);
            this.checkBox_zidong.Name = "checkBox_zidong";
            this.checkBox_zidong.Size = new System.Drawing.Size(80, 23);
            this.checkBox_zidong.TabIndex = 7;
            this.checkBox_zidong.Text = "自动登陆";
            this.checkBox_zidong.UseVisualStyleBackColor = true;
            this.checkBox_zidong.CheckedChanged += new System.EventHandler(this.checkBox_zidong_CheckedChanged);
            // 
            // checkBox_jizhu
            // 
            this.checkBox_jizhu.AutoSize = true;
            this.checkBox_jizhu.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_jizhu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_jizhu.Location = new System.Drawing.Point(186, 287);
            this.checkBox_jizhu.Name = "checkBox_jizhu";
            this.checkBox_jizhu.Size = new System.Drawing.Size(80, 23);
            this.checkBox_jizhu.TabIndex = 8;
            this.checkBox_jizhu.Text = "记住密码";
            this.checkBox_jizhu.UseVisualStyleBackColor = true;
            this.checkBox_jizhu.CheckedChanged += new System.EventHandler(this.checkBox_jizhu_CheckedChanged);
            // 
            // label_findPwd
            // 
            this.label_findPwd.AutoSize = true;
            this.label_findPwd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_findPwd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_findPwd.Location = new System.Drawing.Point(304, 287);
            this.label_findPwd.Name = "label_findPwd";
            this.label_findPwd.Size = new System.Drawing.Size(61, 19);
            this.label_findPwd.TabIndex = 9;
            this.label_findPwd.Text = "找回密码";
            this.label_findPwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_findPwd_MouseClick);
            this.label_findPwd.MouseLeave += new System.EventHandler(this.label_findPwd_MouseLeave);
            this.label_findPwd.MouseHover += new System.EventHandler(this.label_findPwd_MouseHover);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_load.Location = new System.Drawing.Point(88, 319);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(288, 38);
            this.button_load.TabIndex = 10;
            this.button_load.Text = "登录";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label_zhuce
            // 
            this.label_zhuce.AutoSize = true;
            this.label_zhuce.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_zhuce.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_zhuce.Location = new System.Drawing.Point(12, 353);
            this.label_zhuce.Name = "label_zhuce";
            this.label_zhuce.Size = new System.Drawing.Size(61, 19);
            this.label_zhuce.TabIndex = 11;
            this.label_zhuce.Text = "注册账号";
            this.label_zhuce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_zhuce_MouseClick);
            this.label_zhuce.MouseLeave += new System.EventHandler(this.label_zhuce_MouseLeave);
            this.label_zhuce.MouseHover += new System.EventHandler(this.label_zhuce_MouseHover);
            // 
            // pictureBox_touxiang
            // 
            this.pictureBox_touxiang.BackgroundImage = global::myqq.Properties.Resources._0;
            this.pictureBox_touxiang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_touxiang.Location = new System.Drawing.Point(186, 115);
            this.pictureBox_touxiang.Name = "pictureBox_touxiang";
            this.pictureBox_touxiang.Size = new System.Drawing.Size(85, 85);
            this.pictureBox_touxiang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_touxiang.TabIndex = 4;
            this.pictureBox_touxiang.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::myqq.Properties.Resources.QQbj;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(439, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.Image = global::myqq.Properties.Resources.f3cfe2fccacaba57b6f0c416a3ce3d19_AvAtlH_fw658;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 167);
            this.label1.TabIndex = 2;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // loadQQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(478, 381);
            this.Controls.Add(this.label_zhuce);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.label_findPwd);
            this.Controls.Add(this.checkBox_jizhu);
            this.Controls.Add(this.checkBox_zidong);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.pictureBox_touxiang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadQQ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loadQQ_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loadQQ_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loadQQ_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_touxiang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_touxiang;
        public System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.CheckBox checkBox_zidong;
        private System.Windows.Forms.CheckBox checkBox_jizhu;
        private System.Windows.Forms.Label label_findPwd;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label_zhuce;
    }
}


namespace myqq
{
    partial class AnQuanForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_nikeName = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_Ti = new System.Windows.Forms.Label();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.button_yanz = new System.Windows.Forms.Button();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label_friendsp = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel_quanx = new System.Windows.Forms.Panel();
            this.button_ok = new System.Windows.Forms.Button();
            this.panel_yanz = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pwdA = new System.Windows.Forms.TextBox();
            this.textBox_pwdQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_quanx.SuspendLayout();
            this.panel_yanz.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::myqq.Properties.Resources._0;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_nikeName
            // 
            this.label_nikeName.AutoSize = true;
            this.label_nikeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_nikeName.Location = new System.Drawing.Point(32, 169);
            this.label_nikeName.Name = "label_nikeName";
            this.label_nikeName.Size = new System.Drawing.Size(42, 21);
            this.label_nikeName.TabIndex = 1;
            this.label_nikeName.Text = "男孩";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(34, 205);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(49, 20);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "12345";
            // 
            // label_Ti
            // 
            this.label_Ti.AutoSize = true;
            this.label_Ti.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Ti.ForeColor = System.Drawing.Color.Gray;
            this.label_Ti.Location = new System.Drawing.Point(185, 21);
            this.label_Ti.Name = "label_Ti";
            this.label_Ti.Size = new System.Drawing.Size(135, 20);
            this.label_Ti.TabIndex = 3;
            this.label_Ti.Text = "验证您的密保信息：";
            // 
            // textBox_Q
            // 
            this.textBox_Q.Enabled = false;
            this.textBox_Q.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Q.Location = new System.Drawing.Point(189, 44);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(207, 26);
            this.textBox_Q.TabIndex = 4;
            // 
            // button_yanz
            // 
            this.button_yanz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_yanz.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_yanz.Location = new System.Drawing.Point(428, 73);
            this.button_yanz.Name = "button_yanz";
            this.button_yanz.Size = new System.Drawing.Size(68, 29);
            this.button_yanz.TabIndex = 5;
            this.button_yanz.Text = "验证";
            this.button_yanz.UseVisualStyleBackColor = true;
            this.button_yanz.Click += new System.EventHandler(this.button_yanz_Click);
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_A.Location = new System.Drawing.Point(189, 76);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(207, 26);
            this.textBox_A.TabIndex = 0;
            // 
            // label_friendsp
            // 
            this.label_friendsp.AutoSize = true;
            this.label_friendsp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_friendsp.ForeColor = System.Drawing.Color.Gray;
            this.label_friendsp.Location = new System.Drawing.Point(3, 4);
            this.label_friendsp.Name = "label_friendsp";
            this.label_friendsp.Size = new System.Drawing.Size(93, 20);
            this.label_friendsp.TabIndex = 7;
            this.label_friendsp.Text = "修改好友权限";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(12, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "允许任何人加我为好友";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(12, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(209, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "需要身份验证才能加我为好友";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(12, 99);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(181, 24);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "不允许任何人加我为好友";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel_quanx
            // 
            this.panel_quanx.Controls.Add(this.button_ok);
            this.panel_quanx.Controls.Add(this.radioButton3);
            this.panel_quanx.Controls.Add(this.radioButton2);
            this.panel_quanx.Controls.Add(this.radioButton1);
            this.panel_quanx.Controls.Add(this.label_friendsp);
            this.panel_quanx.Location = new System.Drawing.Point(182, 122);
            this.panel_quanx.Name = "panel_quanx";
            this.panel_quanx.Size = new System.Drawing.Size(313, 129);
            this.panel_quanx.TabIndex = 11;
            this.panel_quanx.Visible = false;
            // 
            // button_ok
            // 
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ok.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(246, 92);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(67, 31);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // panel_yanz
            // 
            this.panel_yanz.Controls.Add(this.label2);
            this.panel_yanz.Controls.Add(this.label1);
            this.panel_yanz.Controls.Add(this.textBox_pwdA);
            this.panel_yanz.Controls.Add(this.textBox_pwdQ);
            this.panel_yanz.Location = new System.Drawing.Point(26, 253);
            this.panel_yanz.Name = "panel_yanz";
            this.panel_yanz.Size = new System.Drawing.Size(469, 92);
            this.panel_yanz.TabIndex = 12;
            this.panel_yanz.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(232, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "输入你的验证答案。。。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "输入你的验证问题。。。";
            // 
            // textBox_pwdA
            // 
            this.textBox_pwdA.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_pwdA.ForeColor = System.Drawing.Color.Gray;
            this.textBox_pwdA.Location = new System.Drawing.Point(236, 19);
            this.textBox_pwdA.Multiline = true;
            this.textBox_pwdA.Name = "textBox_pwdA";
            this.textBox_pwdA.Size = new System.Drawing.Size(234, 70);
            this.textBox_pwdA.TabIndex = 1;
            // 
            // textBox_pwdQ
            // 
            this.textBox_pwdQ.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_pwdQ.ForeColor = System.Drawing.Color.Gray;
            this.textBox_pwdQ.Location = new System.Drawing.Point(0, 19);
            this.textBox_pwdQ.Multiline = true;
            this.textBox_pwdQ.Name = "textBox_pwdQ";
            this.textBox_pwdQ.Size = new System.Drawing.Size(234, 70);
            this.textBox_pwdQ.TabIndex = 0;
            // 
            // AnQuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Controls.Add(this.panel_yanz);
            this.Controls.Add(this.panel_quanx);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.button_yanz);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.label_Ti);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_nikeName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnQuanForm";
            this.Text = "安全设置";
            this.Load += new System.EventHandler(this.AnQuanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_quanx.ResumeLayout(false);
            this.panel_quanx.PerformLayout();
            this.panel_yanz.ResumeLayout(false);
            this.panel_yanz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nikeName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_Ti;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.Button button_yanz;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label_friendsp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel_quanx;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Panel panel_yanz;
        private System.Windows.Forms.TextBox textBox_pwdA;
        private System.Windows.Forms.TextBox textBox_pwdQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
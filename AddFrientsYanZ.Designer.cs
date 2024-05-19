namespace myqq
{
    partial class AddFrientsYanZ
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
            this.pictureBox_face = new System.Windows.Forms.PictureBox();
            this.label_nickName = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_yanz = new System.Windows.Forms.Label();
            this.textBox_yanz = new System.Windows.Forms.TextBox();
            this.label_remark = new System.Windows.Forms.Label();
            this.textBox_remark = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_face)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_face
            // 
            this.pictureBox_face.BackgroundImage = global::myqq.Properties.Resources._0;
            this.pictureBox_face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_face.Location = new System.Drawing.Point(34, 22);
            this.pictureBox_face.Name = "pictureBox_face";
            this.pictureBox_face.Size = new System.Drawing.Size(106, 100);
            this.pictureBox_face.TabIndex = 0;
            this.pictureBox_face.TabStop = false;
            // 
            // label_nickName
            // 
            this.label_nickName.AutoSize = true;
            this.label_nickName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_nickName.Location = new System.Drawing.Point(40, 134);
            this.label_nickName.Name = "label_nickName";
            this.label_nickName.Size = new System.Drawing.Size(42, 21);
            this.label_nickName.TabIndex = 1;
            this.label_nickName.Text = "男孩";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(40, 155);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(57, 20);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "123456";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sex.ForeColor = System.Drawing.Color.Gray;
            this.label_sex.Location = new System.Drawing.Point(42, 195);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(65, 20);
            this.label_sex.TabIndex = 3;
            this.label_sex.Text = "性别：男";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_age.ForeColor = System.Drawing.Color.Gray;
            this.label_age.Location = new System.Drawing.Point(42, 215);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(81, 20);
            this.label_age.TabIndex = 4;
            this.label_age.Text = "年龄：21岁";
            // 
            // label_yanz
            // 
            this.label_yanz.AutoSize = true;
            this.label_yanz.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_yanz.Location = new System.Drawing.Point(179, 22);
            this.label_yanz.Name = "label_yanz";
            this.label_yanz.Size = new System.Drawing.Size(121, 20);
            this.label_yanz.TabIndex = 5;
            this.label_yanz.Text = "请输入验证信息：";
            // 
            // textBox_yanz
            // 
            this.textBox_yanz.ForeColor = System.Drawing.Color.Gray;
            this.textBox_yanz.Location = new System.Drawing.Point(183, 45);
            this.textBox_yanz.Multiline = true;
            this.textBox_yanz.Name = "textBox_yanz";
            this.textBox_yanz.Size = new System.Drawing.Size(241, 58);
            this.textBox_yanz.TabIndex = 6;
            this.textBox_yanz.Text = "我是。。。";
            this.textBox_yanz.Enter += new System.EventHandler(this.textBox_yanz_Enter);
            this.textBox_yanz.Leave += new System.EventHandler(this.textBox_yanz_Leave);
            // 
            // label_remark
            // 
            this.label_remark.AutoSize = true;
            this.label_remark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_remark.Location = new System.Drawing.Point(189, 121);
            this.label_remark.Name = "label_remark";
            this.label_remark.Size = new System.Drawing.Size(121, 20);
            this.label_remark.TabIndex = 7;
            this.label_remark.Text = "给对方添加备注：";
            // 
            // textBox_remark
            // 
            this.textBox_remark.ForeColor = System.Drawing.Color.Gray;
            this.textBox_remark.Location = new System.Drawing.Point(183, 144);
            this.textBox_remark.Multiline = true;
            this.textBox_remark.Name = "textBox_remark";
            this.textBox_remark.Size = new System.Drawing.Size(241, 58);
            this.textBox_remark.TabIndex = 8;
            // 
            // button_ok
            // 
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ok.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(339, 236);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(85, 29);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_取消
            // 
            this.button_取消.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_取消.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_取消.Location = new System.Drawing.Point(215, 236);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(85, 29);
            this.button_取消.TabIndex = 10;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // AddFrientsYanZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(454, 306);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_remark);
            this.Controls.Add(this.label_remark);
            this.Controls.Add(this.textBox_yanz);
            this.Controls.Add(this.label_yanz);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_sex);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_nickName);
            this.Controls.Add(this.pictureBox_face);
            this.Name = "AddFrientsYanZ";
            this.Text = "AddFrientsYanZ";
            this.Load += new System.EventHandler(this.AddFrientsYanZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_face;
        private System.Windows.Forms.Label label_nickName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_yanz;
        private System.Windows.Forms.TextBox textBox_yanz;
        private System.Windows.Forms.Label label_remark;
        private System.Windows.Forms.TextBox textBox_remark;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_取消;
    }
}
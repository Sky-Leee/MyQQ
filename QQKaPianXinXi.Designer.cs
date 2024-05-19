namespace myqq
{
    partial class QQKaPianXinXi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQKaPianXinXi));
            this.pictureBox_face = new System.Windows.Forms.PictureBox();
            this.label_NikeName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_changeFace = new System.Windows.Forms.Label();
            this.label_changeZiLiao = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_carClose = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_blood = new System.Windows.Forms.Label();
            this.label_qqnumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_face
            // 
            this.pictureBox_face.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_face.BackgroundImage = global::myqq.Properties.Resources._0;
            this.pictureBox_face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_face.Location = new System.Drawing.Point(312, 38);
            this.pictureBox_face.Name = "pictureBox_face";
            this.pictureBox_face.Size = new System.Drawing.Size(106, 103);
            this.pictureBox_face.TabIndex = 0;
            this.pictureBox_face.TabStop = false;
            // 
            // label_NikeName
            // 
            this.label_NikeName.AutoSize = true;
            this.label_NikeName.BackColor = System.Drawing.Color.Transparent;
            this.label_NikeName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NikeName.Location = new System.Drawing.Point(63, 38);
            this.label_NikeName.Name = "label_NikeName";
            this.label_NikeName.Size = new System.Drawing.Size(52, 27);
            this.label_NikeName.TabIndex = 2;
            this.label_NikeName.Text = "男孩";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 230);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.BackColor = System.Drawing.Color.Transparent;
            this.label_sex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sex.Location = new System.Drawing.Point(64, 69);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(26, 21);
            this.label_sex.TabIndex = 4;
            this.label_sex.Text = "男";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.BackColor = System.Drawing.Color.Transparent;
            this.label_age.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_age.Location = new System.Drawing.Point(119, 69);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(44, 21);
            this.label_age.TabIndex = 5;
            this.label_age.Text = "21岁";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.BackColor = System.Drawing.Color.Transparent;
            this.label_start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_start.Location = new System.Drawing.Point(144, 292);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(58, 21);
            this.label_start.TabIndex = 6;
            this.label_start.Text = "狮子座";
            // 
            // label_changeFace
            // 
            this.label_changeFace.AutoSize = true;
            this.label_changeFace.BackColor = System.Drawing.Color.Transparent;
            this.label_changeFace.ForeColor = System.Drawing.Color.Gray;
            this.label_changeFace.Location = new System.Drawing.Point(339, 154);
            this.label_changeFace.Name = "label_changeFace";
            this.label_changeFace.Size = new System.Drawing.Size(53, 12);
            this.label_changeFace.TabIndex = 7;
            this.label_changeFace.Text = "修改头像";
            this.label_changeFace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_changeFace_MouseClick);
            this.label_changeFace.MouseLeave += new System.EventHandler(this.label_changeFace_MouseLeave);
            this.label_changeFace.MouseHover += new System.EventHandler(this.label_changeFace_MouseHover);
            // 
            // label_changeZiLiao
            // 
            this.label_changeZiLiao.AutoSize = true;
            this.label_changeZiLiao.BackColor = System.Drawing.Color.Transparent;
            this.label_changeZiLiao.ForeColor = System.Drawing.Color.Gray;
            this.label_changeZiLiao.Location = new System.Drawing.Point(200, 49);
            this.label_changeZiLiao.Name = "label_changeZiLiao";
            this.label_changeZiLiao.Size = new System.Drawing.Size(53, 12);
            this.label_changeZiLiao.TabIndex = 8;
            this.label_changeZiLiao.Text = "修改资料";
            this.label_changeZiLiao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_changeZiLiao_MouseClick);
            this.label_changeZiLiao.MouseLeave += new System.EventHandler(this.label_changeZiLiao_MouseLeave);
            this.label_changeZiLiao.MouseHover += new System.EventHandler(this.label_changeZiLiao_MouseHover);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Location = new System.Drawing.Point(134, 49);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 12);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "（姓名)";
            // 
            // pictureBox_carClose
            // 
            this.pictureBox_carClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_carClose.BackgroundImage")));
            this.pictureBox_carClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_carClose.Location = new System.Drawing.Point(408, 7);
            this.pictureBox_carClose.Name = "pictureBox_carClose";
            this.pictureBox_carClose.Size = new System.Drawing.Size(27, 25);
            this.pictureBox_carClose.TabIndex = 10;
            this.pictureBox_carClose.TabStop = false;
            this.pictureBox_carClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_carClose_MouseClick);
            this.pictureBox_carClose.MouseLeave += new System.EventHandler(this.pictureBox_carClose_MouseLeave);
            this.pictureBox_carClose.MouseHover += new System.EventHandler(this.pictureBox_carClose_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(78, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "血型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(78, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "星座";
            // 
            // label_blood
            // 
            this.label_blood.AutoSize = true;
            this.label_blood.BackColor = System.Drawing.Color.Transparent;
            this.label_blood.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_blood.ForeColor = System.Drawing.Color.Black;
            this.label_blood.Location = new System.Drawing.Point(144, 258);
            this.label_blood.Name = "label_blood";
            this.label_blood.Size = new System.Drawing.Size(37, 21);
            this.label_blood.TabIndex = 13;
            this.label_blood.Text = "A型";
            // 
            // label_qqnumber
            // 
            this.label_qqnumber.AutoSize = true;
            this.label_qqnumber.BackColor = System.Drawing.Color.Transparent;
            this.label_qqnumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_qqnumber.ForeColor = System.Drawing.Color.Black;
            this.label_qqnumber.Location = new System.Drawing.Point(144, 226);
            this.label_qqnumber.Name = "label_qqnumber";
            this.label_qqnumber.Size = new System.Drawing.Size(64, 21);
            this.label_qqnumber.TabIndex = 15;
            this.label_qqnumber.Text = "123456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(78, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "QQ号";
            // 
            // QQKaPianXinXi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 358);
            this.Controls.Add(this.label_qqnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_blood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_carClose);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_changeZiLiao);
            this.Controls.Add(this.label_changeFace);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_sex);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_NikeName);
            this.Controls.Add(this.pictureBox_face);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QQKaPianXinXi";
            this.Text = "QQKaPianXinXi";
            this.Load += new System.EventHandler(this.QQKaPianXinXi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QQKaPianXinXi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QQKaPianXinXi_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_changeFace;
        private System.Windows.Forms.Label label_changeZiLiao;
        private System.Windows.Forms.PictureBox pictureBox_carClose;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox pictureBox_face;
        public System.Windows.Forms.Label label_NikeName;
        public System.Windows.Forms.Label label_sex;
        public System.Windows.Forms.Label label_age;
        public System.Windows.Forms.Label label_start;
        public System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_blood;
        private System.Windows.Forms.Label label_qqnumber;
        private System.Windows.Forms.Label label4;
    }
}
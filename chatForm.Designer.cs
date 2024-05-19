namespace myqq
{
    partial class chatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatForm));
            this.richTextBox_historychat = new System.Windows.Forms.RichTextBox();
            this.richTextBox_chat = new System.Windows.Forms.RichTextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_pass = new System.Windows.Forms.Button();
            this.label_font = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox_emoji = new System.Windows.Forms.PictureBox();
            this.panel_emoji = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList_face = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emoji)).BeginInit();
            this.panel_emoji.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_historychat
            // 
            this.richTextBox_historychat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox_historychat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_historychat.Location = new System.Drawing.Point(2, 2);
            this.richTextBox_historychat.Name = "richTextBox_historychat";
            this.richTextBox_historychat.ReadOnly = true;
            this.richTextBox_historychat.Size = new System.Drawing.Size(541, 455);
            this.richTextBox_historychat.TabIndex = 0;
            this.richTextBox_historychat.Text = "";
            // 
            // richTextBox_chat
            // 
            this.richTextBox_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_chat.Location = new System.Drawing.Point(2, 494);
            this.richTextBox_chat.Name = "richTextBox_chat";
            this.richTextBox_chat.Size = new System.Drawing.Size(541, 115);
            this.richTextBox_chat.TabIndex = 2;
            this.richTextBox_chat.Text = "";
            // 
            // button_close
            // 
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.Location = new System.Drawing.Point(407, 615);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(65, 30);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "关闭";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_pass
            // 
            this.button_pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_pass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_pass.Location = new System.Drawing.Point(478, 615);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(65, 30);
            this.button_pass.TabIndex = 4;
            this.button_pass.Text = "发送";
            this.button_pass.UseVisualStyleBackColor = true;
            this.button_pass.Click += new System.EventHandler(this.button_pass_Click);
            // 
            // label_font
            // 
            this.label_font.Font = new System.Drawing.Font("宋体", 20F);
            this.label_font.Location = new System.Drawing.Point(51, 462);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(25, 26);
            this.label_font.TabIndex = 5;
            this.label_font.Text = "A";
            this.label_font.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_font_MouseClick);
            this.label_font.MouseLeave += new System.EventHandler(this.label_font_MouseLeave);
            this.label_font.MouseHover += new System.EventHandler(this.label_font_MouseHover);
            // 
            // label_color
            // 
            this.label_color.Font = new System.Drawing.Font("宋体", 20F);
            this.label_color.ForeColor = System.Drawing.Color.Red;
            this.label_color.Location = new System.Drawing.Point(82, 462);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(25, 26);
            this.label_color.TabIndex = 6;
            this.label_color.Text = "C";
            this.label_color.Click += new System.EventHandler(this.label_color_Click);
            this.label_color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_color_MouseClick);
            this.label_color.MouseLeave += new System.EventHandler(this.label_color_MouseLeave);
            this.label_color.MouseHover += new System.EventHandler(this.label_color_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_pic
            // 
            this.pictureBox_pic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_pic.BackgroundImage")));
            this.pictureBox_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_pic.Location = new System.Drawing.Point(113, 462);
            this.pictureBox_pic.Name = "pictureBox_pic";
            this.pictureBox_pic.Size = new System.Drawing.Size(28, 26);
            this.pictureBox_pic.TabIndex = 7;
            this.pictureBox_pic.TabStop = false;
            this.pictureBox_pic.Click += new System.EventHandler(this.pictureBox_pic_Click);
            this.pictureBox_pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_pic_MouseClick);
            this.pictureBox_pic.MouseLeave += new System.EventHandler(this.pictureBox_pic_MouseLeave);
            this.pictureBox_pic.MouseHover += new System.EventHandler(this.pictureBox_pic_MouseHover);
            // 
            // pictureBox_emoji
            // 
            this.pictureBox_emoji.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_emoji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_emoji.BackgroundImage")));
            this.pictureBox_emoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_emoji.Location = new System.Drawing.Point(12, 463);
            this.pictureBox_emoji.Name = "pictureBox_emoji";
            this.pictureBox_emoji.Size = new System.Drawing.Size(28, 26);
            this.pictureBox_emoji.TabIndex = 1;
            this.pictureBox_emoji.TabStop = false;
            this.pictureBox_emoji.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_emoji_MouseClick);
            this.pictureBox_emoji.MouseLeave += new System.EventHandler(this.pictureBox_emoji_MouseLeave);
            this.pictureBox_emoji.MouseHover += new System.EventHandler(this.pictureBox_emoji_MouseHover);
            // 
            // panel_emoji
            // 
            this.panel_emoji.Controls.Add(this.listView);
            this.panel_emoji.Location = new System.Drawing.Point(12, 56);
            this.panel_emoji.Name = "panel_emoji";
            this.panel_emoji.Size = new System.Drawing.Size(400, 400);
            this.panel_emoji.TabIndex = 8;
            this.panel_emoji.Visible = false;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList_face;
            this.listView.Location = new System.Drawing.Point(0, 1);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(400, 400);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // imageList_face
            // 
            this.imageList_face.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_face.ImageStream")));
            this.imageList_face.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_face.Images.SetKeyName(0, "1.gif");
            this.imageList_face.Images.SetKeyName(1, "2.gif");
            this.imageList_face.Images.SetKeyName(2, "3.gif");
            this.imageList_face.Images.SetKeyName(3, "4.gif");
            this.imageList_face.Images.SetKeyName(4, "5.gif");
            this.imageList_face.Images.SetKeyName(5, "6.gif");
            this.imageList_face.Images.SetKeyName(6, "7.gif");
            this.imageList_face.Images.SetKeyName(7, "8.gif");
            this.imageList_face.Images.SetKeyName(8, "9.gif");
            this.imageList_face.Images.SetKeyName(9, "10.gif");
            this.imageList_face.Images.SetKeyName(10, "11.gif");
            this.imageList_face.Images.SetKeyName(11, "12.gif");
            this.imageList_face.Images.SetKeyName(12, "13.gif");
            this.imageList_face.Images.SetKeyName(13, "14.gif");
            this.imageList_face.Images.SetKeyName(14, "15.gif");
            this.imageList_face.Images.SetKeyName(15, "16.gif");
            this.imageList_face.Images.SetKeyName(16, "17.gif");
            this.imageList_face.Images.SetKeyName(17, "18.gif");
            this.imageList_face.Images.SetKeyName(18, "19.gif");
            this.imageList_face.Images.SetKeyName(19, "20.gif");
            this.imageList_face.Images.SetKeyName(20, "21.gif");
            this.imageList_face.Images.SetKeyName(21, "22.gif");
            this.imageList_face.Images.SetKeyName(22, "23.gif");
            this.imageList_face.Images.SetKeyName(23, "24.gif");
            this.imageList_face.Images.SetKeyName(24, "25.gif");
            this.imageList_face.Images.SetKeyName(25, "26.gif");
            this.imageList_face.Images.SetKeyName(26, "27.gif");
            this.imageList_face.Images.SetKeyName(27, "28.gif");
            this.imageList_face.Images.SetKeyName(28, "29.gif");
            this.imageList_face.Images.SetKeyName(29, "30.gif");
            this.imageList_face.Images.SetKeyName(30, "31.gif");
            this.imageList_face.Images.SetKeyName(31, "32.gif");
            this.imageList_face.Images.SetKeyName(32, "33.gif");
            this.imageList_face.Images.SetKeyName(33, "34.gif");
            this.imageList_face.Images.SetKeyName(34, "35.gif");
            this.imageList_face.Images.SetKeyName(35, "36.gif");
            this.imageList_face.Images.SetKeyName(36, "37.gif");
            this.imageList_face.Images.SetKeyName(37, "38.gif");
            this.imageList_face.Images.SetKeyName(38, "39.gif");
            this.imageList_face.Images.SetKeyName(39, "40.gif");
            this.imageList_face.Images.SetKeyName(40, "41.gif");
            this.imageList_face.Images.SetKeyName(41, "42.gif");
            this.imageList_face.Images.SetKeyName(42, "43.gif");
            this.imageList_face.Images.SetKeyName(43, "44.gif");
            this.imageList_face.Images.SetKeyName(44, "45.gif");
            this.imageList_face.Images.SetKeyName(45, "46.gif");
            this.imageList_face.Images.SetKeyName(46, "47.gif");
            this.imageList_face.Images.SetKeyName(47, "48.gif");
            this.imageList_face.Images.SetKeyName(48, "49.gif");
            this.imageList_face.Images.SetKeyName(49, "50.gif");
            this.imageList_face.Images.SetKeyName(50, "51.gif");
            this.imageList_face.Images.SetKeyName(51, "52.gif");
            this.imageList_face.Images.SetKeyName(52, "53.gif");
            this.imageList_face.Images.SetKeyName(53, "54.gif");
            this.imageList_face.Images.SetKeyName(54, "55.gif");
            this.imageList_face.Images.SetKeyName(55, "56.gif");
            this.imageList_face.Images.SetKeyName(56, "57.gif");
            this.imageList_face.Images.SetKeyName(57, "58.gif");
            this.imageList_face.Images.SetKeyName(58, "59.gif");
            this.imageList_face.Images.SetKeyName(59, "60.gif");
            this.imageList_face.Images.SetKeyName(60, "61.gif");
            this.imageList_face.Images.SetKeyName(61, "62.gif");
            this.imageList_face.Images.SetKeyName(62, "63.gif");
            this.imageList_face.Images.SetKeyName(63, "64.gif");
            this.imageList_face.Images.SetKeyName(64, "65.gif");
            this.imageList_face.Images.SetKeyName(65, "66.gif");
            this.imageList_face.Images.SetKeyName(66, "67.gif");
            this.imageList_face.Images.SetKeyName(67, "68.gif");
            this.imageList_face.Images.SetKeyName(68, "69.gif");
            this.imageList_face.Images.SetKeyName(69, "70.gif");
            this.imageList_face.Images.SetKeyName(70, "71.gif");
            this.imageList_face.Images.SetKeyName(71, "72.gif");
            this.imageList_face.Images.SetKeyName(72, "73.gif");
            this.imageList_face.Images.SetKeyName(73, "74.gif");
            this.imageList_face.Images.SetKeyName(74, "75.gif");
            this.imageList_face.Images.SetKeyName(75, "76.gif");
            this.imageList_face.Images.SetKeyName(76, "77.gif");
            this.imageList_face.Images.SetKeyName(77, "78.gif");
            this.imageList_face.Images.SetKeyName(78, "79.gif");
            this.imageList_face.Images.SetKeyName(79, "80.gif");
            this.imageList_face.Images.SetKeyName(80, "81.gif");
            this.imageList_face.Images.SetKeyName(81, "82.gif");
            this.imageList_face.Images.SetKeyName(82, "83.gif");
            this.imageList_face.Images.SetKeyName(83, "84.gif");
            this.imageList_face.Images.SetKeyName(84, "85.gif");
            this.imageList_face.Images.SetKeyName(85, "86.gif");
            this.imageList_face.Images.SetKeyName(86, "87.gif");
            this.imageList_face.Images.SetKeyName(87, "88.gif");
            this.imageList_face.Images.SetKeyName(88, "89.gif");
            this.imageList_face.Images.SetKeyName(89, "90.gif");
            this.imageList_face.Images.SetKeyName(90, "91.gif");
            this.imageList_face.Images.SetKeyName(91, "92.gif");
            this.imageList_face.Images.SetKeyName(92, "93.gif");
            this.imageList_face.Images.SetKeyName(93, "94.gif");
            this.imageList_face.Images.SetKeyName(94, "95.gif");
            this.imageList_face.Images.SetKeyName(95, "96.gif");
            this.imageList_face.Images.SetKeyName(96, "97.gif");
            this.imageList_face.Images.SetKeyName(97, "98.gif");
            this.imageList_face.Images.SetKeyName(98, "99.gif");
            this.imageList_face.Images.SetKeyName(99, "100.gif");
            this.imageList_face.Images.SetKeyName(100, "101.gif");
            this.imageList_face.Images.SetKeyName(101, "102.gif");
            this.imageList_face.Images.SetKeyName(102, "103.gif");
            this.imageList_face.Images.SetKeyName(103, "104.gif");
            this.imageList_face.Images.SetKeyName(104, "105.gif");
            this.imageList_face.Images.SetKeyName(105, "106.gif");
            this.imageList_face.Images.SetKeyName(106, "107.gif");
            this.imageList_face.Images.SetKeyName(107, "108.gif");
            this.imageList_face.Images.SetKeyName(108, "109.gif");
            this.imageList_face.Images.SetKeyName(109, "110.gif");
            this.imageList_face.Images.SetKeyName(110, "111.gif");
            this.imageList_face.Images.SetKeyName(111, "112.gif");
            this.imageList_face.Images.SetKeyName(112, "113.gif");
            this.imageList_face.Images.SetKeyName(113, "114.gif");
            this.imageList_face.Images.SetKeyName(114, "115.gif");
            this.imageList_face.Images.SetKeyName(115, "116.gif");
            this.imageList_face.Images.SetKeyName(116, "117.gif");
            this.imageList_face.Images.SetKeyName(117, "118.gif");
            this.imageList_face.Images.SetKeyName(118, "119.gif");
            this.imageList_face.Images.SetKeyName(119, "120.gif");
            this.imageList_face.Images.SetKeyName(120, "121.gif");
            this.imageList_face.Images.SetKeyName(121, "122.gif");
            this.imageList_face.Images.SetKeyName(122, "123.gif");
            this.imageList_face.Images.SetKeyName(123, "124.gif");
            this.imageList_face.Images.SetKeyName(124, "125.gif");
            this.imageList_face.Images.SetKeyName(125, "126.gif");
            this.imageList_face.Images.SetKeyName(126, "127.gif");
            this.imageList_face.Images.SetKeyName(127, "128.gif");
            this.imageList_face.Images.SetKeyName(128, "129.gif");
            this.imageList_face.Images.SetKeyName(129, "130.gif");
            this.imageList_face.Images.SetKeyName(130, "131.gif");
            this.imageList_face.Images.SetKeyName(131, "132.gif");
            this.imageList_face.Images.SetKeyName(132, "133.gif");
            this.imageList_face.Images.SetKeyName(133, "134.gif");
            this.imageList_face.Images.SetKeyName(134, "135.gif");
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(709, 648);
            this.Controls.Add(this.panel_emoji);
            this.Controls.Add(this.pictureBox_pic);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label_font);
            this.Controls.Add(this.button_pass);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.richTextBox_chat);
            this.Controls.Add(this.pictureBox_emoji);
            this.Controls.Add(this.richTextBox_historychat);
            this.Name = "chatForm";
            this.Text = "chatForm";
            this.Load += new System.EventHandler(this.chatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emoji)).EndInit();
            this.panel_emoji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_historychat;
        private System.Windows.Forms.PictureBox pictureBox_emoji;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_pass;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.PictureBox pictureBox_pic;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.RichTextBox richTextBox_chat;
        private System.Windows.Forms.Panel panel_emoji;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList_face;
    }
}
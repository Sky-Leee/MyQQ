namespace myqq
{
    partial class QQmainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQmainForm));
            this.label_NickName = new System.Windows.Forms.Label();
            this.textBox_Mysign = new System.Windows.Forms.TextBox();
            this.label_close = new System.Windows.Forms.Label();
            this.pictureBox_face = new System.Windows.Forms.PictureBox();
            this.label_sign = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_min = new System.Windows.Forms.Label();
            this.chatListBox_fridents = new _ChatListBox.ChatListBox();
            this.pictureBox_caiDan = new System.Windows.Forms.PictureBox();
            this.pictureBox_addFriends = new System.Windows.Forms.PictureBox();
            this.panel_caidai = new System.Windows.Forms.Panel();
            this.button_anquan = new System.Windows.Forms.Button();
            this.button_changePwd = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改备注ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_changeRemark = new System.Windows.Forms.Panel();
            this.button_remarkOk = new System.Windows.Forms.Button();
            this.textBox_remark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_caiDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addFriends)).BeginInit();
            this.panel_caidai.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_changeRemark.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NickName
            // 
            this.label_NickName.AutoSize = true;
            this.label_NickName.BackColor = System.Drawing.Color.Transparent;
            this.label_NickName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NickName.Location = new System.Drawing.Point(97, 40);
            this.label_NickName.Name = "label_NickName";
            this.label_NickName.Size = new System.Drawing.Size(46, 21);
            this.label_NickName.TabIndex = 1;
            this.label_NickName.Text = "label";
            // 
            // textBox_Mysign
            // 
            this.textBox_Mysign.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Mysign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Mysign.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_Mysign.Location = new System.Drawing.Point(97, 73);
            this.textBox_Mysign.Name = "textBox_Mysign";
            this.textBox_Mysign.Size = new System.Drawing.Size(222, 19);
            this.textBox_Mysign.TabIndex = 3;
            this.textBox_Mysign.Text = "sign";
            this.textBox_Mysign.Visible = false;
            this.textBox_Mysign.Leave += new System.EventHandler(this.textBox_Mysign_Leave);
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Image = ((System.Drawing.Image)(resources.GetObject("label_close.Image")));
            this.label_close.Location = new System.Drawing.Point(348, 5);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(33, 36);
            this.label_close.TabIndex = 5;
            this.label_close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_close_MouseClick);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            this.label_close.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // pictureBox_face
            // 
            this.pictureBox_face.Image = global::myqq.Properties.Resources._0;
            this.pictureBox_face.Location = new System.Drawing.Point(21, 40);
            this.pictureBox_face.Name = "pictureBox_face";
            this.pictureBox_face.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_face.TabIndex = 0;
            this.pictureBox_face.TabStop = false;
            this.pictureBox_face.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_face_MouseClick);
            // 
            // label_sign
            // 
            this.label_sign.BackColor = System.Drawing.Color.Transparent;
            this.label_sign.Font = new System.Drawing.Font("宋体", 15F);
            this.label_sign.Location = new System.Drawing.Point(93, 73);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(226, 27);
            this.label_sign.TabIndex = 6;
            this.label_sign.Text = "label1";
            this.label_sign.Click += new System.EventHandler(this.label_sign_Click);
            this.label_sign.MouseLeave += new System.EventHandler(this.label_sign_MouseLeave);
            this.label_sign.MouseHover += new System.EventHandler(this.label_sign_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(-2, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "搜索";
            // 
            // label_min
            // 
            this.label_min.BackColor = System.Drawing.Color.Transparent;
            this.label_min.Image = ((System.Drawing.Image)(resources.GetObject("label_min.Image")));
            this.label_min.Location = new System.Drawing.Point(309, 5);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(33, 36);
            this.label_min.TabIndex = 8;
            this.label_min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_min_MouseClick);
            this.label_min.MouseLeave += new System.EventHandler(this.label_min_MouseLeave);
            this.label_min.MouseHover += new System.EventHandler(this.label_min_MouseHover);
            // 
            // chatListBox_fridents
            // 
            this.chatListBox_fridents.BackColor = System.Drawing.Color.Transparent;
            this.chatListBox_fridents.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBox_fridents.Location = new System.Drawing.Point(-2, 141);
            this.chatListBox_fridents.Name = "chatListBox_fridents";
            this.chatListBox_fridents.Size = new System.Drawing.Size(393, 484);
            this.chatListBox_fridents.TabIndex = 9;
            this.chatListBox_fridents.Text = "chatListBox1";
            this.chatListBox_fridents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chatListBox_fridents_MouseClick);
            this.chatListBox_fridents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chatListBox_fridents_MouseDoubleClick);
            // 
            // pictureBox_caiDan
            // 
            this.pictureBox_caiDan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_caiDan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_caiDan.BackgroundImage")));
            this.pictureBox_caiDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_caiDan.Location = new System.Drawing.Point(-2, 618);
            this.pictureBox_caiDan.Name = "pictureBox_caiDan";
            this.pictureBox_caiDan.Size = new System.Drawing.Size(33, 36);
            this.pictureBox_caiDan.TabIndex = 10;
            this.pictureBox_caiDan.TabStop = false;
            this.pictureBox_caiDan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_caiDan_MouseClick);
            this.pictureBox_caiDan.MouseLeave += new System.EventHandler(this.pictureBox_caiDan_MouseLeave);
            this.pictureBox_caiDan.MouseHover += new System.EventHandler(this.pictureBox_caiDan_MouseHover);
            // 
            // pictureBox_addFriends
            // 
            this.pictureBox_addFriends.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_addFriends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_addFriends.BackgroundImage")));
            this.pictureBox_addFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_addFriends.Location = new System.Drawing.Point(37, 618);
            this.pictureBox_addFriends.Name = "pictureBox_addFriends";
            this.pictureBox_addFriends.Size = new System.Drawing.Size(33, 36);
            this.pictureBox_addFriends.TabIndex = 11;
            this.pictureBox_addFriends.TabStop = false;
            this.pictureBox_addFriends.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_addFriends_MouseClick);
            this.pictureBox_addFriends.MouseLeave += new System.EventHandler(this.pictureBox_addFriends_MouseLeave);
            this.pictureBox_addFriends.MouseHover += new System.EventHandler(this.pictureBox_addFriends_MouseHover);
            // 
            // panel_caidai
            // 
            this.panel_caidai.BackColor = System.Drawing.Color.Transparent;
            this.panel_caidai.Controls.Add(this.button_anquan);
            this.panel_caidai.Controls.Add(this.button_changePwd);
            this.panel_caidai.Controls.Add(this.button_exit);
            this.panel_caidai.Location = new System.Drawing.Point(-2, 457);
            this.panel_caidai.Name = "panel_caidai";
            this.panel_caidai.Size = new System.Drawing.Size(93, 168);
            this.panel_caidai.TabIndex = 12;
            this.panel_caidai.Visible = false;
            // 
            // button_anquan
            // 
            this.button_anquan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_anquan.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_anquan.Location = new System.Drawing.Point(1, 79);
            this.button_anquan.Name = "button_anquan";
            this.button_anquan.Size = new System.Drawing.Size(92, 32);
            this.button_anquan.TabIndex = 2;
            this.button_anquan.Text = "安全选项";
            this.button_anquan.UseVisualStyleBackColor = true;
            this.button_anquan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_anquan_MouseClick);
            // 
            // button_changePwd
            // 
            this.button_changePwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_changePwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_changePwd.Location = new System.Drawing.Point(1, 108);
            this.button_changePwd.Name = "button_changePwd";
            this.button_changePwd.Size = new System.Drawing.Size(92, 32);
            this.button_changePwd.TabIndex = 1;
            this.button_changePwd.Text = "修改密码";
            this.button_changePwd.UseVisualStyleBackColor = true;
            this.button_changePwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_changePwd_MouseClick);
            // 
            // button_exit
            // 
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.Location = new System.Drawing.Point(0, 137);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(92, 32);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_exit_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除好友ToolStripMenuItem,
            this.修改备注ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 删除好友ToolStripMenuItem
            // 
            this.删除好友ToolStripMenuItem.Name = "删除好友ToolStripMenuItem";
            this.删除好友ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除好友ToolStripMenuItem.Text = "删除好友";
            this.删除好友ToolStripMenuItem.Click += new System.EventHandler(this.删除好友ToolStripMenuItem_Click);
            // 
            // 修改备注ToolStripMenuItem
            // 
            this.修改备注ToolStripMenuItem.Name = "修改备注ToolStripMenuItem";
            this.修改备注ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改备注ToolStripMenuItem.Text = "修改备注";
            this.修改备注ToolStripMenuItem.Click += new System.EventHandler(this.修改备注ToolStripMenuItem_Click);
            // 
            // panel_changeRemark
            // 
            this.panel_changeRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_changeRemark.Controls.Add(this.button_remarkOk);
            this.panel_changeRemark.Controls.Add(this.textBox_remark);
            this.panel_changeRemark.Controls.Add(this.label1);
            this.panel_changeRemark.Location = new System.Drawing.Point(71, 223);
            this.panel_changeRemark.Name = "panel_changeRemark";
            this.panel_changeRemark.Size = new System.Drawing.Size(234, 68);
            this.panel_changeRemark.TabIndex = 14;
            this.panel_changeRemark.Visible = false;
            // 
            // button_remarkOk
            // 
            this.button_remarkOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_remarkOk.Location = new System.Drawing.Point(147, 0);
            this.button_remarkOk.Name = "button_remarkOk";
            this.button_remarkOk.Size = new System.Drawing.Size(85, 20);
            this.button_remarkOk.TabIndex = 1;
            this.button_remarkOk.Text = "确定";
            this.button_remarkOk.UseVisualStyleBackColor = true;
            this.button_remarkOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_remarkOk_MouseClick);
            // 
            // textBox_remark
            // 
            this.textBox_remark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_remark.Location = new System.Drawing.Point(2, 21);
            this.textBox_remark.Multiline = true;
            this.textBox_remark.Name = "textBox_remark";
            this.textBox_remark.Size = new System.Drawing.Size(231, 46);
            this.textBox_remark.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入备注：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QQmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myqq.Properties.Resources.gun1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 656);
            this.Controls.Add(this.panel_changeRemark);
            this.Controls.Add(this.panel_caidai);
            this.Controls.Add(this.pictureBox_addFriends);
            this.Controls.Add(this.pictureBox_caiDan);
            this.Controls.Add(this.chatListBox_fridents);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_sign);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_NickName);
            this.Controls.Add(this.pictureBox_face);
            this.Controls.Add(this.textBox_Mysign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QQmainForm";
            this.Text = "QQ";
            this.Load += new System.EventHandler(this.QQmainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QQmainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QQmainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_caiDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addFriends)).EndInit();
            this.panel_caidai.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_changeRemark.ResumeLayout(false);
            this.panel_changeRemark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_face;
        private System.Windows.Forms.Label label_NickName;
        private System.Windows.Forms.TextBox textBox_Mysign;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_min;
        private _ChatListBox.ChatListBox chatListBox_fridents;
        private System.Windows.Forms.PictureBox pictureBox_caiDan;
        private System.Windows.Forms.PictureBox pictureBox_addFriends;
        private System.Windows.Forms.Panel panel_caidai;
        private System.Windows.Forms.Button button_anquan;
        private System.Windows.Forms.Button button_changePwd;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除好友ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改备注ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_changeRemark;
        private System.Windows.Forms.TextBox textBox_remark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_remarkOk;
        private System.Windows.Forms.Timer timer1;
    }
}
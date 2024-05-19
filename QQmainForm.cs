using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _ChatListBox;
using _ChatListBox._ChatListBox;
using System.Media;
using MySql.Data.MySqlClient;

namespace myqq
{
    public partial class QQmainForm : Form
    {
        ChatListItem item;

        int userId = 0;
        String NickName = null;
        int FaceId = 0;
        String MySign = null;

        public QQmainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }




        MySqlConnection c;
        private void Qian()
        {
            String s = "server=192.168.43.173;uid=root;pwd=password;database=MyQQ"; // 修改数据库连接字符串
            c = new MySqlConnection(s); // 修改为 MySqlConnection
            c.Open();
        }

        //个性签名
        private void textBox_Mysign_MouseHover(object sender, EventArgs e)
        {
            textBox_Mysign.BorderStyle = BorderStyle.FixedSingle;
        }

        private void textBox_Mysign_MouseLeave(object sender, EventArgs e)
        {
            textBox_Mysign.BorderStyle = BorderStyle.None;
        }



        private void QQmainForm_Load(object sender, EventArgs e)
        {
            userId = QQuser.userId;
            //头像框
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox_face.ClientRectangle);
            Region region = new Region(gp);
            pictureBox_face.Region = region;
            gp.Dispose();
            region.Dispose();

            ChangeImFo();
            timer1.Start();
            timer1.Interval = 1000;
        }

        public void ChangeImFo() {
            //个人信息
            Qian();
            Console.WriteLine(QQuser.userId);
            String sql = String.Format("select NickName,FaceId,MySign from Users where Id={0}", userId);
            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                NickName = r[0].ToString();
                FaceId = int.Parse(r[1].ToString());
                MySign = r[2].ToString();
            }
            label_NickName.Text = NickName;
            String img = "QQ头像/" + FaceId + ".bmp";
            pictureBox_face.Image = Image.FromFile(img);
            if (MySign == null)
            {
                textBox_Mysign.Text = "";
            }
            else
            {
                textBox_Mysign.Text = MySign;
                label_sign.Text = MySign;
            }
            r.Close();
            //c.Close();

            chatListBox_fridents.Items.Clear();
            //好友列表
            item = new ChatListItem("好友");

            sql = String.Format("select FriendId,Remark,NickName,FaceId,MySign from Friends inner join Users on Friends.FriendId=Users.Id where HostId={0}", userId);
            cmd = new MySqlCommand(sql, c);
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                ChatListSubItem list = new ChatListSubItem();
                list.ID = int.Parse(r[0].ToString());
                list.DisplayName = r[1].ToString();
                list.NicName = r[2].ToString();
                img = "QQ头像/" + r[3].ToString() + ".bmp";
                list.HeadImage = Image.FromFile(img);
                list.PersonalMsg = r[4].ToString();

                item.SubItems.Add(list);

            }


            chatListBox_fridents.Items.Add(item);
        }

        //关闭
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label_close.Image = Image.FromFile("素材/QQClose.jpg");
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.Image = Image.FromFile("素材/qqclosekong.png");
        }

        private void label_close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        //窗体移动
        Point p;
        private void QQmainForm_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(-e.X, -e.Y);
        }

        private void QQmainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(p.X, p.Y);
                Location = mousePos;
            }
        }

        //个性签名
        private void label_sign_MouseHover(object sender, EventArgs e)
        {
            label_sign.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label_sign_MouseLeave(object sender, EventArgs e)
        {
            label_sign.BorderStyle = BorderStyle.None;
        }

        private void label_sign_Click(object sender, EventArgs e)
        {
            textBox_Mysign.Text = label_sign.Text;
            label_sign.Visible = false;
            textBox_Mysign.Visible = true;
            this.ActiveControl = textBox_Mysign;
        }

        private void textBox_Mysign_Leave(object sender, EventArgs e)
        {
            String oldText = label_sign.Text;
            label_sign.Text = textBox_Mysign.Text;
            textBox_Mysign.Visible = false;
            label_sign.Visible = true;

            if (!oldText.Equals(label_sign.Text))
            {
                Qian();
                String sql = String.Format("update Users set MySign='{0}' where Id={1}", textBox_Mysign.Text, userId);
                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.ExecuteNonQuery();
            }
            
        }


        //最小化
        private void label_min_MouseLeave(object sender, EventArgs e)
        {
            label_min.Image = Image.FromFile("素材/forMin.png");
        }

        private void label_min_MouseHover(object sender, EventArgs e)
        {
            label_min.Image = Image.FromFile("素材/forMinHover.png");
        }

        private void label_min_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //头像资料
        private void pictureBox_face_MouseClick(object sender, MouseEventArgs e)
        {
            QQuser.carId = userId;
            QQKaPianXinXi fr = new QQKaPianXinXi();
            fr.x = this.Left - fr.Width;
            fr.y = this.Top;
            fr.userId = QQuser.userId;
            fr.FormClosed += QQKaPianXinXi_FormClosed;
            fr.Show();
        }
        private void QQKaPianXinXi_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeImFo();
        }


        //菜单
        private void pictureBox_caiDan_MouseHover(object sender, EventArgs e)
        {
            pictureBox_caiDan.BackgroundImage = Image.FromFile("素材/CaiDaHaver.png");
        }

        private void pictureBox_caiDan_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_caiDan.BackgroundImage = Image.FromFile("素材/caiDan.png");
        }

        private void pictureBox_caiDan_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel_caidai.Visible == false)
            {
                panel_caidai.Visible = true;
            }
            else {
                panel_caidai.Visible = false;
            }
        }
        //退出qq
        private void button_exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        //修改密码
        private void button_changePwd_MouseClick(object sender, MouseEventArgs e)
        {
            FindPwsForm fr = new FindPwsForm();
            fr.zhuangT = 1;
            fr.Show();
        }

        //安全选项
        private void button_anquan_MouseClick(object sender, MouseEventArgs e)
        {
            AnQuanForm fr = new AnQuanForm();
            fr.Show();
        }


        //添加好友
        private void pictureBox_addFriends_MouseHover(object sender, EventArgs e)
        {
            pictureBox_addFriends.BackgroundImage = Image.FromFile("素材/addFriendsHaver.png");
        }

        private void pictureBox_addFriends_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_addFriends.BackgroundImage = Image.FromFile("素材/AddFriendss.png");
        }

        private void pictureBox_addFriends_MouseClick(object sender, MouseEventArgs e)
        {
            AddFriends fr = new AddFriends();
            fr.FormClosed += AddFriends_FormClosed;
            fr.x = this.Left + this.Width;
            fr.y = this.Top;
            fr.Show();
        }

        private void AddFriends_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeImFo();
        }

        //鼠标单击事件
        QQKaPianXinXi kapianfr = new QQKaPianXinXi();
        int lastId=0;
        private void chatListBox_fridents_MouseClick(object sender, MouseEventArgs e)
        {
            if (chatListBox_fridents.SelectSubItem != null && e.Button == MouseButtons.Right) {
                contextMenuStrip1.Show(MousePosition.X,MousePosition.Y);
            }
            if (chatListBox_fridents.SelectSubItem != null && e.Button == MouseButtons.Left)
            {
                kapianfr.userId = chatListBox_fridents.SelectSubItem.ID;
                kapianfr.x = this.Left - kapianfr.Width;
                kapianfr.y = this.Top + chatListBox_fridents.Top;

                kapianfr.changeImfo();
                if (lastId == kapianfr.userId && kapianfr.Visible) {
                    kapianfr.Visible = false;
                }else if (kapianfr.Visible == false) {
                    kapianfr.Visible = true;
                }
                lastId = chatListBox_fridents.SelectSubItem.ID;
            }
            
        }

        private void 删除好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除该好友吗？", "删除好友", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.Yes) {
                int forId = chatListBox_fridents.SelectSubItem.ID;
                Qian();
                String sql = String.Format("delete from Friends where HostId={0} and FriendId={1};delete from Friends where HostId={1} and FriendId={0}", userId, forId);
                MySqlCommand cmd = new MySqlCommand(sql,c);
                int s = cmd.ExecuteNonQuery();
                if (s > 0) {
                    MessageBox.Show("删除成功！");
                    ChangeImFo();
                }
            }
        }

        //修改备注
        private void 修改备注ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_changeRemark.Visible = true;
            textBox_remark.Text = chatListBox_fridents.SelectSubItem.DisplayName;
        }

        private void button_remarkOk_MouseClick(object sender, MouseEventArgs e)
        {
            int forId = chatListBox_fridents.SelectSubItem.ID;
            Qian();
            String sql = String.Format("update Friends set Remark='{0}' where HostId={1} and FriendId={2}", textBox_remark.Text, userId, forId);
            MySqlCommand cmd = new MySqlCommand(sql, c);
            cmd.ExecuteNonQuery();
            ChangeImFo();
            panel_changeRemark.Visible = false;
            c.Close();

        }

        //双击聊天
        private void chatListBox_fridents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (chatListBox_fridents.SelectSubItem != null) {
                chatForm fr = new chatForm();
                fr.FormClosed += chatForm_FormClosed;
                fr.friendId= chatListBox_fridents.SelectSubItem.ID;
                fr.remark = chatListBox_fridents.SelectSubItem.DisplayName;
                fr.nickName = chatListBox_fridents.SelectSubItem.NicName;
                fr.userNickName = label_NickName.Text;
                fr.Show();
            }
        }

        int isTwinkleitem = 0;
        bool isPlaying = false;//是否正在播放
        private void timer1_Tick(object sender, EventArgs e)
        {
            Qian();
            //查询好友发给自己的未读聊天消息
            string sql = string.Format(" select * from Messages where ToUserId = {0} and MessageState = 0 and MessageTypeId = 1", userId);
            MySqlDataAdapter a = new MySqlDataAdapter(sql, c);
            DataTable t = new DataTable();
            a.Fill(t);
            if (t.Rows.Count > 0)
            {
                //有好友发来的未读聊天消息
                //播放系统提示音
                if (isPlaying == false)
                {
                    isPlaying = true;
                    SoundPlayer player = new SoundPlayer("声音/msg.wav");
                    player.Play();
                }

                //遍历消息
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    //消息一条一条处理
                    //遍历好友
                    for (int j = 0; j < item.SubItems.Count; j++)
                    {
                        if (t.Rows[i][1].ToString() == item.SubItems[j].ID.ToString())
                        {
                            //让好友头像闪烁
                            item.SubItems[j].IsTwinkle = true;
                            isTwinkleitem = j;
                        }
                    }
                }
            }
            else
            {
                //没有消息

            }
        }

        //关闭闪烁
        private void chatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            item.SubItems[isTwinkleitem].IsTwinkle = false;
        }


    }
}

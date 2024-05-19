using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Reflection.Emit;

namespace myqq
{
    public partial class chatForm : Form
    {
        public String userNickName;
        public int friendId;
        public String remark;
        public String nickName;
        public chatForm()
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

        private void chatForm_Load(object sender, EventArgs e)
        {
            if (remark == "")
            {
                this.Text = String.Format("正在与{0}聊天中...", nickName);
            }
            else
            {
                this.Text = String.Format("正在与{0}聊天中...", remark);
            }
            ShuaXinChat();
            timer1.Start();
            timer1.Interval = 1000;


            //把所有emoji添加到白道
            for (int i = 0; i < imageList_face.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                listView.Items.Add(item);
            }
        }

        private void ShuaXinChat() {
            Qian();
            String sql = String.Format("select * from Messages where FromUserId={0} and ToUserId={1} or FromUserId={1} and ToUserId={0} and MessageState=1 order by MessageTime ", QQuser.userId, friendId);
            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                String name = "";
                if (r[1].ToString().Equals(friendId.ToString()))
                {
                    name = nickName;
                }
                else
                {
                    name = userNickName;
                }
                string time = r["MessageTime"].ToString();
                string head = string.Format("{0} {1}\n", name, time);
                richTextBox_historychat.AppendText(head);
                richTextBox_historychat.ForeColor = Color.Green;//消息头部绿色
                ////滚动显示最新消息
                //richTextBox_historychat.ScrollToCaret();
                //消息内容
                string message = r["Message"].ToString();
                if (message.IndexOf("添加你为好友") > 0)
                {
                    message += "\r\n";
                    richTextBox_historychat.AppendText(message);
                    richTextBox_historychat.ForeColor = Color.Green;
                }
                else
                {
                    richTextBox_historychat.SelectedRtf = message;
                }
                richTextBox_historychat.ScrollToCaret();
            }
        }

        //emoji
        private void pictureBox_emoji_MouseHover(object sender, EventArgs e)
        {
            pictureBox_emoji.BackgroundImage = Image.FromFile("素材/emojihover.png");
        }

        private void pictureBox_emoji_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_emoji.BackgroundImage = Image.FromFile("素材/emoji.png");
        }

        private void pictureBox_emoji_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel_emoji.Visible)
                panel_emoji.Visible = false;
            else
                panel_emoji.Visible = true;

        }
        //emoji选择
        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                String file = "QQ表情/" + (listView.SelectedItems[0].ImageIndex + 1) + ".gif";
                Image img = Image.FromFile(file);
                //系统剪切板
                Clipboard.SetImage(img);
                //粘贴到发送框
                richTextBox_chat.Paste();
            }
            panel_emoji.Visible = false;
        }

        //字体
        private void label_font_MouseHover(object sender, EventArgs e)
        {
            label_font.BackColor = System.Drawing.Color.Gray;
        }

        private void label_font_MouseLeave(object sender, EventArgs e)
        {
            label_font.BackColor = Color.Transparent;
        }

        private void label_font_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog f = new FontDialog();
            DialogResult r = f.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox_chat.Font = f.Font;
            }
        }

        //颜色
        private void label_color_MouseHover(object sender, EventArgs e)
        {
            label_color.BackColor = System.Drawing.Color.Gray;
        }

        private void label_color_MouseLeave(object sender, EventArgs e)
        {
            label_color.BackColor = Color.Transparent;
        }

        private void label_color_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog c = new ColorDialog();
            DialogResult r = c.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox_chat.ForeColor = c.Color;
            }
        }

        //图片
        private void pictureBox_pic_MouseHover(object sender, EventArgs e)
        {
            pictureBox_pic.BackgroundImage = Image.FromFile("素材/chatPic_picHover.png");
        }

        private void pictureBox_pic_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_pic.BackgroundImage = Image.FromFile("素材/chatPic_pic.png");
        }

        private void pictureBox_pic_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            //文件过滤，文件筛选
            o.Filter = "图片文件|*.jpg;*.png;*.gif";
            DialogResult r = o.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(o.FileName);
                //系统剪切板
                Clipboard.SetImage(img);
                //粘贴到发送框
                richTextBox_chat.Paste();
            }
        }

        //关闭
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //发送
        private void button_pass_Click(object sender, EventArgs e)
        {
            // 判断消息为空
            if (richTextBox_chat.Text == "")
            {
                MessageBox.Show("发送消息不能为空");
                return;
            }
            else
            {
                string message = richTextBox_chat.Rtf;

                // 使用参数化查询将消息添加到数据库
                string sql = "INSERT INTO Messages(fromuserid, touserid, message, messagetime, messagestate, messagetypeid) VALUES (@fromuserid, @touserid, @message, NOW(), 1, 0)";
                Console.WriteLine(sql);

                Qian();

                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@fromuserid", QQuser.userId);
                cmd.Parameters.AddWithValue("@touserid", friendId);
                cmd.Parameters.AddWithValue("@message", message);

                try
                {
                    int count = cmd.ExecuteNonQuery();

                    if (count == 0)
                    {
                        MessageBox.Show("消息发送失败");
                    }
                    else
                    {
                        string head = userNickName + " " + DateTime.Now.ToString() + "\n";
                        richTextBox_historychat.AppendText(head);
                        richTextBox_historychat.ForeColor = Color.Green; // 消息头部绿色
                        richTextBox_historychat.SelectedRtf = message;
                        richTextBox_historychat.ScrollToCaret();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("数据库操作失败：" + ex.Message);
                }
                finally
                {
                    // 清空
                    richTextBox_chat.Clear();
                    c.Close();
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Messages where FromUserId = {0} and ToUserId = {1} and MessageTypeId = 1 and MessageState = 0", friendId, QQuser.userId);
            Qian();
            MySqlDataAdapter a = new MySqlDataAdapter(sql, c);
            DataTable t = new DataTable();
            a.Fill(t);
            if (t.Rows.Count > 0)
            {
                //有消息,把消息显示到richTextBox2
                //消息一条一条处理
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    //消息头部,备注/昵称+时间
                    string name = remark.Length > 0 ? remark : nickName;
                    string time = t.Rows[i]["MessageTime"].ToString();
                    string head = string.Format("{0} {1}\n", name, time);
                    richTextBox_historychat.AppendText(head);
                    richTextBox_historychat.ForeColor = Color.Green;//消息头部绿色
                    //滚动显示最新消息
                    richTextBox_historychat.ScrollToCaret();
                    //消息内容
                    string message = t.Rows[i]["Message"].ToString();
                    richTextBox_historychat.SelectedRtf = message;
                    //马上把消息置为已读
                    string sql2 = string.Format("update Messages set MessageState = 1 where id = {0}", t.Rows[i]["id"].ToString());
                    Qian();
                    MySqlCommand cmd = new MySqlCommand(sql2, c);
                    int count = cmd.ExecuteNonQuery();
                    Console.WriteLine(count);
                    if (count == 0)
                    {
                        MessageBox.Show("接收消息失败");
                    }
                }
            }
            c.Close();
        }

        //颜色
        private void label_color_Click(object sender, EventArgs e)
        {

        }

        //文件
        private void pictureBox_pic_Click(object sender, EventArgs e)
        {

        }
    }
}

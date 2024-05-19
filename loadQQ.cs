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
using myqq.Properties;
using MySql.Data.MySqlClient;

namespace myqq
{
    public partial class loadQQ : Form
    {
        public loadQQ()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        MySqlConnection c; // MySql Connection
        private void Qian() {
            String s = "server=192.168.43.173;uid=root;pwd=password;database=MyQQ"; // 修改数据库连接字符串
            c = new MySqlConnection(s); // 修改为 MySqlConnection
            c.Open();
        }


        private void loadQQ_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox_touxiang.ClientRectangle);
            Region region = new Region(gp);
            pictureBox_touxiang.Region = region;

            gp.Dispose();
            region.Dispose();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image =Image.FromFile("素材/QQClose.jpg");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image =Image.FromFile("素材/QQbj.jpg"); 
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        //窗体拖动
        Point p;
        private void loadQQ_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(-e.X, -e.Y);
        }


        private void loadQQ_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(p.X, p.Y);
                Location = mousePos;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(-e.X, -e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(p.X, p.Y);
                Location = mousePos;
            }
        }


        //找回密码
        private void label_findPwd_MouseHover(object sender, EventArgs e)
        {
            label_findPwd.ForeColor = System.Drawing.Color.Black;
        }

        private void label_findPwd_MouseLeave(object sender, EventArgs e)
        {
            label_findPwd.ForeColor = System.Drawing.Color.Gray;
        }
        private void label_findPwd_MouseClick(object sender, MouseEventArgs e)
        {
            FindPwsForm fr = new FindPwsForm();
            fr.Show();
        }

        //注册账号
        private void label_zhuce_MouseHover(object sender, EventArgs e)
        {
            label_zhuce.ForeColor = System.Drawing.Color.Black;
        }

        private void label_zhuce_MouseLeave(object sender, EventArgs e)
        {
            label_zhuce.ForeColor = System.Drawing.Color.Gray;
        }

        private void label_zhuce_MouseClick(object sender, MouseEventArgs e)
        {
            newQQForm fr = new newQQForm();
            fr.Show();
        }


        //user焦点
        private void textBox_user_Enter(object sender, EventArgs e)
        {
            if(textBox_user.Text== "QQ号码/手机/邮箱")
            {
                textBox_user.Text = "";
            }
            textBox_user.ForeColor= System.Drawing.Color.Black;
        }

        private void textBox_user_Leave(object sender, EventArgs e)
        {
            int faceid = 0;
            String img = null;
            String isRemember=null;
            String isAuto = null;
            String pwd = null;
            if (textBox_user.Text == "")
            {
                textBox_user.Text = "QQ号码/手机/邮箱";
                textBox_user.ForeColor = System.Drawing.Color.Gray;
            }
            else {
                Qian();
                String sql = String.Format("select FaceId,isRemember,isAuto,LoginPwd from users where Id={0}", int.Parse(textBox_user.Text));
                MySqlCommand cmd = new MySqlCommand(sql, c); // 修改为 MySqlCommand
                MySqlDataReader r = cmd.ExecuteReader(); // 修改为 MySqlDataReader
                if (r.Read())
                {
                    faceid = int.Parse(r[0].ToString());
                    isRemember = r[1].ToString();
                    isAuto = r[2].ToString();
                    pwd = r[3].ToString();
                }  
            }
            img = "QQ头像/" + faceid + ".bmp";
            pictureBox_touxiang.Image = Image.FromFile(img);
            if ("1".Equals(isRemember))
            {
                textBox_pwd.PasswordChar = '*';
                textBox_pwd.ForeColor = System.Drawing.Color.Black;
                textBox_pwd.Text = pwd;
                checkBox_jizhu.Checked = true;
                if ("1".Equals(isAuto))
                {
                    checkBox_zidong.Checked = true;
                    button_load_Click(this, null);
                }
                else
                {
                    checkBox_zidong.Checked = false;
                }
            }
            else {
                checkBox_jizhu.Checked = false;
            }
        }

        private void textBox_pwd_Enter(object sender, EventArgs e)
        {
            if (textBox_pwd.Text == "密码")
            {
                textBox_pwd.Text = "";
                textBox_pwd.PasswordChar = '*';
            }
            textBox_pwd.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_pwd_Leave(object sender, EventArgs e)
        {
            if (textBox_pwd.Text == "")
            {
                textBox_pwd.PasswordChar = new char() ;
                textBox_pwd.Text = "密码";
                textBox_pwd.ForeColor = System.Drawing.Color.Gray;
            }
        }


        //登陆
        private void button_load_Click(object sender, EventArgs e)
        {
            Qian();
            int userId;
            if (int.TryParse(textBox_user.Text, out userId))
        {
                String sql = String.Format("select COUNT(*) from Users where Id={0} and LoginPwd='{1}'", userId, textBox_pwd.Text);
                MySqlCommand cmd = new MySqlCommand(sql, c);
                MySqlDataReader r = cmd.ExecuteReader();
                try
                {
                    if (r.Read())
                    {

                        if ("1".Equals(r[0].ToString()))
                        {
                            Qian();
                            String sql1 = String.Format("update users set isRemember={0},isAuto={1} where Id={2}", checkBox_jizhu.Checked ? 1 : 0, checkBox_zidong.Checked ? 1 : 0, userId);
                            // SqlCommand cmd1 = new SqlCommand(sql1, c);
                            MySqlCommand cmd1 = new MySqlCommand(sql1, c); // 修改为 MySqlCommand
                            cmd1.ExecuteNonQuery();
                            QQuser.userId = userId;
                            QQmainForm fr = new QQmainForm();
                            this.Visible = false;
                            fr.Show();
                            c.Close();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误！！！");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("用户名密码不能为空或未输入正确的格式！");
                }  
            }
            else {
                MessageBox.Show("用户名密码不能为空或未输入正确的格式！");
            }

            c.Close();
        }

        private void checkBox_zidong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_zidong.Checked)
            {
                if (!checkBox_jizhu.Checked)
                {
                    MessageBox.Show("自动登陆需要记住密码");
                    checkBox_zidong.Checked = false;
                }
            }
            
        }

        private void checkBox_jizhu_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_jizhu.Checked) {
                if (checkBox_zidong.Checked) {
                    checkBox_zidong.Checked = false;
                }
            }
        }

        private void textBox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button_load_Click(this, null);
            }
            if (e.KeyCode == Keys.Escape) {
                Application.Exit();
            }
        }

        private void textBox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_load_Click(this, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}

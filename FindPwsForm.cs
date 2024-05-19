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

namespace myqq
{
    public partial class FindPwsForm : Form
    {
        
        public FindPwsForm()
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

        int id = 0;
        String pwdQ = null;
        String pwdA = null;

        private void button_select_Click(object sender, EventArgs e)
        {
            if (textBox_user.Text == "")
            {
                MessageBox.Show("请输入QQ账号");
            }
            else {
                Qian();
                if (int.TryParse(textBox_user.Text, out id))
                {
                    
                    String sql = String.Format("select pwdQ,pwdA from users where Id={0}",id);
                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    MySqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        pwdQ = r[0].ToString();
                        pwdA = r[1].ToString();
                        textBox_pwdQ.Text = pwdQ;
                        textBox_pwdA.Enabled = true;
                        button_yanz.Enabled = true;
                    }
                    else {
                        MessageBox.Show("未查询到此QQ号码");
                    }
                    c.Close();
                }
                else {
                    MessageBox.Show("QQ号码格式错误");
                }
               
            }
        }

        private void button_yanz_Click(object sender, EventArgs e)
        {
            if (textBox_pwdA.Text == "")
            {
                MessageBox.Show("请输入密保答案！"); 
            }
            else {
                if (pwdA.Equals(textBox_pwdA.Text))
                {
                    textBox_pwd.Enabled = true;
                    textBox_pwd2.Enabled = true;
                    button_change.Enabled = true;
                }
                else
                {
                    MessageBox.Show("密保答案错误！！");
                }
            }
           
        }

        private void textBox_pwd_Leave(object sender, EventArgs e)
        {
            if (textBox_pwd.Text == "")
            {
                label_kong.Visible = true;
                
            }
            else {
                if (!textBox_pwd.Text.Equals(textBox_pwd2.Text)&&textBox_pwd2.Text!="")
                {
                    label_yizhi.Visible = true;
                }
                else {
                    label_yizhi.Visible = false;
                }
                label_kong.Visible = false;
            }
        }

        private void textBox_pwd2_Leave(object sender, EventArgs e)
        {
            if (!textBox_pwd2.Text.Equals(textBox_pwd.Text))
            {
                label_yizhi.Visible = true;
            }
            else {
                label_yizhi.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_pwd.Text != "") {
                if (textBox_pwd.Text.Equals(textBox_pwd2.Text))
                {
                    Qian();
                    String sql = String.Format("update users set loginPwd='{0}'  where Id={1}", textBox_pwd2.Text, id);
                    MySqlCommand cmd = new MySqlCommand(sql, c);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("修改成功！快去登陆吧！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改发生错误，请重试！");
                    }
                    c.Close();
                }
            }
            
        }
        public int zhuangT;
        public int userId=QQuser.userId;
        private void FindPwsForm_Load(object sender, EventArgs e)
        {
            if (zhuangT == 1) {
                textBox_user.Text = userId.ToString();
                textBox_user.Enabled = false;
                this.Text = "修改密码";
            }
        }
    }
}

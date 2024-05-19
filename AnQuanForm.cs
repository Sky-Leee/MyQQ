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
    public partial class AnQuanForm : Form
    {
        int userId = QQuser.userId;
        String pwdA = "";
        int FriendshipPolicyId = 1;
        public AnQuanForm()
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

        private void AnQuanForm_Load(object sender, EventArgs e)
        {
            textBox_A.Focus();
            Qian();
            String sql = String.Format("select NickName,FaceId,pwdQ,pwdA,FriendshipPolicyId from Users where Id={0}", userId);
            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read()) {
                label_nikeName.Text = r[0].ToString();
                label_id.Text = userId.ToString();
                String img = "QQ头像/" + r[1].ToString() + ".bmp";
                pictureBox1.BackgroundImage = Image.FromFile(img);
                Console.WriteLine(r[2].ToString());
                textBox_Q.Text = r[2].ToString();
                pwdA = r[3].ToString();
                FriendshipPolicyId = int.Parse(r[4].ToString());
            }
           
        }

        private void button_yanz_Click(object sender, EventArgs e)
        {
            if (!pwdA.Equals(textBox_A.Text))
            {
                MessageBox.Show("密保答案错误！");
            }
            else {
                panel_quanx.Visible = true;
                label_Ti.Text = "修改您的安全选项";
                button_yanz.Visible = false;
                if (FriendshipPolicyId == 1)
                {
                    radioButton1.Checked = true;
                }
                else if (FriendshipPolicyId == 2)
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                }
            }
        }

        //好友验证
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panel_yanz.Visible = true;
            }
            else {
                panel_yanz.Visible = false;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Qian();
            String sql;
            if (radioButton1.Checked)
            {
                sql = String.Format("update Users set pwdQ = '{0}', pwdA = '{1}', FriendshipPolicyId ={2} where Id = {3}",textBox_pwdQ.Text,textBox_A.Text,1,userId);
            }
            else if (radioButton2.Checked)
            {
                sql = String.Format("update Users set pwdQ='{0}',pwdA='{1}',FriendshipPolicyId={2},Q='{3}',A='{4}' where Id={5}", textBox_pwdQ.Text, textBox_A.Text, 2,textBox_Q.Text,textBox_A.Text,userId);
            }
            else {
                sql = String.Format("update Users set pwdQ = '{0}', pwdA = '{1}', FriendshipPolicyId ={2} where Id = {3}", textBox_pwdQ.Text, textBox_A.Text, 3, userId);
            }
            MySqlCommand cmd = new MySqlCommand(sql,c);
            int r = cmd.ExecuteNonQuery();
            if (r > 0) {
                MessageBox.Show("修改成功！");
                this.Close();
            }

        }
    }
}

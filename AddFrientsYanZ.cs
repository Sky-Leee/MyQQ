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
    public partial class AddFrientsYanZ : Form
    {
        public int userId;
        public int forId;
        public int quanX;
        public AddFrientsYanZ()
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

        String Q = "";
        String A = "";
        private void AddFrientsYanZ_Load(object sender, EventArgs e)
        {
            if (quanX == 1)
            {
                label_yanz.Visible = false;
                textBox_yanz.Visible = false;
            }
            else if (quanX == 2) {
                label_yanz.Visible = true;
                textBox_yanz.Visible = true;
            }
            Qian();
            String sql = String.Format("select NickName,FaceId,Sex,Age,Q,A from Users where Id={0}", forId);
            MySqlCommand cmd = new MySqlCommand(sql,c);
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read()) {
                label_nickName.Text = r[0].ToString();
                String img = "QQ头像/" + r[1].ToString() + ".bmp";
                pictureBox_face.BackgroundImage = Image.FromFile(img);
                label_sex.Text = "性别：" + r[2].ToString();
                label_age.Text = "年龄：" + r[3].ToString() + "岁";
                textBox_yanz.Text =Q= r[4].ToString();
                A = r[5].ToString();
                label_id.Text = forId.ToString() ;
            }
            c.Close();
            r.Close();
        }

        //验证框
        private void textBox_yanz_Enter(object sender, EventArgs e)
        {
            if (textBox_yanz.Text.Equals(Q)) {
                textBox_yanz.Text = "";
                textBox_yanz.ForeColor = System.Drawing.Color.Black;
            }
            
        }
        private void textBox_yanz_Leave(object sender, EventArgs e)
        {
            if (textBox_yanz.Text == "") {
                textBox_yanz.Text = Q;
                textBox_yanz.ForeColor = System.Drawing.Color.Gray;
            }
        }

        //取消按钮
        private void button_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定按钮
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!textBox_yanz.Text.Equals(A))
            {
                MessageBox.Show("验证消息错误！");
                textBox_yanz.Text = Q;
                textBox_yanz.ForeColor = System.Drawing.Color.Gray;
            }
            else {
                Qian();
                String beiz = textBox_remark.Text;
                string sql = string.Format("insert Friends (hostid,friendid,Remark) values('{0}','{1}','{2}');insert Friends (hostid,friendid) values('{1}','{0}')", userId, forId,beiz);
                MySqlCommand cmd = new MySqlCommand(sql, c);
                int r = cmd.ExecuteNonQuery();
                if (r > 0) {
                    MessageBox.Show("添加成功！！");
                    this.Close();
                }
            }
        }


    }
}

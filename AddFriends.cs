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
    public partial class AddFriends : Form
    {
        public int x;
        public int y;

        public AddFriends()
        {
            InitializeComponent();
        }

        MySqlConnection c;
        private void Qian()
        {
            String s = "server=192.168.43.173;uid=root;pwd=password;database=MyQQ"; // 修改数据库连接字符串
            c = new MySqlConnection(s); // 修改为 MySqlConnection
            c.Open();
        }

        private void AddFriends_Load(object sender, EventArgs e)
        {
            this.Location = new Point(x,y);
            comboBox_sex.Items.Add("不限");
            comboBox_sex.Items.Add("男");
            comboBox_sex.Items.Add("女");
            comboBox_age.Items.Add("不限");
            comboBox_age.Items.Add("18岁以下");
            comboBox_age.Items.Add("18-22岁");
            comboBox_age.Items.Add("22-26岁");
            comboBox_age.Items.Add("27-35岁");
            comboBox_age.Items.Add("35岁以上");
        }

        //输入框
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if ("输入QQ号码/昵称查找".Equals(textBox1.Text))
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                textBox1.Text = "输入QQ号码/昵称查找";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        //查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            label_tishi.Visible = true;
            Qian();
            String sex="1=1";
            if (!"不限".Equals(comboBox_sex.Text)) {
                sex = String.Format("Sex='{0}'",comboBox_sex.Text);
            }

            
            String age = "1=1";
            switch (comboBox_age.SelectedIndex) {
                case 0:
                    break;
                case 1:
                    age = "Age<18";
                    break;
                case 2:
                    age = "Age between 18 and 22";
                    break;
                case 3:
                    age = "Age between 23 and 26";
                    break;
                case 4:
                    age = "Age between 27 and 35";
                    break;
                case 5:
                    age = "Age>35";
                    break;
            }
            int Id;
            String sql;
            if (textBox1.Text == "输入QQ号码/昵称查找") {
                sql = String.Format("select Users.Id,NickName,Sex,Age,FriendshipPolicy from Users inner join  FriendshipPolicy on Users.FriendshipPolicyId=FriendshipPolicy.Id where {0} and {1}", age, sex);
            }
            else {
                if (int.TryParse(textBox1.Text, out Id))
                {
                    sql = String.Format("select Users.Id,NickName,Sex,Age,FriendshipPolicy from Users inner join  FriendshipPolicy on Users.FriendshipPolicyId=FriendshipPolicy.Id where {0} and {1} and Users.Id like '%{2}%'", age, sex, Id);
                }
                else
                {
                    sql = String.Format("select Users.Id,NickName,Sex,Age,FriendshipPolicy from Users inner join  FriendshipPolicy on Users.FriendshipPolicyId=FriendshipPolicy.Id where {0} and {1} and NickName like '%{2}%'", age, sex, textBox1.Text);
                }
            }
            listView1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader r = cmd.ExecuteReader();
            int i = 0;
            while (r.Read()) {
                ListViewItem item = new ListViewItem(r[0].ToString());
                item.ImageIndex = i++;
                item.SubItems.Add(r[1].ToString());
                item.SubItems.Add(r[2].ToString());
                item.SubItems.Add(r[3].ToString());
                item.SubItems.Add(r[4].ToString());
                listView1.Items.Add(item);
            }
            r.Close();
            c.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddFrientsYanZ fr = new AddFrientsYanZ();
            String pan = listView1.SelectedItems[0].SubItems[4].Text;
            Console.WriteLine(pan);
            if ("允许任何人加我为好友".Equals(pan))
            {
                fr.userId = QQuser.userId;
                fr.forId= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                fr.quanX = 1;
                fr.Show();
            }
            else if ("需要身份验证才能加我为好友".Equals(pan))
            {
                fr.userId = QQuser.userId;
                fr.forId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                fr.quanX = 2;
                fr.Show();
            }
            else {
                MessageBox.Show("对方拒绝添加好友！", "添加好友失败");
            }
        }
    }
}

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
    public partial class ChangeImfoForm : Form
    {
        public int x;
        public int y;
        public ChangeImfoForm()
        {
            InitializeComponent();

        }


        int userId = QQuser.carId;
        String nickName = "";
        String name = "";
        String sex = "男";
        int age = 0;
        String star = "";
        String blood = "";
        String sign = "";
        MySqlConnection c;
        private void Qian()
        {
            String s = "server=192.168.43.173;uid=root;pwd=password;database=MyQQ"; // 修改数据库连接字符串
            c = new MySqlConnection(s); // 修改为 MySqlConnection
            c.Open();
        }

        private void ChangeImfoForm_Load(object sender, EventArgs e)
        {
            this.Left = x;
            this.Top = y;
            Qian();
            comboBox_sex.Items.Add("男");
            comboBox_sex.Items.Add("女");
            for (int i = 1; i <= 100; i++) {
                comboBox_age.Items.Add(i);
            }
            String sql = "select Star from Star";
            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read()) {
                comboBox_start.Items.Add(r[0].ToString());
            }
            comboBox_blood.Items.Add("A型");
            comboBox_blood.Items.Add("B型");
            comboBox_blood.Items.Add("O型");
            comboBox_blood.Items.Add("AB型");

            r.Close();

            sql = String.Format("select NickName,Name,Sex,Age,Star,BloodType,MySign from Users inner join Star on Users.StarId=Star.Id inner join BloodType on Users.BloodTypeId=BloodType.Id  where Users.Id={0}", userId);
            cmd = new MySqlCommand(sql, c);
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                nickName = r[0].ToString();
                name =r[1].ToString();
                sex = r[2].ToString();
                age =int.Parse(r[3].ToString());
                star = r[4].ToString();
                blood = r[5].ToString();
                sign = r[6].ToString();
            }
            textBox_NickName.Text = nickName;
            textBox_name.Text = name;
            comboBox_sex.Text = sex;
            comboBox_age.Text = age.ToString();
            comboBox_start.Text = star;
            comboBox_blood.Text = blood;
            textBox_sign.Text = sign;
        }


        //确定
        private void label8_MouseHover(object sender, EventArgs e)
        {
            label_ok.ForeColor = System.Drawing.Color.Black;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label_ok.ForeColor = System.Drawing.Color.Gray;
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            Qian();
            nickName = textBox_NickName.Text;
            name = textBox_name.Text;
            sex = comboBox_sex.Text;
            age = int.Parse(comboBox_age.Text);
            star = comboBox_start.SelectedIndex.ToString();//->int +1
            blood = comboBox_blood.SelectedIndex.ToString();//int +1
            sign = textBox_sign.Text;

            String sql = String.Format("update Users set NickName='{0}',Name='{1}',Sex='{2}',Age='{3}',StarId={4},BloodTypeId={5},MySign='{6}' where Id={7}", nickName, name, sex, age, int.Parse(star) + 1, int.Parse(blood) + 1, sign, userId);
            MySqlCommand cmd = new MySqlCommand(sql,c);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}

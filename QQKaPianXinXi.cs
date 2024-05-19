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
    public partial class QQKaPianXinXi : Form
    {
        public int x;
        public int y;


        public int userId;
        String nickName = "";
        String name = "";
        String sex = "";
        String age = "";
        String star = "";
        int faceId = 0;
        String blood="";
        public QQKaPianXinXi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        MySqlConnection c;
        private void Qian()
        {
            this.Left = x;
            this.Top = y;
            String s = "server=192.168.43.173;uid=root;pwd=password;database=MyQQ"; // 修改数据库连接字符串
            c = new MySqlConnection(s); // 修改为 MySqlConnection
            c.Open();
        }

        public void QQKaPianXinXi_Load(object sender, EventArgs e)
        {
            changeImfo();
            if (userId != QQuser.userId) {
                label_changeZiLiao.Visible = false;
                label_changeFace.Visible = false;
                pictureBox_carClose.Visible = false;
            }

        }

        public void changeImfo() {
            Qian();
            String sql = String.Format("select NickName,Sex,Name,Age,Star,FaceId,BloodType from Users inner join Star on Users.StarId=Star.Id inner join BloodType on Users.BloodTypeId=BloodType.Id where Users.Id={0}", userId);
            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                nickName = r[0].ToString();
                sex = r[1].ToString();
                name = String.Format("({0})", r[2].ToString());
                age = r[3].ToString();
                star = r[4].ToString();
                faceId = int.Parse(r[5].ToString());
                blood = r[6].ToString();
            }
            label_NikeName.Text = nickName;
            label_name.Text = name;
            label_sex.Text = sex;
            label_age.Text = age + "岁";
            label_start.Text = star;
            String img = "QQ头像/" + faceId + ".bmp";
            pictureBox_face.BackgroundImage = Image.FromFile(img);
            label_blood.Text = blood;
            label_qqnumber.Text = userId.ToString();
        }


        //修改资料
        private void label_changeZiLiao_MouseHover(object sender, EventArgs e)
        {
            label_changeZiLiao.ForeColor = System.Drawing.Color.Black;
        }

        private void label_changeZiLiao_MouseLeave(object sender, EventArgs e)
        {
            label_changeZiLiao.ForeColor = System.Drawing.Color.Gray;
        }

        private void label_changeZiLiao_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeImfoForm fr = new ChangeImfoForm();
            fr.x = this.Left + this.Width;
            fr.y = this.Top;
            fr.FormClosed += ChangeImfoForm_FormClosed;
            fr.Show();
        }

        private void ChangeImfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            changeImfo();
        }

        //修改头像
        private void label_changeFace_MouseHover(object sender, EventArgs e)
        {
            label_changeFace.ForeColor = System.Drawing.Color.Black;
        }

        private void label_changeFace_MouseLeave(object sender, EventArgs e)
        {
            label_changeFace.ForeColor = System.Drawing.Color.Gray;
        }

        private void label_changeFace_MouseClick(object sender, MouseEventArgs e)
        {
            FaceChoose fr = new FaceChoose();
            fr.x = this.Left+this.Width;
            fr.y = this.Top;
            fr.FormClosed+= FaceChoose_FormClosed;
            fr.Visible = true;           
        }
        private void FaceChoose_FormClosed(object sender, FormClosedEventArgs e)
        {
            changeImfo();
        }

        //关闭按钮
        private void pictureBox_carClose_MouseHover(object sender, EventArgs e)
        {
            pictureBox_carClose.BackgroundImage = Image.FromFile("素材/QQClose.jpg");
        }

        private void pictureBox_carClose_MouseLeave(object sender, EventArgs e)
        {
             pictureBox_carClose.BackgroundImage = Image.FromFile("素材/qqclosekong.png");
        }

        private void pictureBox_carClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        //窗体移动
        Point p;
        private void QQKaPianXinXi_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(p.X, p.Y);
                Location = mousePos;
            }
        }
        private void QQKaPianXinXi_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(-e.X, -e.Y);
        }
    }


}

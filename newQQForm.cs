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

    /*注册窗口
     *Id自动生成
     * 必填 LoginPwd(密码)、NickName(昵称)、Sex（性别）、Age(年龄)、pwdQ(密保问题)、pwdA(密保答案)
     * 可选 FaceId（默认0）
     * 默认 FriendshipPolicyId（1）、isRemeber（0）、isAuto（0）、其余为空
     * (共18项目)Id	LoginPwd	FriendshipPolicyId	NickName	FaceId	Sex	 Age	Name	StarId	BloodTypeId	Q	A	LastLoginTime	isRemeber	isAuto	MySign	pwdQ	pwdA
     */
    public partial class newQQForm : Form
    {
        public newQQForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        MySqlConnection c;
        private void Qian()
        {
            String s = "server=192.168.43.173;uid=root;pwd=password;database=MyQQ"; 
            c = new MySqlConnection(s);
            c.Open();
        }

        private void newQQForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++) {
                comboBox_age.Items.Add(i);
            }
            timer1.Start();
            timer1.Interval = 1500;
        }

        //图片滚动播放
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i + 1 == 4)
            {
                i = 1;
            }
            else
            {
                i++;
            }
            String file = @"newqq/gun" + i+".png";
            label_pict.Image = Image.FromFile(file);

        }

        //TiNickName昵称空判定
        private void textBox_NickName_Leave(object sender, EventArgs e)
        {
            if (textBox_NickName.Text == "")
            {
                label_TiNickName.Visible = true;
            }
            else {
                label_TiNickName.Visible = false;
            }
        }

        //密码空判定
        private void textBox_LoginPwd_Leave(object sender, EventArgs e)
        {
            if (textBox_LoginPwd.Text == "")
            {
                label_TiPwd.Visible = true;
            }
            else
            {
                label_TiPwd.Visible = false;
            }
        }

        //密保空判定
        private void textBox_pwdQ_Leave(object sender, EventArgs e)
        {
            if (textBox_pwdQ.Text == "")
            {
                label_TiPwdQ.Visible = true;
            }
            else
            {
                label_TiPwdQ.Visible = false;
            }
        }

        //
        private void textBox_pwdA_Leave(object sender, EventArgs e)
        {
            if (textBox_pwdA.Text == "")
            {
                label_TiPwdA.Visible = true;
            }
            else
            {
                label_TiPwdA.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_NickName.Text != "" && textBox_LoginPwd.Text != "" && textBox_pwdQ.Text != "" && textBox_pwdA.Text != "")
            {
                Qian();
                String LoginPwd = textBox_LoginPwd.Text;
                String NickName = textBox_NickName.Text;
                String Sex = radioButton_men.Checked ? "男" : "女";
                int Age = int.Parse(comboBox_age.Text);
                String pwdQ = textBox_pwdQ.Text;
                String pwdA = textBox_pwdA.Text;
                String sql = String.Format("insert into Users (LoginPwd,FriendshipPolicyId,NickName,FaceId,Sex,Age,isRemember,isAuto,pwdQ,pwdA)values('{0}',1,'{1}',0,'{2}',{3},0,0,'{4}','{5}');select Id from Users where NickName='{6}'", LoginPwd, NickName, Sex, Age, pwdQ, pwdA,NickName);
                MySqlCommand cmd = new MySqlCommand(sql, c); 
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read()) {
                    String Id = r[0].ToString();
                    MessageBox.Show("请牢记你的账号：" + Id + "\n快去登陆吧！","注册成功");
                    this.Close();
                }
                c.Close();
            }
            else {
                MessageBox.Show("信息填写不完整");
            }
        }
    }
}

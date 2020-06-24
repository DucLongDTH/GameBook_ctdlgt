using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBook
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (GameBookMB.Show("bạn có muốn thoát không ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private int checkTK()
        {
            SqlConnection ketnoi = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SOURECODE\C# WINFORM\JOB-20200622T095042Z-001\JOB\GAMEBOOK\GAMEBOOK.MDF;Integrated Security=True");
            ketnoi.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) From Account Where Username= @username and Password = @password", ketnoi);
            cmd.Parameters.Add(new SqlParameter("username", tbUser.Text));
            cmd.Parameters.Add(new SqlParameter("password", textBox1.Text));
            int dem = Int32.Parse(cmd.ExecuteScalar().ToString());
            ketnoi.Close();
            return dem;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbUser.Text == "" || textBox1.Text == "")
            {
                GameBookMB.Show("Mời bạn điền đủ thông tin tài khoản !", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                int check = checkTK();
                if (check == 1)
                {
                    this.Hide();
                    MainBoard form = new MainBoard();
                    form.Show();
                }
                else
                {
                    GameBookMB.Show(" Thông tin tài khoản bị sai !", "Lỗi", MessageBoxButtons.OK);
                    tbUser.Text = "";
                    textBox1.Text = "";
                }
            }
            
        }
    }
}

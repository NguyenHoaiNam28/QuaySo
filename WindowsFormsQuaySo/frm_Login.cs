using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsQuaySo.Data;

namespace WindowsFormsQuaySo
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private List<User> listUser;
        UserDAO _userDAO;

        private void frm_Login_Load(object sender, EventArgs e)
        {
            _userDAO = new UserDAO();
            _userDAO.GetUser(Cls_Main.pathfile);
            Cls_Main._listUser = _userDAO.listUser;

            listUser = Cls_Main._listUser;
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập
            
            if (!string.IsNullOrEmpty(txbUserName.Text))
            {
                if (!string.IsNullOrEmpty(txbPassWord.Text))
                {

                    if (Kiemtradangnhap(txbUserName.Text, txbPassWord.Text))
                    {

                        frm_QuaySoMayMan fQuaySoMayMan = new frm_QuaySoMayMan();
                        this.Hide();
                        fQuaySoMayMan.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Nhập tên đăng nhập", "Thông báo");
            }
        }
        //Hàm kiểm tra đăng nhập
        private bool Kiemtradangnhap(string tenDangNhap, string matKhau)
        {
            foreach (User item in listUser)
            {
                if (item.TenDangNhap.Equals(tenDangNhap) && item.MatKhau.Equals(matKhau))
                {
                    item.Remember = chkbRemember.Checked;
                    Cls_Main._staticUser = item;
                    return true;
                }

            }
            return false;

        }

        private void txbUserName_Leave_1(object sender, EventArgs e)
        {
            foreach (User item in listUser)
            {
                if (item.TenDangNhap == txbUserName.Text && item.Remember)
                {
                    chkbRemember.Checked = true;
                    txbPassWord.Text = item.MatKhau;
                    btnLogin.Focus();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

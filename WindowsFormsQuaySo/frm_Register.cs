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
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }
        public bool isAdd = false;
         UserDAO userDAO;
        private void frm_Register_Load(object sender, EventArgs e)
        {
            userDAO = new UserDAO();
            userDAO.GetUser(Cls_Main.pathfile);
            LoadDataToComPhongBan();
            if (isAdd == true)
            {
                //Thêm User
                txtID.Text = CreateMaxID();
                txtID.Enabled = false;


            }
            else
            {
                //Sửa user
                SetDataToControl(user);
            }
        }

        private void LoadDataToComPhongBan()
        {
            List<PhongBan> userType = new List<PhongBan>() {
                new PhongBan(){IDPhongBan = 1, NamePhongban = "Phòng hành chính"},
                new PhongBan(){IDPhongBan = 2, NamePhongban = "Phòng IT"},
                new PhongBan(){IDPhongBan = 3, NamePhongban = "Phòng kế toán"},
                new PhongBan(){IDPhongBan = 4, NamePhongban = "Phòng nội vụ"}
            };


            //Gán vào Datasource cua combo
            cboPhongBan.DataSource = userType;
            //Thiết lập thuộc tính
            cboPhongBan.DisplayMember = "NamePhongban";
            cboPhongBan.ValueMember = "IDPhongBan";
        }

        public User user;

        private void SetDataToControl(User user)
        {
            txtID.Text = user.ID.ToString();
            txthoTen.Text = user.HoTen.ToString();
            txtTenDangNhap.Text = user.TenDangNhap.ToString();
            txtMatKhau.Text = user.MatKhau.ToString();
            chkbRemember.Checked = user.Remember;
            cboPhongBan.SelectedValue = user.PhongBan;
        }

        string err = string.Empty;


        private string CreateMaxID()
        {
            string maxID = string.Empty;
            maxID = userDAO.GetMaxID().ToString();
            return maxID;
        }
        

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txthoTen.Text))
            {
                if (!string.IsNullOrEmpty(txtTenDangNhap.Text))
                {
                    if (!string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        if (cboPhongBan.SelectedIndex > -1)
                        {
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                HoTen = txthoTen.Text,
                                TenDangNhap = txtTenDangNhap.Text,
                                MatKhau = txtMatKhau.Text,
                                Remember = chkbRemember.Checked,
                                PhongBan = cboPhongBan.Text
                            };

                            if (UpdateUser(ref err, user))
                            {
                                MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tên hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool UpdateUser(ref string err, User user)
        {
            try
            {
                if (isAdd)
                {
                    userDAO.listUser.Add(user);
                    userDAO.WriteUser(Cls_Main.pathfile);
                    return true;
                }
                else
                {
                    foreach (User item in userDAO.listUser)
                    {
                        if (item.ID == user.ID)
                        {
                            item.HoTen = user.HoTen;
                            item.TenDangNhap = user.TenDangNhap;
                            item.MatKhau = user.MatKhau;
                            item.Remember = user.Remember;
                            item.PhongBan = user.PhongBan;
                        }
                    }
                    userDAO.WriteUser(Cls_Main.pathfile);
                    return true;
                }
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class frm_Account : Form
    {
        public frm_Account()
        {
            InitializeComponent();
        }

        UserDAO userDAO;
        List<User> listUser;

        private void frm_Account_Load(object sender, EventArgs e)
        {
            userDAO = new UserDAO();

            GetDataToDataGridView();
        }
        private void GetDataToDataGridView()
        {
            //Lấy được data
            userDAO.GetUser(Cls_Main.pathfile);
            listUser = userDAO.listUser;

            //Gán danh sách user vào data
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listUser;
            dgvUserList.DataSource = bindingSource;

            //lblQuantity.Text = dgvUserList.RowCount.ToString();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_Register frmRegister = new frm_Register();
            frmRegister.isAdd = true;
            frmRegister.ShowDialog();
            GetDataToDataGridView();
        }
        User user;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                frm_Register frmRegister = new frm_Register();
                frmRegister.isAdd = false;
                frmRegister.user = user;
                frmRegister.ShowDialog();
                user = null;
                GetDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Chọn tài khoản cần sửa");
            }
        }


        private void dgvUserList_Click(object sender, EventArgs e)
        {
            if (dgvUserList.RowCount > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUserList.CurrentRow.Cells["colID"].Value.ToString()),
                    HoTen = dgvUserList.CurrentRow.Cells["colHoTen"].Value.ToString(),
                    TenDangNhap = dgvUserList.CurrentRow.Cells["colTenDangNhap"].Value.ToString(),
                    MatKhau = dgvUserList.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    Remember = Convert.ToBoolean(dgvUserList.CurrentRow.Cells["colRemember"].Value.ToString()),
                    PhongBan = dgvUserList.CurrentRow.Cells["colPhongBan"].Value.ToString()

                };
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                userDAO.listUser.Remove(user);
                userDAO.WriteUser(Cls_Main.pathfile);
                user = null;
                GetDataToDataGridView();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetDataToDataGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class frm_QuaySoMayMan : Form
    {
        List<Employee> employees;
        EmployeeDAO employeeDAO;
        public frm_QuaySoMayMan()
        {
            InitializeComponent();
        }

        List<NhanVienNhanGiai> nhanVienNhanGiais;
        NhanVienNhanGiaiDAO nhanVienNhanGiaiDAO;
        private void frmQuaySoMayMan_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>();
            employeeDAO = new EmployeeDAO();
            nhanVienNhanGiais = new List<NhanVienNhanGiai>();
            nhanVienNhanGiaiDAO = new NhanVienNhanGiaiDAO();
            LoadComboGiaiThuong();


        }

        private void LoadComboGiaiThuong()
        {
            GiaiThuongDAO giaiThuong = new GiaiThuongDAO();
            giaiThuong.DocFileDanhSachGiaiThuong(Application.StartupPath+@"\GiaiThuong.ini");

            cboGiaiThuong.DataSource = giaiThuong.giaiThuongs;

            cboGiaiThuong.DisplayMember = "TenGiai";
            cboGiaiThuong.ValueMember = "ID";
        }

        bool isOpen = true;
        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (employees.Count > 0)
            {
                if (isOpen)
                {
                    timer1.Enabled = true;
                    btnQuay.Text = "Dừng";
                    isOpen = false;
                    
                }
                else
                {
                    timer1.Enabled = false;
                    btnQuay.Text = "Quay";
                    isOpen = true;
                    ThemDSGiai(EmployeeID);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh sách");
            }

        }
        private void ThemDSGiai(int ID)
        {
            Employee employee = employeeDAO.GetNhanVienTheoID(ID);
            NhanVienNhanGiai nhanVienNhanGiai = new NhanVienNhanGiai()
            {
                ID = employee.ID,
                HoTen = employee.HoTen,
                PhongBan = employee.PhongBan,
                Giai = cboGiaiThuong.Text
            };
            nhanVienNhanGiais.Add(nhanVienNhanGiai);
            HienThiDSNhanGiai();
        }

        private void HienThiDSNhanGiai()
        {
            int i = 1;

            nhanVienNhanGiais.Sort();//Tăng dần
            //nhanVienNhanGiais.Reverse();//Giảm dần

            foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
            {
                item.STT = i++;
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanVienNhanGiais;
            dgvDSTThuong.DataSource = bindingSource;
        }

        private void TachID(int iD)
        {

            //12345
            int mumber = iD;
            if (mumber > 0)
            {
                lblMunber5.Text = (mumber % 10).ToString();
                mumber = mumber / 10;
            }
            if (mumber > 0)
            {
                lblMunber4.Text = (mumber % 10).ToString();
                mumber = mumber / 10; }
            if (mumber > 0)
            {
                lblMunber3.Text = (mumber % 10).ToString();
                mumber = mumber / 10; }
            if (mumber > 0)
            {
                lblMunber2.Text = (mumber % 10).ToString();
                mumber = mumber / 10;
            }
            if (mumber > 0)
            {
                lblMunber1.Text = (mumber % 10).ToString();
                mumber = mumber / 10;
            }
        }

        private void btnDSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.ini)|*.ini|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn danh sách quay";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                //Gọi hàm đọc file
                employeeDAO.DocFileDanhSach(path);
                employees = employeeDAO.employees;

                HienThiDSNhanVien();
            }
            //openFileDialog.ShowDialog();
        }

        private void HienThiDSNhanVien()
        {
            int i = 1;
            foreach (Employee item in employees)
            {
                item.STT = i++;
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = employees;
            dgvDSQuay.DataSource = bindingSource;
        }
        int EmployeeID = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(employees.Count);
            EmployeeID = employees[a].ID;
            TachID(EmployeeID);
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            if (nhanVienNhanGiais.Count > 0)
            {
                try
                {
                    //Đối tường SaveFileDialog cho phép hiển thị một hộp thoại saveFile. Hộp thoại này cho phép nhập tên file và nơi lưu file Excel 
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //Hien thi thu muc khoi tao
                    saveFileDialog.InitialDirectory = @"d:\";
                    //xác định vị trí có được nhớ lại khi mở tiếp hộp thoại này hay không 
                    saveFileDialog.RestoreDirectory = true;

                    saveFileDialog.Filter = "Text files (*.xls)|*.xls|All files (*.*)|*.*";//Lọc loại file
                    saveFileDialog.DefaultExt = "xls";//Phần mở rộng mặc định
                    saveFileDialog.AddExtension = true;

                    saveFileDialog.Title = "Lưu file Excel";//Tiêu đề của hộp thoại
                    saveFileDialog.FileName = string.Format("TrungThuong_{0}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);//trungthuong2021101801
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
                    {
                        //Thực hiện lấy danh sách nhân viên nhận giải
                        nhanVienNhanGiaiDAO.nhanVienNhanGiais = nhanVienNhanGiais;
                        //Luu danh sachs nhan vien nhan giai vào file NhanVienNhanGiai.ini
                        nhanVienNhanGiaiDAO.GhiNoiDung(Cls_Main.pathNhanVienNhanGiai);
                        //thực hiện thao tác ghi nội dung vào file Excel 
                        nhanVienNhanGiaiDAO.XuatExcel(saveFileDialog.FileName);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi: ", ex.Message);
                }

            }

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frm_Account frmAcccout = new frm_Account();
            frmAcccout.Show();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

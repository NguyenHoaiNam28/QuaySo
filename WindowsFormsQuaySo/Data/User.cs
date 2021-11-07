using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsQuaySo.Data
{
    public class User: IComparable
    {
        private int iD;
        private string hoTen;
        private string tenDangNhap;
        private string matKhau;
        private bool remember;
        private string phongBan;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool Remember { get => remember; set => remember = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }

        public User() { }

        public User(int iD, string hoTen, string tenDangNhap, string matKhau, string phongBan, bool remember)
        {
            this.ID = iD;
            this.HoTen = hoTen;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.PhongBan = phongBan;
            this.Remember = remember;
        }

        

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", ID, HoTen, TenDangNhap
                , MatKhau, Remember.ToString(),PhongBan);
        }

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return this.ID.Equals(((User)obj).ID);
            }
            return false;

        }

        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return this.ID.CompareTo(((User)obj).ID);
            }
            return -1;
        }
    }
}

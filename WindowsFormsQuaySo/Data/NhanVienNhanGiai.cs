﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsQuaySo
{
    public class NhanVienNhanGiai: IComparable
    {
        int sTT = 0;
        int iD;
        string hoTen;
        string phongBan;
        string giai;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public int STT { get => sTT; set => sTT = value; }
        public string Giai { get => giai; set => giai = value; }

        public int CompareTo(object obj)
        {
            return this.Giai.CompareTo(((NhanVienNhanGiai)obj).Giai);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsQuaySo.Data
{
    public class UserDAO
    {

        public List<User> listUser = new List<User>();


        public void WriteUser(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (User item in listUser)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}", item.ID, item.HoTen, item.TenDangNhap, item.MatKhau, item.Remember.ToString(), item.PhongBan));
                    }
                }
            }
        }

        public void GetUser(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    User user;
                    listUser.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Kiểm tra xem line có giá trị hay không
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] userArray = line.Split(',');

                            user = new User();
                            user.ID = Convert.ToInt32(userArray[0]);
                            user.HoTen = userArray[1];
                            user.TenDangNhap = userArray[2].ToString();
                            user.MatKhau = userArray[3];
                            user.Remember = Convert.ToBoolean(userArray[4].ToString());

                            user.PhongBan = userArray[5];

                            //Thêm User vào danh sách listUser
                            listUser.Add(user);
                        }
                    }

                }
            }
        }
        public int GetMaxID()
        {
            int maxID = 0;
            foreach (User item in listUser)
            {
                if (item.ID > maxID)
                {
                    maxID = item.ID;

                }
            }
            return maxID + 1;
        }
    }
}

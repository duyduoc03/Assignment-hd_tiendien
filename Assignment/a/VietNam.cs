using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.a
{
    class VietNam : KhachHang
    {
        String DTKH;
        int[] DinhMuc = { 50, 100, 200 };
        public void Nhap()
        {
            base.Nhap();
            Console.Write("\tNhap Đoi Tuong Khach Hang: ");
            DTKH = Console.ReadLine();
            count++;
        }
        public int ThanhTien()
        {
            if (SoLuong < 50)
            {
                return SoLuong * 1000;
            }
            else if (SoLuong < 100)
            {
                return DinhMuc[0] * 1000 + (SoLuong - DinhMuc[0]) * 1200;
            }
            else if (SoLuong < 200)
            {
                return DinhMuc[1] * 1200 + (SoLuong - DinhMuc[1]) * 1500;
            }
            else
            {
                return DinhMuc[2] * 1500 + (SoLuong - DinhMuc[2]) * 2000;
            }
        }
        public void TongSL()
        {
            Console.WriteLine("Tong So Luong Khach Hang Viet Nam la: " + count);
        }
        public void In()
        {
            base.In();
            Console.WriteLine("\tĐoi Tuong Khach Hang: " + DTKH);
            Console.WriteLine("\tThanh Tien: " + ThanhTien() + "đ\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.a
{
    internal class KhachHang
    {
        public string MaKH, HoTen, NRHD;
        public int SoLuong, count = 0;
        public void Nhap()
        {
            Console.WriteLine("Nhap Thong Tin Cua Khach Hang");
            Console.Write("\tNhap Ma Khach Hang: ");         
            MaKH = Console.ReadLine();
            Console.Write("\tNhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("\tNhap Ngay Ra Hoa Đon: ");
            NRHD = Console.ReadLine();
            Console.Write("\tNhap So Luong Tieu Thu: ");
            SoLuong = int.Parse(Console.ReadLine());

        }
        public void In()
        {
            Console.WriteLine("\tMa Khach Hang: " + MaKH);
            Console.WriteLine("\tHo Ten: " + HoTen);
            Console.WriteLine("\tNgay Ra Hoa Đon: " + NRHD);
            Console.WriteLine("\tSo Luong Tieu Thu: " + SoLuong);
        }
        public int DonGia()
        {
            if (SoLuong < 50)
            {
                return 1000;
            }
            else if (SoLuong < 100)
            {
                return 1200;
            }
            else if (SoLuong < 200)
            {
                return 1500;
            }
            else
            {
                return 2000;
            }
        }
    }
}

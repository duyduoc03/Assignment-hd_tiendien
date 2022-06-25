using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.a
{
    internal class NuocNgoai : KhachHang
    {
        string QuocTich;
        int[] arr = new int[10];
        KhachHang kh = new KhachHang();
        public void Nhap()
        {
            base.Nhap();
            Console.Write("\tNhap Quoc Tich: ");
            QuocTich = Console.ReadLine();
            arr[count] = ThanhTien();
            count++;
        }
        public int ThanhTien()
        {
            return SoLuong * DonGia();
        }
        public void TongSL()
        {
            Console.Write("Tong So Lượng Khach Hang Nuoc Ngoai la: " + count);
        }
        public int TBTT()
        {
            int kq = 0;
            for (int i = 0; i < count; i++)
            {
                kq += arr[i];
            }
            return kq / count;
        }
        public void In()
        {
            base.In();
            Console.WriteLine("\tQuoc Tich: " + QuocTich);
            Console.WriteLine("\tThanh Tien: " + ThanhTien() + "đ\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.a;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NuocNgoai nn = new NuocNgoai();
            VietNam vn = new VietNam();
            Console.Write("Nhap So Hoa Don: ");
            int shd = int.Parse(Console.ReadLine());
            string quoctich;
            for (int i = 0; i < shd; i++)
            {
                Console.Write("Nhap Quoc Tich: ");
                quoctich = Console.ReadLine();
                if(quoctich == "vietnam" || quoctich == "VietNam" || quoctich == "Viet Nam")
                {
                    vn.Nhap();
                }
                else
                {
                    nn.Nhap();
                }
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\t\tHien thi Thong Tin Cua Cac Hoa Don");
            nn.In();
            vn.In();
            Console.WriteLine("\t\tTong So Luong Tung Loai Khach Hang");
            vn.TongSL();
            nn.TongSL();

            Console.WriteLine("\n\nThanh Tien Trung Binh Cua Nguoi Nuoc Ngoai = " + nn.TBTT());
        }
    }
}

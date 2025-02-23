using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat
{
    class Program
    {
        enum MauSac
        {
            xanhLamNhat,
            DoMau,
            VangKim
        }

        class Diem
        {
            public int x { get; set; }
            public int y { get; set; }
            public MauSac mau { get; set; }

            public Diem(int x, int y, MauSac mau)
            {
                this.x = x;
                this.y = y;
                this.mau = mau;
            }

            public string MauSacString()
            {
                switch (mau)
                {
                    case MauSac.xanhLamNhat:
                        return "Xanh lam nhat";
                    case MauSac.DoMau:
                        return "Do mau";
                    case MauSac.VangKim:
                        return "Vang kim";
                    default:
                        return "...";
                }
            }

            public void hienThi()
            {
                Console.WriteLine($"Diem ({x}, {y}), Mau: {MauSacString()}");
            }
        }

        class HinhChuNhat
        {
            public Diem gocTrenTrai { get; set; }
            public Diem gocDuoiPhai { get; set; }

            public HinhChuNhat(Diem gocTrenTrai, Diem gocDuoiPhai)
            {
                this.gocTrenTrai = gocTrenTrai;
                this.gocDuoiPhai = gocDuoiPhai;
            }

            public void hienThi()
            {
                Console.WriteLine("\nHinh chu nhat:");
                Console.WriteLine("Goc tren trai:");
                gocTrenTrai.hienThi();
                Console.WriteLine("Goc duoi phai:");
                gocDuoiPhai.hienThi();
            }
        }

        static void Main(string[] args)
        {
            Diem p1_138 = new Diem(2, 5, MauSac.xanhLamNhat);
            Diem p2_138 = new Diem(8, 2, MauSac.DoMau);

            HinhChuNhat hcn = new HinhChuNhat(p1_138, p2_138);

            hcn.hienThi();

            Console.ReadLine(); 
        }
    }
}

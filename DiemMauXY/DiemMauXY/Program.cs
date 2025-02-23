using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemMauXY
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

        public static string MauSacString(MauSac mau)
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
            Console.WriteLine($" Diem {x}, {y}, Mau: {MauSacString(mau)}");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Diem p1_138 = new Diem(1, 3, MauSac.xanhLamNhat);
            Diem p2_138 = new Diem(3, 8, MauSac.DoMau);
            Diem p3_138 = new Diem(1, 8, MauSac.VangKim);

            p1_138.hienThi();
            p2_138.hienThi();
            p3_138.hienThi();

            Console.ReadLine();
        }
    }
}

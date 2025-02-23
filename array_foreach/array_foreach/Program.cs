using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] id_138 = new int[14];

            Console.WriteLine("nhap vao id:");
            for (int i = 0; i < id_138.Length; i++)
            {
                Console.Write("Nhap so thu {0}: ", i + 1);
                id_138[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMa sinh vien:");
            foreach (int id in id_138)
            {
                Console.Write(id + "");
            }

            Console.ReadLine(); 
        }
    }
}

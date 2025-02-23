using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Infor
        {
          id01_138 = 2,
          id02_138 = 2,
          id12_138 = 1,
          id13_138 = 3,
          id14_138 = 8
        }

        static void Main(string[] args)
        {
            string id_138 = $"{(int)Infor.id01_138}{(int)Infor.id02_138}...{(int)Infor.id12_138}{(int)Infor.id13_138}{(int)Infor.id14_138}";
            Console.WriteLine("Id: " + id_138);
            Console.ReadLine();
        }
    }
}

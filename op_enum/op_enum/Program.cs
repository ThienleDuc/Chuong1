using System;

namespace op_enum
{
    class Program
    {
        enum Infor
        {
            name_138,
            id_138
        }

        // Phương thức Student phải là static vì Main() là static
        private static string Student(Infor infor)
        {
            switch (infor)
            {
                case Infor.name_138:
                    return "Le Duc Thien";
                case Infor.id_138:
                    return "22115053122138";
                default:
                    return "answer...";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Name: " + Student(Infor.name_138));
            Console.WriteLine("ID: " + Student(Infor.id_138));

            Console.ReadLine(); 
        }
    }
}

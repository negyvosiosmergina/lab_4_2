using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_1_POGI_S3
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 0;
        start:
            Console.WriteLine("Выберите пункт меню \n    1)Введите A\n    2)Введите B\n    3)Операция +\n    4)Операция -\n    5)Операция *\n    6)Операция /\n");
            string q = Console.ReadLine();


            switch (q)
            {
                case "6":
                    Console.Write("\n");
                    Console.Write("A/B = {0}", a / b);
                    Console.WriteLine();
                    goto start;

            }
        }
    }
}

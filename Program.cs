using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Chuyendoinhietdo
{
    internal class Program
    {

        public static double CtoF(double c)
        {
            double ctof = (9.0 / 5) * c + 32;
            return ctof;
        }
        public static double FtoC(double f)
        {
            double FtoC = (5.0 / 9) * (f - 32);
            return FtoC;
        }

        static void Main(string[] args)
        {
            double f;
            double c;
            int choice;
            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Do F sang Do c");
                Console.WriteLine("2. Do C Sang Do F");
                Console.WriteLine("0. Thoat");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("nhap do F");
                    f = double.Parse(Console.ReadLine());
                    Console.WriteLine("do F chuyen sang do C " + FtoC(f));break;
                    case 2: Console.WriteLine("nhap do C");
                    c = double.Parse(Console.ReadLine());
                        Console.WriteLine("do C chuyen sang do F " + CtoF(c)) ; break;
                    case 0: Environment.Exit(0);
                        break;
                }
            }while (choice != 0);
            
        }



    }
}

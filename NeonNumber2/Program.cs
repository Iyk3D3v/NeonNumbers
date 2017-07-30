using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for neon numbers
            int num = 9;
            int sum = num * num;

            string Snum = sum.ToString();

            int numlength = Snum.Length;

            char[] numChar = new char[numlength];



            numChar = Snum.ToCharArray();



            Console.WriteLine($"{numChar[1]}");
            Console.ReadLine();
        }
    }
}

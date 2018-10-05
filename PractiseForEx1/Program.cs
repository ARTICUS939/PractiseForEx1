using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseForEx1
{
    class Program
    {
        static void Main(string[] args)
        {

                for (int i = 1; i <= 10; i++)

                if (i % 2 == 0)
                {
                    Convert.ToString(i);
                    Console.Write(i + " ");    //выпишем все четные диапазона
                }

            Console.ReadLine();

        }
    }
}

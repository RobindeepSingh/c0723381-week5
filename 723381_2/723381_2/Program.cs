using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _723381_2
{
    class Program
    {
        static void Main(string[] args)
            {
                MethodA();
            }

            public static void MethodA()
            {
                while (Peanut())
                {
                    Console.WriteLine("Help! I am stuck in infinite loop");

                }
            }

            public static bool Peanut()
            {
                return true;
            }
        }
    }
}

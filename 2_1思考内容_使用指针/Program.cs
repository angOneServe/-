using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1思考内容_使用指针
{
    class Program
    {
        static void Main(string[] args)
        {
            //不安全代码
            unsafe
            {
                int num1 = 1;
                int num2 = 2;
                int* numP = &num1;

                Console.WriteLine(*numP);

                ChangeIntNum(&num1);
                Console.WriteLine(*numP);

                numP = &num2;
                Console.WriteLine(*numP);
            }

            Console.ReadKey();
        }
        public static unsafe void ChangeIntNum(int* np)
        {
            *np = 123;
        }
    }
}

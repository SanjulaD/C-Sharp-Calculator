using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static float Calc(float a, float b)
        {
            float num,ans=0;
            Console.Write("Enter the  number : \n");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                ans = (float)(a + b);
            }
            else if (num == 2)
            {
                ans = a - b;
            }
            else if (num == 3)
            {
                ans = a * b;
            }
            else
            {
                ans = a / b;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("Enter the 1st number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division\n");
            Console.WriteLine("Answer is {0}", Calc(x, y));
            Console.ReadLine();
        }
    }
}

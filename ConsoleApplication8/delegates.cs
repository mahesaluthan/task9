using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public delegate double Delegate_Prod(int a, int b);
    class Program
    {
        static double fn_Provalues(int val1, int val2)
        {
            return val1 * val2;
        }
        static void Main(string[] args)
        {
            Delegate_Prod exam = new Delegate_Prod(fn_Provalues);
            Console.Write("please enter the values:  ");
            int v1 = Int32.Parse(Console.ReadLine());
            Console.Write("and ");
            int v2 = Int32.Parse(Console.ReadLine());

            double res = exam(v1, v2);
            Console.WriteLine("Result :" + res);
            Console.ReadLine();
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class sorting
    {
        static void Main(string[] args)
        {
            int[] nilai = new int[10];
            int temp;

            for (int i=0; i < 10;i++ )
            {
                Console.Write("nilai: ");
                nilai[i] = Convert.ToInt16(Console.ReadLine());
            }

            for(int i=0;(i <= (9 -1)); i++)
            {
                if (nilai[i + 1] > nilai[i])
                {
                    temp = nilai[i];
                    nilai[i] = nilai[i + 1];
                    nilai[i + 1] = temp;

                }
            }


            Console.ReadLine();
        }
    }
}

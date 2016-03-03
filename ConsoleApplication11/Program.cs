using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            N = Convert.ToInt32(Console.ReadLine());
            List<int> result = new List<int>();
            for (int k = 0; k < N; k++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                i = 1;
                while (number > i)
                {
                    number -= i;
                    i++;
                }
                if (number == 1)
                     result.Add(1);
                else result.Add(0);
            }
            int size = result.Count;
            for (i = 0; i < size; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}

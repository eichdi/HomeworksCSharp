using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxLenghtSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader("input.txt");
            StreamWriter b = new StreamWriter("output.txt");
            int lenght = int.Parse(a.ReadLine());
            string[] num= a.ReadLine().Split();
            int result=0;
            int max=0;
            int pred=int.MinValue;
            for (int i = 0; i < lenght; i++)
            {
                if (pred < int.Parse(num[i]))
                {
                    max++;
                }
                else
                {
                    if (max > result)
                    {
                        result = max;
                    }
                    max=0;
                }
                pred = int.Parse(num[i]);
            }

            b.Write(result);
          

        }
    }
}

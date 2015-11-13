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
            string o = a.ReadToEnd();
            int num;


            for(int i=1;i<=o.Length;i++)
            {
                if (!(o[i] == ' '))
                {
                    num = int.Parse(o.Substring(0, 1)) * i;
                    o = o.Substring(0, 1);
                }
            }

        }
    }
}

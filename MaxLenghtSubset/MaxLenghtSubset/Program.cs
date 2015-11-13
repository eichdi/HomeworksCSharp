using System;
using System.IO;


    public class MaxLenghtSubset
    {
        public static void Main()
        {
            StreamReader a = new StreamReader("input.txt");
            StreamWriter b = new StreamWriter("output.txt");
            int lenght = int.Parse(a.ReadLine());
            string[] num = a.ReadLine().Split();
            int result = 0;
            int max = 0;
            int pred = int.MinValue;
            for (int i = 0; i < lenght; i++)
            {
                if (pred <= int.Parse(num[i]))
                {
                    max++;
                }
                else
                {
                    max = 1;
                }
                if (max > result)
                {
                    result = max;
                }
                pred = int.Parse(num[i]);
            }

            b.WriteLine(result);
            a.Close();
            b.Close();
        }
    }


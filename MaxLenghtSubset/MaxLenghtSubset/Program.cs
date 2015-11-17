using System;
using System.IO;


    public class MaxLenghtSubset
    {
        //Не проходит по времени №1
       /* public static int MaxSubset(string[] num, int index)
        {
            int result=0;
            int temp;
            if (index + 1 != num.Length)
            {
                for (int i = index+1; i < num.Length; i++)
                {
                    if (long.Parse(num[index]) < long.Parse(num[i]))
                    {
                        temp = MaxSubset(num, i);
                        if (temp > result)
                        {
                            result = temp;
                        }
                    }
                }
            }
                return result+1;
        }*/
        //Не проходит по времени №2
        /*public static int MaxSubset2(int[] num, int index, int pred)
        {
            int[] kolbig = new int[num.Length];
            for (int i = index; i < kolbig.Length; i++)
            {
                if (num[i] > pred)
                {
                    for (int j = i + 1; j < kolbig.Length; j++)
                    {

                        if (num[i] < num[j])
                        {
                            kolbig[i]++;
                        }
                    }
                }
                else
                    num[i] = 0;
            }
            
            int max_value=0;
            int max_index=0;
            for (int i = 0; i < kolbig.Length; i++)
            {
                if (kolbig[i] > max_value)
                {
                    max_value = kolbig[i];
                    max_index = i;
                }
            }
            if (max_value == 0)
            {
                return 1;
            }
            else
            {
                return MaxSubset2(num, max_index, num[max_index])+1;
            }
                
        }*/
        public static void Main()
        {
            StreamReader a = new StreamReader("input.txt");
            StreamWriter b = new StreamWriter("output.txt");
            int lenght = int.Parse(a.ReadLine());
            string[] snum = a.ReadLine().Split();
            int[] num = new int[snum.Length];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(snum[i]);
            }
            //Чистка массива
            bool[] clear = new bool[num.Length];
            for (int i = 0; i < clear.Length; i++)
            {
                if (!clear[i])
                {
                    for (int j = i + 1; j < clear.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            clear[j] = true;
                        }
                    }
                }
            }
            //
            int[] l = new int[num.Length];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = 1;
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (!clear[i])
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (num[i] > num[j] && l[i] < l[j] + 1)
                        {
                            l[i] = l[j] + 1;
                        }
                    }
                }
            }
            int result=l[0];
            for (int i = 1; i < l.Length; i++)
            {
                if(l[i]>result){
                    result=l[i];
                }
            }
            
                //Не проходит по времени №1
                /*int result=0;
                int temp;
                for (int i = 0; i < lenght; i++)
                {
                    temp = MaxSubset(num, i);
                    if (result < temp)
                    {
                        result = temp;
                    }
                }
                b.WriteLine(result);*/
                b.WriteLine(result);
            a.Close();
            b.Close();
           
        }
    }


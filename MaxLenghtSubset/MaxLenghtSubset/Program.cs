using System;


    public class MaxLenghtSubset
    {

        public static void Main()
        {
            
            int lenght = int.Parse(Console.ReadLine());
            int[] num = new int[lenght];
            string temp = Console.ReadLine();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(temp.Split()[i]); 
            }
            
            int[] l = new int[num.Length];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = 1;
            }
            for (int i = 0; i < num.Length; i++)
            {
                
                    for (int j = 0; j < i; j++)
                    {
                        if (num[i] > num[j] && l[i] < l[j] + 1)
                        {
                            l[i] = l[j] + 1;
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
            
            Console.WriteLine(result);
           
        }
    }


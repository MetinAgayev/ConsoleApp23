using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    class Class2
    {
        public int lres = 0;

        public void Method()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int min = arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {
                
                int num=arr[i];
                if (num<min)
                {
                    min = num;
                   
                }
                
            }
            Console.WriteLine(min);
        }
        public void Method1()
        {
            
            int[] arr1={100,12,230 };
            int res = 0;
            int res1 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
              
                
                if (arr1[i] > 99 & arr1[i] < 1000)
                {
                    res = res + arr1[i];
                }
                else
                {
                    res1 = res1 + arr1[i];
                }
               
            }
            Console.WriteLine(res-res1);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    class Class1
    {
        public void Method(double num)
        {
            
            while (num>1)
            {
                num = num / 2;
               
            }
            if (num == 1)
            {
                Console.WriteLine("Beli Quvvetidir");
            }
            else
            {
                Console.WriteLine("Xeyr quvveti deyil");
            }
        }
    }
}

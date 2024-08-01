using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBIApp
{
    internal class RefandOutDemo
    {
       public  int num1;
       public  int num2;

        public RefandOutDemo()
        {
            
        }

        public RefandOutDemo(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public override string ToString()
        {
            return $"Num1 = {num1} - Num2 = {num2}";
        }

        //write a method which swap value of num1 and num2
        public void Swap(int n1, int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        public void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}

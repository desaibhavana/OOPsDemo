using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SBIApp
{
    public struct Employee
    {
        public int EmpId;
        public string EmpName;
        public string  Address;

        public Employee(int id, string name, string add)
        {
            EmpId = id;
            EmpName = name; 
            Address = add;
        }
    }

    public enum Months
    {
        jan=1, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec
    }

    public enum Choice
    {
        yes=1, no=0 
    }
    internal class TypeDemo
    {
        static void Main(string[] args)
        {
            ////  Employee employee = new Employee();

            //Console.WriteLine(DayOfWeek.Wednesday + " = " + (int)DayOfWeek.Sunday);

            //Console.WriteLine(Months.jul + " = " + (int)Months.jul);

            //Choice ch = GetChoiceFromUser();

            //Console.WriteLine(ch);

            ////string var = "22";
            ////Console.WriteLine(var); ;

            ////type casting - convert value type to value type or convert ref type to ref type

            //int i;
            //long l = 100;
            //i = (int)l;

            //Savings s = new Savings();
            //Object obj = s;
            //Savings s1 = (Savings)obj;
            //s1 = obj as Savings;

            ////boxing - convert value type to reference type
            //int x = 100;
            //object obj1 = x;

            ////unboxing - convert reference type to value type
            //int z = (int)obj1;

            //AddNumbers(2, 3, 4);
            //Show("bhavana", 100, true);
            ////Show(200);
            ////  show("user1", false);

            //Show(count: 200);
            //Show(flag: true, name: "user1");


            //ref and out parameter

            //RefandOutDemo demo = new RefandOutDemo(5,10);
            //Console.WriteLine(demo);
            //Console.WriteLine(  "----swap----");
            //demo.Swap(ref demo.num1, ref demo.num2);
            //Console.WriteLine(demo);

            int result;
            bool r= OutTest(10, out result);
            Console.WriteLine("result = " + result);
            Console.WriteLine("return value = " + r);

            Console.WriteLine("-----------");

            bool b = OutTest(15, out result);
            Console.WriteLine("result = " + result);
            Console.WriteLine("return value = " + b);

            Console.ReadLine();
        }

        static bool OutTest(int num1, out int num2)
        {
            num2 = num1;
            if (num2 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static  void Show(string name="test", int count=10, bool flag = false)
        {
            Console.WriteLine(name);
            Console.WriteLine(count);
            Console.WriteLine(flag);
        }

        public static int AddNumbers(int n1, int n2, int n3 = 0, int n4 = 0, int n5 = 0)
        {
            return n1 + n2 + n3 + n4 + n5;
             
        }


        public static int AddNumbersParam(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

        static Choice GetChoiceFromUser()
        {
            return Choice.yes;
        }

        //named and optional parameter

        //write a method which allow user to pass either 2 numbers or 3 numbers or 5 numbers and return sum of 5 numbers

        //public int AddNumbers( int n1, int n2, int n3, int n4, int n5)
        //{
        //    return n1 + n2 + n3 + n4 + n5;
        //}

        //public int AddNumbers(int n1, int n2, int n3)
        //{
        //    return AddNumbers(n1, n2, n3, 0, 0);
        //}

        //public int AddNumbers(int n1, int n2)
        //{
        //    return AddNumbers(n1, n2, 0, 0, 0);
        //}

        //public static  int AddNumbers(int n1, int n2, int n3=0, int n4=0, int n5=0)
        //{
        //    return n1 + n2 + n3 + n4 + n5;
        //}
        //paramarray
    }
}






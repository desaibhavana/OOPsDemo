using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBIApp
{
    internal class ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
            //try  catch finally throw

            int num1, num2, result;
            Savings savings ;
            try
            {
                Console.WriteLine("Enter two integer");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                if (num2 < 1)
                {
                    throw new DivideByZeroException("message ...");
                }
                Console.WriteLine("num1 = " + num1);
                Console.WriteLine("num2 = " + num2);
                //
                //
                //
                result = num1 / num2;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide number by zero \nPlease privide positive number");
                Console.WriteLine(ex.Message);

            }
            catch (FormatException)
            {
                Console.WriteLine("Provide Positive integer");
            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    Console.WriteLine("Program ends");
            //}
            Console.WriteLine("Program ends");
            Console.ReadLine();

            //15    16  17  21

        }
    }
}

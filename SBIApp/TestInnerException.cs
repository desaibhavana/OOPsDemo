using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBIApp
{
    internal class TestInnerException
    {
        static void Main(string[] args)
        {
            // throw new ArgumentException();

            try
            {
                try
                {
                    throw new ArgumentException();
                }

                catch (ArgumentException e)
                {
                    //make sure this path does not exist
                    if (File.Exists("c:\\test.txt") == false)
                    {
                        throw new FileNotFoundException("\nFile Not found when trying to write argument exception to the file", e);
                    }
                }
            }

            catch (Exception e)
            {
                //The e.StackTrace property gives us the location of the error and has the value 

                Console.WriteLine(String.Concat(e.StackTrace, e.Message));


                //check if the InnerException is null or not. If it is not null, we can display InnerException.StackTrace and InnerException.Message

                if (e.InnerException != null)
                {
                    Console.WriteLine("\nInner Exception\n");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }
            Console.ReadLine();
        }
    }
}


/*
 The InnerException is a property of an exception. 

When there are series of exceptions, the most current exception can obtain the prior exception in the InnerException property.

 the InnerException property contains the actual exception. This is the reason for the existence of an InnerException property for any exception.

Example

Let us say we have an exception inside a try block throwing an ArgumentException and the catch clause catches it and writes it to a file. However, if the file path is not found, FileNotFoundException is thrown. Let's say that the outside try block catches this exception, but how about the actual ArgumentException that was thrown? Is it lost? No, the InnerException property contains the actual exception. This is the reason for the existence of an InnerException property for any exception
*/

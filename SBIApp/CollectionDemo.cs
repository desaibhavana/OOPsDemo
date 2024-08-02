using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;
using BankLibrary;

namespace SBIApp
{
    internal class CollectionDemo
    {
        static void Main(string[] args)
        {
            #region Array
            ////datatype[] name = new datatype[size]
            ////int[] numbers = new int[3];
            ////numbers[0] = 100;
            ////numbers[1] = 200;
            ////numbers[2] = 300;


            ////datatype[] name = { initalize with value}
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] +"\t");
            //}


            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //Console.WriteLine(  "\n---------------------");

            ////double dimension
            ////datatype[ , ] = 
            ////int[,] ddarray = new int[3,4];
            //int[, ] ddarray = { { 1, 2, 3,11 }, { 4, 5, 6,21 }, { 7, 8, 9,31 } };
            //Console.WriteLine(ddarray.GetUpperBound(0)); //rows -2
            //Console.WriteLine(ddarray.GetUpperBound(1)); //cols -3

            //Console.WriteLine(  ddarray.Length);


            //for (int i = 0;i <= ddarray.GetUpperBound(0); i++)
            //{
            //    for (int j = 0;j <= ddarray.GetUpperBound(1); j++)
            //    {
            //        Console.Write(ddarray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            ////Jagged Array
            ////datatype[][] = new datatype[size][size]


            #endregion

            #region System.Collection classes

            //ArrayList countryList = new ArrayList();
            //countryList.Add("India");   //0
            //countryList.Add("Japan");   //1
            //countryList.Add("USA");     //2
            //countryList.Insert(2, "France");    //3

            //countryList.Add(100.50);        //4
            //countryList.Add(true);          //5
            //countryList.Add(new Savings()); //6


            ////at position 6 we have added Saving class object
            ////I want to extract only AccHolderNo and Balance

            //Console.WriteLine(((Savings)countryList[6]).AccountNo);

            //Console.WriteLine(((Savings)countryList[6]).Balance);


            //for (int i = 0; i < countryList.Count; i++)
            //{
            //    Console.WriteLine(countryList[i] +"\t" + countryList[i].GetType().Name);
            //}

            //Console.WriteLine(  "--------------");

            // Hashtable stateTable = new Hashtable();
            // stateTable.Add("mh", "maharashtra");
            // stateTable.Add("up", "uttar pardesh");
            // stateTable.Add("kl", "kerala");
            // stateTable.Add("ap", "andhra pradesh");

            // Console.WriteLine(stateTable["mh"]);

            // Console.WriteLine(  "--------------");

            //// foreach(datatype var in collectionname) {  }



            // foreach (string item in stateTable.Keys)
            // {
            //     Console.WriteLine(stateTable[item]);
            // }

            // Hashtable cities = new Hashtable();
            // string[] indiacities = { "mumbai", "delhi", "pune" };
            // string[] usacities = { "new york", "chicage" };
            // cities.Add("India", indiacities);
            // cities.Add("usa", usacities);
            // Console.WriteLine("\n--------------");

            // foreach (string item in cities.Keys)
            // {
            //     string[] items = (string[]) cities[item];
            //     for (int i = 0; i < items.Length; i++)
            //     {
            //         Console.Write(items[i] + "\t");
            //     }
            //     Console.WriteLine();

            // }
            // Console.WriteLine("\n--------------");
            // foreach (DictionaryEntry item in stateTable)
            // {
            //     Console.WriteLine(item.Value);
            // }




            #endregion

            #region Generic Collection

            //List<string> countryList = new List<string>();
            //countryList.Add("India");

            //List<Bank> bankList = new List<Bank>();
            //bankList.Add(new Savings());

            //Dictionary<int,string> names = new Dictionary<int,string>();
            //names.Add(1, "bhavana");
            //names.Add(2, "user1");

            //foreach (int key in names.Keys)
            //{
            //    Console.WriteLine(names[key]);
            //}

            //Console.WriteLine(  "--------------------");
            //foreach (KeyValuePair<int,string> item in names)
            //{
            //    Console.WriteLine(  item);
            //}


            #endregion

            #region Nullable Types
            //Nullable types work with value type only - structure

            int? total = null;

            Nullable<int> number = null;
            number = 100;
            number = null;

            int? num = null;
            num = 10;

            //      null   + 10  = null        
            total = number.GetValueOrDefault() + num.GetValueOrDefault(0);

            //if (number.HasValue )
            //{
            //    if (num.HasValue)
            //    {
            //        total = number + num;
            //    }
            //    else
            //    {
            //        total = number + 0;
            //    }
            //}
            //else
            //{
            //    total = 0 + num;
            //}

            Console.WriteLine("total = " + total);

        





            #endregion




            Console.ReadLine();
        }
    }
}

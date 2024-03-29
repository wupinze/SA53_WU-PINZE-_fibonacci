﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OracleWebTest.Controllers
{
    public class Fibonacci : Controller
    {
        // GET: /<controller>/
        // request url like this: https://localhost:5001/fibonacci?elements=10


        //[HttpGet("{elements}")]
        //public ActionResult<string[]> Get(string elements)
        //{
        //    var fibCountStr = Request.Query["elements"];
        //    Console.WriteLine(fibCountStr);
        //    int fibCount = int.Parse(fibCountStr);
        //    List<List<int>> result = getTheFibonacciNumber(fibCount);
        //    return Json(new { fibonacci = result[0], sorted = result[1] });
        //}

        public IActionResult Index(string elements)
        {
            if (elements != null)
            {
                int fibCount = int.Parse(elements);
                List<long[]> result = getTheFibonacciNumber1(fibCount);
                return Json(new { fibonacci = result[0], sorted = result[1] });
            }
            return View();
        }



        public static List<List<int>> getTheFibonacciNumber(int count) {
            List<List<int>> TotalList = new List<List<int>>();
            List<int> fibonacciList = new List<int>();
            List<int> sortedFibList = new List<int>();

            for (int i = 0; i < count; i++) {
                int fibValue = getFib(i);
                fibonacciList.Add(fibValue);
                sortedFibList.Add(fibValue);
            }

            TotalList.Add(fibonacciList);
            sortedFibList.Sort((x, y) => -x.CompareTo(y));
            TotalList.Add(sortedFibList);
            return TotalList;
        }

        //formula get Fibonacci number
        static int getFib(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            int fib = Convert.ToInt32((1 / sqrt5 * (Math.Pow((1 + sqrt5) / 2, n) - Math.Pow((1 - sqrt5) / 2, n))));
            return fib;
        }

        //recursion get Fib
        public static int getFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return getFibonacci(n - 1) + getFibonacci(n - 2);
            }
        }
        
        
        public static List<long[]> getTheFibonacciNumber1(int count) {

            List<long[]> TotalList = new List<long[]>();
            long[] myList = new long[count];
            long[] sortList = new long[count];

            if (count == 0)
            {
                myList[0] = 0;
               
            }

            if (count == 1)
            {
                myList[0] = 0;
                myList[1] = 1;
            }

            if (count > 1)
            {
                myList[0] = 0;
                myList[1] = 1;
             
                for (int i = 2; i < count; i++)
                {
                    //myList.IndexOf(i - 1);
                    long number = myList[i-1] + myList[i - 2];
                    myList[i] = number;
                }
            }

            for (int i = 0; i < myList.Length; i++)
            {
                sortList[i] = myList[myList.Length - 1 - i];
            }

            TotalList.Add(myList);
          
            TotalList.Add(sortList);

            return TotalList;

        }


       

    }
}


﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class BubbleSortGeneric
    {
        public static void BubbleMethod()
        {
            Console.WriteLine("Enter the length of array");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lement (First press 1 for integer and 0 for string ) ");
           var a = Console.ReadLine();
            if (a == "1")
            {
                int[] arr = new int[len];
                for (int i = 0; i < len; i++)
                {
                    carr[i] = int.Parse(Console.ReadLine());
                }
                int[] b = BubbleSort<int>(arr);
                foreach (int str in b)
                {
                    Console.WriteLine(" " + str);
                }
            }
            else
            {
                string[] arr = new string[len];
                for (int j = 0; j < len; j++)
                {
                    arr[j] = Console.ReadLine();
                }
                string[] b = BubbleSort<string>(arr);
                foreach (string str in b)
                {
                    Console.WriteLine(" " + str);
                }
            }

           
        }

        public static t[] BubbleSort<t>(t[] arr) where t : IComparable
        {
            // Console.WriteLine("Enter the length ");
            int n = arr.Length;
            t[] a = new t[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if ((a[j]).CompareTo(a[j + 1]) > 0)
                    {
                        t temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

    }
}

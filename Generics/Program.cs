using System;
using System.Collections;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BC<string> im = new BC<string>("Anoop");
            im.show();
            Console.WriteLine(im.getob());

            BC<double> im1 = new BC<double>(25.364644);
            im1.show();
            Console.WriteLine(im1.getob());*/
            /* Student<string> al = new Student<string>();

             al.Add("Imran");
             al.Add("tezz");
             al.Add("Train");
             al.Add("Anoop");
             al.show();

             Console.WriteLine("Sorted list ");
             al.sort();*/

            /* Student<int> bl = new Student<int>();
             bl.Add(10);
             bl.Add(15);
             bl.Add(20);
             bl.insert(1, 8);
             //Console.WriteLine(bl.get(1));
             bl.show();
 *//*
             Student<double> db = new Student<double>();
             db.Add(10.25);
             db.Add(5.514654);
             db.Add(12.56458);
             db.Add(6.5454);
             db.show();
             Console.WriteLine("Sorted array");
             db.sort();*/

            /* MathmaticOperation tc = new MathmaticOperation();
             int[] arr = new int[] {10,20,15,25 };
             tc.m1(arr);
             string[] str1 = new string[] { "Anoop", "Imran", "Tezz" };
             tc.m1(str1);
             double[] op = new double[] { 5.354564, 8.54564, 4.354564, 2.564564 };
             tc.m1(op);*/

            GParameter<string> bc = new GParameter<string>();
            GParameter<int> ba = new GParameter<int>();
        }
    }
}

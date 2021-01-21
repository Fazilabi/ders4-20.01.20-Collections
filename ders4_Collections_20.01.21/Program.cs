using System;
using System.Collections.Generic;

namespace ders4_Collections_20._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler2[0]);
            //Console.WriteLine(isimler2[1]);
            //Console.WriteLine(isimler2[2]);
            //Console.WriteLine(isimler2[3]);
            for (int i = 0; i < isimler2.Count; i++)
            {
                Console.WriteLine(isimler2[i]);

            }
            
            Console.WriteLine("-----------------------");
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);

            Console.WriteLine("-----------------------");

            for (int i = 0; i < isimler2.Count; i++)
            {
                Console.WriteLine(isimler2[i]);

            }


        }
    }
}

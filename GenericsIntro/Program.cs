using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler2 = new MyList<string>();
            isimler2.MyAdd("Fazil");
            isimler2.MyAdd("Murad");
            Console.WriteLine(isimler2.Length);

          
            
        }
    }
}

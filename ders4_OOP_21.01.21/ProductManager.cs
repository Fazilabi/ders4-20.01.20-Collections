using System;
using System.Collections.Generic;
using System.Text;

namespace ders4_OOP_20._01._21
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
            

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi.");

        }
        public int Topla(int number1, int number2)
        {
            return number1 + number2;
            // return yazanda geri dondurulen deyeri daha sonra her hansi bir toplamada mi
            //ve ya basqa bir yerde return edilen deyeri istifade ede bilerem
        }
        public void Topla2(int number1, int number2)
        {
            Console.WriteLine( number1 + number2);
            // ama void edilen deyer ekrana bir deyer gosterir ve gedir, sonra hemin deyeri hardasa istifade etmek olmur
        }
    }
}

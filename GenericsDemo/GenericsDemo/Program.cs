using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(25);
            Generics<string> genericsString = new Generics<string>("Ruchita");
            Generics<float> genericsfloat = new Generics<float>(25.23f);
            Generics<double> genericsdouble = new Generics<double>(25.1234);
            Generics<char> genericschar = new Generics<char>('R');
            Generics<bool> genericsbool = new Generics<bool>(true);
            Console.WriteLine("-------------------------------------");

            //Generic method 
            generics.GenericMethod(9);
           genericsString.GenericMethod("Ruchi");
            //genericsString.GenericMethod(9);
            // genericsString.GenericMethod("Aabha");
            // genericsDouble.GenericMethod(12.5);
            // genericsChar.GenericMethod(false);
            Console.WriteLine("-------------------------------------------");


            GenericsMethod obj =new GenericsMethod();
            obj.GenericMethodOne<int>(30);
            obj.GenericMethodOne<string>("ABC");
            obj.GenericMethodOne<float>(123.5f);
            obj.GenericMethodOne<double>(2345.6);
            obj.GenericMethodOne<bool>(false);
            obj.GenericMethodOne<char>('A');

            Console.ReadLine();





        }
    }
}

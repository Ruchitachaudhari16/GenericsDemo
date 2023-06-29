using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
//Generics means general form.
//It doesnot specify aprticular data type
//We are using <> (Angular type) with type name.
//TypeName<T> T is your type paramter.
//Generics allow us to a single class or method that can be used in Different data type.
//We can reuse the code.
{ 
    public class Generics<T>
    {
    //public string name;
    public T data;

    public Generics(T data)
    {
        this.data = data;
        Console.WriteLine(this.data);
    }

        public void GenericMethod(int num)
        {
            Console.WriteLine(num);
        }
        
    }
    public class GenericsMethod
    {
        public void GenericMethodOne<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}

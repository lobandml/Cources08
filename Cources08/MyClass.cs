using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources08
{
    class MyClass<T> where T: IMyProduct, new()
    {
        public static T FactoryMethod()
        {
            T a=new T();
            return a;
        }
    }
}

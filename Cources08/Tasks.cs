using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cources08
{
    public static class Tasks
    {

        // 2,3,4,6 - реализованы в заданиях на коллекции

        public static void Task1()
        {
           var first= MyClass<ProductA>.FactoryMethod();
           Console.WriteLine(first.ItIs());
           var second = MyClass<ProductB>.FactoryMethod();
           Console.WriteLine(second.ItIs());
           
        }

        public static void Task5()
        {
            
            Cars.CarCollection<Cars.Car> collection = new Cars.CarCollection<Cars.Car>();
            collection.Add(new Cars.BMW("someBMW",2000));
            collection.Add(new Cars.Opel("someOpel",2010));
            collection.Add(new Cars.BMW("someBMW", 2001));
            collection.Add(new Cars.Opel("someOpel", 2011));
            collection.Add(new Cars.BMW("someBMW", 2002));
            collection.Add(new Cars.Opel("someOpel", 2012));

            collection[2].IsActive = true; 
            collection[3].IsActive = true;

            foreach(Cars.Car element in collection)
            {
                Console.WriteLine("{0} - {1} - {2}", element.Model, element.Year,element.IsActive);
            }

            collection.Clear();



            collection.Add(new Cars.BMW("secondsomeBMW", 2009));
            collection.Add(new Cars.Opel("secondsomeOpel", 2011));

            foreach (Cars.Car element in collection)
            {
                Console.WriteLine("{0} - {1} - {2}", element.Model, element.Year, element.IsActive);
            }

        }
        public static void Task7()
        {
            Random ran = new Random();
            Arrays.MyArrayList arr = new Arrays.MyArrayList();

            for (int i = 0; i < 10; i++)
            {
                arr.Add(ran.Next(1, 50));
            }

            foreach (int val in arr)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}

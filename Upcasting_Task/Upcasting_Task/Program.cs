using System.Reflection;
using Upcasting_Task.Models;

namespace Upcasting_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new(200, 340, 1.5m, "red");
            Pineapple pineapple = new(120, 600, 5.2m, "Africa");
            Orange orange = new(400, 2, "Lankaran");

            Fruit[] basket = { apple,pineapple,orange};


            Assembly assembly = Assembly.GetExecutingAssembly();
           var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);

                var properties = type.GetProperties();
                foreach (var prop in properties)
                {
                    foreach (var obj in basket)
                    {
                        if(obj.GetType() == type)
                        {
                          var value = prop.GetValue(obj);
                            Console.WriteLine(String.Concat(prop.Name,":",value));
                        }
                    }

                }
            }

        }
    }
}

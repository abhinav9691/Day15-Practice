using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Day15_PracticeProblem
{
    public class NearestNumber
    {
        public NearestNumber()
        {
            Console.WriteLine("Hello World");
        }
        public NearestNumber(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public int Number(int a)
        {
            return a * a;
        }
        public static void FindType()
        {
            Type type = typeof(NearestNumber);
            ConstructorInfo con = type.GetConstructor(Type.EmptyTypes);
            NearestNumber nearest = (NearestNumber)con.Invoke(null);
            object numberclassobject = con.Invoke(new object[] { });
            MethodInfo method = type.GetMethod("Number");
            object value = method.Invoke(numberclassobject, new object[] { 20 });
            Console.WriteLine(nearest);
            Console.WriteLine("NearestNumber.Number Returned {0}", value);
        }
        public static void ReflectionTest()
        {
            Type type = typeof(NearestNumber);

            Console.WriteLine("Full name {0} ", type.FullName);

            Console.WriteLine("Class Name {0} ", type.Name);
            Console.WriteLine("Methods In Given Class");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            }

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "  " + property.Name);
            }

            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
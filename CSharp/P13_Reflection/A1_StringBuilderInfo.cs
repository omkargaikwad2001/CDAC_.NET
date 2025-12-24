using System;
using System.Reflection;
using System.Text;

namespace P13_Reflection
{
    internal class A1_StringBuilderInfo
    {
        static void Main1(string[] args)
        {
            // Get Type information of StringBuilder
            Type t = typeof(StringBuilder);

            Console.WriteLine("===== CLASS INFORMATION =====");
            Console.WriteLine("Name       : " + t.Name);
            Console.WriteLine("Full Name  : " + t.FullName);
            Console.WriteLine("Base Type  : " + t.BaseType);
            Console.WriteLine("Assembly   : " + t.Assembly.FullName);

            Console.WriteLine("\n===== CONSTRUCTORS =====");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo c in constructors)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\n===== PROPERTIES =====");
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo p in properties)
            {
                Console.WriteLine(p.PropertyType + " " + p.Name);
            }

            Console.WriteLine("\n===== METHODS =====");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine(m.ReturnType + " " + m.Name);
            }

            Console.WriteLine("\n===== CUSTOM ATTRIBUTES =====");
            object[] attributes = t.GetCustomAttributes(false);
            foreach (object attr in attributes)
            {
                Console.WriteLine(attr.GetType().Name);
            }

            Console.ReadLine();
        }
    }
}

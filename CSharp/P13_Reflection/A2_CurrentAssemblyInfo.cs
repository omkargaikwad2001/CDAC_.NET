using System;
using System.Reflection;

namespace P13_Reflection
{
    internal class A2_CurrentAssemblyInfo
    {
        static void Main1(string[] args)
        {
            // Get current executing assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine("===== CURRENT EXECUTING ASSEMBLY =====");
            Console.WriteLine("Full Name : " + assembly.FullName);

            // Get all types in the assembly
            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine("Type Name   : " + t.Name);
                Console.WriteLine("Full Name   : " + t.FullName);
                Console.WriteLine("Base Type   : " + t.BaseType);
                Console.WriteLine("Namespace   : " + t.Namespace);

                Console.WriteLine("\n--- Constructors ---");
                ConstructorInfo[] constructors = t.GetConstructors();
                foreach (ConstructorInfo c in constructors)
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine("\n--- Properties ---");
                PropertyInfo[] properties = t.GetProperties();
                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.PropertyType + " " + p.Name);
                }

                Console.WriteLine("\n--- Methods ---");
                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType + " " + m.Name);
                }

                Console.WriteLine("\n--- Custom Attributes ---");
                object[] attributes = t.GetCustomAttributes(false);
                foreach (object attr in attributes)
                {
                    Console.WriteLine(attr.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
}

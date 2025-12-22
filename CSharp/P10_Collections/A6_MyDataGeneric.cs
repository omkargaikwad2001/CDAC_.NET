using System;

namespace P10_Collections
{
    internal class A6_MyDataGeneric<T>
    {
        public T Data { get; set; }

        public A6_MyDataGeneric(T data)
        {
            Data = data;
        }
        public void DisplayData()
        {
            Console.WriteLine("Data : " + Data);
        }
    }
}

using System;

namespace Exercise9
{
    class A
    {
        int n;
        string s;
        public A()
        { }
        //other stuff..
    }
    class Program
    {
        static void Main(string[] args)
        {
            A[] v = new A[10];
            Array.Sort(v);
            Console.WriteLine(v);
        }
    }
}

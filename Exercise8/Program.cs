using System;

namespace Exercise8
{
    class A
    {
        int X;
        public abstract void f(int n);
    private virtual void g(var n)
    {
        X = n as int;
    }
    public string ToString()
    {
        return X.ToString();
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

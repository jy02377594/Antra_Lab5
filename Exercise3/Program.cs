using System;

namespace Exercise3
{
    class MainClass
    {
        static void f(string s)
        {
            s += "world";
        }
        [STAThread]
        static void Main(string[] args)
        {
            string s = "hello";
            //f(ref s);
            f(s);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

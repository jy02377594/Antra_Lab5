using System;

namespace Exercise5
{
    public class MyClass
    {
        public delegate void LogHandler(string message);

        public void process(LogHandler logHandler)
        {
            if (logHandler != null) 
                logHandler("begin");
            if (logHandler != null)
                logHandler("End");
        }
    }

    public class Mylogger
    {
        public void logger(string s)
        {
            Console.WriteLine(s);
        }
    }
    class Program
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Mylogger f1 = new Mylogger();
            MyClass myClass = new MyClass();
            MyClass.LogHandler myLogger = null;
            myLogger += new MyClass.LogHandler(Logger);
            myLogger += new MyClass.LogHandler(f1.logger);
            myClass.process(myLogger);

        }
    }
}

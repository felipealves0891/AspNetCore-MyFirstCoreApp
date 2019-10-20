using System;

namespace MyFirstCoreApp.src.MyConsoleLogger
{
    public class MyConsoleLogger : ILog
    {
        public void info(string str)
        {
            Console.WriteLine(str);
        }        
    }
}
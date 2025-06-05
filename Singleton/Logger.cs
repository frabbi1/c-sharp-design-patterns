using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static readonly Lazy<Logger> _lazyIns = new Lazy<Logger>(() => new Logger());

        public static Logger Instance => _lazyIns.Value;
        private Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    //public class Logger
    //{
    //    private static volatile Logger? _instance;
    //    private static readonly object _lock = new object();

    //    public static Logger Instance
    //    {
    //        get 
    //        {
    //            lock(_lock)
    //            {
    //                if (_instance == null)
    //                {
    //                    _instance = new Logger();
    //                }
    //                return _instance;
    //            }
    //        }
    //    }
    //    private Logger()
    //    {

    //    }

    //    public void Log(string message) { 
    //        Console.WriteLine($"Log: {message}");
    //    }
    //}
}

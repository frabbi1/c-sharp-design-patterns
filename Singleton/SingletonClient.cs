using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public static class SingletonClient
    {
        public static void Run()
        {
            Logger.Instance.Log("This is a singleton logger message.");
        }
    }
}

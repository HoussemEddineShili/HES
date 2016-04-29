using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
       (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.GlobalContext.Properties["tab"] = "\t";
            ILog log = log4net.LogManager.GetLogger(typeof(Program));
            log.Debug("This is a debug message");
            log.Warn("This is a warn message");
            log.Error("This is a error message");
            log.Fatal("This is a fatal message");
            Console.ReadLine();
        }
    }
}

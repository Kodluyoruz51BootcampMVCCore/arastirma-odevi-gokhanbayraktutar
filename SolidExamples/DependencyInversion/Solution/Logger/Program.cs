using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Solution.Logger
{
    public class Program
    {
        static void Main()
        {
            var dbLogger = new DbLogger();
            dbLogger.Message = "Test 123";

            var manager = new LogManager(dbLogger);
            manager.Log();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Solution.Logger
{
    public class DbLogger : ILogger
    {
        public string Message { get; set; }

        public void Log()
        {
            //Database Log
        }
    }
}
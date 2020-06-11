using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Problems.Logger
{
    public class DbLogger
    {
        public string Message { get; set; }
        public void Log()
        {
            //Database Log
        }
    }
}
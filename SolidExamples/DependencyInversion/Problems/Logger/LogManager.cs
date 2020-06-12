using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Problems.Logger
{
    public class LogManager
    {
        private FileLogger _file;
        private DbLogger _db;

        public LogManager()
        {
            _file = new FileLogger();
            _db = new DbLogger();
        }

        public void Log()
        {
            _file.Log();
            _db.Log();
        }
    }
}
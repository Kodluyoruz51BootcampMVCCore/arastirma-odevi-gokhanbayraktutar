using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Solution.Logger
{
    public class LogManager
    {
        private ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log()
        {
            _logger.Log();
        }
    }
}
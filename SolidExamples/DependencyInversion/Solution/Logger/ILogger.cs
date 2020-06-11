using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInversion.Solution.Logger
{
    public interface ILogger
    {
        void Log();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceSegregation.Solution.User
{
    public interface IUpdater
    {
        void UpdateProgram(string programme);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceSegregation.Solution.User
{
    public class HighLevelUser : IUpdater, IAccountManager
    {
        public void UpdateProgram(string programme)
        {
            // Start update service
        }

        public void CreateAccount(string accountName)
        {
            // Start create service
        }

        public void DeletaAccount(string accountName)
        {
            // Start delete service
        }
    }
}
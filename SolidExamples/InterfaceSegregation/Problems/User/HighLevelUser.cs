using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceSegregation.Problems.User
{
    public class HighLevelUser : IUser
    {
        public void UpdateProgram(string programme)
        {
            // Start update service
        }

        public void CreateAccount(string accountName)
        {
            // Start create service
        }

        public void DeleteAccount(string accountName)
        {
            // Start delete service
        }
    }
}
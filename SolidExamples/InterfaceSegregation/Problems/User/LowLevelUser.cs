using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceSegregation.Problems.User
{
    public class LowLevelUser : IUser
    {
        public void UpdateProgram(string programme)
        {
            // Start update service
        }

        public void CreateAccount(string accountName)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(string accountName)
        {
            throw new NotImplementedException();
        }
    }
}
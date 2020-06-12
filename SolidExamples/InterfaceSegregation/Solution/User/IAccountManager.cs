using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceSegregation.Solution.User
{
    public interface IAccountManager
    {
        void CreateAccount(string accountName);
        void DeletaAccount(string accountName);
    }
}
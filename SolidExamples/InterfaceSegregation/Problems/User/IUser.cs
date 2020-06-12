using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceSegregation.Problems.User
{
    public interface IUser
    {
        void UpdateAccount(string programme);
        void CreateAccount(string accountName);
        void DeleteAccount(string accountName);
    }
}
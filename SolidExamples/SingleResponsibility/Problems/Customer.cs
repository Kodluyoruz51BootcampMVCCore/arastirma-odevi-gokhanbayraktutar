using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibility.Problems
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public void EmailGonder()
        {
            //Email gönderme işlemi
        }

        public void Create()
        {
            //Veritabanına Kayıt işlemi
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

        public void Login()
        {
            //Login işlemi
        }
    }
}

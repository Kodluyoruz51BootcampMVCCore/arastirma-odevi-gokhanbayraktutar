using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosed.Solution.Product
{
    public class Order
    {
        public decimal FiyatHesapla(decimal fiyat, Customer customer)
        {
            return musteri.Uyelik.Hesapla(fiyat);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosed.Solution.Product
{
    public class PremiumAccountType : AccountType
    {
        public override decimal Hesapla(decimal urunFiyati)
        {
            return urunFiyati * (1 - 0.1M);
        }
    }
}

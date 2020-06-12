namespace OpenClosed.Problems.Product
{
    public class Order
    {
        public decimal FiyatHesapla(decimal fiyat, Customer customer)
        {
            decimal sonuc = 0;

            switch (customer.Account)
            {
                case AccountType.Standart:
                    sonuc = fiyat;
                    break;
                case AccountType.Premium:
                    sonuc = fiyat * (1 - 0.1M);
                    break;
            }
            return sonuc;
        }
    }
}

namespace OpenClosed.Solution.Product
{
    public class StandartAccountType : AccountType
    {
        public override decimal Hesapla(decimal urunFiyati)
        {
            return urunFiyati;
        }
    }
}

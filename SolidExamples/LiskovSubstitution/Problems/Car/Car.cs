namespace LiskovSubstitution.Problems.Car
{
    public abstract class Car
    {
        public string Run()
        {
            return "Araba çalıştırıldı.";
        }

        public abstract string OpenAirConditioning();
    }
}

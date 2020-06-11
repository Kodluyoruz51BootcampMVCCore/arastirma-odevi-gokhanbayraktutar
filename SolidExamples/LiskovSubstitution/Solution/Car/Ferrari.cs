namespace LiskovSubstitution.Solution.Car
{
    public class Ferrari : Car, IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima açıldı.";
        }
    }
}
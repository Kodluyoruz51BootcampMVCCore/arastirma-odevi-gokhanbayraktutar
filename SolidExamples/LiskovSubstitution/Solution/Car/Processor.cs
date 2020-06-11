namespace LiskovSubstitution.Solution.Car
{
    public class Processor
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();

            ferrari.Run();
            ferrari.OpenAirConditioning();

            Sahin sahin = new Sahin();

            sahin.Run();
        }
    }
}
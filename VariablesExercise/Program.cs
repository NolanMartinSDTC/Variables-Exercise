namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string longWord = "Wow";
            int reallyBigNumber = 12;
            char letter = 'a';
            bool isHappy = true;
            double priceOfEggs = 6.25;
            decimal priceOfBeef = 4.50m;

            Console.WriteLine($"{longWord}, {letter} {reallyBigNumber} pack of eggs costs ${priceOfEggs}, while " +
                $"a pound of beef costs ${priceOfBeef}. I can't believe that's {isHappy}!");
        }
    }
}

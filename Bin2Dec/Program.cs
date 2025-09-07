class Program
{
    static void Main(string[] args)
    {
        new Program();
    }

    private string bin;
    private double res;

    public Program()
    {
        bin = Console.ReadLine();

        if (!int.TryParse(bin, out _))
        {
            Console.WriteLine("The given binary number is not a valid integer!");
            return;
        }

        if (bin == null)
        {
            Console.WriteLine("No binary number given!");
            return;
        }

        if (bin.Length != 8)
        {
            Console.WriteLine("The given binary number is not 8 characters long!");
            return;
        }

        for (int i = 0; i < 8; i++)
        {
            int num = bin[i] - '0'; // konvertál char-ból int-re

            if (num != 0 && num != 1)
            {
                Console.WriteLine("Only 0 and 1 can be in the binary number!");
                return;
            }

            res += Math.Pow(2, 7 - i) * num; // binárisból decimálissá alakítás
        }

        Console.WriteLine($"The binary number in decimal: {res}");
    }
}

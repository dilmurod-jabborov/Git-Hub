namespace MathCalc;

public static class EvenNumbers
{
    public static void Even(int number)
    {
        if(number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an even number.");
        }
    }
}

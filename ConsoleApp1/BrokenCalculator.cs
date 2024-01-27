

namespace ConsoleApp1;

internal class BrokenCalculator : ICalculator
{
    public int AddNumbers(int number1, int number2)
    {
        return number1 * number2;
    }
}

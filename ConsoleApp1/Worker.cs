
namespace ConsoleApp1;

public class Worker
{
    private ICalculator _calculator;

    public Worker(ICalculator calculator)
        => _calculator = calculator;

    public int AddNumbers(int number1, int number2)
        => _calculator.AddNumbers(number1, number2);
}

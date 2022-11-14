class Practical1
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter first number");
        string num1 = Console.ReadLine();
        Console.WriteLine("Enter second number");
        string num2 = Console.ReadLine();
        int number1 = Int32.Parse(num1);
        int number2 = Int32.Parse(num2);
        int addition = number1 + number2;
        Console.WriteLine("Addition: " + addition);
        int substraction = number1 - number2;
        Console.WriteLine("Substraction: " + substraction);
        int multiplication = number1 * number2;
        Console.WriteLine("Multiplication: " + multiplication);
        int division = number1 / number2;
        Console.WriteLine("Division: " + division);

    }
}

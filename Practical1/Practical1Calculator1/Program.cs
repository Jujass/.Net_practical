class Practical1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1:");
        string number1str = Console.ReadLine();

        Console.WriteLine("Enter number 2:");
        string number2str = Console.ReadLine();

        int number1 = int.Parse(number1str);
        int number2 = int.Parse(number2str);

        Console.WriteLine("Addition:");
        int addition = number1 + number2;
        Console.WriteLine(number1 + "+" + number2 + "=" + addition);

        Console.WriteLine("Substraction:");
        int substraction = number1 - number2;
        Console.WriteLine(number1 + "-" + number2 + "=" + substraction);

        Console.WriteLine("Multiplication:");
        int multiplication = number1 * number2;
        Console.WriteLine(number1 + "*" + number2 + "=" + multiplication);

        double num1 = Double.Parse(number1str);
        double num2 = Double.Parse(number2str);

        Console.WriteLine("Division:");
        double division = num1 / num2;
        Console.WriteLine(number1 + "/" + number2 + "=" + division);





    }

}
class Practical2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        var num1str = Console.ReadLine();
        Console.WriteLine("Enter number again");
        var num2str = Console.ReadLine();
        Console.WriteLine("Enter operation character: * / % + or - ");
        var char1 = Console.ReadLine();
        double num1 = Double.Parse(num1str);
        double num2 = Double.Parse(num2str);
        if (char1 == "*")
        {
            double resultMult = num1 * num2;
            Console.WriteLine("You chose multiplication. The result is:" + resultMult);
        }
        else if (char1 == "/")
        {
            double resultDiv = num1 / num2;
            Console.WriteLine("You chose division. The result is:" + resultDiv);
        }
        else if (char1 == "%")
        {
            double resultMod = num1 % num2;
            Console.WriteLine("You chose modulo. The result is:" + resultMod);
        }
        else if (char1 == "+")
        {
            double resultAdd = num1 + num2;
            Console.WriteLine("You chose addition. The result is:" + resultAdd);
        }
        else if (char1 == "-")
        {
            double resultSubtract = num1 - num2;
            Console.WriteLine("You chose subtraction. The result is:" + resultSubtract);
        }
        else
        {
            Console.WriteLine("Operation is not valid, please try again and enter correct character.");
        }
    }
}
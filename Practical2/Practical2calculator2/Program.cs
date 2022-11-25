class Practical2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        string num1str = Console.ReadLine();
        Console.WriteLine("Enter number again");
        string num2str = Console.ReadLine();
        int num1 = Int32.Parse(num1str);
        int num2 = Int32.Parse(num2str);
        Console.WriteLine("Enter character (*/%+-) to proceed the operation");
        string Char = Console.ReadLine();

        if (Char == "+")
        {
            int sumresult = num1 + num2;
            Console.WriteLine(num1 + "+" + num2 + "=" + sumresult);
        }
        if (Char == "-")
        {
            int difresult = num1 - num2;
            Console.WriteLine(num1 + "-" + num2 + "=" + difresult);
        }
        if (Char == "*")
        {
            int multresult = num1 * num2;
            Console.WriteLine(num1 + "*" + num2 + "=" + multresult);
        }
        if (Char == "/")
        {
            int divresult = num1 / num2;
            Console.WriteLine(num1 + "/" + num2 + "=" + divresult);
        }
        else
            Console.WriteLine("Operation is not valid, please try again providing correct chatacter.");
                }
            }



class Practical3
{
    static void Main(string[] args)
    {

        Console.WriteLine("Press enter to bake a cake");
        string input = Console.ReadLine();

        bool condition1 = true;
        bool condition2 = false;

        if (condition1)
        {
            Console.WriteLine("Buy all ingredients;");
            Console.WriteLine("Mix together all ingredients in the bowl;");
            Console.WriteLine("Preheat the oven to 175°C;");
            Console.WriteLine("Put mixed ingredients in the oven for 40min;");
            Console.WriteLine("Eat a cake!");
        }
        else if (condition2)
        {
            Console.WriteLine("Error");
        }
        else
        {
            Console.WriteLine("Error2");
        }

    }
}
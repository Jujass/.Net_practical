//using System.ComponentModel.DataAnnotations;

//class Practical2
//{
//    static void Main(string[] args)
//    {
//        string str1 = "Hello";
//        string str2 = "World";
//        int number = 2121;
//        int number2 = 134;

//            string strResult = str1 + " " + str2 + number;
//        //string strNumberRes = number + number2; //not possible, because int+ int = int;

//        string strnumberRes = str1 + (number + number2);
//        Console.WriteLine(strnumberRes);
//        //string strMinus = str1 - str2;//operation isn't defined
//        int modResult = 10 % 3;//10 - 3 * [10 / 3] = 10 - 3 * 3 = 10 - 9 = 1
//        int modResult2 = 16 % 7;//16 - 7 * [16/7] = 16 - 7 * 2 = 16 -14 = 2
//        Console.Write(modResult);
//        Console.WriteLine(modResult2);

//        ///7984454645645646 % 100 -----> the result will be in the range of 0 to 99
//        ///
//        ++modResult;//same as modResult = modResult + 1;
//        modResult *= 3;//same as modResult = modResult * 3;
//        double valueDouble = 23.9878;
//        double valueRound = Math.Round(valueDouble++, 2);
////        Console.WriteLine(valueRound);

//    }
//}


//bool answer;
//answer = 13 > 7;//True
//answer = 19 < 7;//False
//answer = 13 >= 7;//True
//answer = 13 > 13;//False
//answer = 13 >= 13;//True
//answer = 13 == 13; //True
//answer = 13 != 13;// False !=means NOT equals to
//answer = !true; //false (the opossite of true)
//answer = !false;//true (the opossite of false
//answer = true && true;//true
//answer = (13 >= 13) && (13 == 13);//would be the same as true && true

//answer = true && false;//false
//answer = false && false;//false

//double val1 = 23.6543;
//double val2 = 56.56565;
//answer = ++val1 == 21 && ++val2 == 57.56565;//the right side won't be executed, because the left side is false.
//Console.WriteLine(answer);
//Console.WriteLine(val1);
//Console.WriteLine(val2);

//answer = true || true;//true
//answer = true || false;//true
//answer = false || false;//false
//answer = false || true;//true

//answer = true && true || false && false; //I don't know
//answer = true && (false || (false || true)); //true (always use brackets)

//Random rand = new Random();

//double randomResult = rand.NextDouble();//it returns the random value from 0 to 1
//int oneToTen = (int) (1 + (randomResult * 10));
//Console.WriteLine(oneToTen);

//bool isMorining = true;

//if(isMorining)///true==true ----->true; False==false ----------> False;Always be if() for the bracnhing.

//{
//    Console.WriteLine("Wake up!");

//}



//else if (time >= 9 && time < 16)

//{
//    Console.WriteLine("Good afternoon");
//}
//else if (time < 24 && time >= 0)
//{
//    Console.WriteLine("Good evening");
//}
class Practical2
    int i = 0;

public record Person
{
    public string targetDate { get; set; }
    public string endDate { get; set; }
   
}
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter Date");
    }
        string EnterDate = Console.ReadLine();
}
        bool istargetDate = true;
        bool isendDate = true;

if (istargetDate)

Console.WriteLine("Aries");

DateTime startDate = new DateTime(2022, 03, 20);
DateTime endDate = new DateTime(2022, 04, 21);

if (startDate >= endDate && endDate <= startDate)
{
    Console.WriteLine("Aries");
    { 
}
}
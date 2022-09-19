namespace Assignment_w1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment_w1";
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Enjoy the app!");
            Console.WriteLine("");
            Console.WriteLine("***********************************");
            Console.WriteLine("");
            double num01;
            double num02;
            double num03;
            
            Console.Write("Input a first number: ");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a third number: ");
            num03 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

// 1. WAP to perform all arithmetic operations.

            double addition = num01 + num02 + num03;
            Console.WriteLine("Addition of the three number is " + addition +".");

            Console.WriteLine();

            double subtraction = num01 - num02 - num03;
            Console.WriteLine("Subtraction of the three number is " + subtraction +".");

            Console.WriteLine();

            double multiplication = num01 - num02 - num03;
            Console.WriteLine("Multiplication of the three number is " + multiplication +".");

            Console.WriteLine();

            double division = num01 / num02 ;
            Console.WriteLine("Division of number one & two is " + division +".");

            Console.WriteLine();

            double remainder = num01 % num02 % num03;
            Console.WriteLine("Remainder of number one & two is " + remainder +".");

            Console.WriteLine();

// 5. WAP to compute sum and average of numbers.            

            double average = addition/3;
            Console.WriteLine("Average of the three number is " + average +".");


            Console.ReadKey();
        }
    }
}
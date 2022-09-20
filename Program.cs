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

// 2. Write a program to display user’s complete mailing address. Accept user’s name, city,
// street, pin and house no. and store it in a variable and display it.

            string userName;
            string userCity;
            string userStreet;
            int userPin;
            int houseNumber;

            Console.Write("Input your name: ");
            userName = Convert.ToString(Console.ReadLine());

            Console.Write("Input your City: ");
            userCity = Convert.ToString(Console.ReadLine());

            Console.Write("Input your Street: ");
            userStreet = Convert.ToString(Console.ReadLine());

            Console.Write("Input your Pin: ");
            userPin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your house number: ");
            houseNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Hello {userName}, your mailling address is shown below. ");
            Console.WriteLine($"********************");
            Console.WriteLine($"     {userName}");
            Console.WriteLine($"     {userStreet}");
            Console.WriteLine($"     {userCity},{userPin}");
            Console.WriteLine($"     {houseNumber}");
            Console.WriteLine($"********************");

// Write a program to display student information. Accept Student’s name, Roll no, Age,
// class, and university name and display it on console.

            string studentName;
            int rollNumber;
            int age;
            string studentClass;
            string university;

            Console.Write("Input a student name: ");
            studentName = Convert.ToString(Console.ReadLine());

            Console.Write("Input student roll number: ");
            rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input student age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input student class: ");
            studentClass = Convert.ToString(Console.ReadLine());

            Console.Write("Input student university: ");
            university = Convert.ToString(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine($"{studentName} having age {age} is a student of the {university}, studing {studentClass}. His roll number is {rollNumber}.");






            Console.ReadKey();
        }
    }
}
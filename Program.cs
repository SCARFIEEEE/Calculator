using System;
 class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Good day, I am your trusty alculator BIND.");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Please write your numbers and I'll compute them");

            Console.WriteLine();
            Console.WriteLine("Enter your first number:");
            string numplace1 = Console.ReadLine();
            double num1 = Convert.ToDouble(numplace1);

            Console.WriteLine();
            Console.WriteLine("Enter your second number:");
            string numplace2 = Console.ReadLine();
            double num2 = Convert.ToDouble(numplace2);

            //not showed cause why not
            string addition = Convert.ToString(num1 + num2);
            string subtraction = Convert.ToString(num1 - num2);
            string multiplication = Convert.ToString(num1 * num2);
            string division = Convert.ToString(num1 / num2);
            string square1 = Convert.ToString(Math.Sqrt(num1));
            string square2 = Convert.ToString(Math.Sqrt(num2));
            string absolute1 = Convert.ToString(Math.Abs(num1));
            string absolute2 = Convert.ToString(Math.Abs(num2));

            if (num1 + num2 == 143)
            {
            Console.WriteLine("I love you too");
            }
            else
            {
            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Divition: " + division);
            Console.WriteLine("Square root of the first number: " + square1);
            Console.WriteLine("Square root of the second number: " + square2);
            Console.WriteLine("Absolute number of the first number: " + absolute1);
            Console.WriteLine("Absolute number of the first number: " + absolute2);
            Console.ReadLine();
            }
            
        }
    }
using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you");
            string age = Console.ReadLine();


            Console.WriteLine("What is the name of your hamster?");
            string userHamsterName = Console.ReadLine();


            Console.WriteLine("What color is your hamsters fur?");
            string userHamsterColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old");
            Console.WriteLine($" He had a {userHamsterColor} hamster named {userHamsterName}");
            Console.WriteLine($"{userName} loved {userHamsterName} but did not like being {age} years old");

            //Console.WriteLine($"Give me a number to add");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Give me a number to add to the first number");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum = Sum(num1, num2);
            //Console.WriteLine($"{sum} is the Sum");



        }


    }
}

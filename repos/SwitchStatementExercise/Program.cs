using System;

namespace SwitchStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject");
                    break;
                case "Science":
                    Console.WriteLine("Science is a tough subject");
                    break;
                case "English":
                    Console.WriteLine("English is an interesting subject");
                    break;
                default:
                    Console.WriteLine($"Oh Ok!! I haven't taken that subject before. {subject} sounds fun!!");
                    break;
            }
        }
    }
}

using System;

namespace ReturnStatementPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int iceNumber = ice(6);
            Console.WriteLine(iceNumber);
        }
        static int ice(int num)
        {
            int result = num * num * num;
            return result;
        }








    }
}

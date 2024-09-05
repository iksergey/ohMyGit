using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Are You happy?");
            string answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "yes": Console.WriteLine("So am I!!!"); break;
                case "no":
                    Console.WriteLine("Why? You are so cute. You can't be unhappy.."); break;
                default: Console.WriteLine($"I don't understand your answer(( Try again))"); break;
            }
        }
    }
}


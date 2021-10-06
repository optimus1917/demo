using System;

namespace tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi my name is optimus");

            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine("Hallo " + aFriend);

            Console.WriteLine($"My Friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");

            String songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
        }
    }
}

using System;

namespace DelegateDemo
{
    public class AnonymousMethods
    {
        public delegate string GreetingsDelegate(string name);
        public static string Greetings(string name)
        {
            return "Hello @" + name + " Welcome to Dotnet Tutorials";
        }

        static void Main(string[] args)
        {
            GreetingsDelegate gd = new GreetingsDelegate(AnonymousMethods.Greetings);
            string GreetingsMessage = gd.Invoke("Raju Ahmed");
            Console.WriteLine(GreetingsMessage);

            GreetingsDelegate del = delegate (string name)
            {
                return "Hello @" + name + " Welcome to Dotnet Tutorials";
            };
            string GreetingsMessage2 = del.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage2);

            Console.ReadKey();
        }
    }
}
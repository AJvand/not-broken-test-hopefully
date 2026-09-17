namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double guessTarget = 0;
            double userGuess = -1;
            double attempts = 0;
            string temp = "AAAAAAAAAAAAAAA";

            guessTarget = rand.Next(1, 101);
            Console.WriteLine("Guess a number between 1 and 100");
            temp = Console.ReadLine();
            userGuess = Convert.ToDouble(temp);
            do
            {
                if (userGuess > guessTarget)
                {
                    if (attempts == 6)
                    {
                        Console.WriteLine("This is taking a lot of attempts, you should try a better strategy");
                    }
                    Console.WriteLine("You guessed too high, try again");
                    Thread.Sleep(800);
                    attempts = (attempts + 1);
                    Console.WriteLine("Input your guess");
                    temp = Console.ReadLine();
                    Thread.Sleep(800);
                    userGuess = Convert.ToDouble(temp);
                }

                else if (userGuess < guessTarget)
                {
                    if (attempts == 6)
                    {
                        Console.WriteLine("This is taking a lot of attempts, you should try a better strategy");
                    }
                    Console.WriteLine("You guessed too low, try again");
                    Thread.Sleep(800);
                    attempts = (attempts + 1);
                    Console.WriteLine("Input your guess");
                    temp = Console.ReadLine();
                    Thread.Sleep(800);
                    userGuess = Convert.ToDouble(temp);
                }
            } while (userGuess != guessTarget);
            Thread.Sleep(800);
            Console.WriteLine("Congratulations, you guessed the right number!");
            Console.WriteLine("testing...");
            Console.WriteLine("i am trying to break the code :)");
            Console.ReadLine();
        }
    }
}
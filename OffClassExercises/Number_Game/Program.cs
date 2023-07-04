// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool restart = true;
        int Minimum = 1;
        int Maximum = 100;
        int guess;
        int number;
        int GuessCount;
        string? response;

        while (restart)
        {
            guess = 0;
            GuessCount = 0;
            response = "";
            number = random.Next(Minimum, Maximum + 1);

            while (guess != number)
            {
                Console.WriteLine($"Guess a number between {Minimum} - {Maximum}:" );
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine($"{guess} is to high from the actual number!");
                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is to low from the actual number!");
                }
                GuessCount++;
            }
            Console.WriteLine($"Actual number: {number}");
            Console.WriteLine($"You have successfully guessed the number in {GuessCount} attempt(s)");

            Console.WriteLine("Play again? Y/N: ");
            
            response = Convert.ToString(Console.ReadLine());
            if (response is not null)
            {
                response = response.ToUpper();
            }

            if (response == "Y")
            {
                restart = true;
            }
            else
            {
                restart = false;
            }
        }

        Console.WriteLine("Thanks for Playing!");
        Console.ReadKey();
    }
}

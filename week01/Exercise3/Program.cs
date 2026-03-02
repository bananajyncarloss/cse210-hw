using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int guess = -1;
        int attempts = 0;

        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number!");
            }
        }

        Console.WriteLine($"Your random number is: {randomNumber}");
        Console.WriteLine($"It took you {attempts} attempts to guess the number.");
    }
}
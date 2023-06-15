// Guess the Number Challenge
string guess;
int guessInt;

Random rand = new Random();
int answer = rand.Next(1, 20); ;

bool running = true;


do
{
    Console.WriteLine("Guess a number between 1 and 20.");

    guess = Console.ReadLine();
    bool isInt = int.TryParse(guess, out guessInt);

    if (!isInt)
    {
        Console.WriteLine("Please enter an integer.");
        continue;
    }

    if (guessInt == -1)
    {
        running = false;
        continue;
    }

    if (guessInt < answer)
    {
        Console.WriteLine("Your guess is too low");
    }
    else if (guessInt > answer)
    {
        Console.WriteLine("Your guess is too high");
    }
    else
    {
        Console.WriteLine("You got it!");
        running = false;
        continue;
    }

} while (running);
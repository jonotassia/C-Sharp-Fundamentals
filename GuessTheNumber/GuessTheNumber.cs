// Guess the Number Challenge
string guess;
int guessInt;
int answer;
Random rand = new Random();

do
{
    answer = rand.Next(1, 20);
    Console.WriteLine("Guess a number between 1 and 20");

    guess = Console.ReadLine();
    bool isInt = int.TryParse(guess, out guessInt);

    if (!isInt)
    {
        Console.WriteLine("Please enter an integer.");
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
        break;
    }

} while (guessInt != answer || guess != "-1");
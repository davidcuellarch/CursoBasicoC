// control structures: switch & While loops


string message = "";
string switchControl = "4";
Random random = new Random();

while (true) { 

switch (switchControl)
{
    case "1":
        int totalPlayer = 0;
        int totalDealer = 18;
        Console.WriteLine("Select your card");
        totalPlayer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your card is " + totalPlayer);
        Console.WriteLine("Dealer card is " + totalDealer);
        Console.WriteLine("Calculating.... result is: ");
        if (totalPlayer > totalDealer && totalPlayer < 22)
        {
            message = "You win! dealer loose.... Congratulations!!!";
            switchControl= "4";
        }
        else if (totalPlayer < totalDealer)
        {
            message = "You loose! dealer win.... Sorry!!!";
            switchControl = "4";
            }

        else if (totalPlayer >= 22)
        {
            message = "You loose! dealer win.... Sorry!!!";
            switchControl = "4";
            }
        else
        {
            message = "It's a tie! dealer win.... Sorry!!!";
            switchControl = "4";
            }
        break;
    case "2":
        int randomNumber = random.Next(0, 9);
        int guess = 0;
        int guessCount = 0;
        bool outOfGuesses = false;
        Console.WriteLine("Guess the number between 0 and 20");
        while (guess != randomNumber && !outOfGuesses)// guessCount < 3 && guess != randomNumber) 
        {
            if (guessCount < 4)
            {
                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != randomNumber)
                {
                    Console.WriteLine($"Wrong guess, try again current try: {guessCount+1}");
                    guessCount++;
                }
                else
                {
                    Console.WriteLine("You win!");
                    switchControl = "4";

                }
                
            }
            else
            {
                outOfGuesses = true;
                Console.WriteLine($"You loose!, your attemps was {guessCount + 1}");
                switchControl = "4";
            }
        }

            break;
    case "3":
        message = "Thank you for playing";
        Console.WriteLine(message);
        Environment.Exit(0);
        break;
    case "4":
            Console.WriteLine("1. Play BlackJack");
            Console.WriteLine("2. Play Guessing Game");
            Console.WriteLine("3. Exit");
            Console.WriteLine("4. Menu");
            Console.WriteLine("Enter your choice: ");
            switchControl = Console.ReadLine();
    break;
    default:
    message = "Invalid input";
    Console.WriteLine(message);
            Environment.Exit(0);
    break;

}

}

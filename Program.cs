// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Declaring Random 
Random random = new Random();

// System.Console.WriteLine(rand_num);

//Player And Character Scores
int playerScore = 0;
int computerScore = 0;

// System.Console.WriteLine(playerScore.ToString());
// System.Console.WriteLine(computerScore.ToString());
System.Console.WriteLine("Welcome to Rock, Paper, Scissors!!");

while (playerScore != 3 && computerScore != 3)
{
    System.Console.WriteLine("Type r for Rock, p for Paper, s for Scissors");
    System.Console.WriteLine("Player Score is: " + playerScore + ". Computer Score is: " + computerScore + ".");

    //Choosing random number 0-2
    int rand_num = random.Next(0, 3);

    //Taking in user input and assigning to a variable
    string userInput = Console.ReadLine();

    // System.Console.WriteLine(userInput);
    if (rand_num == 0) {
        System.Console.WriteLine("Computer Chooses Rock!");

        switch (userInput)
        {
            case "r":
            System.Console.WriteLine("It's a Tie!");
            break;
            case "p":
            System.Console.WriteLine("Player Wins!!");
            playerScore++;
            // System.Console.WriteLine(playerScore);
            break;
            default:
            System.Console.WriteLine("Computer Wins!");
            computerScore++;
            break;
        }
    }
    else if (rand_num == 1) {
        System.Console.WriteLine("Computer Chooses Paper!");

            switch (userInput)
        {
            case "r":
            System.Console.WriteLine("Computer Wins!");
            computerScore++;
            break;
            case "p":
            System.Console.WriteLine("It's a Tie!");
            break;
            default:
            System.Console.WriteLine("Player Wins!");
            playerScore++;
            // System.Console.WriteLine(playerScore);
            break;
        }
    }
    else {
        System.Console.WriteLine("Computer Chooses Scissors!");

            switch (userInput)
        {
            case "r":
            System.Console.WriteLine("Player Wins!");
            playerScore++;
            // System.Console.WriteLine(playerScore);
            break;
            case "p":
            System.Console.WriteLine("Computer Wins!");
            computerScore++;
            break;
            default:
            System.Console.WriteLine("It's a Tie!");
            break;
        }
    }
}
if (playerScore == 3) {
    System.Console.WriteLine("Game Over, You Win!");
}
else {
    System.Console.WriteLine("Game Over, You Lost!");
}

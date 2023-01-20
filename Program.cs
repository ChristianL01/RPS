// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Random 
Random random = new Random();
int rand_num = random.Next(0, 3);
System.Console.WriteLine(rand_num);
string userInput = Console.ReadLine();
System.Console.WriteLine(userInput);
if (rand_num == 0) {
    System.Console.WriteLine("Computer Chooses Rock!");

    switch (userInput)
    {
        case "r":
        System.Console.WriteLine("It's a Tie!");
        break;
        case "p":
        System.Console.WriteLine("Player Wins!!");
        break;
        default:
        System.Console.WriteLine("Computer Wins!");
        break;
    }
}
else if (rand_num == 1) {
    System.Console.WriteLine("Computer Chooses Paper!");

        switch (userInput)
    {
        case "r":
        System.Console.WriteLine("Computer Wins!");
        break;
        case "p":
        System.Console.WriteLine("It's a Tie!");
        break;
        default:
        System.Console.WriteLine("Player Wins!");
        break;
    }
}
else {
    System.Console.WriteLine("Computer Chooses Scissors!");

        switch (userInput)
    {
        case "r":
        System.Console.WriteLine("Player Wins!");
        break;
        case "p":
        System.Console.WriteLine("Computer Wins!");
        break;
        default:
        System.Console.WriteLine("It's a Tie!");
        break;
    }
}

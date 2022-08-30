using RockPaperScissors;
using RockPaperScissors.Contracts;
using RockPaperScissors.Models;

string[] movements = { "Rock", "Paper", "Scissors" };

ConsoleOutput console = new ConsoleOutput();
IPlayer player = new PersonPlayer();
IPlayer computer = new NPC();

while (true)
{
    console.SetOptions(ConsoleColor.Gray, ConsoleColor.DarkBlue);
    console.Print("Choose [r]ock, [p]aper or [s]cissors: ");
    string playerMove = Console.ReadLine();

    var isMoveSetted = player.SetMovement(playerMove);

    if (!isMoveSetted)
    {
        console.SetOptions(ConsoleColor.Red, ConsoleColor.Black);
        console.Print("Invalid Input. Try Again...");
        console.ResetOptions();
        return;
    }

    Random rdm = new Random();
    int computerRandomNumber = rdm.Next(0, 3);
    string computerMove = movements[computerRandomNumber];

    computer.SetMovement(computerMove.ToLower());


    console.PrintLine($"The Computer chose {computer.Move.ToString()}.");

    if (player.Move == computer.Move)
    {
        console.SetOptions(ConsoleColor.Cyan, ConsoleColor.DarkBlue);
        console.PrintLine("The game was draw.");
    }
    else
    {
        if (player.Move == Movement.Rock && computer.Move == Movement.Scissors ||
            player.Move == Movement.Scissors && computer.Move == Movement.Paper ||
            player.Move == Movement.Paper && computer.Move == Movement.Rock)
        {
            console.SetOptions(ConsoleColor.Green, ConsoleColor.DarkBlue);
            console.PrintLine("You win.");
        }
        else
        {
            console.SetOptions(ConsoleColor.Red, ConsoleColor.Black);
            console.PrintLine("You lose.");
        }
    }

    console.ResetOptions();

    console.SetOptions(ConsoleColor.Black, ConsoleColor.White);
    console.Print("Press [n] to stop the game or any key to play again: ");

    var key = Console.ReadKey();

    if(key.KeyChar == 'n')
    {
        break;
    }
    console.PrintLine("");
}

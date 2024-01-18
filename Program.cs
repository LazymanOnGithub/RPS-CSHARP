namespace ConsoleApp1;
abstract class Program
{
    private static void Main(){
        GameSystem();
    }
    private static void GameSystem(){
        var keepPlaying = true;
        while (keepPlaying)
        {
            Game();
            Console.WriteLine("Would you like to start a new game? y/n (lower capitals)");
            ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
            keepPlaying = cki.KeyChar == 'y'; //continue only if y was pressed
            Console.WriteLine("\n");
        }
    }
    private static void Game(){
        Console.WriteLine("To play Rock Paper Scissors, enter your name");
        var playerName = Console.ReadLine();
        const string comSym = "[COMPUTER]";
        Random aiRng = new();
        var aiName = comSym + aiRng.Next(1, 1000000000); 
        string[] moves = {"Scissors", "Paper", "Rock"};
        Random moveRng = new();
        var move = moveRng.Next(moves.Length);
        Console.WriteLine("Rock, Paper, Scissors, SHOOT!");
        Console.WriteLine("\nEnter your move with the first letter being capital!");
        var playerMove = Console.ReadLine();
        var aiMove = $"{moves[move]}";
        Console.WriteLine("You chose " + playerMove);
        Console.WriteLine(aiName + " chose " + aiMove); 
        switch (aiMove)
        {
            case "Rock" when playerMove == "Scissors":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Rock beats Scissors, " + aiName + " wins!");
                Console.Beep();
                break;
            case "Scissors" when playerMove == "Rock":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Rock beats Scissors, " + playerName + " wins!");
                Console.Beep();
                break;
            case "Rock" when playerMove == "Paper":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Paper covers Rock, " + playerName + " wins!");
                Console.Beep();
                break;
            case "Paper" when playerMove == "Rock":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Paper covers Rock, " + aiName + " wins!");
                Console.Beep();
                break;
            case "Scissors" when playerMove == "Paper":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Scissors cut Paper, " + aiName + " wins!");
                Console.Beep();
                break;
            case "Paper" when playerMove == "Scissors":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Scissors cut Paper, " + playerName + " wins!");
                Console.Beep();
                break;
            case "Paper" when playerMove == "Paper":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Its a tie!");
                Console.Beep();
                break;
            case "Scissors" when playerMove == "Scissors":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Its a tie!");
                Console.Beep();
                break;
            case "Rock" when playerMove == "Rock":
                Console.WriteLine("=============");
                Console.WriteLine("=============");
                Console.WriteLine("Its a tie!");
                Console.Beep();
                break;
        }
    }
}

using System;

class Program
{
    // Main Menu
    static void PrintMenu()
    {
        Console.WriteLine("Game Suite Menu:");
        Console.WriteLine("1. Play Nought and Crosses (Tic-Tac-Toe)");
        Console.WriteLine("2. Play Rock, Paper, Scissors");
        Console.WriteLine("3. Exit");
    }

    // Main game loop
    static void Main()
    {
        while (true)
        {
            PrintMenu();
            Console.Write("Select an option (1-3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                PlayTicTacToe();
            }
            else if (choice == "2")
            {
                PlayRockPaperScissors();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a valid option.");
            }
        }
    }

    // Tic-Tac-Toe Game
    static void PlayTicTacToe()
    {
        string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string currentPlayer = "X";
        int move;

        while (true)
        {
            Console.Clear();
            PrintBoard(board);
            Console.WriteLine($"Player {currentPlayer}, it's your turn!");
            Console.Write("Enter a number (1-9) to make your move: ");

            // Input validation
            bool validInput = int.TryParse(Console.ReadLine(), out move);
            if (!validInput || move < 1 || move > 9 || board[move - 1] == "X" || board[move - 1] == "O")
            {
                Console.WriteLine("Invalid move! Try again.");
                continue;
            }

            // Make the move
            board[move - 1] = currentPlayer;

            // Check for a winner
            if (CheckWinner(board))
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            // Check for a tie
            if (Array.IndexOf(board, "1") == -1 && Array.IndexOf(board, "2") == -1 &&
                Array.IndexOf(board, "3") == -1 && Array.IndexOf(board, "4") == -1 &&
                Array.IndexOf(board, "5") == -1 && Array.IndexOf(board, "6") == -1 &&
                Array.IndexOf(board, "7") == -1 && Array.IndexOf(board, "8") == -1 &&
                Array.IndexOf(board, "9") == -1)
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine("It's a tie!");
                break;
            }

            // Switch player
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
        }
    }

    // Rock, Paper, Scissors Game
    static void PlayRockPaperScissors()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();

        Console.Write("Enter your choice (rock, paper, or scissors): ");
        string playerChoice = Console.ReadLine().ToLower();

        while (!Array.Exists(choices, element => element == playerChoice))
        {
            Console.Write("Invalid input! Please choose rock, paper, or scissors: ");
            playerChoice = Console.ReadLine().ToLower();
        }

        string computerChoice = choices[random.Next(choices.Length)];
        Console.WriteLine($"Computer chooses {computerChoice}.");

        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }

    // Print Tic-Tac-Toe board
    static void PrintBoard(string[] board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    // Check for a winner in Tic-Tac-Toe
    static bool CheckWinner(string[] board)
    {
        // Check rows, columns, and diagonals
        return (board[0] == board[1] && board[1] == board[2]) ||
               (board[3] == board[4] && board[4] == board[5]) ||
               (board[6] == board[7] && board[7] == board[8]) ||
               (board[0] == board[3] && board[3] == board[6]) ||
               (board[1] == board[4] && board[4] == board[7]) ||
               (board[2] == board[5] && board[5] == board[8]) ||
               (board[0] == board[4] && board[4] == board[8]) ||
               (board[2] == board[4] && board[4] == board[6]);
    }
}

using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {

    internal class TicTacToe {

        public static string[,] CreateBoard(int size) {
            size = Math.Min(size, 8);
            size = Math.Max(size, 3);
            string[,] board = new string[size, size];
            int counter = 1;
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    board[i, j] = "" + (counter);
                    counter++;
                }
            }
            return board;
        }

        public static void DrawBoard(string[,] board) {
            for (int i = 0; i < board.GetLength(0); i++) {
                Console.WriteLine();
                for (int l = 0; l < board.GetLength(1); l++) {
                    Console.Write(" ");
                    Console.Write("| " + board[i, l] + " ");
                    if (board[i, l].Length < 2) {
                        Console.Write(" ");
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int InputNumber() {
            int num;
            bool inputParseSucessful = int.TryParse(Console.ReadLine(), out num);
            while (!inputParseSucessful) {
                Console.Write("Please input an number: ");
                inputParseSucessful = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        public static void Main(string[] args) {
            while (true) {
                Console.Write("Type n to stop type enter to play: ");
                if (Console.ReadLine() == "n") {
                    break;
                }
                Console.Write("Input a board size: ");
                int size = InputNumber();
                size = Math.Min(size, 8);
                size = Math.Max(size, 3);

                string[,] board = CreateBoard(size);
                int chosenCount = 0;
                int maxInputs = size * size;
                bool player1 = true;
                bool gameWin = false;
                while (chosenCount <= maxInputs - 1) {
                    DrawBoard(board);
                    string curPlayerAnounce = player1 ? "Player 1 " : "Player 2";
                    Console.WriteLine(curPlayerAnounce);
                    ChoosePos(board, player1);

                    if (GameChecker.CheckBoard(board)) {
                        Console.Clear();
                        DrawBoard(board);
                        string congadulations = player1 ? "Player 1 wins!" : "Player 2 wins!";
                        Console.WriteLine(congadulations);
                        gameWin = true;
                        break;
                    };

                    chosenCount++;
                    player1 = !player1;
                    Console.Clear();
                }
                if (!gameWin) {
                    Console.WriteLine("Its a draw!");
                }
            }
        }

        public static void ChoosePos(string[,] board, bool player1) {
            Console.Write("Choose a spot: ");
            while (true) {
                int numSelect = InputNumber()-1;

                int rowIndex = numSelect / board.GetLength(0);
                int columnIndex = numSelect % board.GetLength(0);

                try {
                    string curChar = board[rowIndex, columnIndex];
                    if (curChar == "O" || curChar == "X") {
                        Console.WriteLine("Already chosen this one");
                        continue;
                    }
                    if (player1) {
                        board[rowIndex, columnIndex] = "X";
                    } else {
                        board[rowIndex, columnIndex] = "O";
                    }
                    break;
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("This spot doesnt exist");
                    continue;
                }
            }
        }
    }
}

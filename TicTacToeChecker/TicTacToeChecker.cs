using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {

    internal class Project {
        public static void Main(string[] args) {
            string[,] board =
            {
                { "O", "X", "O" },
                {"O", "X", "X" },
                {"X", "X", "X" }
            };

            Console.WriteLine(TicTacToe.Checker(board));
        }



        public class TicTacToe {
            public static bool checkHorizontal(string[,] board) {

                for (int i = 0; i < board.GetLength(0); i++) {
                    bool rowWin = true;
                    bool columnWin = true;

                    string firstCharColumn = board[0, i];
                    string firstCharRow = board[i, 0];


                    for (int j = 0; j < board.GetLength(1); j++) {
                        if (board[j, i] != firstCharColumn) {
                            columnWin = false;
                        }
                        if (board[i, j] != firstCharRow) {
                            rowWin = false;
                        }
                        if (!rowWin && !columnWin) {
                            break;
                        }
                    }
                    if (rowWin || columnWin) {
                        return true;
                    }
                }
                return false;
            }

            public static bool checkDiagnol(string[,] board) {
                bool leftWin = true;
                bool rightWin = true;

                string firstCharLeft = board[0, 0];

                int boardLength = board.GetLength(0);
                string firstCharRight = board[0, boardLength - 1];

                for (int i = 0; i < boardLength; i++) {
                    if (board[i, i] != firstCharLeft) {
                        leftWin = false;
                    }
                    if (board[i, (boardLength - 1) - i] != firstCharRight) {
                        rightWin = false; 
                    }
                    if (!rightWin && !leftWin) {
                        return false;
                    }
                }
                return true;
            }

            public static bool Checker(string[,] board) {
                if (checkHorizontal(board)) {
                    return true;
                }
                if (checkDiagnol(board)) {
                    return true;
                }
                return false;
            }
        }

    }

}

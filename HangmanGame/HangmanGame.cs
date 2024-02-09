using System.ComponentModel.Design;
using System.Text;

namespace PracticeApp {
    internal class HangmanGame {
        private static string[] wordList = new string[10] { "Apple", "Banana", "Orange", "Grape", "Pineapple", "Strawberry", "Watermelon", "Mango", "Kiwi", "Peach" };
        private static Random random = new Random();
        static void Main(string[] args) {
            while (true) {
                Console.Write("Type y to play type n to exit: ");
                string input = Console.ReadLine().ToLower();
                if (input == "y") {
                    PlayGame();
                } else if (input == "n") {
                    Console.WriteLine("Game ended");
                    break;
                } else {
                    Console.WriteLine("Incorrect input");
                }
            }
        }

        static void PlayGame() {
            string word = chooseRandomWord().ToLower();
            bool solved = false;
            string lettersGuessed = "";
            StringBuilder filledWord = new StringBuilder(new string('*', word.Length));

            int triesLeft = 5;

            while (triesLeft > 0) {
                Console.WriteLine("\nTries left {0}", triesLeft);
                Console.WriteLine("So far you have filled: {0}", filledWord);
                Console.Write("Choose a letter or guess a word: ");
                string input = Console.ReadLine().ToLower();
                if (input.Length >= 2) { //Inputed word
                    if (input == word) {
                        solved = true;
                        break;
                    } else { //Inputed character
                        Console.WriteLine("Incorrect word guessed");
                        triesLeft--;
                    }
                } else {
                    int charIndex = word.IndexOf(input);
                    if (lettersGuessed.IndexOf(input) != -1) {
                        Console.WriteLine("You already guessed " + input);
                        continue;
                    }
                    if (charIndex == -1) {
                        Console.WriteLine(input + " is not in the word");
                        triesLeft--;
                        lettersGuessed += input;
                        continue;
                    }
                    int curIndex = charIndex;
                    Console.WriteLine("The word does contain a [{0}]", input);
                    lettersGuessed += input;
                    while (curIndex != -1) {
                        filledWord[curIndex] = input[0];
                        curIndex = word.IndexOf(input, curIndex + 1);
                    }
                    if (filledWord.ToString() == word) {
                        solved = true;
                        break;
                    }
                }
            }
            if (solved == true) {
                Console.WriteLine("\nCongratulations!!! the word was {0} and you solved it in {1} tries ", word, triesLeft);
            } else {
                Console.WriteLine("\nYou ran out of tries play again!");
            }
        }

        static string chooseRandomWord() {
            return wordList[random.Next(0, 10)];
        }
    }
}

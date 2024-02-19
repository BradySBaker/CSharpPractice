using System.IO;
using System.Text.RegularExpressions;

namespace FileParsingGame {
    internal class FilesAndRegex {
        public static void ParseInput1() {
            string fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "assets");

            string[] lines = File.ReadAllLines(fileDirectory + "/input.txt");

            using (StreamWriter file = new StreamWriter(fileDirectory + "/output.txt")) {
                foreach (string line in lines) {
                    if (line.Contains("split")) {
                        string[] splitLine = line.Split();
                        file.Write(" " + splitLine[4]);
                    }
                }
            }
        }

        public static void ParseInput2() {
            string fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "assets");

            string fileText = File.ReadAllText(fileDirectory + "/input2.txt");
            string regexPattern = @"\d{2,3}";
            Regex regex = new Regex(regexPattern);
            MatchCollection matches = regex.Matches(fileText);

            foreach(Match match in matches) {
                int number = int.Parse(match.Value);
                Console.Write((char)number);
            }

        }


        static void Main(string[] args) {
            ParseInput1();
            ParseInput2();
        }
    }
}

using System.Net.NetworkInformation;

namespace CSharpPractice.Pyramid
{
    internal class Program
    {

        static void printPyramid(int size)
        {
            int starAmount = (int)Math.Pow(size, 2);
            int startCharAmount = size - 1;
            int printedStarAmount = 0;
            int curStarAmount = 1;
            while (printedStarAmount < starAmount)
            {
                startCharAmount++;
                for (int i = 0; i < startCharAmount; i++)
                {
                    if (i >= startCharAmount - curStarAmount)
                    {
                        if (i == startCharAmount - 1)
                        {
                            Console.WriteLine("*");
                            curStarAmount += 2;
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        printedStarAmount++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Input Size: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                printPyramid(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

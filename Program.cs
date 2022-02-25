// Programmers: Team Delta
// T-4 Team Bela Problem
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of hands played, followed by the dominant suit: \nPlease separate with a space");
            try
            {
                // Reads user input of dominant suit and # of hands played
                string input = Console.ReadLine();;
                string value_of_input = input.Substring(0,input.IndexOf(" "));  // Stores # of hands as variable
                string dSuit = input.Substring(input.IndexOf(" ") + 1);         // Stores dominant card suit as variable
                int cardValue = int.Parse(value_of_input);                      // # of hands converted to int
                // Console.WriteLine("Input is: {0},{1}", value_of_input, domSuit);
                if (cardValue > 0 && cardValue < 101)
                {
                    // Multiplies the # of hands by the number of crads in a hand (4)
                    int cardNum = cardValue * 4;
                    for (int i = 0; i < 1; i++)
                    {
                        int points = 0;     // initializes points for output calculation

                        Console.WriteLine("Please enter the card values and suits for this hand: ");
                        for (int j = 0; j < cardNum; j++)
                        {
                            string cardInput = Console.ReadLine();  // Exception handling for card inputs (length)
                            if (cardInput.Length > 2)
                            {
                                Console.WriteLine("Error, invalid card.");
                            }
                            else if (cardInput.Length < 2)
                            {
                                Console.WriteLine("Error, invalid card.");
                            }

                            string cardScore = cardInput.Substring(0, 1);   // Stores card #/face value as a variable
                            string cardSuit = cardInput.Substring(1, 1);    // Stores the cards given suit as a variable

                            switch (cardScore)          // switch statement adds/calculates point(s) total
                            {
                                case "A":
                                    points += 11;
                                    break;
                                case "K":
                                    points += 4;
                                    break;
                                case "Q":
                                    points += 3;
                                    break;
                                case "J":
                                    if (dSuit == cardSuit)      // If the input card's suit is the same as the dominant suit: add points
                                        points += 20;
                                    else
                                        points += 2;
                                    break;
                                case "T":
                                    points += 10;
                                    break;
                                case "9":
                                    if (dSuit == cardSuit)
                                        points += 14;
                                    break;
                                default:
                                    break;
                            }
                        }
                        Console.WriteLine("Total: {0}", points);    // Points output

                    }

                }
                else if (cardValue < 1 || cardValue > 100)       // # of hands exception handling
                {
                    Console.WriteLine("Error, invalid number of hands played. Please enter a number between 1 and 100.");
                }
                else
                {
                    Console.WriteLine("Unknown error, please try again.");
                }



               
            }
            catch (Exception ex)    // Additional exception handling 
            {
                Console.WriteLine("Error, exception -- {0}.", ex);
            }
        }
    }
}

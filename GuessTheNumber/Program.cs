using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace GuessTheNumber
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
          

             string question;

             

             Random rnd = new Random();
             int numberToGuess = rnd.Next(31);

             int turns = 0;
             while(true)
             {

             Console.Write("Insert number ");
             question = Console.ReadLine();

             int s =int.Parse(question);


                if (s < 0 | s > 30)
                {
                 Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                 turns++;
                }
                else if (s<numberToGuess)
                {
                    Console.WriteLine($"The hidden number is higher than {s}. Try again.");
                    turns++;
                }
                else if(s>numberToGuess)
                {
                 Console.WriteLine($"The number is lower than {s}. Try again.");
                 turns++;
                }

                else if (s == numberToGuess)
                {
                turns++;
                Console.WriteLine($"You found the hidden number {numberToGuess} after {turns} tries.");
                break;
                }

             }
            
            
                

                
            


        } 
    }
}

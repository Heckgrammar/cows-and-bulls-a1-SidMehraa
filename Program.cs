using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random(); 
    int Answer; 
    do 
    { 
        Answer = random.Next(1023, 9876); 
    } while (answer.ToString().Distinct().Count() < 4 ); 
    int NumOfCows, NumOfBulls; 
    do 
    { 
        Console.WriteLine("Guess what four digit number it is"); 
        string Guess = Console.ReadLine(); 
        while (Guess.Length != 4 || Guess[0] == '0' || Guess.Distinct().Count() < 4) 
        { 
  
            Console.WriteLine("That guess wasn't valid, please try again with a 4 digit number, with unique numbers everywhere and not starting at 0"); 
            Guess = Console.ReadLine(); 
        } 
        NumOfCows = 0; 
        NumOfBulls = 0; 
        for (int i = 0; i < 4; i++) 
        { 
            if (Guess[i] == Answer.ToString()[i]) 
                NumOfBulls++; 
            else if (Answer.ToString().Contains(Guess[i])) 
                NumOfCows++; 
        } 
        Console.WriteLine("Number of bulls are " + NumOfBulls + "and the number of cows are " + NumOfCows); 
    } while (NumOfBulls != 4); 
    Console.WriteLine("You guessed the number well done"); 
} 
        }
    }
}

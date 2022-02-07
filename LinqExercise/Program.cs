using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{

    /*
     * 
     * 
     * Using Method Syntax, create a list of video games of your choice…
Order the list of games by the length of the game’s names...
Be sure to use the lambda expression in this exercise!
Bonus - Try to use each of these methods on your list of video games
Use the list of Linq methods for help 

     * 
     * 
     * 
     * 
     * 
     * 
     */



    class Program
    {
        static void Main(string[] args)
        {

            List<string> games = new List<string>()
            {
                "Mario World - 3rd, 11 chars",
                "Legend of Dragoon - 2nd, 16 chars",
                "Ratchet & Clank - 4th, 14 chars",
                "Where in the World is Carmen Sandiego - 5th, 36 chars",
                "Zelda - 6th, 5 chars",
                "Atlantis is Lost - 1st, 15 chars"
            };

            Console.WriteLine("******At first, the list is out of order:****");
            foreach(string g in games)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("**********And then, alphabetical:************");

            games.Sort();
            foreach (string g in games)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("*************NOT IMPRESSED?!?!:**************");
            Console.WriteLine("********How about by LENGTH? (Jerk!)*********");

            var lengthGames = games.OrderBy(x => x.Length);
            foreach (string g in lengthGames)
            {
                Console.WriteLine(g);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            start:  string[] suite = new string[4] { "Diamonds", "Clubs", "Spades", "Hearts" };
            string[] value = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            List<string> shuffle = new List<string>();
            List<string> dealer = new List<string>();
            List<string> player1 = new List<string>();
            Random rnd = new Random();
            while (shuffle.Count < 52)
            {
                string randomCard = value[rnd.Next(value.Length)] + " of " + suite[rnd.Next(suite.Length)];
                if (!shuffle.Contains(randomCard))
                {
                    shuffle.Add(randomCard);
                }
            }
            dealer.Add(shuffle[0]);
            Console.WriteLine("The dealer has " + dealer[0]);
            Console.ReadLine();
            player1.Add(shuffle[1]);
            player1.Add(shuffle[2]);
            Console.WriteLine("Player 1 has " + player1[0] + " and " + player1[1]);
            Console.ReadLine();
            if (((player1[0]=="Ace of Spades" || player1[0] == "Ace of Diamonds" || player1[0] == "Ace of Hearts" || player1[0] == "Ace of Clubs") && 
                (player1[1] == "10 of Diamonds"|| player1[1] == "10 of Spades"|| player1[1] == "10 of Hearts"|| player1[1] == "10 of Clubs")||
                (player1[1]== "Jack of Diamonds"|| player1[1] == "Jack of Spades"|| player1[1] == "Jack of Clubs"|| player1[1] == "Jack of Hearts")||
                (player1[1] == "Queen of Diamonds" || player1[1] == "Queen of Spades" || player1[1] == "Queen of Clubs" || player1[1] == "Queen of Hearts")||
                (player1[1] == "King of Diamonds" || player1[1] == "King of Spades" || player1[1] == "King of Clubs" || player1[1] == "King of Hearts"))|| 
                (player1[1] == "Ace of Spades" || player1[1] == "Ace of Diamonds" || player1[1] == "Ace of Hearts" || player1[1] == "Ace of Clubs") &&
                (player1[0] == "10 of Diamonds" || player1[0] == "10 of Spades" || player1[0] == "10 of Hearts" || player1[0] == "10 of Clubs") ||
                (player1[0] == "Jack of Diamonds" || player1[0] == "Jack of Spades" || player1[0] == "Jack of Clubs" || player1[0] == "Jack of Hearts") ||
                (player1[0] == "Queen of Diamonds" || player1[0] == "Queen of Spades" || player1[0] == "Queen of Clubs" || player1[0] == "Queen of Hearts") ||
                (player1[0] == "King of Diamonds" || player1[0] == "King of Spades" || player1[0] == "King of Clubs" || player1[0] == "King of Hearts"))
            {
                Console.WriteLine("Player 1 has BlackJack and wins!");
                goto start;
            }
            Console.WriteLine("Would you like to hit, stay, or fold?");
            string action = Console.ReadLine();
            if(action == "fold")
            {
                Console.WriteLine("You fold! Dealer wins.");
                goto start;
            }
            else if(action == "stay")
            {
                Console.WriteLine("The dealer has " + dealer[0] + " and " + shuffle[3]);
                Console.WriteLine("Player 1 has " + player1[0] + " and " + player1[1]);
                Console.ReadLine();
                goto start;
            }
            else if (action == "hit")
            {
                player1.Add(shuffle[3]);
                Console.WriteLine("Player 1 now has " + player1[0] + " and " + player1[1]+ " and " + player1[2]);
                Console.WriteLine("Would you like to hit or stay?");
                string secaction = Console.ReadLine();
                if(secaction == "stay")
                {
                    Console.WriteLine("The dealer has " + dealer[0] + " and " + shuffle[4]);
                    Console.WriteLine("Player 1 now has " + player1[0] + " and " + player1[1] + " and " + player1[2]);
                    Console.ReadLine();
                }
                else if(secaction == "hit")
                {
                    player1.Add(shuffle[4]);
                    Console.WriteLine("Player 1 now has " + player1[0] + " and " + player1[1] + " and " + player1[2] + " and " + player1[3]);

                }
            }
            Console.ReadLine();
        }
    }
}

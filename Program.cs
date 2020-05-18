using System;
using System.Collections.Generic;
using System.Linq;



namespace Cards
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rnd = new Random();
            var deck1 = new List<string>() { "Ace of Spades", "Ace of Hearts", "Ace of Diamonds", "Ace of Clubs", "Two of Spades", "Two of Hearts", "Two of Diamonds", "Two of Clubs", "Three of Spades", "Three of Hearts", "Three of Diamonds", "Three of Clubs", "Four of Spades", "Four of Hearts", "Four of Diamonds", "Four of Clubs", "Five of Spades", "Five of Hearts", "Five of Diamonds", "Five of Clubs", "Six of Spades", "Six of Hearts", "Six of Diamonds", "Six of Diamonds", "Seven of Spades", "Seven of Hearts", "Seven of Diamonds", "Seven of Clubs", "Eight of Spades", "Eight of Hearts", "Eight of Diamonds", "Eight of Clubs", "Nine of Spades", "Nine of Hearts", "Nine of Diamonds", "Nine of Clubs", "Ten of Spades", "Ten of Hearts", "Ten of Diamonds", "Ten of Clubs", "Jack of Spades", "Jack of Hearts", "Jack of Diamonds", "Jack of Clubs", "Queen of Spades", "Queen of Hearts", "Queen of Diamonds", "Queen of Clubs", "King of Spades", "King of Hearts", "King of Diamonds", "King of Clubs" };
            Console.WriteLine("Hit Enter To Shuffle Deck and Reveal Two Cards");
            Console.ReadLine();

            for (int firstIndex = deck1.Count - 1; firstIndex >= 0; firstIndex--)
            {
                int secondIndex = rnd.Next(0, firstIndex);
                var firstValue = deck1[firstIndex];
                deck1[firstIndex] = deck1[secondIndex];
                deck1[secondIndex] = firstValue;
            }
            Console.WriteLine(deck1[0]);
            Console.WriteLine(deck1[1]);
        }
    }
}

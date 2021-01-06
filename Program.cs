using System;
using System.Collections.Generic;

namespace AllCardsOnDeck_
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List for Suits and Faces
            var suitList = new List<string>() { "Spades", "Diamonds", "Hearts", "Clubs" };
            var faceList = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //  Creating the Deck Of cards
            var deckOfCards = new List<string>();
            for (var suitindex = 0; suitindex < suitList.Count; suitindex++)
            {
                for (var faceindex = 0; faceindex < faceList.Count; faceindex++)
                {
                    var testing = suitList[suitindex] + faceList[faceindex];
                    deckOfCards.Add(testing);
                }
            }
            foreach (var cards in deckOfCards)
            {
                Console.WriteLine(cards);
            }

            //  Shuffling
            var numOfCards = deckOfCards.Count;
            for (var rightindex = numOfCards - 1; rightindex >= 0; rightindex--)
            {
                var leftindex = new Random().Next(0, rightindex);
            }

            // for rightIndex from numberOfCards - 1 down to 1 do:
            // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")

            // Now swap the values at rightIndex and leftIndex by doing this:
            // leftCard = the value from deck[leftIndex]
            // rightCard = the value from deck[rightIndex]
            // deck[rightIndex] = leftCard
            // deck[leftIndex] = rightCard
        }
    }
}
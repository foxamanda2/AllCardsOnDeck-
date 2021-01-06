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
                    deckOfCards.Add($"{faceList[faceindex]} of {suitList[suitindex]}");
                }
            }
            // foreach (var cards in deckOfCards)
            // {
            // Console.WriteLine(cards);
            // }

            //  Shuffling
            var numOfCards = deckOfCards.Count;
            for (var rightindex = numOfCards - 1; rightindex >= 0; rightindex--)
            {
                var leftindex = new Random().Next(0, rightindex);
                var leftNum = deckOfCards[leftindex];
                var rightNum = deckOfCards[rightindex];
                deckOfCards[rightindex] = leftNum;
                deckOfCards[leftindex] = rightNum;
            }
            foreach (var shufCards in deckOfCards)
            {
                Console.WriteLine($"{shufCards}");
            }
            var firstTwoCards = ($"Card 1: {deckOfCards[0]} Card 2: {deckOfCards[1]}");

            Console.WriteLine(firstTwoCards);
        }
    }
}
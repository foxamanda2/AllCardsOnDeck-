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

            //  First Two Cards
            var firstTwoCards = ($"Card 1: {deckOfCards[0]} Card 2: {deckOfCards[1]}");
            Console.WriteLine(firstTwoCards);

            // Two Hands of Cards
            Console.Write("How many cards do you want in your hand? ");
            var cardNum = int.Parse(Console.ReadLine());

            Console.WriteLine(deckOfCards.Count);

            for (var hand1index = 0; hand1index < cardNum; hand1index++)
            {
                var hand1 = deckOfCards[hand1index];
                Console.WriteLine($"This is in person 1 deck: {hand1}");
                deckOfCards.Remove(hand1);

            }
            Console.WriteLine("\n\n\n");
            for (var hand2index = 0; hand2index < cardNum; hand2index++)
            {
                var hand2 = deckOfCards[hand2index];
                Console.WriteLine($"This is in person 2 deck: {hand2}");
            }
        }
    }
}
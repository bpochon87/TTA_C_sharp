﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Brady", "Sara", "Dale Dee", "Ron" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle();

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine($"Length of deck is {deck.Cards.Count}.");
            //Console.ReadLine();
        }
    }
}

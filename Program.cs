using System;
using System.Collections;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            displaySuits();
            Console.WriteLine();

            displayValues();
            Console.WriteLine();

            displayDeckOfCards();
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void displaySuits()
        {
            Console.WriteLine("The suits are:");
            IEnumerator suits = new SuitsEnumerator();

            while (suits.MoveNext())
            {
                Console.WriteLine(suits.Current);
            }
        }

        private static void displayValues()
        {
            Console.WriteLine("The Values are:");
            IEnumerator values = new CardValuesEnumerator();

            while (values.MoveNext())
            {
                Console.WriteLine(values.Current);
            }
        }

        private static void displayDeckOfCards()
        {
            Console.WriteLine("The deckOfCards contains:");

            foreach (object card in new DeckOfCards())
            {
                Console.WriteLine(card);
            }
        }
    }
}

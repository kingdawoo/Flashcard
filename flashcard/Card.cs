using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace flashcard
{
    public class Card
    {
        // Deck that the card belongs to
        // Korthållaren som kortet tillhör till
        public Deck Deck;
        public string Question { get; set; }
        public string Answer { get; set; }

        // Constructor to create a new card
        // Konstruktor för att skapa ett nytt kort
        public Card(Deck deck, string question, string answer)
        {
            this.Deck = deck;
            this.Question = question;
            this.Answer = answer;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;

namespace flashcard
{
    public class Deck
    {
        // List of cards in the deck
        public List<Card> Cards { get; set; }
        public int Id { get; set; }
        public string Names { get; set; }
        
        // Method to add a card to the deck
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public Deck(List<Deck> decks, string name)
        {
            this.Id = decks.Count + 1; // Assign unique Id to deck
            this.Names = name;

            // Initialize the cards list
            Cards = new List<Card>();
        }
    }
}

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
        // Lista av kort i korthållaren
        public List<Card> Cards { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        
        // Method to add a card to the deck
        // Metod till att lägga till ett kort till korthållaren
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public Deck(List<Deck> decks, string name)
        {
            // Assign unique Id to deck
            // Tilldela unik Id till korthållare
            this.Id = decks.Count + 1;
            this.Name = name;

            // Initialize the cards list
            // Initiera kortlistan
            Cards = new List<Card>();
        }
    }
}

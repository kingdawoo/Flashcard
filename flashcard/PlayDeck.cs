using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace flashcard
{
    public partial class PlayDeck : Form
    {
        private Deck selectedDeck;
        private int currentCardIndex;

        public PlayDeck(Deck deck, int currentCardIndex)
        {
            InitializeComponent();
            selectedDeck = deck;
            this.currentCardIndex = currentCardIndex;

            // Clear the Cards list so it wíll not duplicate the cards
            // Ta bort kort listan så att kort inte dubblas
            selectedDeck.Cards.Clear();

            // Load the cards from the text file
            // Ladda kort från textfilen
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "cards_" + selectedDeck.Name + ".txt");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('\t');
                string question = parts[0];
                string answer = parts[1];
                Card card = new Card(selectedDeck, question, answer);
                selectedDeck.AddCard(card);
            }

            // Disable buttons if exceeding index
            // Inaktivera knappar om överskrider index
            if (currentCardIndex == 0)
            {
                btnPreviousCard.Enabled = false;
            }
            if (currentCardIndex == selectedDeck.Cards.Count - 1)
            {
                btnNextCard.Enabled = false;
            }


            // Display the first card in the form
            // Visa det första kortet i form
            Card currentCard = selectedDeck.Cards[currentCardIndex];
            displayQuestion.Text = currentCard.Question;
            displayAnswer.Text = currentCard.Answer;
        }

        private void btnShowCard_Click(object sender, EventArgs e)
        {
            displayAnswer.Visible = true;
            btnShowCard.Visible = false;
            btnHideCard.Visible = true;
        }

        private void btnHideCard_Click(object sender, EventArgs e)
        {
            displayAnswer.Visible = false;
            btnHideCard.Visible = false;
            btnShowCard.Visible = true;
        }

        private void btnPreviousCard_Click(object sender, EventArgs e)
        {
            // Check if the current card is the first card in the deck
            // Kontrollera om det aktuella kortet är det första kortet i leken
            if (currentCardIndex > 0)
            {
                // Decrement the current card index
                // Minska det aktuella kort index
                currentCardIndex--;

                // Display the previous card and fix buttons
                // Visa föregående kort och fixknappar
                Card currentCard = selectedDeck.Cards[currentCardIndex];
                displayQuestion.Text = currentCard.Question;
                displayAnswer.Text = currentCard.Answer;
                displayAnswer.Visible = false;
                btnHideCard.Visible = false;
                btnShowCard.Visible = true;
                btnNextCard.Enabled = true;
            }
            btnPreviousCard.Enabled = currentCardIndex > 0;
        }

        private void btnNextCard_Click(object sender, EventArgs e)
        {
            // Check if the current card is the last card in the deck
            // Kontrollera om det aktuella kortet är det sista kortet i leken
            if (currentCardIndex < selectedDeck.Cards.Count - 1)
            {
                // Increment the current card index
                // Öka det aktuella kort index
                currentCardIndex++;

                // Display the next card and fix buttons
                // Visa nästa kort och fixknappar
                Card currentCard = selectedDeck.Cards[currentCardIndex];
                displayQuestion.Text = currentCard.Question;
                displayAnswer.Text = currentCard.Answer;
                displayAnswer.Visible = false;
                btnHideCard.Visible = false;
                btnShowCard.Visible = true;
                btnPreviousCard.Enabled = true;
            }
            btnNextCard.Enabled = currentCardIndex < selectedDeck.Cards.Count - 1;
        }
    }
}

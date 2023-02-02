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
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace flashcard
{
    public partial class AddCard : Form
    {

        Timer timer = new Timer();

        // Reference to the "BrowseCards" form
        public BrowseCards browseCards;
        // Reference to the selected deck
        public Deck selectedDeck;

        // Constructor to create a new "AddCard"-form
        // Kontruktör till att skapa nytt "AddCard"-from
        public AddCard(Deck deck, BrowseCards browse)
        {
            InitializeComponent();
            this.selectedDeck = deck;
            this.browseCards = browse;
            timer.Interval = 1000;
            timer.Tick += T_Tick;

        }

        private void T_Tick(object sender, EventArgs e)
        {
            // Set timer for label
            // Lägg timer för label
            Timer timer = sender as Timer;
            txtSuccess.Visible = false;
            timer.Stop();
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            // Error message if question or answer empty
            // Error meddelande ifall ingen fråga eller svar
            if (string.IsNullOrEmpty(txtQuestion.Text)  || string.IsNullOrEmpty(txtAnswer.Text))
            {
                // Throw error message if card is empty
                // Kasta error meddelande ifall kort är tom
                MessageBox.Show("Please type on both boxes and try again!", "Error message: No input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create a new card and add it to the selected deck
                // Skapa nytt kort och lägg till i vald kortlek
                Card card = new Card(selectedDeck, txtQuestion.Text, txtAnswer.Text);
                selectedDeck.AddCard(card);

                // Save the card data to a text file
                // Spara kort data till en text fil
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
                Directory.CreateDirectory(folderPath);
                string filePath = Path.Combine(folderPath, "cards_" + selectedDeck.Name + ".txt");
                
                // Garbage collection
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                
                // Write to file
                // Skriv till fil
                StreamWriter writer = File.AppendText(filePath);
                writer.WriteLine(card.Question + "\t" + card.Answer);
                writer.Close();

                // Reload the data grid view in the BrowseCards form to show the updated list of cards
                // Ladda om data grid view i "BrowseCards"-form för att visa den uppdaterade listan med kort
                if (Application.OpenForms.OfType<BrowseCards>().Any())
                {
                    browseCards.dataGridView2.Rows.Clear();
                    foreach (Card c in selectedDeck.Cards)
                    {
                        int index = browseCards.dataGridView2.Rows.Add();
                        DataGridViewRow row = browseCards.dataGridView2.Rows[index];
                        row.Cells["Question"].Value = c.Question;
                        row.Cells["Answer"].Value = c.Answer;
                    }
                }
                txtQuestion.Clear();
                txtAnswer.Clear();

                txtSuccess.Visible = true;
                timer.Start();

            }            
        }
    }
}

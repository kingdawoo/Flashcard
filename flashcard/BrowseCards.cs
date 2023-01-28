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
using static System.Net.WebRequestMethods;

namespace flashcard
{
    public partial class BrowseCards : Form
    {
        // Reference to the selected deck
        public Deck selectedDeck;

        // Reference to the "AddCard" form
        public AddCard addCardForm;

        // Constructor to create a new "BrowseCards" form
        public BrowseCards(Deck deck)
        {
            InitializeComponent();
            this.selectedDeck = deck;
        }
        private void BrowseCards_Load(object sender, EventArgs e)
        {
            try
            {
                // Get the file path for the selected deck
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
                string filePath = Path.Combine(folderPath, "cards_" + selectedDeck.Names + ".txt");

                // Garbage collection
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();

                // Read all lines from the text file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                // Loop through the lines and create a new card for each line
                for (int i = 0; i < lines.Length; i++)
                {
                    // Split the line into parts using the tab separator
                    string[] parts = lines[i].Split('\t');
                    string question = parts[0];
                    string answer = parts[1];

                    // Create a new card using the current question and answer
                    Card card = new Card(selectedDeck, question, answer);

                    // Add the card to the selected deck
                    selectedDeck.Cards.Add(card);

                    // Add the card to the data grid view
                    int index = dataGridView2.Rows.Add();
                    DataGridViewRow row = dataGridView2.Rows[index];
                    row.Cells["Question"].Value = card.Question;
                    row.Cells["Answer"].Value = card.Answer;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }           
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
            string files = Path.Combine(folderPath, "cards_" + selectedDeck.Names + ".txt");

            System.Diagnostics.Process.Start(files);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BrowseCards browse = new BrowseCards(selectedDeck);
            browse.Show();
            this.Hide();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
            System.Diagnostics.Process.Start(folderPath);
        }
    }
}

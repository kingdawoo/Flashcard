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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flashcard
{
    public partial class DeckMenu : Form
    {

        // Reference to "BrowseCards" form
        public BrowseCards browseCardsForm;

        // List to hold decks
        private List<Deck> decks = new List<Deck>();

        // Currently selected deck
        private Deck selectedDeck;

        public DeckMenu()
        {
            InitializeComponent();
            notSelected();
        }

        public void isSelected()
        {
            btnDeleteDeck.Enabled = true;
            btnEditDeck.Enabled = true;
            btnBrowseDeck.Enabled = true;
            btnPlayDeck.Enabled = true;
            btnAddCards.Enabled = true;

            btnDeleteDeck.BackColor = Color.Red; btnEditDeck.BackColor = Color.Green; btnBrowseDeck.BackColor = Color.LightGreen; btnPlayDeck.BackColor = Color.Green; 
            btnAddCards.BackColor = Color.Green;
        }
        public void notSelected()
        {
            btnDeleteDeck.Enabled = false;
            btnEditDeck.Enabled = false;
            btnBrowseDeck.Enabled = false;
            btnPlayDeck.Enabled = false;
            btnAddCards.Enabled = false;

            btnDeleteDeck.BackColor = SystemColors.ButtonFace; btnEditDeck.BackColor = SystemColors.ButtonFace; btnBrowseDeck.BackColor = SystemColors.ButtonFace; btnPlayDeck.BackColor = SystemColors.ButtonFace;
            btnAddCards.BackColor = SystemColors.ButtonFace;
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            // Add each deck in list of decks to data grid view
            foreach (Deck deck in decks)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Cells["Id"].Value = deck.Id;
                row.Cells["Names"].Value = deck.Names;
            }

            txtDeckName.Clear();
        }


        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            try
            {
                // Throw error if no user input
                if (string.IsNullOrEmpty(txtDeckName.Text))
                {
                    MessageBox.Show("Name for deck missing, try again!", "Error message: No deck name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deckName = txtDeckName.Text;

                    // Create new deck with user-specified name
                    Deck newDeck = new Deck(decks, deckName);
                    decks.Add(newDeck);

                    // Place the txt file in specialfolder
                    string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
                    Directory.CreateDirectory(folderPath);
                    string filePath = Path.Combine(folderPath, "cards_" + deckName + ".txt");
                    File.CreateText(filePath);

                    UpdateDataGridView();
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Please do not create another deck with the same name as another, try again!", "Error message: No deck name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeckName.Clear();
            }
        }

        private void btnDeleteDeck_Click(object sender, EventArgs e)
        {
            // Check if a deck is selected in the data grid view
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get selected deck from data grid view
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deckId = (int)selectedRow.Cells["Id"].Value;
                    selectedDeck = decks.First(d => d.Id == deckId);

                    // Remove selected deck from list of decks
                    decks.Remove(selectedDeck);

                    // Update Ids of remaining decks in the list
                    for (int i = 0; i < decks.Count; i++)
                    {
                        decks[i].Id = i + 1;
                    }

                    // Delete the text file for the selected deck
                    string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
                    string filePath = Path.Combine(folderPath, "cards_" + selectedDeck.Names + ".txt");

                    // Garbage collection
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();

                    File.Delete(filePath);

                    // Update data grid view to show updated list of decks
                    UpdateDataGridView();
                    notSelected();
                }
                catch (NullReferenceException)
                {
                    // Throw specific exception if deck selected is null
                    MessageBox.Show("Please select a created deck and try again!", "Error message: Null deck",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            } 
            else
            {
                // Throw error message if deck is not selected
                MessageBox.Show("Please select a deck and try again!", "Error message: Deck not selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBrowseDeck_Click(object sender, EventArgs e)
        {            
            // Check if a deck is selected in the data grid view
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get selected deck from data grid view
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deckId = (int)selectedRow.Cells["Id"].Value;
                    selectedDeck = decks.First(d => d.Id == deckId);

                    // Create a new instance of the "BrowseCards" form and show it
                    browseCardsForm = new BrowseCards(selectedDeck);
                    browseCardsForm.Show();
                }
                catch (NullReferenceException)
                {
                    // Throw specific exception if deck selected is null
                    MessageBox.Show("Please select a created deck and try again!", "Error message: Null deck",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                // Throw error message if deck is not selected
                MessageBox.Show("Please select a deck and try again!", "Error message: Deck not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCards_Click(object sender, EventArgs e)
        {
            // Check if a deck is selected in the data grid view
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get selected deck from data grid view
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deckId = (int)selectedRow.Cells["Id"].Value;
                    selectedDeck = decks.First(d => d.Id == deckId);

                    // Create a new instance of the "AddCard" form and show it
                    AddCard addCardForm = new AddCard(selectedDeck, browseCardsForm);
                    addCardForm.ShowDialog();

                    // Update data grid view to show cards for the selected deck
                    UpdateDataGridView();
                }
                catch (NullReferenceException)
                {
                    // Throw specific exception if deck selected is null
                    MessageBox.Show("Please select a created deck and try again!", "Error message: Null deck",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Throw error message if deck is not selected
                MessageBox.Show("Please select a deck and try again!", "Error message: Deck not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            notSelected();
        }

        private void btnPlayDeck_Click(object sender, EventArgs e)
        {
            // Check if a deck is selected in the data grid view
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get selected deck from data grid view
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deckId = (int)selectedRow.Cells["Id"].Value;
                    Deck selectedDeck = decks.First(d => d.Id == deckId);

                    // Open the play deck form and pass it the selected deck
                    PlayDeck playDeckForm = new PlayDeck(selectedDeck, 0);
                    playDeckForm.ShowDialog();
                }
                catch (NullReferenceException)
                {
                    // Throw exception if deck selected is null
                    MessageBox.Show("Please select a created deck and try again!", "Error message: Null deck",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Please add cards to the selected deck and try again!", "Error message: Empty deck",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Throw error message if deck is not selected
                MessageBox.Show("Please select a deck and try again!", "Error message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeckMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // Get all txt files in the specified file path
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");
                string[] files = Directory.GetFiles(folderPath, "*.txt");

                // Iterate through each file
                foreach (string file in files)
                {
                    // Get the name of the file (which is the name of the deck)
                    string deckName = Path.GetFileNameWithoutExtension(file).Replace("cards_", "");

                    // Create a new deck with the name
                    Deck newDeck = new Deck(decks, deckName);

                    // Add the new deck to the list of decks
                    decks.Add(newDeck);
                }

                // Update the data grid view to show the loaded decks
                UpdateDataGridView();
            }
            catch (System.IO.DirectoryNotFoundException)
            {

            }
        }

        private void btnEditDeck_Click(object sender, EventArgs e)
        {
            // Check if a deck is selected in the data grid view
            if (string.IsNullOrEmpty(txtDeckName.Text))
            {
                MessageBox.Show("Please give the deck a name!", "Error message: No input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "flashcard\\decks");

                    // Get selected deck from data grid view
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deckId = (int)selectedRow.Cells["Id"].Value;
                    selectedDeck = decks.First(d => d.Id == deckId);

                    // Garbage collection
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();

                    // Rename file
                    System.IO.File.Move(Path.Combine(folderPath, "cards_" + selectedDeck.Names + ".txt"), Path.Combine(folderPath, "cards_" + txtDeckName.Text + ".txt"));
                    selectedDeck.Names = txtDeckName.Text;
                    UpdateDataGridView();
                    notSelected();

                }
                catch (NullReferenceException)
                {
                    // Throw specific exception if deck selected is null
                    MessageBox.Show("Please select a created deck and try again!", "Error message: Null deck",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Throw error message if deck is not selected
                MessageBox.Show("Please select a deck and try again!", "Error message: Deck not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSelected();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Create a deck by writing a name in the textbox then clicking 'Create deck'.\n\n" +
                "2. Select the deck by clicking on the decks row header cell on the grid view.\n\n" +
                "3. Pick if you want to delete or add cards to the deck.\n\n" + 
                "4. If add card, input question and answer then click 'Add'.\n\n" +
                "5. Now you can choose to play the deck or browse the deck.\n\n\n" +
                "If you want to you can select a deck and rename then click 'Edit deck' button.\n\n" +
                "If you want to unselect a deck double-click the row cell.", 
                "Instructions",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            notSelected();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isSelected();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            notSelected();
            dataGridView1.ClearSelection();
        }
    }
}
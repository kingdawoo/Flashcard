namespace flashcard
{
    partial class DeckMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckMenu));
            this.txtDeckName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateDeck = new System.Windows.Forms.Button();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnBrowseDeck = new System.Windows.Forms.Button();
            this.btnAddCards = new System.Windows.Forms.Button();
            this.btnPlayDeck = new System.Windows.Forms.Button();
            this.btnEditDeck = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeckName
            // 
            this.txtDeckName.Location = new System.Drawing.Point(36, 69);
            this.txtDeckName.Name = "txtDeckName";
            this.txtDeckName.Size = new System.Drawing.Size(186, 26);
            this.txtDeckName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names});
            this.dataGridView1.Location = new System.Drawing.Point(268, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(662, 376);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Names.HeaderText = "Name";
            this.Names.MinimumWidth = 8;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write deck name:";
            // 
            // btnCreateDeck
            // 
            this.btnCreateDeck.BackColor = System.Drawing.Color.Green;
            this.btnCreateDeck.Location = new System.Drawing.Point(36, 118);
            this.btnCreateDeck.Name = "btnCreateDeck";
            this.btnCreateDeck.Size = new System.Drawing.Size(186, 48);
            this.btnCreateDeck.TabIndex = 4;
            this.btnCreateDeck.Text = "Create deck";
            this.btnCreateDeck.UseVisualStyleBackColor = false;
            this.btnCreateDeck.Click += new System.EventHandler(this.btnCreateDeck_Click);
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteDeck.Location = new System.Drawing.Point(36, 184);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(186, 48);
            this.btnDeleteDeck.TabIndex = 5;
            this.btnDeleteDeck.Text = "Delete deck";
            this.btnDeleteDeck.UseVisualStyleBackColor = false;
            this.btnDeleteDeck.Click += new System.EventHandler(this.btnDeleteDeck_Click);
            // 
            // btnBrowseDeck
            // 
            this.btnBrowseDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowseDeck.Location = new System.Drawing.Point(955, 58);
            this.btnBrowseDeck.Name = "btnBrowseDeck";
            this.btnBrowseDeck.Size = new System.Drawing.Size(186, 48);
            this.btnBrowseDeck.TabIndex = 6;
            this.btnBrowseDeck.Text = "Browse deck";
            this.btnBrowseDeck.UseVisualStyleBackColor = false;
            this.btnBrowseDeck.Click += new System.EventHandler(this.btnBrowseDeck_Click);
            // 
            // btnAddCards
            // 
            this.btnAddCards.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCards.Location = new System.Drawing.Point(36, 317);
            this.btnAddCards.Name = "btnAddCards";
            this.btnAddCards.Size = new System.Drawing.Size(186, 48);
            this.btnAddCards.TabIndex = 7;
            this.btnAddCards.Text = "Add cards";
            this.btnAddCards.UseVisualStyleBackColor = false;
            this.btnAddCards.Click += new System.EventHandler(this.btnAddCards_Click);
            // 
            // btnPlayDeck
            // 
            this.btnPlayDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlayDeck.Location = new System.Drawing.Point(36, 385);
            this.btnPlayDeck.Name = "btnPlayDeck";
            this.btnPlayDeck.Size = new System.Drawing.Size(186, 48);
            this.btnPlayDeck.TabIndex = 8;
            this.btnPlayDeck.Text = "Play deck";
            this.btnPlayDeck.UseVisualStyleBackColor = false;
            this.btnPlayDeck.Click += new System.EventHandler(this.btnPlayDeck_Click);
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditDeck.Location = new System.Drawing.Point(36, 249);
            this.btnEditDeck.Name = "btnEditDeck";
            this.btnEditDeck.Size = new System.Drawing.Size(186, 48);
            this.btnEditDeck.TabIndex = 9;
            this.btnEditDeck.Text = "Edit deck";
            this.btnEditDeck.UseVisualStyleBackColor = false;
            this.btnEditDeck.Click += new System.EventHandler(this.btnEditDeck_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHelp.Location = new System.Drawing.Point(955, 385);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(186, 48);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(955, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DeckMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1167, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnEditDeck);
            this.Controls.Add(this.btnPlayDeck);
            this.Controls.Add(this.btnAddCards);
            this.Controls.Add(this.btnBrowseDeck);
            this.Controls.Add(this.btnDeleteDeck);
            this.Controls.Add(this.btnCreateDeck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDeckName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1003, 544);
            this.Name = "DeckMenu";
            this.Text = "Deck Menu";
            this.Load += new System.EventHandler(this.DeckMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeckName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDeck;
        private System.Windows.Forms.Button btnDeleteDeck;
        private System.Windows.Forms.Button btnBrowseDeck;
        private System.Windows.Forms.Button btnAddCards;
        private System.Windows.Forms.Button btnPlayDeck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.Button btnEditDeck;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


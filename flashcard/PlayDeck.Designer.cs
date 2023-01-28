namespace flashcard
{
    partial class PlayDeck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayDeck));
            this.displayQuestion = new System.Windows.Forms.RichTextBox();
            this.btnPreviousCard = new System.Windows.Forms.Button();
            this.btnShowCard = new System.Windows.Forms.Button();
            this.btnNextCard = new System.Windows.Forms.Button();
            this.displayAnswer = new System.Windows.Forms.RichTextBox();
            this.btnHideCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayQuestion
            // 
            this.displayQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayQuestion.Location = new System.Drawing.Point(51, 33);
            this.displayQuestion.Name = "displayQuestion";
            this.displayQuestion.ReadOnly = true;
            this.displayQuestion.Size = new System.Drawing.Size(693, 122);
            this.displayQuestion.TabIndex = 0;
            this.displayQuestion.Text = "";
            // 
            // btnPreviousCard
            // 
            this.btnPreviousCard.Location = new System.Drawing.Point(51, 383);
            this.btnPreviousCard.Name = "btnPreviousCard";
            this.btnPreviousCard.Size = new System.Drawing.Size(147, 40);
            this.btnPreviousCard.TabIndex = 1;
            this.btnPreviousCard.Text = "Previous card";
            this.btnPreviousCard.UseVisualStyleBackColor = true;
            this.btnPreviousCard.Click += new System.EventHandler(this.btnPreviousCard_Click);
            // 
            // btnShowCard
            // 
            this.btnShowCard.Location = new System.Drawing.Point(359, 383);
            this.btnShowCard.Name = "btnShowCard";
            this.btnShowCard.Size = new System.Drawing.Size(75, 40);
            this.btnShowCard.TabIndex = 2;
            this.btnShowCard.Text = "Show";
            this.btnShowCard.UseVisualStyleBackColor = true;
            this.btnShowCard.Click += new System.EventHandler(this.btnShowCard_Click);
            // 
            // btnNextCard
            // 
            this.btnNextCard.Location = new System.Drawing.Point(601, 383);
            this.btnNextCard.Name = "btnNextCard";
            this.btnNextCard.Size = new System.Drawing.Size(147, 40);
            this.btnNextCard.TabIndex = 3;
            this.btnNextCard.Text = "Next card";
            this.btnNextCard.UseVisualStyleBackColor = true;
            this.btnNextCard.Click += new System.EventHandler(this.btnNextCard_Click);
            // 
            // displayAnswer
            // 
            this.displayAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAnswer.Location = new System.Drawing.Point(51, 184);
            this.displayAnswer.Name = "displayAnswer";
            this.displayAnswer.ReadOnly = true;
            this.displayAnswer.Size = new System.Drawing.Size(693, 122);
            this.displayAnswer.TabIndex = 4;
            this.displayAnswer.Text = "";
            this.displayAnswer.Visible = false;
            // 
            // btnHideCard
            // 
            this.btnHideCard.Location = new System.Drawing.Point(359, 383);
            this.btnHideCard.Name = "btnHideCard";
            this.btnHideCard.Size = new System.Drawing.Size(75, 40);
            this.btnHideCard.TabIndex = 5;
            this.btnHideCard.Text = "Hide";
            this.btnHideCard.UseVisualStyleBackColor = true;
            this.btnHideCard.Visible = false;
            this.btnHideCard.Click += new System.EventHandler(this.btnHideCard_Click);
            // 
            // PlayDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHideCard);
            this.Controls.Add(this.displayAnswer);
            this.Controls.Add(this.btnNextCard);
            this.Controls.Add(this.btnShowCard);
            this.Controls.Add(this.btnPreviousCard);
            this.Controls.Add(this.displayQuestion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayDeck";
            this.Text = "PlayDeck";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayQuestion;
        private System.Windows.Forms.Button btnPreviousCard;
        private System.Windows.Forms.Button btnShowCard;
        private System.Windows.Forms.Button btnNextCard;
        private System.Windows.Forms.RichTextBox displayAnswer;
        private System.Windows.Forms.Button btnHideCard;
    }
}
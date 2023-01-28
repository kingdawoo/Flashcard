namespace flashcard
{
    partial class AddCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCard));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateCard = new System.Windows.Forms.Button();
            this.txtSuccess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(62, 49);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(671, 157);
            this.txtQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(62, 259);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(671, 157);
            this.txtAnswer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer";
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Location = new System.Drawing.Point(62, 433);
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.Size = new System.Drawing.Size(111, 42);
            this.btnCreateCard.TabIndex = 4;
            this.btnCreateCard.Text = "Create card";
            this.btnCreateCard.UseVisualStyleBackColor = true;
            this.btnCreateCard.Click += new System.EventHandler(this.btnCreateCard_Click);
            // 
            // txtSuccess
            // 
            this.txtSuccess.AutoSize = true;
            this.txtSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSuccess.Location = new System.Drawing.Point(548, 444);
            this.txtSuccess.Name = "txtSuccess";
            this.txtSuccess.Size = new System.Drawing.Size(185, 20);
            this.txtSuccess.TabIndex = 5;
            this.txtSuccess.Text = "Card created and added!";
            this.txtSuccess.Visible = false;
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(794, 487);
            this.Controls.Add(this.txtSuccess);
            this.Controls.Add(this.btnCreateCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCard";
            this.Text = "Add Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateCard;
        private System.Windows.Forms.Label txtSuccess;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace Part_8_Hangman
{
    partial class Hangman
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.imgHangman = new System.Windows.Forms.PictureBox();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(531, 285);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(67, 25);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(16, 334);
            this.lblWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 69);
            this.lblWord.TabIndex = 1;
            this.lblWord.Click += new System.EventHandler(this.lblWord_Click);
            // 
            // imgHangman
            // 
            this.imgHangman.Image = global::Part_8_Hangman.Properties.Resources.hangman_empty1;
            this.imgHangman.Location = new System.Drawing.Point(13, 85);
            this.imgHangman.Margin = new System.Windows.Forms.Padding(4);
            this.imgHangman.Name = "imgHangman";
            this.imgHangman.Size = new System.Drawing.Size(154, 200);
            this.imgHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgHangman.TabIndex = 3;
            this.imgHangman.TabStop = false;
            this.imgHangman.Click += new System.EventHandler(this.imgHangman_Click);
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.ItemHeight = 16;
            this.lstGuessedLetters.Location = new System.Drawing.Point(452, 107);
            this.lstGuessedLetters.Margin = new System.Windows.Forms.Padding(4);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(145, 164);
            this.lstGuessedLetters.TabIndex = 4;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(448, 74);
            this.lblUsedLetters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(149, 29);
            this.lblUsedLetters.TabIndex = 5;
            this.lblUsedLetters.Text = "Used Letters";
            this.lblUsedLetters.Click += new System.EventHandler(this.lblUsedLetters_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(453, 285);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(70, 22);
            this.txtGuess.TabIndex = 6;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(268, 316);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(163, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 46);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Hangman Lite!";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(624, 408);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblUsedLetters);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.imgHangman);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.PictureBox imgHangman;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
    }
}


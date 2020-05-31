namespace prjSelectionPart1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsersGuess = new System.Windows.Forms.TextBox();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberGuesses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUESS MY NUMBER(1-100):";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Turquoise;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartGame.Location = new System.Drawing.Point(107, 109);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(272, 42);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "START GAME!";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(72, 167);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(149, 45);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "STATUS:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(227, 167);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(47, 45);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "GUESS?";
            // 
            // txtUsersGuess
            // 
            this.txtUsersGuess.BackColor = System.Drawing.Color.Lime;
            this.txtUsersGuess.Enabled = false;
            this.txtUsersGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersGuess.ForeColor = System.Drawing.SystemColors.Info;
            this.txtUsersGuess.Location = new System.Drawing.Point(199, 215);
            this.txtUsersGuess.Name = "txtUsersGuess";
            this.txtUsersGuess.Size = new System.Drawing.Size(100, 47);
            this.txtUsersGuess.TabIndex = 5;
            this.txtUsersGuess.Text = "0";
            this.txtUsersGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.BackColor = System.Drawing.Color.Turquoise;
            this.btnSubmitGuess.Enabled = false;
            this.btnSubmitGuess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGuess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmitGuess.Location = new System.Drawing.Point(80, 268);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(272, 42);
            this.btnSubmitGuess.TabIndex = 6;
            this.btnSubmitGuess.Text = "SUBMIT GUESS";
            this.btnSubmitGuess.UseVisualStyleBackColor = false;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "# GUESSES:";
            // 
            // lblNumberGuesses
            // 
            this.lblNumberGuesses.AutoSize = true;
            this.lblNumberGuesses.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberGuesses.Location = new System.Drawing.Point(268, 313);
            this.lblNumberGuesses.Name = "lblNumberGuesses";
            this.lblNumberGuesses.Size = new System.Drawing.Size(38, 45);
            this.lblNumberGuesses.TabIndex = 8;
            this.lblNumberGuesses.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "TEMPERATURE?";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.Red;
            this.lblTemperature.Location = new System.Drawing.Point(351, 358);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(62, 45);
            this.lblTemperature.TabIndex = 10;
            this.lblTemperature.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(571, 458);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumberGuesses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmitGuess);
            this.Controls.Add(this.txtUsersGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Your Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsersGuess;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberGuesses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemperature;
    }
}


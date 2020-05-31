namespace prjCPDRT
{
    partial class Form4
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
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblMid = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblWhite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(13, 19);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(185, 129);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBlue_MouseMove);
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(296, 19);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(185, 129);
            this.lblRed.TabIndex = 1;
            this.lblRed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblRed_MouseMove);
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(13, 186);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(185, 129);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblGreen_MouseMove);
            // 
            // lblYellow
            // 
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(296, 186);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(185, 129);
            this.lblYellow.TabIndex = 3;
            this.lblYellow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblYellow_MouseMove);
            // 
            // lblMid
            // 
            this.lblMid.BackColor = System.Drawing.Color.Black;
            this.lblMid.Location = new System.Drawing.Point(156, 103);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(185, 129);
            this.lblMid.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(205, 336);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblWhite
            // 
            this.lblWhite.Location = new System.Drawing.Point(0, 2);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(499, 384);
            this.lblWhite.TabIndex = 9;
            this.lblWhite.Text = " ";
            this.lblWhite.MouseHover += new System.EventHandler(this.lblWhite_MouseHover);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 383);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblWhite);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblWhite;
    }
}
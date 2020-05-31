namespace prjCPDRT
{
    partial class Form3
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
            this.scr1 = new System.Windows.Forms.HScrollBar();
            this.lblScroll = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scr1
            // 
            this.scr1.Location = new System.Drawing.Point(9, 28);
            this.scr1.Name = "scr1";
            this.scr1.Size = new System.Drawing.Size(365, 27);
            this.scr1.TabIndex = 0;
            this.scr1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lblScroll
            // 
            this.lblScroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScroll.Location = new System.Drawing.Point(22, 68);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(252, 179);
            this.lblScroll.TabIndex = 1;
            this.lblScroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(148, 215);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 35);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.scr1);
            this.Name = "Form3";
            this.Text = "Scroll Bar Test - CPDRT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar scr1;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.Button btnNext;
    }
}
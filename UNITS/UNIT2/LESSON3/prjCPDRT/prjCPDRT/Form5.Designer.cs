namespace prjCPDRT
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.scrH = new System.Windows.Forms.HScrollBar();
            this.scrV = new System.Windows.Forms.VScrollBar();
            this.pboxMario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMario)).BeginInit();
            this.SuspendLayout();
            // 
            // scrH
            // 
            this.scrH.Location = new System.Drawing.Point(67, 279);
            this.scrH.Maximum = 361;
            this.scrH.Name = "scrH";
            this.scrH.Size = new System.Drawing.Size(361, 29);
            this.scrH.TabIndex = 0;
            this.scrH.Value = 361;
            this.scrH.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrH_Scroll);
            // 
            // scrV
            // 
            this.scrV.Location = new System.Drawing.Point(10, 11);
            this.scrV.Maximum = 239;
            this.scrV.Name = "scrV";
            this.scrV.Size = new System.Drawing.Size(32, 265);
            this.scrV.TabIndex = 1;
            this.scrV.Value = 239;
            this.scrV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrV_Scroll);
            // 
            // pboxMario
            // 
            this.pboxMario.Image = ((System.Drawing.Image)(resources.GetObject("pboxMario.Image")));
            this.pboxMario.Location = new System.Drawing.Point(67, 20);
            this.pboxMario.Name = "pboxMario";
            this.pboxMario.Size = new System.Drawing.Size(361, 256);
            this.pboxMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMario.TabIndex = 2;
            this.pboxMario.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 328);
            this.Controls.Add(this.pboxMario);
            this.Controls.Add(this.scrV);
            this.Controls.Add(this.scrH);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrH;
        private System.Windows.Forms.VScrollBar scrV;
        private System.Windows.Forms.PictureBox pboxMario;
    }
}
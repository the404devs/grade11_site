namespace prjBubbleSort
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAndDisplay = new System.Windows.Forms.Button();
            this.btnSortAndDisplay = new System.Windows.Forms.Button();
            this.btnTestSortFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUBBLE SORTING";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(31, 196);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(537, 177);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "OUTPUT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "OPTIONS:";
            // 
            // btnCreateAndDisplay
            // 
            this.btnCreateAndDisplay.Location = new System.Drawing.Point(426, 83);
            this.btnCreateAndDisplay.Name = "btnCreateAndDisplay";
            this.btnCreateAndDisplay.Size = new System.Drawing.Size(122, 25);
            this.btnCreateAndDisplay.TabIndex = 4;
            this.btnCreateAndDisplay.Text = "Create and Display Array";
            this.btnCreateAndDisplay.UseVisualStyleBackColor = true;
            this.btnCreateAndDisplay.Click += new System.EventHandler(this.btnCreateAndDisplay_Click);
            // 
            // btnSortAndDisplay
            // 
            this.btnSortAndDisplay.Location = new System.Drawing.Point(426, 114);
            this.btnSortAndDisplay.Name = "btnSortAndDisplay";
            this.btnSortAndDisplay.Size = new System.Drawing.Size(122, 25);
            this.btnSortAndDisplay.TabIndex = 5;
            this.btnSortAndDisplay.Text = "Sort and Display";
            this.btnSortAndDisplay.UseVisualStyleBackColor = true;
            this.btnSortAndDisplay.Click += new System.EventHandler(this.btnSortAndDisplay_Click);
            // 
            // btnTestSortFunction
            // 
            this.btnTestSortFunction.Location = new System.Drawing.Point(426, 145);
            this.btnTestSortFunction.Name = "btnTestSortFunction";
            this.btnTestSortFunction.Size = new System.Drawing.Size(122, 25);
            this.btnTestSortFunction.TabIndex = 6;
            this.btnTestSortFunction.Text = "Test Sort Function";
            this.btnTestSortFunction.UseVisualStyleBackColor = true;
            this.btnTestSortFunction.Click += new System.EventHandler(this.btnTestSortFunction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 405);
            this.Controls.Add(this.btnTestSortFunction);
            this.Controls.Add(this.btnSortAndDisplay);
            this.Controls.Add(this.btnCreateAndDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bubble Sorting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAndDisplay;
        private System.Windows.Forms.Button btnSortAndDisplay;
        private System.Windows.Forms.Button btnTestSortFunction;
    }
}


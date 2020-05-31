namespace prjVariables2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPenny = new System.Windows.Forms.TextBox();
            this.txtNickel = new System.Windows.Forms.TextBox();
            this.txtDime = new System.Windows.Forms.TextBox();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piggy Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pennies:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(78, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nickels:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(75, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dimes:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(72, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quarters:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPenny
            // 
            this.txtPenny.Location = new System.Drawing.Point(135, 65);
            this.txtPenny.Name = "txtPenny";
            this.txtPenny.Size = new System.Drawing.Size(92, 20);
            this.txtPenny.TabIndex = 5;
            this.txtPenny.Text = "0";
            // 
            // txtNickel
            // 
            this.txtNickel.Location = new System.Drawing.Point(135, 104);
            this.txtNickel.Name = "txtNickel";
            this.txtNickel.Size = new System.Drawing.Size(92, 20);
            this.txtNickel.TabIndex = 6;
            this.txtNickel.Text = "0";
            // 
            // txtDime
            // 
            this.txtDime.Location = new System.Drawing.Point(135, 143);
            this.txtDime.Name = "txtDime";
            this.txtDime.Size = new System.Drawing.Size(92, 20);
            this.txtDime.TabIndex = 7;
            this.txtDime.Text = "0";
            // 
            // txtQuarter
            // 
            this.txtQuarter.Location = new System.Drawing.Point(135, 182);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.Size = new System.Drawing.Size(92, 20);
            this.txtQuarter.TabIndex = 8;
            this.txtQuarter.Text = "0";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 259);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(84, 50);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Caclulate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 50);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 50);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(72, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(135, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 326);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtQuarter);
            this.Controls.Add(this.txtDime);
            this.Controls.Add(this.txtNickel);
            this.Controls.Add(this.txtPenny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Piggy Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPenny;
        private System.Windows.Forms.TextBox txtNickel;
        private System.Windows.Forms.TextBox txtDime;
        private System.Windows.Forms.TextBox txtQuarter;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
    }
}


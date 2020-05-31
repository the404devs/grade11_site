namespace prjArrays
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.btnProcess2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIn3 = new System.Windows.Forms.TextBox();
            this.lblOut3 = new System.Windows.Forms.Label();
            this.btnProcess3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.txtIn1);
            this.groupBox1.Controls.Add(this.lblOut1);
            this.groupBox1.Controls.Add(this.btnProcess1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple";
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(406, 25);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(107, 44);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // txtIn1
            // 
            this.txtIn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn1.Location = new System.Drawing.Point(220, 32);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(169, 31);
            this.txtIn1.TabIndex = 4;
            // 
            // lblOut1
            // 
            this.lblOut1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOut1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblOut1.Location = new System.Drawing.Point(19, 84);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(197, 83);
            this.lblOut1.TabIndex = 3;
            this.lblOut1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcess1
            // 
            this.btnProcess1.Enabled = false;
            this.btnProcess1.Location = new System.Drawing.Point(22, 25);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(134, 38);
            this.btnProcess1.TabIndex = 2;
            this.btnProcess1.Text = "Process";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIn2);
            this.groupBox3.Controls.Add(this.lblOut2);
            this.groupBox3.Controls.Add(this.btnProcess2);
            this.groupBox3.Location = new System.Drawing.Point(6, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 191);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parallel";
            // 
            // txtIn2
            // 
            this.txtIn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn2.Location = new System.Drawing.Point(220, 35);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(169, 31);
            this.txtIn2.TabIndex = 5;
            // 
            // lblOut2
            // 
            this.lblOut2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOut2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblOut2.Location = new System.Drawing.Point(22, 82);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(197, 83);
            this.lblOut2.TabIndex = 4;
            this.lblOut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcess2
            // 
            this.btnProcess2.Location = new System.Drawing.Point(22, 28);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(134, 38);
            this.btnProcess2.TabIndex = 3;
            this.btnProcess2.Text = "Process";
            this.btnProcess2.UseVisualStyleBackColor = true;
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtIn3);
            this.groupBox4.Controls.Add(this.lblOut3);
            this.groupBox4.Controls.Add(this.btnProcess3);
            this.groupBox4.Location = new System.Drawing.Point(6, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(534, 191);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Functions";
            // 
            // txtIn3
            // 
            this.txtIn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn3.Location = new System.Drawing.Point(220, 38);
            this.txtIn3.Name = "txtIn3";
            this.txtIn3.Size = new System.Drawing.Size(169, 31);
            this.txtIn3.TabIndex = 6;
            // 
            // lblOut3
            // 
            this.lblOut3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOut3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblOut3.Location = new System.Drawing.Point(19, 84);
            this.lblOut3.Name = "lblOut3";
            this.lblOut3.Size = new System.Drawing.Size(197, 83);
            this.lblOut3.TabIndex = 4;
            this.lblOut3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcess3
            // 
            this.btnProcess3.Location = new System.Drawing.Point(22, 31);
            this.btnProcess3.Name = "btnProcess3";
            this.btnProcess3.Size = new System.Drawing.Size(134, 38);
            this.btnProcess3.TabIndex = 3;
            this.btnProcess3.Text = "Process";
            this.btnProcess3.UseVisualStyleBackColor = true;
            this.btnProcess3.Click += new System.EventHandler(this.btnProcess3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 594);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ARRAYS-Sample Code";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtIn1;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Button btnProcess2;
        private System.Windows.Forms.TextBox txtIn3;
        private System.Windows.Forms.Label lblOut3;
        private System.Windows.Forms.Button btnProcess3;
        private System.Windows.Forms.Button btnFill;
    }
}


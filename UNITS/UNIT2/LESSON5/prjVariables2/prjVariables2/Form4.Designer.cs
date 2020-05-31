namespace prjVariables2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(76, 33);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(104, 20);
            this.txtCelsius.TabIndex = 5;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            this.txtCelsius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCelsius_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Celsius:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Temperature Converter";
            // 
            // btnCtoF
            // 
            this.btnCtoF.Enabled = false;
            this.btnCtoF.Location = new System.Drawing.Point(12, 89);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(84, 21);
            this.btnCtoF.TabIndex = 13;
            this.btnCtoF.Text = "C to F";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fahrenheit:";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(76, 63);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(104, 20);
            this.txtFahrenheit.TabIndex = 14;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtFahrenheit_TextChanged);
            this.txtFahrenheit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFahrenheit_KeyDown);
            // 
            // btnFtoC
            // 
            this.btnFtoC.Enabled = false;
            this.btnFtoC.Location = new System.Drawing.Point(96, 89);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(84, 21);
            this.btnFtoC.TabIndex = 16;
            this.btnFtoC.Text = "F to C";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(96, 111);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 21);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(12, 111);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(84, 21);
            this.lblOutput.TabIndex = 18;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 144);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCelsius);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblOutput;
    }
}
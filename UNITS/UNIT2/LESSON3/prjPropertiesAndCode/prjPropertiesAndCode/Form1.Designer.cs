namespace prjPropertiesAndCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInputData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblOutputData = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.scrInfo = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputData
            // 
            this.lblInputData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputData.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputData.Location = new System.Drawing.Point(12, 9);
            this.lblInputData.Name = "lblInputData";
            this.lblInputData.Size = new System.Drawing.Size(129, 29);
            this.lblInputData.TabIndex = 0;
            this.lblInputData.Text = "Input Data:";
            this.lblInputData.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtData.Location = new System.Drawing.Point(161, 9);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(228, 25);
            this.txtData.TabIndex = 1;
            this.txtData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOutputData
            // 
            this.lblOutputData.BackColor = System.Drawing.Color.Yellow;
            this.lblOutputData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputData.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputData.Location = new System.Drawing.Point(395, 6);
            this.lblOutputData.Name = "lblOutputData";
            this.lblOutputData.Size = new System.Drawing.Size(129, 29);
            this.lblOutputData.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(161, 39);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(227, 30);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(12, 123);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(506, 247);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // scrInfo
            // 
            this.scrInfo.Location = new System.Drawing.Point(9, 384);
            this.scrInfo.Maximum = 1000;
            this.scrInfo.Name = "scrInfo";
            this.scrInfo.Size = new System.Drawing.Size(515, 22);
            this.scrInfo.TabIndex = 5;
            this.scrInfo.Value = 500;
            this.scrInfo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrInfo_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 641);
            this.Controls.Add(this.scrInfo);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblOutputData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblInputData);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Changing Properties and Code";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblOutputData;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.HScrollBar scrInfo;
    }
}


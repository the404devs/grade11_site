namespace WindowsFormsApplication1
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnMaybe = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblBrown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Blue;
            this.btnYes.Location = new System.Drawing.Point(14, 15);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(286, 83);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Blue;
            this.btnNo.Location = new System.Drawing.Point(562, 15);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(286, 83);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnMaybe
            // 
            this.btnMaybe.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaybe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMaybe.Location = new System.Drawing.Point(287, 104);
            this.btnMaybe.Name = "btnMaybe";
            this.btnMaybe.Size = new System.Drawing.Size(286, 83);
            this.btnMaybe.TabIndex = 2;
            this.btnMaybe.Text = "Maybe";
            this.btnMaybe.UseVisualStyleBackColor = true;
            this.btnMaybe.Click += new System.EventHandler(this.btnMaybe_Click);
            // 
            // lblTop
            // 
            this.lblTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTop.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(310, 19);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(240, 78);
            this.lblTop.TabIndex = 3;
            this.lblTop.Text = "Top";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.DoubleClick += new System.EventHandler(this.lblTop_DoubleClick);
            // 
            // txtRight
            // 
            this.txtRight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRight.Location = new System.Drawing.Point(579, 141);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(260, 21);
            this.txtRight.TabIndex = 4;
            this.txtRight.Text = "Right";
            this.txtRight.DoubleClick += new System.EventHandler(this.txtRight_DoubleClick);
            // 
            // txtLeft
            // 
            this.txtLeft.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeft.Location = new System.Drawing.Point(14, 141);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(267, 21);
            this.txtLeft.TabIndex = 5;
            this.txtLeft.Text = "Left";
            this.txtLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeft_KeyPress);
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(14, 204);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(193, 117);
            this.lblRed.TabIndex = 6;
            this.lblRed.MouseLeave += new System.EventHandler(this.lblRed_MouseLeave);
            this.lblRed.MouseHover += new System.EventHandler(this.lblRed_MouseHover);
            // 
            // lblYellow
            // 
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYellow.Location = new System.Drawing.Point(225, 204);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(193, 117);
            this.lblYellow.TabIndex = 7;
            this.lblYellow.MouseLeave += new System.EventHandler(this.lblYellow_MouseLeave);
            this.lblYellow.MouseHover += new System.EventHandler(this.lblYellow_MouseHover);
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Location = new System.Drawing.Point(433, 204);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(193, 117);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.MouseLeave += new System.EventHandler(this.lblBlue_MouseLeave);
            this.lblBlue.MouseHover += new System.EventHandler(this.lblBlue_MouseHover);
            // 
            // lblBrown
            // 
            this.lblBrown.BackColor = System.Drawing.Color.DarkRed;
            this.lblBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrown.Location = new System.Drawing.Point(646, 204);
            this.lblBrown.Name = "lblBrown";
            this.lblBrown.Size = new System.Drawing.Size(193, 117);
            this.lblBrown.TabIndex = 9;
            this.lblBrown.MouseLeave += new System.EventHandler(this.lblBrown_MouseLeave);
            this.lblBrown.MouseHover += new System.EventHandler(this.lblBrown_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 343);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblBrown);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnMaybe);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnMaybe;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblBrown;
    }
}


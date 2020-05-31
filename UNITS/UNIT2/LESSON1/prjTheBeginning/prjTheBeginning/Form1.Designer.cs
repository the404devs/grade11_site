namespace prjTheBeginning
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This is a text box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is a label";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 115);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Radio Button";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Check Box";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem,
            this.menuItem2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem1ToolStripMenuItem
            // 
            this.menuItem1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu1ToolStripMenuItem,
            this.submenu2ToolStripMenuItem});
            this.menuItem1ToolStripMenuItem.Name = "menuItem1ToolStripMenuItem";
            this.menuItem1ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.menuItem1ToolStripMenuItem.Text = "Menu item 1";
            // 
            // menuItem2ToolStripMenuItem
            // 
            this.menuItem2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu1ToolStripMenuItem1,
            this.submenu2ToolStripMenuItem1});
            this.menuItem2ToolStripMenuItem.Name = "menuItem2ToolStripMenuItem";
            this.menuItem2ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.menuItem2ToolStripMenuItem.Text = "Menu item 2";
            // 
            // submenu1ToolStripMenuItem
            // 
            this.submenu1ToolStripMenuItem.Name = "submenu1ToolStripMenuItem";
            this.submenu1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.submenu1ToolStripMenuItem.Text = "Sub-menu 1";
            // 
            // submenu2ToolStripMenuItem
            // 
            this.submenu2ToolStripMenuItem.Name = "submenu2ToolStripMenuItem";
            this.submenu2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.submenu2ToolStripMenuItem.Text = "Sub-menu 2";
            // 
            // submenu1ToolStripMenuItem1
            // 
            this.submenu1ToolStripMenuItem1.Name = "submenu1ToolStripMenuItem1";
            this.submenu1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.submenu1ToolStripMenuItem1.Text = "Sub-menu 1";
            // 
            // submenu2ToolStripMenuItem1
            // 
            this.submenu2ToolStripMenuItem1.Name = "submenu2ToolStripMenuItem1";
            this.submenu2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.submenu2ToolStripMenuItem1.Text = "Sub-menu 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem submenu2ToolStripMenuItem1;
    }
}


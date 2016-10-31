namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1Button = new System.Windows.Forms.Button();
            this.A2Button = new System.Windows.Forms.Button();
            this.A3Button = new System.Windows.Forms.Button();
            this.B3Button = new System.Windows.Forms.Button();
            this.B2Button = new System.Windows.Forms.Button();
            this.B1Button = new System.Windows.Forms.Button();
            this.C3Button = new System.Windows.Forms.Button();
            this.C2Button = new System.Windows.Forms.Button();
            this.C1Button = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1Button
            // 
            this.A1Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1Button.Location = new System.Drawing.Point(16, 35);
            this.A1Button.Margin = new System.Windows.Forms.Padding(7);
            this.A1Button.Name = "A1Button";
            this.A1Button.Size = new System.Drawing.Size(75, 75);
            this.A1Button.TabIndex = 1;
            this.A1Button.UseVisualStyleBackColor = true;
            this.A1Button.Click += new System.EventHandler(this.button_click);
            // 
            // A2Button
            // 
            this.A2Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2Button.Location = new System.Drawing.Point(97, 35);
            this.A2Button.Margin = new System.Windows.Forms.Padding(7);
            this.A2Button.Name = "A2Button";
            this.A2Button.Size = new System.Drawing.Size(75, 75);
            this.A2Button.TabIndex = 2;
            this.A2Button.UseVisualStyleBackColor = true;
            this.A2Button.Click += new System.EventHandler(this.button_click);
            // 
            // A3Button
            // 
            this.A3Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3Button.Location = new System.Drawing.Point(178, 35);
            this.A3Button.Margin = new System.Windows.Forms.Padding(7);
            this.A3Button.Name = "A3Button";
            this.A3Button.Size = new System.Drawing.Size(75, 75);
            this.A3Button.TabIndex = 3;
            this.A3Button.UseVisualStyleBackColor = true;
            this.A3Button.Click += new System.EventHandler(this.button_click);
            // 
            // B3Button
            // 
            this.B3Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3Button.Location = new System.Drawing.Point(178, 116);
            this.B3Button.Margin = new System.Windows.Forms.Padding(7);
            this.B3Button.Name = "B3Button";
            this.B3Button.Size = new System.Drawing.Size(75, 75);
            this.B3Button.TabIndex = 6;
            this.B3Button.UseVisualStyleBackColor = true;
            this.B3Button.Click += new System.EventHandler(this.button_click);
            // 
            // B2Button
            // 
            this.B2Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2Button.Location = new System.Drawing.Point(97, 116);
            this.B2Button.Margin = new System.Windows.Forms.Padding(7);
            this.B2Button.Name = "B2Button";
            this.B2Button.Size = new System.Drawing.Size(75, 75);
            this.B2Button.TabIndex = 5;
            this.B2Button.UseVisualStyleBackColor = true;
            this.B2Button.Click += new System.EventHandler(this.button_click);
            // 
            // B1Button
            // 
            this.B1Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1Button.Location = new System.Drawing.Point(16, 116);
            this.B1Button.Margin = new System.Windows.Forms.Padding(7);
            this.B1Button.Name = "B1Button";
            this.B1Button.Size = new System.Drawing.Size(75, 75);
            this.B1Button.TabIndex = 4;
            this.B1Button.UseVisualStyleBackColor = true;
            this.B1Button.Click += new System.EventHandler(this.button_click);
            // 
            // C3Button
            // 
            this.C3Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3Button.Location = new System.Drawing.Point(178, 197);
            this.C3Button.Margin = new System.Windows.Forms.Padding(7);
            this.C3Button.Name = "C3Button";
            this.C3Button.Size = new System.Drawing.Size(75, 75);
            this.C3Button.TabIndex = 9;
            this.C3Button.UseVisualStyleBackColor = true;
            this.C3Button.Click += new System.EventHandler(this.button_click);
            // 
            // C2Button
            // 
            this.C2Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2Button.Location = new System.Drawing.Point(97, 197);
            this.C2Button.Margin = new System.Windows.Forms.Padding(7);
            this.C2Button.Name = "C2Button";
            this.C2Button.Size = new System.Drawing.Size(75, 75);
            this.C2Button.TabIndex = 8;
            this.C2Button.UseVisualStyleBackColor = true;
            this.C2Button.Click += new System.EventHandler(this.button_click);
            // 
            // C1Button
            // 
            this.C1Button.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1Button.Location = new System.Drawing.Point(16, 197);
            this.C1Button.Margin = new System.Windows.Forms.Padding(7);
            this.C1Button.Name = "C1Button";
            this.C1Button.Size = new System.Drawing.Size(75, 75);
            this.C1Button.TabIndex = 7;
            this.C1Button.UseVisualStyleBackColor = true;
            this.C1Button.Click += new System.EventHandler(this.button_click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 287);
            this.Controls.Add(this.C3Button);
            this.Controls.Add(this.C2Button);
            this.Controls.Add(this.C1Button);
            this.Controls.Add(this.B3Button);
            this.Controls.Add(this.B2Button);
            this.Controls.Add(this.B1Button);
            this.Controls.Add(this.A3Button);
            this.Controls.Add(this.A2Button);
            this.Controls.Add(this.A1Button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1Button;
        private System.Windows.Forms.Button A2Button;
        private System.Windows.Forms.Button A3Button;
        private System.Windows.Forms.Button B3Button;
        private System.Windows.Forms.Button B2Button;
        private System.Windows.Forms.Button B1Button;
        private System.Windows.Forms.Button C3Button;
        private System.Windows.Forms.Button C2Button;
        private System.Windows.Forms.Button C1Button;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


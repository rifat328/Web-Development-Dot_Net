
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(525, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.newGameToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.newGameToolStripMenuItem1.Text = "New game";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.bugReportToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            // 
            // bugReportToolStripMenuItem
            // 
            this.bugReportToolStripMenuItem.Name = "bugReportToolStripMenuItem";
            this.bugReportToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.bugReportToolStripMenuItem.Text = "Bug Report";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatorToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.creatorToolStripMenuItem.Text = "Creator";
            this.creatorToolStripMenuItem.Click += new System.EventHandler(this.creatorToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.ForeColor = System.Drawing.Color.Red;
            this.A1.Location = new System.Drawing.Point(98, 141);
            this.A1.Margin = new System.Windows.Forms.Padding(4);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(109, 90);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.ForeColor = System.Drawing.Color.Red;
            this.A2.Location = new System.Drawing.Point(210, 141);
            this.A2.Margin = new System.Windows.Forms.Padding(4);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(109, 90);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.ForeColor = System.Drawing.Color.Red;
            this.A3.Location = new System.Drawing.Point(321, 141);
            this.A3.Margin = new System.Windows.Forms.Padding(4);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(109, 90);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.ForeColor = System.Drawing.Color.Red;
            this.B3.Location = new System.Drawing.Point(321, 238);
            this.B3.Margin = new System.Windows.Forms.Padding(4);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(109, 90);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.ForeColor = System.Drawing.Color.Red;
            this.B2.Location = new System.Drawing.Point(210, 238);
            this.B2.Margin = new System.Windows.Forms.Padding(4);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(109, 90);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.ForeColor = System.Drawing.Color.Red;
            this.B1.Location = new System.Drawing.Point(98, 238);
            this.B1.Margin = new System.Windows.Forms.Padding(4);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(109, 90);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.ForeColor = System.Drawing.Color.Red;
            this.C3.Location = new System.Drawing.Point(321, 336);
            this.C3.Margin = new System.Windows.Forms.Padding(4);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(109, 90);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.ForeColor = System.Drawing.Color.Red;
            this.C2.Location = new System.Drawing.Point(210, 336);
            this.C2.Margin = new System.Windows.Forms.Padding(4);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(109, 90);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.ForeColor = System.Drawing.Color.Red;
            this.C1.Location = new System.Drawing.Point(98, 336);
            this.C1.Margin = new System.Windows.Forms.Padding(4);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(109, 90);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 524);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
    }
}


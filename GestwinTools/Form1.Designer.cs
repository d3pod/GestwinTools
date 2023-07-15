namespace GestwinTools
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
            menuStrip1 = new MenuStrip();
            listagensToolStripMenuItem = new ToolStripMenuItem();
            anuladosToolStripMenuItem = new ToolStripMenuItem();
            backupsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { listagensToolStripMenuItem, backupsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1208, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // listagensToolStripMenuItem
            // 
            listagensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anuladosToolStripMenuItem });
            listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            listagensToolStripMenuItem.Size = new Size(68, 20);
            listagensToolStripMenuItem.Text = "Listagens";
            // 
            // anuladosToolStripMenuItem
            // 
            anuladosToolStripMenuItem.Name = "anuladosToolStripMenuItem";
            anuladosToolStripMenuItem.Size = new Size(180, 22);
            anuladosToolStripMenuItem.Text = "Anulados";
            anuladosToolStripMenuItem.Click += anuladosToolStripMenuItem_Click;
            // 
            // backupsToolStripMenuItem
            // 
            backupsToolStripMenuItem.Name = "backupsToolStripMenuItem";
            backupsToolStripMenuItem.Size = new Size(74, 20);
            backupsToolStripMenuItem.Text = "Segurança";
            backupsToolStripMenuItem.Click += backupsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 635);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Gestwin Tools";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listagensToolStripMenuItem;
        private ToolStripMenuItem backupsToolStripMenuItem;
        private ToolStripMenuItem anuladosToolStripMenuItem;
    }
}
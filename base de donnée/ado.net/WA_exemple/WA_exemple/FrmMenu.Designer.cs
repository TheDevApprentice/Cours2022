namespace WA_exemple
{
    partial class FrmMenu
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
            this.étudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnÉtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierOuDétruireUnÉtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.étudiantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // étudiantToolStripMenuItem
            // 
            this.étudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnÉtudiantToolStripMenuItem,
            this.modifierOuDétruireUnÉtudiantToolStripMenuItem});
            this.étudiantToolStripMenuItem.Name = "étudiantToolStripMenuItem";
            this.étudiantToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.étudiantToolStripMenuItem.Text = "Étudiant";
            // 
            // ajouterUnÉtudiantToolStripMenuItem
            // 
            this.ajouterUnÉtudiantToolStripMenuItem.Name = "ajouterUnÉtudiantToolStripMenuItem";
            this.ajouterUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.ajouterUnÉtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnÉtudiantToolStripMenuItem_Click);
            // 
            // modifierOuDétruireUnÉtudiantToolStripMenuItem
            // 
            this.modifierOuDétruireUnÉtudiantToolStripMenuItem.Name = "modifierOuDétruireUnÉtudiantToolStripMenuItem";
            this.modifierOuDétruireUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.modifierOuDétruireUnÉtudiantToolStripMenuItem.Text = "Modifier ou détruire un étudiant";
            this.modifierOuDétruireUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.modifierOuDétruireUnÉtudiantToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "Cas Hobby";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem étudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierOuDétruireUnÉtudiantToolStripMenuItem;
    }
}
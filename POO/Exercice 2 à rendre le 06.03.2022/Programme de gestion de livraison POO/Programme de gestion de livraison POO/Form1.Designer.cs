
namespace Programme_de_gestion_de_livraison_POO
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
            this.grpb_voyages = new System.Windows.Forms.GroupBox();
            this.lst_voyages = new System.Windows.Forms.ListBox();
            this.lst_livraisonNonAssignees = new System.Windows.Forms.ListBox();
            this.grpb_livraisonNonAssignees = new System.Windows.Forms.GroupBox();
            this.btn_directionsLivraisonIncluses = new System.Windows.Forms.Button();
            this.btn_directionLivraisonsNonAssignees = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livraisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterVoyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_voyageSelectionne = new System.Windows.Forms.GroupBox();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_camion = new System.Windows.Forms.Label();
            this.lbl_camionneur = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_livraisonIncluses = new System.Windows.Forms.Label();
            this.cmb_camionneurs = new System.Windows.Forms.ComboBox();
            this.cmb_camions = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lst_livraisonIncluses = new System.Windows.Forms.ListBox();
            this.txt_distance = new System.Windows.Forms.TextBox();
            this.grpb_voyages.SuspendLayout();
            this.grpb_livraisonNonAssignees.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grp_voyageSelectionne.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_voyages
            // 
            this.grpb_voyages.Controls.Add(this.lst_voyages);
            this.grpb_voyages.Location = new System.Drawing.Point(12, 23);
            this.grpb_voyages.Name = "grpb_voyages";
            this.grpb_voyages.Size = new System.Drawing.Size(443, 179);
            this.grpb_voyages.TabIndex = 1;
            this.grpb_voyages.TabStop = false;
            this.grpb_voyages.Text = "Voyages";
            // 
            // lst_voyages
            // 
            this.lst_voyages.FormattingEnabled = true;
            this.lst_voyages.ItemHeight = 20;
            this.lst_voyages.Location = new System.Drawing.Point(15, 26);
            this.lst_voyages.Name = "lst_voyages";
            this.lst_voyages.Size = new System.Drawing.Size(422, 144);
            this.lst_voyages.TabIndex = 2;
            this.lst_voyages.SelectedIndexChanged += new System.EventHandler(this.lst_voyages_SelectedIndexChanged);
            // 
            // lst_livraisonNonAssignees
            // 
            this.lst_livraisonNonAssignees.FormattingEnabled = true;
            this.lst_livraisonNonAssignees.ItemHeight = 20;
            this.lst_livraisonNonAssignees.Location = new System.Drawing.Point(9, 26);
            this.lst_livraisonNonAssignees.Name = "lst_livraisonNonAssignees";
            this.lst_livraisonNonAssignees.Size = new System.Drawing.Size(422, 224);
            this.lst_livraisonNonAssignees.TabIndex = 3;
            // 
            // grpb_livraisonNonAssignees
            // 
            this.grpb_livraisonNonAssignees.Controls.Add(this.lst_livraisonNonAssignees);
            this.grpb_livraisonNonAssignees.Location = new System.Drawing.Point(12, 208);
            this.grpb_livraisonNonAssignees.Name = "grpb_livraisonNonAssignees";
            this.grpb_livraisonNonAssignees.Size = new System.Drawing.Size(437, 267);
            this.grpb_livraisonNonAssignees.TabIndex = 4;
            this.grpb_livraisonNonAssignees.TabStop = false;
            this.grpb_livraisonNonAssignees.Text = "Livraison non-assignées";
            // 
            // btn_directionsLivraisonIncluses
            // 
            this.btn_directionsLivraisonIncluses.Location = new System.Drawing.Point(455, 222);
            this.btn_directionsLivraisonIncluses.Name = "btn_directionsLivraisonIncluses";
            this.btn_directionsLivraisonIncluses.Size = new System.Drawing.Size(43, 126);
            this.btn_directionsLivraisonIncluses.TabIndex = 4;
            this.btn_directionsLivraisonIncluses.Text = ">";
            this.btn_directionsLivraisonIncluses.UseVisualStyleBackColor = true;
            this.btn_directionsLivraisonIncluses.Visible = false;
            this.btn_directionsLivraisonIncluses.Click += new System.EventHandler(this.btn_assigneLivraison_Click);
            // 
            // btn_directionLivraisonsNonAssignees
            // 
            this.btn_directionLivraisonsNonAssignees.Location = new System.Drawing.Point(455, 354);
            this.btn_directionLivraisonsNonAssignees.Name = "btn_directionLivraisonsNonAssignees";
            this.btn_directionLivraisonsNonAssignees.Size = new System.Drawing.Size(43, 104);
            this.btn_directionLivraisonsNonAssignees.TabIndex = 5;
            this.btn_directionLivraisonsNonAssignees.Text = "<";
            this.btn_directionLivraisonsNonAssignees.UseVisualStyleBackColor = true;
            this.btn_directionLivraisonsNonAssignees.Visible = false;
            this.btn_directionLivraisonsNonAssignees.Click += new System.EventHandler(this.btn_directionNonAssignees_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionneurToolStripMenuItem,
            this.camionToolStripMenuItem,
            this.livraisonToolStripMenuItem,
            this.ajouterVoyageToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // camionneurToolStripMenuItem
            // 
            this.camionneurToolStripMenuItem.Name = "camionneurToolStripMenuItem";
            this.camionneurToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.camionneurToolStripMenuItem.Text = "Camionneur";
            this.camionneurToolStripMenuItem.Click += new System.EventHandler(this.camionneurToolStripMenuItem_Click);
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.camionToolStripMenuItem.Text = "Camion";
            this.camionToolStripMenuItem.Click += new System.EventHandler(this.camionToolStripMenuItem_Click);
            // 
            // livraisonToolStripMenuItem
            // 
            this.livraisonToolStripMenuItem.Name = "livraisonToolStripMenuItem";
            this.livraisonToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.livraisonToolStripMenuItem.Text = "Livraison";
            this.livraisonToolStripMenuItem.Click += new System.EventHandler(this.livraisonToolStripMenuItem_Click);
            // 
            // ajouterVoyageToolStripMenuItem
            // 
            this.ajouterVoyageToolStripMenuItem.Name = "ajouterVoyageToolStripMenuItem";
            this.ajouterVoyageToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ajouterVoyageToolStripMenuItem.Text = "Ajouter voyage";
            this.ajouterVoyageToolStripMenuItem.Click += new System.EventHandler(this.ajouterVoyageToolStripMenuItem_Click);
            // 
            // grp_voyageSelectionne
            // 
            this.grp_voyageSelectionne.Controls.Add(this.lbl_distance);
            this.grp_voyageSelectionne.Controls.Add(this.lbl_camion);
            this.grp_voyageSelectionne.Controls.Add(this.lbl_camionneur);
            this.grp_voyageSelectionne.Controls.Add(this.lbl_date);
            this.grp_voyageSelectionne.Controls.Add(this.lbl_livraisonIncluses);
            this.grp_voyageSelectionne.Controls.Add(this.cmb_camionneurs);
            this.grp_voyageSelectionne.Controls.Add(this.cmb_camions);
            this.grp_voyageSelectionne.Controls.Add(this.dtp_date);
            this.grp_voyageSelectionne.Controls.Add(this.lst_livraisonIncluses);
            this.grp_voyageSelectionne.Controls.Add(this.txt_distance);
            this.grp_voyageSelectionne.Location = new System.Drawing.Point(514, 49);
            this.grp_voyageSelectionne.Name = "grp_voyageSelectionne";
            this.grp_voyageSelectionne.Size = new System.Drawing.Size(574, 409);
            this.grp_voyageSelectionne.TabIndex = 7;
            this.grp_voyageSelectionne.TabStop = false;
            this.grp_voyageSelectionne.Text = "Voyage Selectionné";
            this.grp_voyageSelectionne.Visible = false;
            // 
            // lbl_distance
            // 
            this.lbl_distance.AutoSize = true;
            this.lbl_distance.Location = new System.Drawing.Point(23, 139);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(66, 20);
            this.lbl_distance.TabIndex = 13;
            this.lbl_distance.Text = "Distance";
            // 
            // lbl_camion
            // 
            this.lbl_camion.AutoSize = true;
            this.lbl_camion.Location = new System.Drawing.Point(23, 108);
            this.lbl_camion.Name = "lbl_camion";
            this.lbl_camion.Size = new System.Drawing.Size(60, 20);
            this.lbl_camion.TabIndex = 12;
            this.lbl_camion.Text = "Camion";
            // 
            // lbl_camionneur
            // 
            this.lbl_camionneur.AutoSize = true;
            this.lbl_camionneur.Location = new System.Drawing.Point(23, 74);
            this.lbl_camionneur.Name = "lbl_camionneur";
            this.lbl_camionneur.Size = new System.Drawing.Size(89, 20);
            this.lbl_camionneur.TabIndex = 11;
            this.lbl_camionneur.Text = "Camionneur";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(23, 38);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 20);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "Date";
            // 
            // lbl_livraisonIncluses
            // 
            this.lbl_livraisonIncluses.AutoSize = true;
            this.lbl_livraisonIncluses.Location = new System.Drawing.Point(0, 166);
            this.lbl_livraisonIncluses.Name = "lbl_livraisonIncluses";
            this.lbl_livraisonIncluses.Size = new System.Drawing.Size(128, 20);
            this.lbl_livraisonIncluses.TabIndex = 9;
            this.lbl_livraisonIncluses.Text = "Livraisons Incluses";
            // 
            // cmb_camionneurs
            // 
            this.cmb_camionneurs.FormattingEnabled = true;
            this.cmb_camionneurs.Location = new System.Drawing.Point(212, 71);
            this.cmb_camionneurs.Name = "cmb_camionneurs";
            this.cmb_camionneurs.Size = new System.Drawing.Size(337, 28);
            this.cmb_camionneurs.TabIndex = 8;
            this.cmb_camionneurs.TextChanged += new System.EventHandler(this.cmb_camionneurs_TextChanged);
            // 
            // cmb_camions
            // 
            this.cmb_camions.FormattingEnabled = true;
            this.cmb_camions.Location = new System.Drawing.Point(212, 105);
            this.cmb_camions.Name = "cmb_camions";
            this.cmb_camions.Size = new System.Drawing.Size(337, 28);
            this.cmb_camions.TabIndex = 7;
            this.cmb_camions.SelectedIndexChanged += new System.EventHandler(this.cmb_camions_SelectedIndexChanged);
            this.cmb_camions.TextChanged += new System.EventHandler(this.cmb_camions_TextChanged);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(212, 38);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(337, 27);
            this.dtp_date.TabIndex = 6;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // lst_livraisonIncluses
            // 
            this.lst_livraisonIncluses.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lst_livraisonIncluses.FormattingEnabled = true;
            this.lst_livraisonIncluses.ItemHeight = 20;
            this.lst_livraisonIncluses.Location = new System.Drawing.Point(6, 189);
            this.lst_livraisonIncluses.Name = "lst_livraisonIncluses";
            this.lst_livraisonIncluses.Size = new System.Drawing.Size(568, 224);
            this.lst_livraisonIncluses.TabIndex = 4;
            // 
            // txt_distance
            // 
            this.txt_distance.Location = new System.Drawing.Point(394, 139);
            this.txt_distance.Name = "txt_distance";
            this.txt_distance.Size = new System.Drawing.Size(155, 27);
            this.txt_distance.TabIndex = 3;
            this.txt_distance.TextChanged += new System.EventHandler(this.txt_distance_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 555);
            this.Controls.Add(this.grp_voyageSelectionne);
            this.Controls.Add(this.btn_directionLivraisonsNonAssignees);
            this.Controls.Add(this.btn_directionsLivraisonIncluses);
            this.Controls.Add(this.grpb_livraisonNonAssignees);
            this.Controls.Add(this.grpb_voyages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpb_voyages.ResumeLayout(false);
            this.grpb_livraisonNonAssignees.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_voyageSelectionne.ResumeLayout(false);
            this.grp_voyageSelectionne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpb_voyages;
        private System.Windows.Forms.ListBox lst_voyages;
        private System.Windows.Forms.ListBox lst_livraisonNonAssignees;
        private System.Windows.Forms.GroupBox grpb_livraisonNonAssignees;
        private System.Windows.Forms.Button btn_directionsLivraisonIncluses;
        private System.Windows.Forms.Button btn_directionLivraisonsNonAssignees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionneurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livraisonToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_voyageSelectionne;
        private System.Windows.Forms.ComboBox cmb_camionneurs;
        private System.Windows.Forms.ComboBox cmb_camions;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ListBox lst_livraisonIncluses;
        private System.Windows.Forms.TextBox txt_distance;
        private System.Windows.Forms.Label lbl_livraisonIncluses;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_camion;
        private System.Windows.Forms.Label lbl_camionneur;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ToolStripMenuItem ajouterVoyageToolStripMenuItem;
    }
}


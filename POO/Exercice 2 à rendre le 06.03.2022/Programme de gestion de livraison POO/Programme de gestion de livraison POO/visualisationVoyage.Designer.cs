
namespace Programme_de_gestion_de_livraison_POO
{
    partial class visualisationVoyage
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
            this.grp_voyageSelectionne.SuspendLayout();
            this.SuspendLayout();
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
            this.grp_voyageSelectionne.Location = new System.Drawing.Point(113, 21);
            this.grp_voyageSelectionne.Name = "grp_voyageSelectionne";
            this.grp_voyageSelectionne.Size = new System.Drawing.Size(574, 409);
            this.grp_voyageSelectionne.TabIndex = 8;
            this.grp_voyageSelectionne.TabStop = false;
            this.grp_voyageSelectionne.Text = "Voyage Selectionné";
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
            // 
            // cmb_camions
            // 
            this.cmb_camions.FormattingEnabled = true;
            this.cmb_camions.Location = new System.Drawing.Point(212, 105);
            this.cmb_camions.Name = "cmb_camions";
            this.cmb_camions.Size = new System.Drawing.Size(337, 28);
            this.cmb_camions.TabIndex = 7;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(212, 38);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(337, 27);
            this.dtp_date.TabIndex = 6;
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
            // 
            // visualisationVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_voyageSelectionne);
            this.Name = "visualisationVoyage";
            this.Text = "visualisationVoyage";
            this.grp_voyageSelectionne.ResumeLayout(false);
            this.grp_voyageSelectionne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_voyageSelectionne;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_camion;
        private System.Windows.Forms.Label lbl_camionneur;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_livraisonIncluses;
        private System.Windows.Forms.ComboBox cmb_camionneurs;
        private System.Windows.Forms.ComboBox cmb_camions;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ListBox lst_livraisonIncluses;
        private System.Windows.Forms.TextBox txt_distance;
    }
}
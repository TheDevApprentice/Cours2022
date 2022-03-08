
namespace travail_pratique_2
{
    partial class ModifierDetrureCours
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
            this.cmb_RechercheEntreprise = new System.Windows.Forms.ComboBox();
            this.grpb_RechercheEntreprise = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AjouterCategorie = new System.Windows.Forms.Button();
            this.lbl_Categorie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_Mixte = new System.Windows.Forms.GroupBox();
            this.rad_Non = new System.Windows.Forms.RadioButton();
            this.rad_Oui = new System.Windows.Forms.RadioButton();
            this.btn_Detruire = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.txt_NbHeure = new System.Windows.Forms.TextBox();
            this.txt_NomDCours = new System.Windows.Forms.TextBox();
            this.cmb_Categorie = new System.Windows.Forms.ComboBox();
            this.grpb_RechercheEntreprise.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpbox_Mixte.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_RechercheEntreprise
            // 
            this.cmb_RechercheEntreprise.FormattingEnabled = true;
            this.cmb_RechercheEntreprise.Location = new System.Drawing.Point(21, 26);
            this.cmb_RechercheEntreprise.Name = "cmb_RechercheEntreprise";
            this.cmb_RechercheEntreprise.Size = new System.Drawing.Size(580, 28);
            this.cmb_RechercheEntreprise.TabIndex = 0;
            this.cmb_RechercheEntreprise.SelectedIndexChanged += new System.EventHandler(this.cmb_RechercheEntreprise_SelectedIndexChanged);
            // 
            // grpb_RechercheEntreprise
            // 
            this.grpb_RechercheEntreprise.Controls.Add(this.cmb_RechercheEntreprise);
            this.grpb_RechercheEntreprise.Location = new System.Drawing.Point(12, 12);
            this.grpb_RechercheEntreprise.Name = "grpb_RechercheEntreprise";
            this.grpb_RechercheEntreprise.Size = new System.Drawing.Size(652, 65);
            this.grpb_RechercheEntreprise.TabIndex = 1;
            this.grpb_RechercheEntreprise.TabStop = false;
            this.grpb_RechercheEntreprise.Text = "Recherche d\'un cours";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AjouterCategorie);
            this.groupBox2.Controls.Add(this.lbl_Categorie);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grpbox_Mixte);
            this.groupBox2.Controls.Add(this.btn_Detruire);
            this.groupBox2.Controls.Add(this.btn_Modifier);
            this.groupBox2.Controls.Add(this.txt_NbHeure);
            this.groupBox2.Controls.Add(this.txt_NomDCours);
            this.groupBox2.Controls.Add(this.cmb_Categorie);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 326);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier/Détruire";
            // 
            // btn_AjouterCategorie
            // 
            this.btn_AjouterCategorie.Location = new System.Drawing.Point(684, 224);
            this.btn_AjouterCategorie.Name = "btn_AjouterCategorie";
            this.btn_AjouterCategorie.Size = new System.Drawing.Size(34, 29);
            this.btn_AjouterCategorie.TabIndex = 1;
            this.btn_AjouterCategorie.Text = "+";
            this.btn_AjouterCategorie.UseVisualStyleBackColor = true;
            this.btn_AjouterCategorie.Click += new System.EventHandler(this.btn_AjouterCategorie_Click);
            // 
            // lbl_Categorie
            // 
            this.lbl_Categorie.AutoSize = true;
            this.lbl_Categorie.Location = new System.Drawing.Point(79, 228);
            this.lbl_Categorie.Name = "lbl_Categorie";
            this.lbl_Categorie.Size = new System.Drawing.Size(74, 20);
            this.lbl_Categorie.TabIndex = 11;
            this.lbl_Categorie.Text = "Categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre d\'heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom du cours";
            // 
            // grpbox_Mixte
            // 
            this.grpbox_Mixte.Controls.Add(this.rad_Non);
            this.grpbox_Mixte.Controls.Add(this.rad_Oui);
            this.grpbox_Mixte.Location = new System.Drawing.Point(456, 65);
            this.grpbox_Mixte.Name = "grpbox_Mixte";
            this.grpbox_Mixte.Size = new System.Drawing.Size(250, 125);
            this.grpbox_Mixte.TabIndex = 7;
            this.grpbox_Mixte.TabStop = false;
            this.grpbox_Mixte.Text = "Mixte";
            // 
            // rad_Non
            // 
            this.rad_Non.AutoSize = true;
            this.rad_Non.Location = new System.Drawing.Point(14, 84);
            this.rad_Non.Name = "rad_Non";
            this.rad_Non.Size = new System.Drawing.Size(55, 24);
            this.rad_Non.TabIndex = 1;
            this.rad_Non.TabStop = true;
            this.rad_Non.Text = "non";
            this.rad_Non.UseVisualStyleBackColor = true;
            // 
            // rad_Oui
            // 
            this.rad_Oui.AutoSize = true;
            this.rad_Oui.Location = new System.Drawing.Point(14, 35);
            this.rad_Oui.Name = "rad_Oui";
            this.rad_Oui.Size = new System.Drawing.Size(51, 24);
            this.rad_Oui.TabIndex = 0;
            this.rad_Oui.TabStop = true;
            this.rad_Oui.Text = "oui";
            this.rad_Oui.UseVisualStyleBackColor = true;
            // 
            // btn_Detruire
            // 
            this.btn_Detruire.Location = new System.Drawing.Point(493, 278);
            this.btn_Detruire.Name = "btn_Detruire";
            this.btn_Detruire.Size = new System.Drawing.Size(94, 29);
            this.btn_Detruire.TabIndex = 6;
            this.btn_Detruire.Text = "Detruire";
            this.btn_Detruire.UseVisualStyleBackColor = true;
            this.btn_Detruire.Click += new System.EventHandler(this.btn_Detruire_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(364, 278);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(94, 29);
            this.btn_Modifier.TabIndex = 5;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // txt_NbHeure
            // 
            this.txt_NbHeure.Location = new System.Drawing.Point(274, 119);
            this.txt_NbHeure.Name = "txt_NbHeure";
            this.txt_NbHeure.Size = new System.Drawing.Size(125, 27);
            this.txt_NbHeure.TabIndex = 4;
            // 
            // txt_NomDCours
            // 
            this.txt_NomDCours.Location = new System.Drawing.Point(274, 36);
            this.txt_NomDCours.Name = "txt_NomDCours";
            this.txt_NomDCours.Size = new System.Drawing.Size(125, 27);
            this.txt_NomDCours.TabIndex = 2;
            // 
            // cmb_Categorie
            // 
            this.cmb_Categorie.FormattingEnabled = true;
            this.cmb_Categorie.Location = new System.Drawing.Point(274, 225);
            this.cmb_Categorie.Name = "cmb_Categorie";
            this.cmb_Categorie.Size = new System.Drawing.Size(372, 28);
            this.cmb_Categorie.TabIndex = 1;
            // 
            // ModifierDetrureCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpb_RechercheEntreprise);
            this.Name = "ModifierDetrureCours";
            this.Text = "ModifierDetrureEntreprise";
            this.Load += new System.EventHandler(this.ModifierDetruireCours_Load);
            this.grpb_RechercheEntreprise.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpbox_Mixte.ResumeLayout(false);
            this.grpbox_Mixte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_RechercheEntreprise;
        private System.Windows.Forms.GroupBox grpb_RechercheEntreprise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_NomDCours;
        private System.Windows.Forms.ComboBox cmb_Categorie;
        private System.Windows.Forms.GroupBox grpbox_Mixte;
        private System.Windows.Forms.RadioButton rad_Non;
        private System.Windows.Forms.RadioButton rad_Oui;
        private System.Windows.Forms.Button btn_Detruire;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.TextBox txt_NbHeure;
        private System.Windows.Forms.Button btn_AjouterCategorie;
        private System.Windows.Forms.Label lbl_Categorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
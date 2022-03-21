
namespace travail_pratique_2
{
    partial class ModifierDetruireCategorie
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ModifierCategorie = new System.Windows.Forms.TextBox();
            this.lbl_Categorie = new System.Windows.Forms.Label();
            this.btn_Detruire = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.grpb_RechercheEntreprise = new System.Windows.Forms.GroupBox();
            this.cmb_RechercheCategorie = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.grpb_RechercheEntreprise.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ModifierCategorie);
            this.groupBox2.Controls.Add(this.lbl_Categorie);
            this.groupBox2.Controls.Add(this.btn_Detruire);
            this.groupBox2.Controls.Add(this.btn_Modifier);
            this.groupBox2.Location = new System.Drawing.Point(23, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier/Détruire";
            // 
            // txt_ModifierCategorie
            // 
            this.txt_ModifierCategorie.Location = new System.Drawing.Point(167, 92);
            this.txt_ModifierCategorie.Name = "txt_ModifierCategorie";
            this.txt_ModifierCategorie.Size = new System.Drawing.Size(415, 27);
            this.txt_ModifierCategorie.TabIndex = 12;
            // 
            // lbl_Categorie
            // 
            this.lbl_Categorie.AutoSize = true;
            this.lbl_Categorie.Location = new System.Drawing.Point(23, 92);
            this.lbl_Categorie.Name = "lbl_Categorie";
            this.lbl_Categorie.Size = new System.Drawing.Size(74, 20);
            this.lbl_Categorie.TabIndex = 11;
            this.lbl_Categorie.Text = "Categorie";
            // 
            // btn_Detruire
            // 
            this.btn_Detruire.Location = new System.Drawing.Point(437, 142);
            this.btn_Detruire.Name = "btn_Detruire";
            this.btn_Detruire.Size = new System.Drawing.Size(94, 29);
            this.btn_Detruire.TabIndex = 6;
            this.btn_Detruire.Text = "Detruire";
            this.btn_Detruire.UseVisualStyleBackColor = true;
            this.btn_Detruire.Click += new System.EventHandler(this.btn_Detruire_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(308, 142);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(94, 29);
            this.btn_Modifier.TabIndex = 5;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // grpb_RechercheEntreprise
            // 
            this.grpb_RechercheEntreprise.Controls.Add(this.cmb_RechercheCategorie);
            this.grpb_RechercheEntreprise.Location = new System.Drawing.Point(23, 12);
            this.grpb_RechercheEntreprise.Name = "grpb_RechercheEntreprise";
            this.grpb_RechercheEntreprise.Size = new System.Drawing.Size(652, 65);
            this.grpb_RechercheEntreprise.TabIndex = 3;
            this.grpb_RechercheEntreprise.TabStop = false;
            this.grpb_RechercheEntreprise.Text = "Recherche d\'une categorie";
            // 
            // cmb_RechercheCategorie
            // 
            this.cmb_RechercheCategorie.FormattingEnabled = true;
            this.cmb_RechercheCategorie.Location = new System.Drawing.Point(21, 26);
            this.cmb_RechercheCategorie.Name = "cmb_RechercheCategorie";
            this.cmb_RechercheCategorie.Size = new System.Drawing.Size(580, 28);
            this.cmb_RechercheCategorie.TabIndex = 0;
            this.cmb_RechercheCategorie.SelectedIndexChanged += new System.EventHandler(this.cmb_RechercheCategorie_SelectedIndexChanged);
            // 
            // ModifierDetruireCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpb_RechercheEntreprise);
            this.Name = "ModifierDetruireCategorie";
            this.Text = "ModifierDetruireCategorie";
            this.Load += new System.EventHandler(this.ModifierDetruireCategorie_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpb_RechercheEntreprise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Categorie;
        private System.Windows.Forms.Button btn_Detruire;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.GroupBox grpb_RechercheEntreprise;
        private System.Windows.Forms.ComboBox cmb_RechercheCategorie;
        private System.Windows.Forms.TextBox txt_ModifierCategorie;
    }
}
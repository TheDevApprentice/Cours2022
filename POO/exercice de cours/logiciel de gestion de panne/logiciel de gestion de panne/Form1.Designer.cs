
namespace logiciel_de_gestion_de_panne
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
            this.grpb_pannesListe = new System.Windows.Forms.GroupBox();
            this.lst_pannes = new System.Windows.Forms.ListBox();
            this.grp_ajoutPanne = new System.Windows.Forms.GroupBox();
            this.lbl_clientsTouché = new System.Windows.Forms.Label();
            this.txtbox_nbClientsTouche = new System.Windows.Forms.TextBox();
            this.btn_ajouterPanne = new System.Windows.Forms.Button();
            this.btn_progresserEtat = new System.Windows.Forms.Button();
            this.btn_dupliquer = new System.Windows.Forms.Button();
            this.grpb_pannesListe.SuspendLayout();
            this.grp_ajoutPanne.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_pannesListe
            // 
            this.grpb_pannesListe.Controls.Add(this.lst_pannes);
            this.grpb_pannesListe.Location = new System.Drawing.Point(0, 0);
            this.grpb_pannesListe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpb_pannesListe.Name = "grpb_pannesListe";
            this.grpb_pannesListe.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpb_pannesListe.Size = new System.Drawing.Size(920, 220);
            this.grpb_pannesListe.TabIndex = 0;
            this.grpb_pannesListe.TabStop = false;
            this.grpb_pannesListe.Text = "Pannes";
            // 
            // lst_pannes
            // 
            this.lst_pannes.FormattingEnabled = true;
            this.lst_pannes.ItemHeight = 20;
            this.lst_pannes.Location = new System.Drawing.Point(6, 28);
            this.lst_pannes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_pannes.Name = "lst_pannes";
            this.lst_pannes.Size = new System.Drawing.Size(891, 184);
            this.lst_pannes.TabIndex = 0;
            // 
            // grp_ajoutPanne
            // 
            this.grp_ajoutPanne.Controls.Add(this.lbl_clientsTouché);
            this.grp_ajoutPanne.Controls.Add(this.txtbox_nbClientsTouche);
            this.grp_ajoutPanne.Controls.Add(this.btn_ajouterPanne);
            this.grp_ajoutPanne.Location = new System.Drawing.Point(1008, 13);
            this.grp_ajoutPanne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ajoutPanne.Name = "grp_ajoutPanne";
            this.grp_ajoutPanne.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_ajoutPanne.Size = new System.Drawing.Size(587, 199);
            this.grp_ajoutPanne.TabIndex = 1;
            this.grp_ajoutPanne.TabStop = false;
            this.grp_ajoutPanne.Text = "Ajouter une panne";
            // 
            // lbl_clientsTouché
            // 
            this.lbl_clientsTouché.AutoSize = true;
            this.lbl_clientsTouché.Location = new System.Drawing.Point(84, 46);
            this.lbl_clientsTouché.Name = "lbl_clientsTouché";
            this.lbl_clientsTouché.Size = new System.Drawing.Size(203, 20);
            this.lbl_clientsTouché.TabIndex = 5;
            this.lbl_clientsTouché.Text = "Nombres de clients touchés : ";
            // 
            // txtbox_nbClientsTouche
            // 
            this.txtbox_nbClientsTouche.Location = new System.Drawing.Point(309, 43);
            this.txtbox_nbClientsTouche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_nbClientsTouche.Name = "txtbox_nbClientsTouche";
            this.txtbox_nbClientsTouche.Size = new System.Drawing.Size(60, 27);
            this.txtbox_nbClientsTouche.TabIndex = 4;
            // 
            // btn_ajouterPanne
            // 
            this.btn_ajouterPanne.Location = new System.Drawing.Point(263, 112);
            this.btn_ajouterPanne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ajouterPanne.Name = "btn_ajouterPanne";
            this.btn_ajouterPanne.Size = new System.Drawing.Size(86, 31);
            this.btn_ajouterPanne.TabIndex = 3;
            this.btn_ajouterPanne.Text = "Ajouter";
            this.btn_ajouterPanne.UseVisualStyleBackColor = true;
            this.btn_ajouterPanne.Click += new System.EventHandler(this.btn_ajouterPanne_Click);
            // 
            // btn_progresserEtat
            // 
            this.btn_progresserEtat.Location = new System.Drawing.Point(14, 228);
            this.btn_progresserEtat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_progresserEtat.Name = "btn_progresserEtat";
            this.btn_progresserEtat.Size = new System.Drawing.Size(141, 31);
            this.btn_progresserEtat.TabIndex = 2;
            this.btn_progresserEtat.Text = "Progresser l\'état";
            this.btn_progresserEtat.UseVisualStyleBackColor = true;
            this.btn_progresserEtat.Click += new System.EventHandler(this.btn_progresserEtat_Click);
            // 
            // btn_dupliquer
            // 
            this.btn_dupliquer.Location = new System.Drawing.Point(161, 228);
            this.btn_dupliquer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dupliquer.Name = "btn_dupliquer";
            this.btn_dupliquer.Size = new System.Drawing.Size(158, 31);
            this.btn_dupliquer.TabIndex = 3;
            this.btn_dupliquer.Text = "Dupliquer";
            this.btn_dupliquer.UseVisualStyleBackColor = true;
            this.btn_dupliquer.Click += new System.EventHandler(this.btn_dupliquer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 435);
            this.Controls.Add(this.btn_dupliquer);
            this.Controls.Add(this.btn_progresserEtat);
            this.Controls.Add(this.grp_ajoutPanne);
            this.Controls.Add(this.grpb_pannesListe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpb_pannesListe.ResumeLayout(false);
            this.grp_ajoutPanne.ResumeLayout(false);
            this.grp_ajoutPanne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_pannesListe;
        private System.Windows.Forms.ListBox lst_pannes;
        private System.Windows.Forms.GroupBox grp_ajoutPanne;
        private System.Windows.Forms.TextBox txtbox_nbClientsTouche;
        private System.Windows.Forms.Button btn_ajouterPanne;
        private System.Windows.Forms.Button btn_progresserEtat;
        private System.Windows.Forms.Button btn_dupliquer;
        private System.Windows.Forms.Label lbl_clientsTouché;
    }
}


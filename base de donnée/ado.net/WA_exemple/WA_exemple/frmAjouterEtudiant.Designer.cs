namespace WA_exemple
{
    partial class frmAjouterEtudiant
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCellulaire = new System.Windows.Forms.Label();
            this.txtCellulaire = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblProvenance = new System.Windows.Forms.Label();
            this.cmbProvenance = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCellulaire
            // 
            this.lblCellulaire.AutoSize = true;
            this.lblCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellulaire.Location = new System.Drawing.Point(23, 115);
            this.lblCellulaire.Name = "lblCellulaire";
            this.lblCellulaire.Size = new System.Drawing.Size(36, 20);
            this.lblCellulaire.TabIndex = 20;
            this.lblCellulaire.Text = "age";
            // 
            // txtCellulaire
            // 
            this.txtCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellulaire.Location = new System.Drawing.Point(255, 115);
            this.txtCellulaire.Name = "txtCellulaire";
            this.txtCellulaire.Size = new System.Drawing.Size(163, 26);
            this.txtCellulaire.TabIndex = 19;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(324, 229);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 32);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(23, 74);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 17;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(23, 31);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblPrenom.TabIndex = 16;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(255, 74);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(163, 26);
            this.txtNom.TabIndex = 15;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(255, 31);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(163, 26);
            this.txtPrenom.TabIndex = 14;
            // 
            // lblProvenance
            // 
            this.lblProvenance.AutoSize = true;
            this.lblProvenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvenance.Location = new System.Drawing.Point(23, 167);
            this.lblProvenance.Name = "lblProvenance";
            this.lblProvenance.Size = new System.Drawing.Size(93, 20);
            this.lblProvenance.TabIndex = 26;
            this.lblProvenance.Text = "Provenance";
            // 
            // cmbProvenance
            // 
            this.cmbProvenance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvenance.FormattingEnabled = true;
            this.cmbProvenance.Location = new System.Drawing.Point(256, 167);
            this.cmbProvenance.Name = "cmbProvenance";
            this.cmbProvenance.Size = new System.Drawing.Size(163, 27);
            this.cmbProvenance.TabIndex = 25;
            // 
            // frmAjouterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 294);
            this.Controls.Add(this.lblProvenance);
            this.Controls.Add(this.cmbProvenance);
            this.Controls.Add(this.lblCellulaire);
            this.Controls.Add(this.txtCellulaire);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAjouterEtudiant";
            this.Text = "Ajouter un étudiant";
            this.Load += new System.EventHandler(this.frmAjouterEtudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCellulaire;
        private System.Windows.Forms.TextBox txtCellulaire;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblProvenance;
        internal System.Windows.Forms.ComboBox cmbProvenance;
    }
}


﻿namespace WA_exemple
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
            this.lblDegreHumour = new System.Windows.Forms.Label();
            this.lblCellulaire = new System.Windows.Forms.Label();
            this.txtCellulaire = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.NUDHumour = new System.Windows.Forms.NumericUpDown();
            this.lblProvenance = new System.Windows.Forms.Label();
            this.cmbProvenance = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHumour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDegreHumour
            // 
            this.lblDegreHumour.AutoSize = true;
            this.lblDegreHumour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreHumour.Location = new System.Drawing.Point(31, 198);
            this.lblDegreHumour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegreHumour.Name = "lblDegreHumour";
            this.lblDegreHumour.Size = new System.Drawing.Size(151, 25);
            this.lblDegreHumour.TabIndex = 21;
            this.lblDegreHumour.Text = "Degré d\'humour";
            // 
            // lblCellulaire
            // 
            this.lblCellulaire.AutoSize = true;
            this.lblCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellulaire.Location = new System.Drawing.Point(31, 142);
            this.lblCellulaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellulaire.Name = "lblCellulaire";
            this.lblCellulaire.Size = new System.Drawing.Size(93, 25);
            this.lblCellulaire.TabIndex = 20;
            this.lblCellulaire.Text = "Cellulaire";
           // this.lblCellulaire.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCellulaire
            // 
            this.txtCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellulaire.Location = new System.Drawing.Point(340, 142);
            this.txtCellulaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtCellulaire.Name = "txtCellulaire";
            this.txtCellulaire.Size = new System.Drawing.Size(216, 30);
            this.txtCellulaire.TabIndex = 19;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(456, 301);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 39);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(31, 91);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 25);
            this.lblNom.TabIndex = 17;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(31, 38);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(80, 25);
            this.lblPrenom.TabIndex = 16;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(340, 91);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(216, 30);
            this.txtNom.TabIndex = 15;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(340, 38);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(216, 30);
            this.txtPrenom.TabIndex = 14;
            // 
            // NUDHumour
            // 
            this.NUDHumour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHumour.Location = new System.Drawing.Point(340, 200);
            this.NUDHumour.Name = "NUDHumour";
            this.NUDHumour.Size = new System.Drawing.Size(216, 30);
            this.NUDHumour.TabIndex = 22;
            // 
            // lblProvenance
            // 
            this.lblProvenance.AutoSize = true;
            this.lblProvenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvenance.Location = new System.Drawing.Point(30, 251);
            this.lblProvenance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvenance.Name = "lblProvenance";
            this.lblProvenance.Size = new System.Drawing.Size(146, 31);
            this.lblProvenance.TabIndex = 26;
            this.lblProvenance.Text = "Provenance";
            // 
            // cmbProvenance
            // 
            this.cmbProvenance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvenance.FormattingEnabled = true;
            this.cmbProvenance.Location = new System.Drawing.Point(340, 251);
            this.cmbProvenance.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProvenance.Name = "cmbProvenance";
            this.cmbProvenance.Size = new System.Drawing.Size(216, 32);
            this.cmbProvenance.TabIndex = 25;
            // 
            // frmAjouterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 362);
            this.Controls.Add(this.lblProvenance);
            this.Controls.Add(this.cmbProvenance);
            this.Controls.Add(this.NUDHumour);
            this.Controls.Add(this.lblDegreHumour);
            this.Controls.Add(this.lblCellulaire);
            this.Controls.Add(this.txtCellulaire);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Name = "frmAjouterEtudiant";
            this.Text = "Ajouter un étudiant";
            ((System.ComponentModel.ISupportInitialize)(this.NUDHumour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDegreHumour;
        private System.Windows.Forms.Label lblCellulaire;
        private System.Windows.Forms.TextBox txtCellulaire;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.NumericUpDown NUDHumour;
        private System.Windows.Forms.Label lblProvenance;
        internal System.Windows.Forms.ComboBox cmbProvenance;
    }
}


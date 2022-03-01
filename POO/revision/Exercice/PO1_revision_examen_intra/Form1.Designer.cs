
namespace PO1_revision_examen_intra
{
    partial class FormPrincipale
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
            this.groupBox_nouvelleCommande = new System.Windows.Forms.GroupBox();
            this.label_prix = new System.Windows.Forms.Label();
            this.textBox_prixAjouterCommnande = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBox_descriptionAjouterCommande = new System.Windows.Forms.TextBox();
            this.listBox_commandes = new System.Windows.Forms.ListBox();
            this.button_marquerCompletee = new System.Windows.Forms.Button();
            this.groupBox_nouvelleCommande.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_nouvelleCommande
            // 
            this.groupBox_nouvelleCommande.Controls.Add(this.label_prix);
            this.groupBox_nouvelleCommande.Controls.Add(this.textBox_prixAjouterCommnande);
            this.groupBox_nouvelleCommande.Controls.Add(this.label_description);
            this.groupBox_nouvelleCommande.Controls.Add(this.button_ajouter);
            this.groupBox_nouvelleCommande.Controls.Add(this.textBox_descriptionAjouterCommande);
            this.groupBox_nouvelleCommande.Location = new System.Drawing.Point(649, 16);
            this.groupBox_nouvelleCommande.Name = "groupBox_nouvelleCommande";
            this.groupBox_nouvelleCommande.Size = new System.Drawing.Size(285, 160);
            this.groupBox_nouvelleCommande.TabIndex = 0;
            this.groupBox_nouvelleCommande.TabStop = false;
            this.groupBox_nouvelleCommande.Text = "Ajouter une commande";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Location = new System.Drawing.Point(6, 66);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(33, 20);
            this.label_prix.TabIndex = 4;
            this.label_prix.Text = "Prix";
            // 
            // textBox_prixAjouterCommnande
            // 
            this.textBox_prixAjouterCommnande.Location = new System.Drawing.Point(111, 63);
            this.textBox_prixAjouterCommnande.Name = "textBox_prixAjouterCommnande";
            this.textBox_prixAjouterCommnande.Size = new System.Drawing.Size(125, 27);
            this.textBox_prixAjouterCommnande.TabIndex = 3;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(6, 33);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(85, 20);
            this.label_description.TabIndex = 2;
            this.label_description.Text = "Description";
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(184, 125);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(94, 29);
            this.button_ajouter.TabIndex = 1;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // textBox_descriptionAjouterCommande
            // 
            this.textBox_descriptionAjouterCommande.Location = new System.Drawing.Point(111, 30);
            this.textBox_descriptionAjouterCommande.Name = "textBox_descriptionAjouterCommande";
            this.textBox_descriptionAjouterCommande.Size = new System.Drawing.Size(125, 27);
            this.textBox_descriptionAjouterCommande.TabIndex = 0;
            // 
            // listBox_commandes
            // 
            this.listBox_commandes.FormattingEnabled = true;
            this.listBox_commandes.ItemHeight = 20;
            this.listBox_commandes.Location = new System.Drawing.Point(12, 12);
            this.listBox_commandes.Name = "listBox_commandes";
            this.listBox_commandes.Size = new System.Drawing.Size(597, 164);
            this.listBox_commandes.TabIndex = 1;
            // 
            // button_marquerCompletee
            // 
            this.button_marquerCompletee.Location = new System.Drawing.Point(92, 182);
            this.button_marquerCompletee.Name = "button_marquerCompletee";
            this.button_marquerCompletee.Size = new System.Drawing.Size(263, 29);
            this.button_marquerCompletee.TabIndex = 2;
            this.button_marquerCompletee.Text = "Marquer comme complétée";
            this.button_marquerCompletee.UseVisualStyleBackColor = true;
            this.button_marquerCompletee.Click += new System.EventHandler(this.button_marquerCompletee_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.button_marquerCompletee);
            this.Controls.Add(this.listBox_commandes);
            this.Controls.Add(this.groupBox_nouvelleCommande);
            this.Name = "FormPrincipale";
            this.Text = "Cremerie Inc.";
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.groupBox_nouvelleCommande.ResumeLayout(false);
            this.groupBox_nouvelleCommande.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_nouvelleCommande;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.TextBox textBox_prixAjouterCommnande;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox textBox_descriptionAjouterCommande;
        private System.Windows.Forms.ListBox listBox_commandes;
        private System.Windows.Forms.Button button_marquerCompletee;
    }
}


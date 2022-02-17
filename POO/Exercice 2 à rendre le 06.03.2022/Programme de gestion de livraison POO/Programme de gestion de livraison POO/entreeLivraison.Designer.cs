
namespace Programme_de_gestion_de_livraison_POO
{
    partial class entreeLivraison
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
            this.btb_validateLivraisonEntree = new System.Windows.Forms.Button();
            this.txt_entreePoidsLivraison = new System.Windows.Forms.TextBox();
            this.lbl_entreePoidsLivraison = new System.Windows.Forms.Label();
            this.lbl_entreeVolumeLivraison = new System.Windows.Forms.Label();
            this.txt_entreeVolumeLivraison = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btb_validateLivraisonEntree
            // 
            this.btb_validateLivraisonEntree.Location = new System.Drawing.Point(182, 190);
            this.btb_validateLivraisonEntree.Name = "btb_validateLivraisonEntree";
            this.btb_validateLivraisonEntree.Size = new System.Drawing.Size(94, 29);
            this.btb_validateLivraisonEntree.TabIndex = 0;
            this.btb_validateLivraisonEntree.Text = "Valider";
            this.btb_validateLivraisonEntree.UseVisualStyleBackColor = true;
            this.btb_validateLivraisonEntree.Click += new System.EventHandler(this.btb_validateLivraisonEntree_Click);
            // 
            // txt_entreePoidsLivraison
            // 
            this.txt_entreePoidsLivraison.Location = new System.Drawing.Point(136, 79);
            this.txt_entreePoidsLivraison.Name = "txt_entreePoidsLivraison";
            this.txt_entreePoidsLivraison.Size = new System.Drawing.Size(125, 27);
            this.txt_entreePoidsLivraison.TabIndex = 1;
            // 
            // lbl_entreePoidsLivraison
            // 
            this.lbl_entreePoidsLivraison.AutoSize = true;
            this.lbl_entreePoidsLivraison.Location = new System.Drawing.Point(57, 82);
            this.lbl_entreePoidsLivraison.Name = "lbl_entreePoidsLivraison";
            this.lbl_entreePoidsLivraison.Size = new System.Drawing.Size(44, 20);
            this.lbl_entreePoidsLivraison.TabIndex = 2;
            this.lbl_entreePoidsLivraison.Text = "Poids";
            // 
            // lbl_entreeVolumeLivraison
            // 
            this.lbl_entreeVolumeLivraison.AutoSize = true;
            this.lbl_entreeVolumeLivraison.Location = new System.Drawing.Point(57, 134);
            this.lbl_entreeVolumeLivraison.Name = "lbl_entreeVolumeLivraison";
            this.lbl_entreeVolumeLivraison.Size = new System.Drawing.Size(59, 20);
            this.lbl_entreeVolumeLivraison.TabIndex = 4;
            this.lbl_entreeVolumeLivraison.Text = "Volume";
            // 
            // txt_entreeVolumeLivraison
            // 
            this.txt_entreeVolumeLivraison.Location = new System.Drawing.Point(136, 131);
            this.txt_entreeVolumeLivraison.Name = "txt_entreeVolumeLivraison";
            this.txt_entreeVolumeLivraison.Size = new System.Drawing.Size(125, 27);
            this.txt_entreeVolumeLivraison.TabIndex = 3;
            // 
            // entreeLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 265);
            this.Controls.Add(this.lbl_entreeVolumeLivraison);
            this.Controls.Add(this.txt_entreeVolumeLivraison);
            this.Controls.Add(this.lbl_entreePoidsLivraison);
            this.Controls.Add(this.txt_entreePoidsLivraison);
            this.Controls.Add(this.btb_validateLivraisonEntree);
            this.Name = "entreeLivraison";
            this.Text = "entreeLivraison";
            this.Load += new System.EventHandler(this.entreeLivraison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_validateLivraisonEntree;
        private System.Windows.Forms.TextBox txt_entreePoidsLivraison;
        private System.Windows.Forms.Label lbl_entreePoidsLivraison;
        private System.Windows.Forms.Label lbl_entreeVolumeLivraison;
        private System.Windows.Forms.TextBox txt_entreeVolumeLivraison;
    }
}
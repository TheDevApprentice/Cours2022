
namespace Programme_de_gestion_de_livraison_POO
{
    partial class lbl_entreeCamionneurPrenom
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
            this.txt_entreeNom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_entreePrenom = new System.Windows.Forms.TextBox();
            this.btn_validerEntreeCamionneur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_entreeNom
            // 
            this.txt_entreeNom.Location = new System.Drawing.Point(130, 52);
            this.txt_entreeNom.Name = "txt_entreeNom";
            this.txt_entreeNom.Size = new System.Drawing.Size(218, 27);
            this.txt_entreeNom.TabIndex = 0;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(65, 55);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(42, 20);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(47, 98);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(60, 20);
            this.lbl_prenom.TabIndex = 3;
            this.lbl_prenom.Text = "Prenom";
            // 
            // txt_entreePrenom
            // 
            this.txt_entreePrenom.Location = new System.Drawing.Point(130, 95);
            this.txt_entreePrenom.Name = "txt_entreePrenom";
            this.txt_entreePrenom.Size = new System.Drawing.Size(218, 27);
            this.txt_entreePrenom.TabIndex = 2;
            // 
            // btn_validerEntreeCamionneur
            // 
            this.btn_validerEntreeCamionneur.Location = new System.Drawing.Point(254, 144);
            this.btn_validerEntreeCamionneur.Name = "btn_validerEntreeCamionneur";
            this.btn_validerEntreeCamionneur.Size = new System.Drawing.Size(94, 29);
            this.btn_validerEntreeCamionneur.TabIndex = 4;
            this.btn_validerEntreeCamionneur.Text = "Valider";
            this.btn_validerEntreeCamionneur.UseVisualStyleBackColor = true;
            this.btn_validerEntreeCamionneur.Click += new System.EventHandler(this.btn_validerEntreeCamionneur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prénom";
            // 
            // lbl_entreeCamionneurPrenom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_validerEntreeCamionneur);
            this.Controls.Add(this.txt_entreePrenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_entreeNom);
            this.Name = "lbl_entreeCamionneurPrenom";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_entreeNom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_entreePrenom;
        private System.Windows.Forms.Button btn_validerEntreeCamionneur;
        private System.Windows.Forms.Label label1;
    }
}
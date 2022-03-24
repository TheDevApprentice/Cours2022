
namespace travail_pratique_2
{
    partial class AjouterUneCategorie
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
            this.lbl_NomDeLaCategorie = new System.Windows.Forms.Label();
            this.btn_AjouterCategorie = new System.Windows.Forms.Button();
            this.txtAjoutCategorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_NomDeLaCategorie
            // 
            this.lbl_NomDeLaCategorie.AutoSize = true;
            this.lbl_NomDeLaCategorie.Location = new System.Drawing.Point(12, 64);
            this.lbl_NomDeLaCategorie.Name = "lbl_NomDeLaCategorie";
            this.lbl_NomDeLaCategorie.Size = new System.Drawing.Size(146, 20);
            this.lbl_NomDeLaCategorie.TabIndex = 0;
            this.lbl_NomDeLaCategorie.Text = "Nom de la categorie";
            // 
            // btn_AjouterCategorie
            // 
            this.btn_AjouterCategorie.Location = new System.Drawing.Point(323, 125);
            this.btn_AjouterCategorie.Name = "btn_AjouterCategorie";
            this.btn_AjouterCategorie.Size = new System.Drawing.Size(94, 29);
            this.btn_AjouterCategorie.TabIndex = 1;
            this.btn_AjouterCategorie.Text = "Ajouter";
            this.btn_AjouterCategorie.UseVisualStyleBackColor = true;
            this.btn_AjouterCategorie.Click += new System.EventHandler(this.btn_AjouterCategorie_Click);
            // 
            // txtAjoutCategorie
            // 
            this.txtAjoutCategorie.Location = new System.Drawing.Point(180, 61);
            this.txtAjoutCategorie.Name = "txtAjoutCategorie";
            this.txtAjoutCategorie.Size = new System.Drawing.Size(237, 27);
            this.txtAjoutCategorie.TabIndex = 2;
            // 
            // AjouterUneCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 184);
            this.Controls.Add(this.txtAjoutCategorie);
            this.Controls.Add(this.btn_AjouterCategorie);
            this.Controls.Add(this.lbl_NomDeLaCategorie);
            this.Name = "AjouterUneCategorie";
            this.Text = "AjouterUneCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomDeLaCategorie;
        private System.Windows.Forms.Button btn_AjouterCategorie;
        private System.Windows.Forms.TextBox txtAjoutCategorie;
    }
}
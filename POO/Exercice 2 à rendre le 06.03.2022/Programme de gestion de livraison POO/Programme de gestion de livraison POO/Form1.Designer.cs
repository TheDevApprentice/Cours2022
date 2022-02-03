
namespace Programme_de_gestion_de_livraison_POO
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
            this.label_ajouter = new System.Windows.Forms.Label();
            this.grpb_voyages = new System.Windows.Forms.GroupBox();
            this.lst_voyages = new System.Windows.Forms.ListBox();
            this.lst_livraisonNonAssignees = new System.Windows.Forms.ListBox();
            this.grpb_livraisonNonAssignees = new System.Windows.Forms.GroupBox();
            this.btn_assigneLivraison = new System.Windows.Forms.Button();
            this.btn_directionNonAssignees = new System.Windows.Forms.Button();
            this.grpb_voyages.SuspendLayout();
            this.grpb_livraisonNonAssignees.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ajouter
            // 
            this.label_ajouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ajouter.Location = new System.Drawing.Point(0, 0);
            this.label_ajouter.Name = "label_ajouter";
            this.label_ajouter.Size = new System.Drawing.Size(112, 46);
            this.label_ajouter.TabIndex = 0;
            this.label_ajouter.Text = "Ajouter";
            // 
            // grpb_voyages
            // 
            this.grpb_voyages.Controls.Add(this.lst_voyages);
            this.grpb_voyages.Location = new System.Drawing.Point(12, 23);
            this.grpb_voyages.Name = "grpb_voyages";
            this.grpb_voyages.Size = new System.Drawing.Size(443, 179);
            this.grpb_voyages.TabIndex = 1;
            this.grpb_voyages.TabStop = false;
            this.grpb_voyages.Text = "Voyages";
            // 
            // lst_voyages
            // 
            this.lst_voyages.FormattingEnabled = true;
            this.lst_voyages.ItemHeight = 20;
            this.lst_voyages.Location = new System.Drawing.Point(15, 26);
            this.lst_voyages.Name = "lst_voyages";
            this.lst_voyages.Size = new System.Drawing.Size(422, 144);
            this.lst_voyages.TabIndex = 2;
            // 
            // lst_livraisonNonAssignees
            // 
            this.lst_livraisonNonAssignees.FormattingEnabled = true;
            this.lst_livraisonNonAssignees.ItemHeight = 20;
            this.lst_livraisonNonAssignees.Location = new System.Drawing.Point(9, 26);
            this.lst_livraisonNonAssignees.Name = "lst_livraisonNonAssignees";
            this.lst_livraisonNonAssignees.Size = new System.Drawing.Size(422, 224);
            this.lst_livraisonNonAssignees.TabIndex = 3;
            // 
            // grpb_livraisonNonAssignees
            // 
            this.grpb_livraisonNonAssignees.Controls.Add(this.lst_livraisonNonAssignees);
            this.grpb_livraisonNonAssignees.Location = new System.Drawing.Point(12, 208);
            this.grpb_livraisonNonAssignees.Name = "grpb_livraisonNonAssignees";
            this.grpb_livraisonNonAssignees.Size = new System.Drawing.Size(437, 267);
            this.grpb_livraisonNonAssignees.TabIndex = 4;
            this.grpb_livraisonNonAssignees.TabStop = false;
            this.grpb_livraisonNonAssignees.Text = "Livraison non-assignées";
            // 
            // btn_assigneLivraison
            // 
            this.btn_assigneLivraison.Location = new System.Drawing.Point(455, 222);
            this.btn_assigneLivraison.Name = "btn_assigneLivraison";
            this.btn_assigneLivraison.Size = new System.Drawing.Size(43, 126);
            this.btn_assigneLivraison.TabIndex = 4;
            this.btn_assigneLivraison.Text = ">";
            this.btn_assigneLivraison.UseVisualStyleBackColor = true;
            this.btn_assigneLivraison.Click += new System.EventHandler(this.btn_assigneLivraison_Click);
            // 
            // btn_directionNonAssignees
            // 
            this.btn_directionNonAssignees.Location = new System.Drawing.Point(455, 354);
            this.btn_directionNonAssignees.Name = "btn_directionNonAssignees";
            this.btn_directionNonAssignees.Size = new System.Drawing.Size(43, 104);
            this.btn_directionNonAssignees.TabIndex = 5;
            this.btn_directionNonAssignees.Text = "<";
            this.btn_directionNonAssignees.UseVisualStyleBackColor = true;
            this.btn_directionNonAssignees.Click += new System.EventHandler(this.btn_directionNonAssignees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 487);
            this.Controls.Add(this.btn_directionNonAssignees);
            this.Controls.Add(this.btn_assigneLivraison);
            this.Controls.Add(this.grpb_livraisonNonAssignees);
            this.Controls.Add(this.grpb_voyages);
            this.Controls.Add(this.label_ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpb_voyages.ResumeLayout(false);
            this.grpb_livraisonNonAssignees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ajouter;
        private System.Windows.Forms.GroupBox grpb_voyages;
        private System.Windows.Forms.ListBox lst_voyages;
        private System.Windows.Forms.ListBox lst_livraisonNonAssignees;
        private System.Windows.Forms.GroupBox grpb_livraisonNonAssignees;
        private System.Windows.Forms.Button btn_assigneLivraison;
        private System.Windows.Forms.Button btn_directionNonAssignees;
    }
}


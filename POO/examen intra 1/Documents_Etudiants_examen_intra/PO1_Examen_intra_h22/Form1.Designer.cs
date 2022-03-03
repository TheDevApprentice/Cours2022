
namespace PO1_Examen_intra_h22
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
            this.listBox_voiture = new System.Windows.Forms.ListBox();
            this.textBox_kmAAjouter = new System.Windows.Forms.TextBox();
            this.groupBox_modificationVoiture = new System.Windows.Forms.GroupBox();
            this.button_ajouterKm = new System.Windows.Forms.Button();
            this.label_kmAAjouter = new System.Windows.Forms.Label();
            this.button_changementDHuile = new System.Windows.Forms.Button();
            this.groupBox_modificationVoiture.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_voiture
            // 
            this.listBox_voiture.FormattingEnabled = true;
            this.listBox_voiture.ItemHeight = 20;
            this.listBox_voiture.Location = new System.Drawing.Point(12, 12);
            this.listBox_voiture.Name = "listBox_voiture";
            this.listBox_voiture.Size = new System.Drawing.Size(1042, 104);
            this.listBox_voiture.TabIndex = 0;
            // 
            // textBox_kmAAjouter
            // 
            this.textBox_kmAAjouter.Location = new System.Drawing.Point(119, 26);
            this.textBox_kmAAjouter.Name = "textBox_kmAAjouter";
            this.textBox_kmAAjouter.Size = new System.Drawing.Size(95, 27);
            this.textBox_kmAAjouter.TabIndex = 1;
            // 
            // groupBox_modificationVoiture
            // 
            this.groupBox_modificationVoiture.Controls.Add(this.button_ajouterKm);
            this.groupBox_modificationVoiture.Controls.Add(this.label_kmAAjouter);
            this.groupBox_modificationVoiture.Controls.Add(this.textBox_kmAAjouter);
            this.groupBox_modificationVoiture.Location = new System.Drawing.Point(1079, 24);
            this.groupBox_modificationVoiture.Name = "groupBox_modificationVoiture";
            this.groupBox_modificationVoiture.Size = new System.Drawing.Size(241, 104);
            this.groupBox_modificationVoiture.TabIndex = 2;
            this.groupBox_modificationVoiture.TabStop = false;
            this.groupBox_modificationVoiture.Text = "Ajout de kilométrage";
            // 
            // button_ajouterKm
            // 
            this.button_ajouterKm.Location = new System.Drawing.Point(119, 59);
            this.button_ajouterKm.Name = "button_ajouterKm";
            this.button_ajouterKm.Size = new System.Drawing.Size(95, 29);
            this.button_ajouterKm.TabIndex = 4;
            this.button_ajouterKm.Text = "Ajouter";
            this.button_ajouterKm.UseVisualStyleBackColor = true;
            this.button_ajouterKm.Click += new System.EventHandler(this.button_ajouterKm_Click);
            // 
            // label_kmAAjouter
            // 
            this.label_kmAAjouter.AutoSize = true;
            this.label_kmAAjouter.Location = new System.Drawing.Point(6, 29);
            this.label_kmAAjouter.Name = "label_kmAAjouter";
            this.label_kmAAjouter.Size = new System.Drawing.Size(107, 20);
            this.label_kmAAjouter.TabIndex = 3;
            this.label_kmAAjouter.Text = "KMs à ajouter :";
            // 
            // button_changementDHuile
            // 
            this.button_changementDHuile.Location = new System.Drawing.Point(205, 122);
            this.button_changementDHuile.Name = "button_changementDHuile";
            this.button_changementDHuile.Size = new System.Drawing.Size(207, 63);
            this.button_changementDHuile.TabIndex = 5;
            this.button_changementDHuile.Text = "Effectuer un changement d\'huile";
            this.button_changementDHuile.UseVisualStyleBackColor = true;
            this.button_changementDHuile.Click += new System.EventHandler(this.button_changementDHuile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 284);
            this.Controls.Add(this.button_changementDHuile);
            this.Controls.Add(this.groupBox_modificationVoiture);
            this.Controls.Add(this.listBox_voiture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_modificationVoiture.ResumeLayout(false);
            this.groupBox_modificationVoiture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_voiture;
        private System.Windows.Forms.TextBox textBox_kmAAjouter;
        private System.Windows.Forms.GroupBox groupBox_modificationVoiture;
        private System.Windows.Forms.Button button_ajouterKm;
        private System.Windows.Forms.Label label_kmAAjouter;
        private System.Windows.Forms.Button button_changementDHuile;
    }
}


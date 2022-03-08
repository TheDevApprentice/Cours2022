
namespace travail_pratique_2
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNbHeure = new System.Windows.Forms.TextBox();
            this.radioButton_Oui = new System.Windows.Forms.RadioButton();
            this.radioButton_Non = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbListeCategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomDuCours = new System.Windows.Forms.TextBox();
            this.btn_AjoutCategorie = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ModifierCours = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ModifierDetruireCategorie = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(501, 491);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 29);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre d\'heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // txtNbHeure
            // 
            this.txtNbHeure.Location = new System.Drawing.Point(257, 200);
            this.txtNbHeure.Name = "txtNbHeure";
            this.txtNbHeure.Size = new System.Drawing.Size(261, 27);
            this.txtNbHeure.TabIndex = 6;
            // 
            // radioButton_Oui
            // 
            this.radioButton_Oui.AutoSize = true;
            this.radioButton_Oui.Location = new System.Drawing.Point(17, 41);
            this.radioButton_Oui.Name = "radioButton_Oui";
            this.radioButton_Oui.Size = new System.Drawing.Size(51, 24);
            this.radioButton_Oui.TabIndex = 0;
            this.radioButton_Oui.TabStop = true;
            this.radioButton_Oui.Text = "oui";
            this.radioButton_Oui.UseVisualStyleBackColor = true;
            // 
            // radioButton_Non
            // 
            this.radioButton_Non.AutoSize = true;
            this.radioButton_Non.Location = new System.Drawing.Point(203, 41);
            this.radioButton_Non.Name = "radioButton_Non";
            this.radioButton_Non.Size = new System.Drawing.Size(55, 24);
            this.radioButton_Non.TabIndex = 1;
            this.radioButton_Non.TabStop = true;
            this.radioButton_Non.Text = "non";
            this.radioButton_Non.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Non);
            this.groupBox1.Controls.Add(this.radioButton_Oui);
            this.groupBox1.Location = new System.Drawing.Point(257, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mixte";
            // 
            // cmbListeCategorie
            // 
            this.cmbListeCategorie.FormattingEnabled = true;
            this.cmbListeCategorie.Location = new System.Drawing.Point(257, 424);
            this.cmbListeCategorie.Name = "cmbListeCategorie";
            this.cmbListeCategorie.Size = new System.Drawing.Size(261, 28);
            this.cmbListeCategorie.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du cours";
            // 
            // txtNomDuCours
            // 
            this.txtNomDuCours.Location = new System.Drawing.Point(257, 81);
            this.txtNomDuCours.Name = "txtNomDuCours";
            this.txtNomDuCours.Size = new System.Drawing.Size(261, 27);
            this.txtNomDuCours.TabIndex = 4;
            // 
            // btn_AjoutCategorie
            // 
            this.btn_AjoutCategorie.Location = new System.Drawing.Point(545, 424);
            this.btn_AjoutCategorie.Name = "btn_AjoutCategorie";
            this.btn_AjoutCategorie.Size = new System.Drawing.Size(50, 29);
            this.btn_AjoutCategorie.TabIndex = 12;
            this.btn_AjoutCategorie.Text = "+";
            this.btn_AjoutCategorie.UseVisualStyleBackColor = true;
            this.btn_AjoutCategorie.Click += new System.EventHandler(this.btn_AjoutCategorie_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ModifierCours,
            this.toolStripSeparator1,
            this.btn_ModifierDetruireCategorie,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_ModifierCours
            // 
            this.btn_ModifierCours.Name = "btn_ModifierCours";
            this.btn_ModifierCours.Size = new System.Drawing.Size(167, 22);
            this.btn_ModifierCours.Text = "Modifier/Détruire Cours";
            this.btn_ModifierCours.Click += new System.EventHandler(this.btn_ModifierCours_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ModifierDetruireCategorie
            // 
            this.btn_ModifierDetruireCategorie.Name = "btn_ModifierDetruireCategorie";
            this.btn_ModifierDetruireCategorie.Size = new System.Drawing.Size(185, 22);
            this.btn_ModifierDetruireCategorie.Text = "ModifierDetruireCategorie";
            this.btn_ModifierDetruireCategorie.Click += new System.EventHandler(this.btn_ModifierDetruireCategorie_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_AjoutCategorie);
            this.Controls.Add(this.cmbListeCategorie);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNbHeure);
            this.Controls.Add(this.txtNomDuCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNbHeure;
        private System.Windows.Forms.RadioButton radioButton_Oui;
        private System.Windows.Forms.RadioButton radioButton_Non;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbListeCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomDuCours;
        private System.Windows.Forms.Button btn_AjoutCategorie;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btn_ModifierCours;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel btn_ModifierDetruireCategorie;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


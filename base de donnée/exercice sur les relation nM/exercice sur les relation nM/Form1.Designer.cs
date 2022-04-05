
namespace exercice_sur_les_relation_nM
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
            this.cmb_etudiant = new System.Windows.Forms.ComboBox();
            this.cmb_Hobby = new System.Windows.Forms.ComboBox();
            this.lbl_etudiant = new System.Windows.Forms.Label();
            this.lbl_hobby = new System.Windows.Forms.Label();
            this.btn_associerEtudiantHobby = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nombreDeHobbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_ajouterEtAssocierHobby = new System.Windows.Forms.GroupBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.txt_hobby = new System.Windows.Forms.TextBox();
            this.btn_ajouterHobbyEtAssocier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grp_ajouterEtAssocierHobby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_etudiant
            // 
            this.cmb_etudiant.FormattingEnabled = true;
            this.cmb_etudiant.Location = new System.Drawing.Point(137, 62);
            this.cmb_etudiant.Name = "cmb_etudiant";
            this.cmb_etudiant.Size = new System.Drawing.Size(382, 28);
            this.cmb_etudiant.TabIndex = 0;
            // 
            // cmb_Hobby
            // 
            this.cmb_Hobby.FormattingEnabled = true;
            this.cmb_Hobby.Location = new System.Drawing.Point(137, 126);
            this.cmb_Hobby.Name = "cmb_Hobby";
            this.cmb_Hobby.Size = new System.Drawing.Size(382, 28);
            this.cmb_Hobby.TabIndex = 1;
            // 
            // lbl_etudiant
            // 
            this.lbl_etudiant.AutoSize = true;
            this.lbl_etudiant.Location = new System.Drawing.Point(13, 65);
            this.lbl_etudiant.Name = "lbl_etudiant";
            this.lbl_etudiant.Size = new System.Drawing.Size(64, 20);
            this.lbl_etudiant.TabIndex = 2;
            this.lbl_etudiant.Text = "étudiant";
            // 
            // lbl_hobby
            // 
            this.lbl_hobby.AutoSize = true;
            this.lbl_hobby.Location = new System.Drawing.Point(23, 126);
            this.lbl_hobby.Name = "lbl_hobby";
            this.lbl_hobby.Size = new System.Drawing.Size(54, 20);
            this.lbl_hobby.TabIndex = 3;
            this.lbl_hobby.Text = "Hobby";
            // 
            // btn_associerEtudiantHobby
            // 
            this.btn_associerEtudiantHobby.Location = new System.Drawing.Point(351, 175);
            this.btn_associerEtudiantHobby.Name = "btn_associerEtudiantHobby";
            this.btn_associerEtudiantHobby.Size = new System.Drawing.Size(168, 29);
            this.btn_associerEtudiantHobby.TabIndex = 4;
            this.btn_associerEtudiantHobby.Text = "Associer";
            this.btn_associerEtudiantHobby.UseVisualStyleBackColor = true;
            this.btn_associerEtudiantHobby.Click += new System.EventHandler(this.btn_associerEtudiantHobby_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeHobbyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nombreDeHobbyToolStripMenuItem
            // 
            this.nombreDeHobbyToolStripMenuItem.Name = "nombreDeHobbyToolStripMenuItem";
            this.nombreDeHobbyToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.nombreDeHobbyToolStripMenuItem.Text = "nombre de hobby";
            this.nombreDeHobbyToolStripMenuItem.Click += new System.EventHandler(this.nombreDeHobbyToolStripMenuItem_Click_1);
            // 
            // grp_ajouterEtAssocierHobby
            // 
            this.grp_ajouterEtAssocierHobby.Controls.Add(this.btn_annuler);
            this.grp_ajouterEtAssocierHobby.Controls.Add(this.btn_ajouter);
            this.grp_ajouterEtAssocierHobby.Controls.Add(this.txt_hobby);
            this.grp_ajouterEtAssocierHobby.Location = new System.Drawing.Point(619, 65);
            this.grp_ajouterEtAssocierHobby.Name = "grp_ajouterEtAssocierHobby";
            this.grp_ajouterEtAssocierHobby.Size = new System.Drawing.Size(461, 172);
            this.grp_ajouterEtAssocierHobby.TabIndex = 6;
            this.grp_ajouterEtAssocierHobby.TabStop = false;
            this.grp_ajouterEtAssocierHobby.Text = "Ajouter un hobby";
            this.grp_ajouterEtAssocierHobby.Visible = false;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(320, 110);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(94, 29);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(183, 110);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(94, 29);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "btn_ajouterhobby";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // txt_hobby
            // 
            this.txt_hobby.Location = new System.Drawing.Point(90, 42);
            this.txt_hobby.Name = "txt_hobby";
            this.txt_hobby.Size = new System.Drawing.Size(281, 27);
            this.txt_hobby.TabIndex = 0;
            // 
            // btn_ajouterHobbyEtAssocier
            // 
            this.btn_ajouterHobbyEtAssocier.Location = new System.Drawing.Point(553, 107);
            this.btn_ajouterHobbyEtAssocier.Name = "btn_ajouterHobbyEtAssocier";
            this.btn_ajouterHobbyEtAssocier.Size = new System.Drawing.Size(51, 47);
            this.btn_ajouterHobbyEtAssocier.TabIndex = 7;
            this.btn_ajouterHobbyEtAssocier.Text = "+";
            this.btn_ajouterHobbyEtAssocier.UseVisualStyleBackColor = true;
            this.btn_ajouterHobbyEtAssocier.Click += new System.EventHandler(this.btn_ajouterHobbyEtAssocier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(586, 190);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 222);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ajouterHobbyEtAssocier);
            this.Controls.Add(this.grp_ajouterEtAssocierHobby);
            this.Controls.Add(this.btn_associerEtudiantHobby);
            this.Controls.Add(this.lbl_hobby);
            this.Controls.Add(this.lbl_etudiant);
            this.Controls.Add(this.cmb_Hobby);
            this.Controls.Add(this.cmb_etudiant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_ajouterEtAssocierHobby.ResumeLayout(false);
            this.grp_ajouterEtAssocierHobby.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_etudiant;
        private System.Windows.Forms.ComboBox cmb_Hobby;
        private System.Windows.Forms.Label lbl_etudiant;
        private System.Windows.Forms.Label lbl_hobby;
        private System.Windows.Forms.Button btn_associerEtudiantHobby;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nombreDeHobbyToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_ajouterEtAssocierHobby;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.TextBox txt_hobby;
        private System.Windows.Forms.Button btn_ajouterHobbyEtAssocier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


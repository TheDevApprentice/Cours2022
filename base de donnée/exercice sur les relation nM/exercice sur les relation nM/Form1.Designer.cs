
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
            this.SuspendLayout();
            // 
            // cmb_etudiant
            // 
            this.cmb_etudiant.FormattingEnabled = true;
            this.cmb_etudiant.Location = new System.Drawing.Point(229, 66);
            this.cmb_etudiant.Name = "cmb_etudiant";
            this.cmb_etudiant.Size = new System.Drawing.Size(382, 28);
            this.cmb_etudiant.TabIndex = 0;
            // 
            // cmb_Hobby
            // 
            this.cmb_Hobby.FormattingEnabled = true;
            this.cmb_Hobby.Location = new System.Drawing.Point(229, 170);
            this.cmb_Hobby.Name = "cmb_Hobby";
            this.cmb_Hobby.Size = new System.Drawing.Size(382, 28);
            this.cmb_Hobby.TabIndex = 1;
            // 
            // lbl_etudiant
            // 
            this.lbl_etudiant.AutoSize = true;
            this.lbl_etudiant.Location = new System.Drawing.Point(105, 69);
            this.lbl_etudiant.Name = "lbl_etudiant";
            this.lbl_etudiant.Size = new System.Drawing.Size(64, 20);
            this.lbl_etudiant.TabIndex = 2;
            this.lbl_etudiant.Text = "étudiant";
            // 
            // lbl_hobby
            // 
            this.lbl_hobby.AutoSize = true;
            this.lbl_hobby.Location = new System.Drawing.Point(105, 170);
            this.lbl_hobby.Name = "lbl_hobby";
            this.lbl_hobby.Size = new System.Drawing.Size(54, 20);
            this.lbl_hobby.TabIndex = 3;
            this.lbl_hobby.Text = "Hobby";
            // 
            // btn_associerEtudiantHobby
            // 
            this.btn_associerEtudiantHobby.Location = new System.Drawing.Point(545, 247);
            this.btn_associerEtudiantHobby.Name = "btn_associerEtudiantHobby";
            this.btn_associerEtudiantHobby.Size = new System.Drawing.Size(168, 29);
            this.btn_associerEtudiantHobby.TabIndex = 4;
            this.btn_associerEtudiantHobby.Text = "Associer";
            this.btn_associerEtudiantHobby.UseVisualStyleBackColor = true;
            this.btn_associerEtudiantHobby.Click += new System.EventHandler(this.btn_associerEtudiantHobby_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_associerEtudiantHobby);
            this.Controls.Add(this.lbl_hobby);
            this.Controls.Add(this.lbl_etudiant);
            this.Controls.Add(this.cmb_Hobby);
            this.Controls.Add(this.cmb_etudiant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_etudiant;
        private System.Windows.Forms.ComboBox cmb_Hobby;
        private System.Windows.Forms.Label lbl_etudiant;
        private System.Windows.Forms.Label lbl_hobby;
        private System.Windows.Forms.Button btn_associerEtudiantHobby;
    }
}


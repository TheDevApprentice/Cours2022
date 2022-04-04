
namespace exercice_sur_les_relation_nM
{
    partial class NombreDehobby
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
            this.cmb_etudiantNombreDeHobby = new System.Windows.Forms.ComboBox();
            this.btn_calcul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_etudiantNombreDeHobby
            // 
            this.cmb_etudiantNombreDeHobby.FormattingEnabled = true;
            this.cmb_etudiantNombreDeHobby.Location = new System.Drawing.Point(258, 144);
            this.cmb_etudiantNombreDeHobby.Name = "cmb_etudiantNombreDeHobby";
            this.cmb_etudiantNombreDeHobby.Size = new System.Drawing.Size(363, 28);
            this.cmb_etudiantNombreDeHobby.TabIndex = 0;
            this.cmb_etudiantNombreDeHobby.SelectedIndexChanged += new System.EventHandler(this.cmb_etudiantNombreDeHobby_SelectedIndexChanged);
            // 
            // btn_calcul
            // 
            this.btn_calcul.Location = new System.Drawing.Point(527, 268);
            this.btn_calcul.Name = "btn_calcul";
            this.btn_calcul.Size = new System.Drawing.Size(94, 29);
            this.btn_calcul.TabIndex = 1;
            this.btn_calcul.Text = "calcul";
            this.btn_calcul.UseVisualStyleBackColor = true;
            this.btn_calcul.Click += new System.EventHandler(this.btn_calcul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "nombre de hobbys";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NombreDehobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcul);
            this.Controls.Add(this.cmb_etudiantNombreDeHobby);
            this.Name = "NombreDehobby";
            this.Text = "NombreDehobby";
            this.Load += new System.EventHandler(this.NombreDehobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_etudiantNombreDeHobby;
        private System.Windows.Forms.Button btn_calcul;
        private System.Windows.Forms.Label label1;
    }
}

namespace Programme_de_gestion_de_livraison_POO
{
    partial class entreeCamion
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
            this.txt_poids = new System.Windows.Forms.TextBox();
            this.txt_volume = new System.Windows.Forms.TextBox();
            this.lbl_poids = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.btn_validateEntreeCamion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_poids
            // 
            this.txt_poids.Location = new System.Drawing.Point(140, 32);
            this.txt_poids.Name = "txt_poids";
            this.txt_poids.Size = new System.Drawing.Size(160, 27);
            this.txt_poids.TabIndex = 0;
            // 
            // txt_volume
            // 
            this.txt_volume.Location = new System.Drawing.Point(140, 87);
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(160, 27);
            this.txt_volume.TabIndex = 1;
            // 
            // lbl_poids
            // 
            this.lbl_poids.AutoSize = true;
            this.lbl_poids.Location = new System.Drawing.Point(45, 35);
            this.lbl_poids.Name = "lbl_poids";
            this.lbl_poids.Size = new System.Drawing.Size(44, 20);
            this.lbl_poids.TabIndex = 2;
            this.lbl_poids.Text = "Poids";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(45, 94);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(59, 20);
            this.lbl_volume.TabIndex = 3;
            this.lbl_volume.Text = "Volume";
            // 
            // btn_validateEntreeCamion
            // 
            this.btn_validateEntreeCamion.Location = new System.Drawing.Point(237, 140);
            this.btn_validateEntreeCamion.Name = "btn_validateEntreeCamion";
            this.btn_validateEntreeCamion.Size = new System.Drawing.Size(94, 29);
            this.btn_validateEntreeCamion.TabIndex = 4;
            this.btn_validateEntreeCamion.Text = "Valider";
            this.btn_validateEntreeCamion.UseVisualStyleBackColor = true;
            this.btn_validateEntreeCamion.Click += new System.EventHandler(this.btn_validateEntreeCamion_Click);
            // 
            // entreeCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.btn_validateEntreeCamion);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_poids);
            this.Controls.Add(this.txt_volume);
            this.Controls.Add(this.txt_poids);
            this.Name = "entreeCamion";
            this.Text = "entreeCamion";
            this.Load += new System.EventHandler(this.entreeCamion_Load);
          

        }

        #endregion

        private System.Windows.Forms.TextBox txt_poids;
        private System.Windows.Forms.TextBox txt_volume;
        private System.Windows.Forms.Label lbl_poids;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Button btn_validateEntreeCamion;
    }
}
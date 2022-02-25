
namespace Programme_de_gestion_de_livraison_POO
{
    partial class EntreeVoyage
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
            this.btn_entreeDestination = new System.Windows.Forms.Button();
            this.txt_entreeDestiantion = new System.Windows.Forms.TextBox();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_entreeDestination
            // 
            this.btn_entreeDestination.Location = new System.Drawing.Point(204, 159);
            this.btn_entreeDestination.Name = "btn_entreeDestination";
            this.btn_entreeDestination.Size = new System.Drawing.Size(94, 29);
            this.btn_entreeDestination.TabIndex = 0;
            this.btn_entreeDestination.Text = "Ajouter voyage";
            this.btn_entreeDestination.UseVisualStyleBackColor = true;
            this.btn_entreeDestination.Click += new System.EventHandler(this.btn_entreeDestination_Click);
            // 
            // txt_entreeDestiantion
            // 
            this.txt_entreeDestiantion.Location = new System.Drawing.Point(103, 71);
            this.txt_entreeDestiantion.Name = "txt_entreeDestiantion";
            this.txt_entreeDestiantion.Size = new System.Drawing.Size(220, 27);
            this.txt_entreeDestiantion.TabIndex = 1;
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Location = new System.Drawing.Point(12, 74);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(85, 20);
            this.lbl_destination.TabIndex = 2;
            this.lbl_destination.Text = "Destination";
            // 
            // EntréeVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 221);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.txt_entreeDestiantion);
            this.Controls.Add(this.btn_entreeDestination);
            this.Name = "EntreeVoyage";
            this.Text = "EntreeVoyage";
            this.Load += new System.EventHandler(this.EntreeVoyage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entreeDestination;
        private System.Windows.Forms.TextBox txt_entreeDestiantion;
        private System.Windows.Forms.Label lbl_destination;
    }
}
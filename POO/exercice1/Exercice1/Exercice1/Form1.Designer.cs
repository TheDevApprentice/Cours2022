
namespace Exercice1
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
            this.txt_Aajouter = new System.Windows.Forms.TextBox();
            this.txt_Aretirer = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.btn_debug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Aajouter
            // 
            this.txt_Aajouter.Location = new System.Drawing.Point(295, 13);
            this.txt_Aajouter.Name = "txt_Aajouter";
            this.txt_Aajouter.Size = new System.Drawing.Size(250, 23);
            this.txt_Aajouter.TabIndex = 0;
            // 
            // txt_Aretirer
            // 
            this.txt_Aretirer.Location = new System.Drawing.Point(295, 61);
            this.txt_Aretirer.Name = "txt_Aretirer";
            this.txt_Aretirer.Size = new System.Drawing.Size(250, 23);
            this.txt_Aretirer.TabIndex = 1;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(567, 13);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(567, 61);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(75, 23);
            this.btn_retirer.TabIndex = 4;
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // btn_debug
            // 
            this.btn_debug.Location = new System.Drawing.Point(567, 111);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(75, 23);
            this.btn_debug.TabIndex = 5;
            this.btn_debug.Text = "Debug";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_Aretirer);
            this.Controls.Add(this.txt_Aajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Aajouter;
        private System.Windows.Forms.TextBox txt_Aretirer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.Button btn_debug;
    }
}


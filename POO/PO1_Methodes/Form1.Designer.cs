
namespace PO1_Methodes
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
            this.pictureBox_course = new System.Windows.Forms.PictureBox();
            this.button_avancer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_course
            // 
            this.pictureBox_course.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_course.Name = "pictureBox_course";
            this.pictureBox_course.Size = new System.Drawing.Size(776, 473);
            this.pictureBox_course.TabIndex = 0;
            this.pictureBox_course.TabStop = false;
            this.pictureBox_course.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_course_Paint);
            // 
            // button_avancer
            // 
            this.button_avancer.Location = new System.Drawing.Point(12, 491);
            this.button_avancer.Name = "button_avancer";
            this.button_avancer.Size = new System.Drawing.Size(78, 31);
            this.button_avancer.TabIndex = 1;
            this.button_avancer.Text = "Avancer";
            this.button_avancer.UseVisualStyleBackColor = true;
            this.button_avancer.Click += new System.EventHandler(this.button_avancer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 534);
            this.Controls.Add(this.button_avancer);
            this.Controls.Add(this.pictureBox_course);
            this.Name = "Form1";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_course;
        private System.Windows.Forms.Button button_avancer;
    }
}


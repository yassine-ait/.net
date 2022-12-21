namespace riad_yassine_project
{
    partial class Form2
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
            this.user_simple = new System.Windows.Forms.Button();
            this.professeur = new System.Windows.Forms.Button();
            this.etudiant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_simple
            // 
            this.user_simple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.user_simple.Location = new System.Drawing.Point(157, 147);
            this.user_simple.Name = "user_simple";
            this.user_simple.Size = new System.Drawing.Size(235, 56);
            this.user_simple.TabIndex = 0;
            this.user_simple.Text = "user simple";
            this.user_simple.UseVisualStyleBackColor = true;
            // 
            // professeur
            // 
            this.professeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.professeur.Location = new System.Drawing.Point(742, 147);
            this.professeur.Name = "professeur";
            this.professeur.Size = new System.Drawing.Size(235, 56);
            this.professeur.TabIndex = 1;
            this.professeur.Text = "professeur";
            this.professeur.UseVisualStyleBackColor = true;
            // 
            // etudiant
            // 
            this.etudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.etudiant.Location = new System.Drawing.Point(456, 147);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(235, 56);
            this.etudiant.TabIndex = 2;
            this.etudiant.Text = "etudiant";
            this.etudiant.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 525);
            this.Controls.Add(this.etudiant);
            this.Controls.Add(this.professeur);
            this.Controls.Add(this.user_simple);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button user_simple;
        private System.Windows.Forms.Button professeur;
        private System.Windows.Forms.Button etudiant;
    }
}
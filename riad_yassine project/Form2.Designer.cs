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
            this.etudient = new System.Windows.Forms.Button();
            this.classe = new System.Windows.Forms.Button();
            this.filiere = new System.Windows.Forms.Button();
            this.pay_etudient = new System.Windows.Forms.Button();
            this.ecole = new System.Windows.Forms.Button();
            this.pay_professeur = new System.Windows.Forms.Button();
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
            // etudient
            // 
            this.etudient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.etudient.Location = new System.Drawing.Point(456, 147);
            this.etudient.Name = "etudient";
            this.etudient.Size = new System.Drawing.Size(235, 56);
            this.etudient.TabIndex = 2;
            this.etudient.Text = "etudient";
            this.etudient.UseVisualStyleBackColor = true;
            // 
            // classe
            // 
            this.classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.classe.Location = new System.Drawing.Point(157, 255);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(235, 56);
            this.classe.TabIndex = 3;
            this.classe.Text = "classe";
            this.classe.UseVisualStyleBackColor = true;
            // 
            // filiere
            // 
            this.filiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filiere.Location = new System.Drawing.Point(456, 255);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(235, 56);
            this.filiere.TabIndex = 4;
            this.filiere.Text = "filiere";
            this.filiere.UseVisualStyleBackColor = true;
            // 
            // pay_etudient
            // 
            this.pay_etudient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pay_etudient.Location = new System.Drawing.Point(742, 255);
            this.pay_etudient.Name = "pay_etudient";
            this.pay_etudient.Size = new System.Drawing.Size(235, 56);
            this.pay_etudient.TabIndex = 5;
            this.pay_etudient.Text = "pay etudient";
            this.pay_etudient.UseVisualStyleBackColor = true;
            // 
            // ecole
            // 
            this.ecole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ecole.Location = new System.Drawing.Point(157, 350);
            this.ecole.Name = "ecole";
            this.ecole.Size = new System.Drawing.Size(235, 56);
            this.ecole.TabIndex = 6;
            this.ecole.Text = "ecole";
            this.ecole.UseVisualStyleBackColor = true;
            // 
            // pay_professeur
            // 
            this.pay_professeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pay_professeur.Location = new System.Drawing.Point(456, 350);
            this.pay_professeur.Name = "pay_professeur";
            this.pay_professeur.Size = new System.Drawing.Size(235, 56);
            this.pay_professeur.TabIndex = 7;
            this.pay_professeur.Text = "pay professeur";
            this.pay_professeur.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 525);
            this.Controls.Add(this.pay_professeur);
            this.Controls.Add(this.ecole);
            this.Controls.Add(this.pay_etudient);
            this.Controls.Add(this.filiere);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.etudient);
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
        private System.Windows.Forms.Button etudient;
        private System.Windows.Forms.Button classe;
        private System.Windows.Forms.Button filiere;
        private System.Windows.Forms.Button pay_etudient;
        private System.Windows.Forms.Button ecole;
        private System.Windows.Forms.Button pay_professeur;
    }
}
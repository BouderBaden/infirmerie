
namespace DevoirDemainR6
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.identifiant = new System.Windows.Forms.TextBox();
            this.motdepasse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fail = new System.Windows.Forms.Label();
            this.sucess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // identifiant
            // 
            this.identifiant.Location = new System.Drawing.Point(193, 66);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(294, 22);
            this.identifiant.TabIndex = 0;
            // 
            // motdepasse
            // 
            this.motdepasse.Location = new System.Drawing.Point(193, 135);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(294, 22);
            this.motdepasse.TabIndex = 1;
            this.motdepasse.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(193, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identifiant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de Passe :";
            // 
            // Fail
            // 
            this.Fail.AutoSize = true;
            this.Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fail.ForeColor = System.Drawing.Color.DarkRed;
            this.Fail.Location = new System.Drawing.Point(233, 170);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(47, 25);
            this.Fail.TabIndex = 6;
            this.Fail.Text = "Fail";
            this.Fail.Visible = false;
            // 
            // sucess
            // 
            this.sucess.AutoSize = true;
            this.sucess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess.ForeColor = System.Drawing.Color.Lime;
            this.sucess.Location = new System.Drawing.Point(272, 170);
            this.sucess.Name = "sucess";
            this.sucess.Size = new System.Drawing.Size(80, 25);
            this.sucess.TabIndex = 7;
            this.sucess.Text = "sucess";
            this.sucess.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Page D\'acceuil";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sucess);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.identifiant);
            this.Name = "Form1";
            this.Text = "Formulaire de Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.TextBox motdepasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Fail;
        private System.Windows.Forms.Label sucess;
        private System.Windows.Forms.Label label4;
    }
}


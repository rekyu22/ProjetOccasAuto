namespace Co_n
{
    partial class FormConnexion
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subscriptionSubmit = new System.Windows.Forms.Button();
            this.subscription = new System.Windows.Forms.Label();
            this.hideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(320, 169);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(173, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(320, 245);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(173, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(320, 142);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Identifiant";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(317, 219);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Mot de passe";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(342, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(123, 25);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Bienvenue";
            // 
            // subscriptionSubmit
            // 
            this.subscriptionSubmit.Location = new System.Drawing.Point(371, 297);
            this.subscriptionSubmit.Name = "subscriptionSubmit";
            this.subscriptionSubmit.Size = new System.Drawing.Size(75, 23);
            this.subscriptionSubmit.TabIndex = 5;
            this.subscriptionSubmit.Text = "Connexion";
            this.subscriptionSubmit.UseVisualStyleBackColor = true;
            this.subscriptionSubmit.Click += new System.EventHandler(this.subscriptionSubmit_Click);
            // 
            // subscription
            // 
            this.subscription.AutoSize = true;
            this.subscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscription.ForeColor = System.Drawing.Color.Black;
            this.subscription.Location = new System.Drawing.Point(320, 268);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(55, 13);
            this.subscription.TabIndex = 7;
            this.subscription.Text = "Inscription";
            // 
            // hideLabel
            // 
            this.hideLabel.AutoSize = true;
            this.hideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideLabel.Location = new System.Drawing.Point(499, 245);
            this.hideLabel.Name = "hideLabel";
            this.hideLabel.Size = new System.Drawing.Size(22, 24);
            this.hideLabel.TabIndex = 8;
            this.hideLabel.Text = "+";
            this.hideLabel.Click += new System.EventHandler(this.hideLabel_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hideLabel);
            this.Controls.Add(this.subscription);
            this.Controls.Add(this.subscriptionSubmit);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button subscriptionSubmit;
        private System.Windows.Forms.Label subscription;
        private System.Windows.Forms.Label hideLabel;
    }
}


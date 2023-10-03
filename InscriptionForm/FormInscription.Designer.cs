namespace InscriptionForm
{
    partial class FormInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscription));
            this.subscriptionLabel = new System.Windows.Forms.Label();
            this.idTextBoxInscr = new System.Windows.Forms.TextBox();
            this.idLabelnscr = new System.Windows.Forms.Label();
            this.passwordLabelInscr = new System.Windows.Forms.Label();
            this.passwordTextBoxInscr = new System.Windows.Forms.TextBox();
            this.hideLab = new System.Windows.Forms.Label();
            this.InscriptionSubmit = new System.Windows.Forms.Button();
            this.acceptLabel = new System.Windows.Forms.Label();
            this.refuseLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.PictureBox();
            this.clsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.AutoSize = true;
            this.subscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionLabel.Location = new System.Drawing.Point(346, 86);
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(121, 25);
            this.subscriptionLabel.TabIndex = 5;
            this.subscriptionLabel.Text = "Inscription";
            // 
            // idTextBoxInscr
            // 
            this.idTextBoxInscr.Location = new System.Drawing.Point(318, 166);
            this.idTextBoxInscr.Name = "idTextBoxInscr";
            this.idTextBoxInscr.Size = new System.Drawing.Size(173, 20);
            this.idTextBoxInscr.TabIndex = 6;
            this.idTextBoxInscr.TextChanged += new System.EventHandler(this.idTextBoxInscr_TextChanged);
            // 
            // idLabelnscr
            // 
            this.idLabelnscr.AutoSize = true;
            this.idLabelnscr.Location = new System.Drawing.Point(324, 140);
            this.idLabelnscr.Name = "idLabelnscr";
            this.idLabelnscr.Size = new System.Drawing.Size(53, 13);
            this.idLabelnscr.TabIndex = 7;
            this.idLabelnscr.Text = "Identifiant";
            // 
            // passwordLabelInscr
            // 
            this.passwordLabelInscr.AutoSize = true;
            this.passwordLabelInscr.Location = new System.Drawing.Point(324, 213);
            this.passwordLabelInscr.Name = "passwordLabelInscr";
            this.passwordLabelInscr.Size = new System.Drawing.Size(71, 13);
            this.passwordLabelInscr.TabIndex = 8;
            this.passwordLabelInscr.Text = "Mot de passe";
            // 
            // passwordTextBoxInscr
            // 
            this.passwordTextBoxInscr.Location = new System.Drawing.Point(318, 239);
            this.passwordTextBoxInscr.Name = "passwordTextBoxInscr";
            this.passwordTextBoxInscr.Size = new System.Drawing.Size(173, 20);
            this.passwordTextBoxInscr.TabIndex = 9;
            this.passwordTextBoxInscr.UseSystemPasswordChar = true;
            this.passwordTextBoxInscr.TextChanged += new System.EventHandler(this.passwordTextBoxInscr_TextChanged);
            // 
            // hideLab
            // 
            this.hideLab.AutoSize = true;
            this.hideLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideLab.Location = new System.Drawing.Point(497, 239);
            this.hideLab.Name = "hideLab";
            this.hideLab.Size = new System.Drawing.Size(22, 24);
            this.hideLab.TabIndex = 10;
            this.hideLab.Text = "+";
            this.hideLab.Click += new System.EventHandler(this.hideLab_Click);
            // 
            // InscriptionSubmit
            // 
            this.InscriptionSubmit.Location = new System.Drawing.Point(368, 279);
            this.InscriptionSubmit.Name = "InscriptionSubmit";
            this.InscriptionSubmit.Size = new System.Drawing.Size(75, 23);
            this.InscriptionSubmit.TabIndex = 11;
            this.InscriptionSubmit.Text = "Inscription";
            this.InscriptionSubmit.UseVisualStyleBackColor = true;
            this.InscriptionSubmit.Click += new System.EventHandler(this.InscriptionSubmit_Click);
            // 
            // acceptLabel
            // 
            this.acceptLabel.AutoSize = true;
            this.acceptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.acceptLabel.Location = new System.Drawing.Point(584, 111);
            this.acceptLabel.Name = "acceptLabel";
            this.acceptLabel.Size = new System.Drawing.Size(179, 24);
            this.acceptLabel.TabIndex = 12;
            this.acceptLabel.Text = "Inscription validée";
            this.acceptLabel.Visible = false;
            // 
            // refuseLabel
            // 
            this.refuseLabel.AutoSize = true;
            this.refuseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refuseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.refuseLabel.Location = new System.Drawing.Point(584, 152);
            this.refuseLabel.Name = "refuseLabel";
            this.refuseLabel.Size = new System.Drawing.Size(182, 24);
            this.refuseLabel.TabIndex = 13;
            this.refuseLabel.Text = "Inscription refusée";
            this.refuseLabel.Visible = false;
            // 
            // minBox
            // 
            this.minBox.Image = ((System.Drawing.Image)(resources.GetObject("minBox.Image")));
            this.minBox.Location = new System.Drawing.Point(722, 12);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(30, 30);
            this.minBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minBox.TabIndex = 15;
            this.minBox.TabStop = false;
            this.minBox.Click += new System.EventHandler(this.minBox_Click);
            // 
            // clsBox
            // 
            this.clsBox.Image = ((System.Drawing.Image)(resources.GetObject("clsBox.Image")));
            this.clsBox.Location = new System.Drawing.Point(758, 12);
            this.clsBox.Name = "clsBox";
            this.clsBox.Size = new System.Drawing.Size(30, 30);
            this.clsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clsBox.TabIndex = 16;
            this.clsBox.TabStop = false;
            this.clsBox.Click += new System.EventHandler(this.clsBox_Click);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.clsBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.refuseLabel);
            this.Controls.Add(this.acceptLabel);
            this.Controls.Add(this.InscriptionSubmit);
            this.Controls.Add(this.hideLab);
            this.Controls.Add(this.passwordTextBoxInscr);
            this.Controls.Add(this.passwordLabelInscr);
            this.Controls.Add(this.idLabelnscr);
            this.Controls.Add(this.idTextBoxInscr);
            this.Controls.Add(this.subscriptionLabel);
            this.Name = "FormInscription";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subscriptionLabel;
        private System.Windows.Forms.TextBox idTextBoxInscr;
        private System.Windows.Forms.Label idLabelnscr;
        private System.Windows.Forms.Label passwordLabelInscr;
        private System.Windows.Forms.TextBox passwordTextBoxInscr;
        private System.Windows.Forms.Label hideLab;
        private System.Windows.Forms.Button InscriptionSubmit;
        private System.Windows.Forms.Label acceptLabel;
        private System.Windows.Forms.Label refuseLabel;
        private System.Windows.Forms.PictureBox minBox;
        private System.Windows.Forms.PictureBox clsBox;
    }
}


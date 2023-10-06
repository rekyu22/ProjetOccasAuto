namespace OccasAuto
{
    partial class Submit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Submit));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewAuto = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.closBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updtTB = new System.Windows.Forms.TextBox();
            this.UpdtLab = new System.Windows.Forms.Label();
            this.updCbBox = new System.Windows.Forms.ComboBox();
            this.updtBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.VilleLab = new System.Windows.Forms.Label();
            this.CPLab = new System.Windows.Forms.Label();
            this.adresseLab = new System.Windows.Forms.Label();
            this.nomLab = new System.Windows.Forms.Label();
            this.prenomLab = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.cpTB = new System.Windows.Forms.TextBox();
            this.adrTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.idLab = new System.Windows.Forms.Label();
            this.updtIdTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Critères de sélection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ville",
            "Nom",
            "Code postal"});
            this.comboBox1.Location = new System.Drawing.Point(139, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 7;
            // 
            // listViewAuto
            // 
            this.listViewAuto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nom,
            this.Prenom,
            this.Adresse,
            this.codePostal,
            this.Ville});
            this.listViewAuto.FullRowSelect = true;
            this.listViewAuto.HideSelection = false;
            this.listViewAuto.Location = new System.Drawing.Point(6, 63);
            this.listViewAuto.Name = "listViewAuto";
            this.listViewAuto.Size = new System.Drawing.Size(577, 270);
            this.listViewAuto.TabIndex = 8;
            this.listViewAuto.UseCompatibleStateImageBehavior = false;
            this.listViewAuto.View = System.Windows.Forms.View.Details;
            this.listViewAuto.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAuto_ItemSelectionChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 64;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 108;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 88;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 83;
            // 
            // codePostal
            // 
            this.codePostal.Text = "codePostal";
            this.codePostal.Width = 122;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 149;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(722, 12);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(30, 30);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBox.TabIndex = 17;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // closBox
            // 
            this.closBox.Image = ((System.Drawing.Image)(resources.GetObject("closBox.Image")));
            this.closBox.Location = new System.Drawing.Point(758, 12);
            this.closBox.Name = "closBox";
            this.closBox.Size = new System.Drawing.Size(30, 30);
            this.closBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closBox.TabIndex = 18;
            this.closBox.TabStop = false;
            this.closBox.Click += new System.EventHandler(this.closBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 419);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listViewAuto);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updtIdTb);
            this.tabPage2.Controls.Add(this.updtTB);
            this.tabPage2.Controls.Add(this.UpdtLab);
            this.tabPage2.Controls.Add(this.updCbBox);
            this.tabPage2.Controls.Add(this.updtBtn);
            this.tabPage2.Controls.Add(this.dltBtn);
            this.tabPage2.Controls.Add(this.addBtn);
            this.tabPage2.Controls.Add(this.VilleLab);
            this.tabPage2.Controls.Add(this.CPLab);
            this.tabPage2.Controls.Add(this.adresseLab);
            this.tabPage2.Controls.Add(this.nomLab);
            this.tabPage2.Controls.Add(this.prenomLab);
            this.tabPage2.Controls.Add(this.cityTB);
            this.tabPage2.Controls.Add(this.cpTB);
            this.tabPage2.Controls.Add(this.adrTB);
            this.tabPage2.Controls.Add(this.nameTB);
            this.tabPage2.Controls.Add(this.surnameTB);
            this.tabPage2.Controls.Add(this.idTB);
            this.tabPage2.Controls.Add(this.idLab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updtTB
            // 
            this.updtTB.Location = new System.Drawing.Point(540, 177);
            this.updtTB.Name = "updtTB";
            this.updtTB.Size = new System.Drawing.Size(100, 20);
            this.updtTB.TabIndex = 17;
            // 
            // UpdtLab
            // 
            this.UpdtLab.AutoSize = true;
            this.UpdtLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdtLab.Location = new System.Drawing.Point(556, 39);
            this.UpdtLab.Name = "UpdtLab";
            this.UpdtLab.Size = new System.Drawing.Size(97, 25);
            this.UpdtLab.TabIndex = 16;
            this.UpdtLab.Text = "Modifier";
            // 
            // updCbBox
            // 
            this.updCbBox.FormattingEnabled = true;
            this.updCbBox.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Adresse",
            "Code postal",
            "Ville"});
            this.updCbBox.Location = new System.Drawing.Point(540, 132);
            this.updCbBox.Name = "updCbBox";
            this.updCbBox.Size = new System.Drawing.Size(121, 21);
            this.updCbBox.TabIndex = 15;
            // 
            // updtBtn
            // 
            this.updtBtn.Location = new System.Drawing.Point(532, 304);
            this.updtBtn.Name = "updtBtn";
            this.updtBtn.Size = new System.Drawing.Size(75, 23);
            this.updtBtn.TabIndex = 14;
            this.updtBtn.Text = "Modifier";
            this.updtBtn.UseVisualStyleBackColor = true;
            this.updtBtn.Click += new System.EventHandler(this.updtBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(102, 304);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(75, 23);
            this.dltBtn.TabIndex = 13;
            this.dltBtn.Text = "Supprimer";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(324, 304);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // VilleLab
            // 
            this.VilleLab.AutoSize = true;
            this.VilleLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VilleLab.Location = new System.Drawing.Point(288, 220);
            this.VilleLab.Name = "VilleLab";
            this.VilleLab.Size = new System.Drawing.Size(58, 25);
            this.VilleLab.TabIndex = 11;
            this.VilleLab.Text = "Ville";
            // 
            // CPLab
            // 
            this.CPLab.AutoSize = true;
            this.CPLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPLab.Location = new System.Drawing.Point(206, 171);
            this.CPLab.Name = "CPLab";
            this.CPLab.Size = new System.Drawing.Size(140, 25);
            this.CPLab.TabIndex = 10;
            this.CPLab.Text = "Code Postal";
            // 
            // adresseLab
            // 
            this.adresseLab.AutoSize = true;
            this.adresseLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseLab.Location = new System.Drawing.Point(244, 127);
            this.adresseLab.Name = "adresseLab";
            this.adresseLab.Size = new System.Drawing.Size(98, 25);
            this.adresseLab.TabIndex = 9;
            this.adresseLab.Text = "Adresse";
            // 
            // nomLab
            // 
            this.nomLab.AutoSize = true;
            this.nomLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLab.Location = new System.Drawing.Point(283, 40);
            this.nomLab.Name = "nomLab";
            this.nomLab.Size = new System.Drawing.Size(59, 25);
            this.nomLab.TabIndex = 8;
            this.nomLab.Text = "Nom";
            // 
            // prenomLab
            // 
            this.prenomLab.AutoSize = true;
            this.prenomLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLab.Location = new System.Drawing.Point(250, 81);
            this.prenomLab.Name = "prenomLab";
            this.prenomLab.Size = new System.Drawing.Size(92, 25);
            this.prenomLab.TabIndex = 7;
            this.prenomLab.Text = "Prenom";
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(388, 226);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(100, 20);
            this.cityTB.TabIndex = 6;
            // 
            // cpTB
            // 
            this.cpTB.Location = new System.Drawing.Point(388, 176);
            this.cpTB.Name = "cpTB";
            this.cpTB.Size = new System.Drawing.Size(100, 20);
            this.cpTB.TabIndex = 5;
            // 
            // adrTB
            // 
            this.adrTB.Location = new System.Drawing.Point(388, 132);
            this.adrTB.Name = "adrTB";
            this.adrTB.Size = new System.Drawing.Size(100, 20);
            this.adrTB.TabIndex = 4;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(388, 87);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 3;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(388, 40);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(100, 20);
            this.surnameTB.TabIndex = 2;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(102, 44);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 1;
            // 
            // idLab
            // 
            this.idLab.AutoSize = true;
            this.idLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLab.Location = new System.Drawing.Point(535, 87);
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(31, 25);
            this.idLab.TabIndex = 0;
            this.idLab.Text = "Id";
            // 
            // updtIdTb
            // 
            this.updtIdTb.Location = new System.Drawing.Point(561, 92);
            this.updtIdTb.Name = "updtIdTb";
            this.updtIdTb.Size = new System.Drawing.Size(100, 20);
            this.updtIdTb.TabIndex = 18;
            // 
            // Submit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.closBox);
            this.Controls.Add(this.minimizeBox);
            this.Name = "Submit";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listViewAuto;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader codePostal;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox closBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label idLab;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label VilleLab;
        private System.Windows.Forms.Label CPLab;
        private System.Windows.Forms.Label adresseLab;
        private System.Windows.Forms.Label nomLab;
        private System.Windows.Forms.Label prenomLab;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox cpTB;
        private System.Windows.Forms.TextBox adrTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label UpdtLab;
        private System.Windows.Forms.ComboBox updCbBox;
        private System.Windows.Forms.Button updtBtn;
        private System.Windows.Forms.TextBox updtTB;
        private System.Windows.Forms.TextBox updtIdTb;
    }
}


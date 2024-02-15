namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class TarifGui
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
            lbl_secteur = new Label();
            lbl_liaison = new Label();
            lbl_periode = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            gbx_tarif = new GroupBox();
            lbl_tarif = new Label();
            lbl_categorie_type = new Label();
            btn_confirm = new Button();
            lbx_secteur = new ListBox();
            gbx_tarif.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_secteur
            // 
            lbl_secteur.AutoSize = true;
            lbl_secteur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_secteur.Location = new Point(29, 35);
            lbl_secteur.Name = "lbl_secteur";
            lbl_secteur.Size = new Size(81, 21);
            lbl_secteur.TabIndex = 0;
            lbl_secteur.Text = "Secteurs :";
            // 
            // lbl_liaison
            // 
            lbl_liaison.AutoSize = true;
            lbl_liaison.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_liaison.Location = new Point(23, 206);
            lbl_liaison.Name = "lbl_liaison";
            lbl_liaison.Size = new Size(68, 21);
            lbl_liaison.TabIndex = 1;
            lbl_liaison.Text = "Liaison :";
            // 
            // lbl_periode
            // 
            lbl_periode.AutoSize = true;
            lbl_periode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_periode.Location = new Point(36, 497);
            lbl_periode.Name = "lbl_periode";
            lbl_periode.Size = new Size(74, 21);
            lbl_periode.TabIndex = 2;
            lbl_periode.Text = "Période :";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // gbx_tarif
            // 
            gbx_tarif.Controls.Add(lbl_tarif);
            gbx_tarif.Controls.Add(lbl_categorie_type);
            gbx_tarif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbx_tarif.Location = new Point(159, 35);
            gbx_tarif.Name = "gbx_tarif";
            gbx_tarif.Size = new Size(389, 423);
            gbx_tarif.TabIndex = 4;
            gbx_tarif.TabStop = false;
            gbx_tarif.Text = "Tarifs par Catégorie-Type";
            // 
            // lbl_tarif
            // 
            lbl_tarif.AutoSize = true;
            lbl_tarif.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tarif.Location = new Point(213, 41);
            lbl_tarif.Name = "lbl_tarif";
            lbl_tarif.Size = new Size(32, 15);
            lbl_tarif.TabIndex = 1;
            lbl_tarif.Text = "Tarif";
            // 
            // lbl_categorie_type
            // 
            lbl_categorie_type.AutoSize = true;
            lbl_categorie_type.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_categorie_type.Location = new Point(26, 39);
            lbl_categorie_type.Name = "lbl_categorie_type";
            lbl_categorie_type.Size = new Size(98, 15);
            lbl_categorie_type.TabIndex = 0;
            lbl_categorie_type.Text = "Catégorie - Type";
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(443, 498);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(128, 23);
            btn_confirm.TabIndex = 5;
            btn_confirm.Text = "Ajouter";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbx_secteur
            // 
            lbx_secteur.FormattingEnabled = true;
            lbx_secteur.ItemHeight = 15;
            lbx_secteur.Location = new Point(23, 59);
            lbx_secteur.Name = "lbx_secteur";
            lbx_secteur.Size = new Size(120, 94);
            lbx_secteur.TabIndex = 2;
            // 
            // TarifGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 545);
            Controls.Add(lbx_secteur);
            Controls.Add(btn_confirm);
            Controls.Add(gbx_tarif);
            Controls.Add(lbl_periode);
            Controls.Add(lbl_liaison);
            Controls.Add(lbl_secteur);
            Name = "TarifGui";
            Text = "Tarif pour une liaison et une période";
            Load += Tarif_Load;
            gbx_tarif.ResumeLayout(false);
            gbx_tarif.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_secteur;
        private Label lbl_liaison;
        private Label lbl_periode;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private GroupBox gbx_tarif;
        private Button btn_confirm;
        private Label lbl_categorie_type;
        private Label lbl_tarif;
        private TextBox textBox1;
        private ListBox lbx_secteur;
    }
}
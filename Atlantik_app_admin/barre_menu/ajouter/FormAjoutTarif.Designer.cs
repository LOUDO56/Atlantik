namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class FormAjoutTarif
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
            gbx_tarif = new GroupBox();
            lbl_tarif = new Label();
            lbl_categorie_type = new Label();
            btn_confirm = new Button();
            lbx_secteur = new ListBox();
            cmb_liaison = new ComboBox();
            cmb_periode = new ComboBox();
            pnl_bottom = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbx_tarif.SuspendLayout();
            pnl_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_secteur
            // 
            lbl_secteur.AutoSize = true;
            lbl_secteur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_secteur.Location = new Point(23, 35);
            lbl_secteur.Name = "lbl_secteur";
            lbl_secteur.Size = new Size(81, 21);
            lbl_secteur.TabIndex = 0;
            lbl_secteur.Text = "Secteurs :";
            // 
            // lbl_liaison
            // 
            lbl_liaison.AutoSize = true;
            lbl_liaison.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_liaison.Location = new Point(23, 235);
            lbl_liaison.Name = "lbl_liaison";
            lbl_liaison.Size = new Size(68, 21);
            lbl_liaison.TabIndex = 1;
            lbl_liaison.Text = "Liaison :";
            // 
            // lbl_periode
            // 
            lbl_periode.AutoSize = true;
            lbl_periode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_periode.Location = new Point(26, 28);
            lbl_periode.Name = "lbl_periode";
            lbl_periode.Size = new Size(74, 21);
            lbl_periode.TabIndex = 2;
            lbl_periode.Text = "Période :";
            // 
            // gbx_tarif
            // 
            gbx_tarif.Controls.Add(lbl_tarif);
            gbx_tarif.Controls.Add(lbl_categorie_type);
            gbx_tarif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbx_tarif.Location = new Point(185, 35);
            gbx_tarif.Name = "gbx_tarif";
            gbx_tarif.Size = new Size(377, 423);
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
            btn_confirm.Location = new Point(437, 25);
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
            lbx_secteur.Size = new Size(140, 154);
            lbx_secteur.TabIndex = 2;
            lbx_secteur.SelectedIndexChanged += lbx_secteur_SelectedIndexChanged;
            // 
            // cmb_liaison
            // 
            cmb_liaison.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_liaison.FormattingEnabled = true;
            cmb_liaison.Location = new Point(23, 259);
            cmb_liaison.Name = "cmb_liaison";
            cmb_liaison.Size = new Size(141, 23);
            cmb_liaison.TabIndex = 2;
            // 
            // cmb_periode
            // 
            cmb_periode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_periode.FormattingEnabled = true;
            cmb_periode.Location = new Point(106, 28);
            cmb_periode.Name = "cmb_periode";
            cmb_periode.Size = new Size(180, 23);
            cmb_periode.TabIndex = 2;
            // 
            // pnl_bottom
            // 
            pnl_bottom.Controls.Add(lbl_periode);
            pnl_bottom.Controls.Add(cmb_periode);
            pnl_bottom.Controls.Add(btn_confirm);
            pnl_bottom.Location = new Point(-3, 464);
            pnl_bottom.Name = "pnl_bottom";
            pnl_bottom.Size = new Size(589, 70);
            pnl_bottom.TabIndex = 2;
            // 
            // FormAjoutTarif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 545);
            Controls.Add(pnl_bottom);
            Controls.Add(cmb_liaison);
            Controls.Add(lbx_secteur);
            Controls.Add(gbx_tarif);
            Controls.Add(lbl_liaison);
            Controls.Add(lbl_secteur);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAjoutTarif";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter un tarif pour une liaison et une période";
            Load += Tarif_Load;
            gbx_tarif.ResumeLayout(false);
            gbx_tarif.PerformLayout();
            pnl_bottom.ResumeLayout(false);
            pnl_bottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_secteur;
        private Label lbl_liaison;
        private Label lbl_periode;
        private GroupBox gbx_tarif;
        private Button btn_confirm;
        private Label lbl_categorie_type;
        private Label lbl_tarif;
        private TextBox textBox1;
        private ListBox lbx_secteur;
        private ComboBox cmb_liaison;
        private ComboBox cmb_periode;
        private Panel pnl_bottom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
namespace Atlantik_app_admin.barre_menu.afficher
{
    partial class AfficherTraverse
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
            lbl_date = new Label();
            btn_afficherTraverse = new Button();
            dtp_date = new DateTimePicker();
            lv_traverse = new ListView();
            lbx_secteur = new ListBox();
            cmb_liaison = new ComboBox();
            SuspendLayout();
            // 
            // lbl_secteur
            // 
            lbl_secteur.AutoSize = true;
            lbl_secteur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_secteur.Location = new Point(12, 19);
            lbl_secteur.Name = "lbl_secteur";
            lbl_secteur.Size = new Size(81, 21);
            lbl_secteur.TabIndex = 0;
            lbl_secteur.Text = "Secteurs :";
            // 
            // lbl_liaison
            // 
            lbl_liaison.AutoSize = true;
            lbl_liaison.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_liaison.Location = new Point(12, 237);
            lbl_liaison.Name = "lbl_liaison";
            lbl_liaison.Size = new Size(68, 21);
            lbl_liaison.TabIndex = 1;
            lbl_liaison.Text = "Liaison :";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_date.Location = new Point(248, 56);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(235, 21);
            lbl_date.TabIndex = 2;
            lbl_date.Text = "Date (par défaut date du jour) :";
            // 
            // btn_afficherTraverse
            // 
            btn_afficherTraverse.Location = new Point(343, 99);
            btn_afficherTraverse.Name = "btn_afficherTraverse";
            btn_afficherTraverse.Size = new Size(179, 23);
            btn_afficherTraverse.TabIndex = 3;
            btn_afficherTraverse.Text = "Afficher les traversées";
            btn_afficherTraverse.UseVisualStyleBackColor = true;
            btn_afficherTraverse.Click += btn_afficherTraverse_Click;
            // 
            // dtp_date
            // 
            dtp_date.Format = DateTimePickerFormat.Short;
            dtp_date.Location = new Point(489, 56);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(96, 23);
            dtp_date.TabIndex = 4;
            // 
            // lv_traverse
            // 
            lv_traverse.FullRowSelect = true;
            lv_traverse.GridLines = true;
            lv_traverse.Location = new Point(176, 145);
            lv_traverse.Name = "lv_traverse";
            lv_traverse.Size = new Size(493, 206);
            lv_traverse.TabIndex = 5;
            lv_traverse.UseCompatibleStateImageBehavior = false;
            lv_traverse.View = View.Details;
            // 
            // lbx_secteur
            // 
            lbx_secteur.FormattingEnabled = true;
            lbx_secteur.ItemHeight = 15;
            lbx_secteur.Location = new Point(12, 43);
            lbx_secteur.Name = "lbx_secteur";
            lbx_secteur.Size = new Size(136, 169);
            lbx_secteur.TabIndex = 6;
            lbx_secteur.SelectedIndexChanged += lbx_secteur_SelectedIndexChanged;
            // 
            // cmb_liaison
            // 
            cmb_liaison.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_liaison.FormattingEnabled = true;
            cmb_liaison.Location = new Point(11, 261);
            cmb_liaison.Name = "cmb_liaison";
            cmb_liaison.Size = new Size(137, 23);
            cmb_liaison.TabIndex = 7;
            // 
            // AfficherTraverse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 374);
            Controls.Add(cmb_liaison);
            Controls.Add(lbx_secteur);
            Controls.Add(lv_traverse);
            Controls.Add(dtp_date);
            Controls.Add(btn_afficherTraverse);
            Controls.Add(lbl_date);
            Controls.Add(lbl_liaison);
            Controls.Add(lbl_secteur);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AfficherTraverse";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Afficher les traversées pour une liaison et une date donnée avec places restantes par catégorie";
            Load += AfficherTraverse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_secteur;
        private Label lbl_liaison;
        private Label lbl_date;
        private Button btn_afficherTraverse;
        private DateTimePicker dtp_date;
        private ListView lv_traverse;
        private ListBox lbx_secteur;
        private ComboBox cmb_liaison;
    }
}
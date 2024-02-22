namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class TraverseGui
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
            lbx_secteur = new ListBox();
            lbl_liaison = new Label();
            cmb_liaison = new ComboBox();
            label1 = new Label();
            cmb_bateau = new ComboBox();
            dtp_depart = new DateTimePicker();
            lbl_depart = new Label();
            dtp_arrivee = new DateTimePicker();
            lbl_arrivee = new Label();
            btn_ajouter = new Button();
            SuspendLayout();
            // 
            // lbl_secteur
            // 
            lbl_secteur.AutoSize = true;
            lbl_secteur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_secteur.Location = new Point(12, 20);
            lbl_secteur.Name = "lbl_secteur";
            lbl_secteur.Size = new Size(81, 21);
            lbl_secteur.TabIndex = 0;
            lbl_secteur.Text = "Secteurs :";
            // 
            // lbx_secteur
            // 
            lbx_secteur.FormattingEnabled = true;
            lbx_secteur.ItemHeight = 15;
            lbx_secteur.Location = new Point(12, 44);
            lbx_secteur.Name = "lbx_secteur";
            lbx_secteur.Size = new Size(133, 184);
            lbx_secteur.TabIndex = 1;
            lbx_secteur.SelectedIndexChanged += lbx_secteur_SelectedIndexChanged;
            // 
            // lbl_liaison
            // 
            lbl_liaison.AutoSize = true;
            lbl_liaison.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_liaison.Location = new Point(12, 262);
            lbl_liaison.Name = "lbl_liaison";
            lbl_liaison.Size = new Size(68, 21);
            lbl_liaison.TabIndex = 2;
            lbl_liaison.Text = "Liaison :";
            // 
            // cmb_liaison
            // 
            cmb_liaison.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_liaison.FormattingEnabled = true;
            cmb_liaison.Location = new Point(12, 286);
            cmb_liaison.Name = "cmb_liaison";
            cmb_liaison.Size = new Size(133, 23);
            cmb_liaison.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 14);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 4;
            label1.Text = "Nom bateau :";
            // 
            // cmb_bateau
            // 
            cmb_bateau.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_bateau.FormattingEnabled = true;
            cmb_bateau.Location = new Point(354, 12);
            cmb_bateau.Name = "cmb_bateau";
            cmb_bateau.Size = new Size(93, 23);
            cmb_bateau.TabIndex = 5;
            // 
            // dtp_depart
            // 
            dtp_depart.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtp_depart.Format = DateTimePickerFormat.Custom;
            dtp_depart.ImeMode = ImeMode.Off;
            dtp_depart.Location = new Point(357, 73);
            dtp_depart.Name = "dtp_depart";
            dtp_depart.Size = new Size(150, 23);
            dtp_depart.TabIndex = 6;
            // 
            // lbl_depart
            // 
            lbl_depart.AutoSize = true;
            lbl_depart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_depart.Location = new Point(181, 73);
            lbl_depart.Name = "lbl_depart";
            lbl_depart.Size = new Size(170, 21);
            lbl_depart.TabIndex = 7;
            lbl_depart.Text = "Date et heure départ :";
            // 
            // dtp_arrivee
            // 
            dtp_arrivee.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtp_arrivee.Format = DateTimePickerFormat.Custom;
            dtp_arrivee.Location = new Point(358, 122);
            dtp_arrivee.Name = "dtp_arrivee";
            dtp_arrivee.Size = new Size(149, 23);
            dtp_arrivee.TabIndex = 8;
            // 
            // lbl_arrivee
            // 
            lbl_arrivee.AutoSize = true;
            lbl_arrivee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_arrivee.Location = new Point(181, 122);
            lbl_arrivee.Name = "lbl_arrivee";
            lbl_arrivee.Size = new Size(171, 21);
            lbl_arrivee.TabIndex = 9;
            lbl_arrivee.Text = "Date et heure arrivée :";
            // 
            // btn_ajouter
            // 
            btn_ajouter.Location = new Point(357, 285);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(94, 23);
            btn_ajouter.TabIndex = 10;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // TraverseGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 326);
            Controls.Add(btn_ajouter);
            Controls.Add(lbl_arrivee);
            Controls.Add(dtp_arrivee);
            Controls.Add(lbl_depart);
            Controls.Add(dtp_depart);
            Controls.Add(cmb_bateau);
            Controls.Add(label1);
            Controls.Add(cmb_liaison);
            Controls.Add(lbl_liaison);
            Controls.Add(lbx_secteur);
            Controls.Add(lbl_secteur);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TraverseGui";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter une traversée";
            Load += TraverseGui_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_secteur;
        private ListBox lbx_secteur;
        private Label lbl_liaison;
        private ComboBox cmb_liaison;
        private Label label1;
        private ComboBox cmb_bateau;
        private DateTimePicker dtp_depart;
        private Label lbl_depart;
        private DateTimePicker dtp_arrivee;
        private Label lbl_arrivee;
        private Button btn_ajouter;
    }
}
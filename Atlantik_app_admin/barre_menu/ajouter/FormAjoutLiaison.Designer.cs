namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class FormAjoutLiaison
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
            cmb_depart_liste = new ComboBox();
            lbl_depart = new Label();
            cmb_arrivee_list = new ComboBox();
            lbl_arrivee = new Label();
            lbl_distance = new Label();
            tbx_distance_value = new TextBox();
            btn_ajouter = new Button();
            lbx_secteur = new ListBox();
            SuspendLayout();
            // 
            // lbl_secteur
            // 
            lbl_secteur.AutoSize = true;
            lbl_secteur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_secteur.Location = new Point(22, 24);
            lbl_secteur.Name = "lbl_secteur";
            lbl_secteur.Size = new Size(81, 21);
            lbl_secteur.TabIndex = 0;
            lbl_secteur.Text = "Secteurs :";
            // 
            // cmb_depart_liste
            // 
            cmb_depart_liste.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_depart_liste.FormattingEnabled = true;
            cmb_depart_liste.Location = new Point(170, 48);
            cmb_depart_liste.Name = "cmb_depart_liste";
            cmb_depart_liste.Size = new Size(121, 23);
            cmb_depart_liste.TabIndex = 3;
            // 
            // lbl_depart
            // 
            lbl_depart.AutoSize = true;
            lbl_depart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_depart.Location = new Point(170, 24);
            lbl_depart.Name = "lbl_depart";
            lbl_depart.Size = new Size(68, 21);
            lbl_depart.TabIndex = 2;
            lbl_depart.Text = "Départ :";
            // 
            // cmb_arrivee_list
            // 
            cmb_arrivee_list.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_arrivee_list.FormattingEnabled = true;
            cmb_arrivee_list.Location = new Point(316, 48);
            cmb_arrivee_list.Name = "cmb_arrivee_list";
            cmb_arrivee_list.Size = new Size(121, 23);
            cmb_arrivee_list.TabIndex = 5;
            // 
            // lbl_arrivee
            // 
            lbl_arrivee.AutoSize = true;
            lbl_arrivee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_arrivee.Location = new Point(316, 24);
            lbl_arrivee.Name = "lbl_arrivee";
            lbl_arrivee.Size = new Size(71, 21);
            lbl_arrivee.TabIndex = 4;
            lbl_arrivee.Text = "Arrivée :";
            // 
            // lbl_distance
            // 
            lbl_distance.AutoSize = true;
            lbl_distance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_distance.Location = new Point(251, 149);
            lbl_distance.Name = "lbl_distance";
            lbl_distance.Size = new Size(80, 21);
            lbl_distance.TabIndex = 6;
            lbl_distance.Text = "Distance :";
            // 
            // tbx_distance_value
            // 
            tbx_distance_value.Location = new Point(337, 149);
            tbx_distance_value.Name = "tbx_distance_value";
            tbx_distance_value.Size = new Size(100, 23);
            tbx_distance_value.TabIndex = 7;
            // 
            // btn_ajouter
            // 
            btn_ajouter.Location = new Point(341, 201);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(75, 23);
            btn_ajouter.TabIndex = 8;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // lbx_secteur
            // 
            lbx_secteur.FormattingEnabled = true;
            lbx_secteur.ItemHeight = 15;
            lbx_secteur.Location = new Point(22, 48);
            lbx_secteur.Name = "lbx_secteur";
            lbx_secteur.Size = new Size(120, 184);
            lbx_secteur.TabIndex = 9;
            // 
            // FormAjoutLiaison
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 245);
            Controls.Add(lbx_secteur);
            Controls.Add(btn_ajouter);
            Controls.Add(tbx_distance_value);
            Controls.Add(lbl_distance);
            Controls.Add(cmb_arrivee_list);
            Controls.Add(lbl_arrivee);
            Controls.Add(cmb_depart_liste);
            Controls.Add(lbl_depart);
            Controls.Add(lbl_secteur);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAjoutLiaison";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter une liaison";
            Load += LiaisonGui_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_secteur;
        private ComboBox cmb_depart_liste;
        private Label lbl_depart;
        private ComboBox cmb_arrivee_list;
        private Label lbl_arrivee;
        private Label lbl_distance;
        private TextBox tbx_distance_value;
        private Button btn_ajouter;
        private ListBox lbx_secteur;
    }
}
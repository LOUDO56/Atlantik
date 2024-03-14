namespace Atlantik_app_admin.barre_menu.modifier
{
    partial class FormModifParametreSite
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
            gbx_idPayBox = new GroupBox();
            tbx_cleHMAC = new TextBox();
            tbx_identifiant = new TextBox();
            tbx_rang = new TextBox();
            tbx_site = new TextBox();
            lbl_cleHMAC = new Label();
            lbl_identifiant = new Label();
            lbl_rang = new Label();
            lbl_site = new Label();
            cbx_production = new CheckBox();
            lbl_melSite = new Label();
            tbx_melSite = new TextBox();
            btn_modifier = new Button();
            gbx_idPayBox.SuspendLayout();
            SuspendLayout();
            // 
            // gbx_idPayBox
            // 
            gbx_idPayBox.Controls.Add(tbx_cleHMAC);
            gbx_idPayBox.Controls.Add(tbx_identifiant);
            gbx_idPayBox.Controls.Add(tbx_rang);
            gbx_idPayBox.Controls.Add(tbx_site);
            gbx_idPayBox.Controls.Add(lbl_cleHMAC);
            gbx_idPayBox.Controls.Add(lbl_identifiant);
            gbx_idPayBox.Controls.Add(lbl_rang);
            gbx_idPayBox.Controls.Add(lbl_site);
            gbx_idPayBox.Location = new Point(12, 12);
            gbx_idPayBox.Name = "gbx_idPayBox";
            gbx_idPayBox.Size = new Size(388, 320);
            gbx_idPayBox.TabIndex = 0;
            gbx_idPayBox.TabStop = false;
            gbx_idPayBox.Text = "Identifiants PayBox";
            // 
            // tbx_cleHMAC
            // 
            tbx_cleHMAC.Location = new Point(113, 161);
            tbx_cleHMAC.Multiline = true;
            tbx_cleHMAC.Name = "tbx_cleHMAC";
            tbx_cleHMAC.Size = new Size(233, 125);
            tbx_cleHMAC.TabIndex = 7;
            // 
            // tbx_identifiant
            // 
            tbx_identifiant.Location = new Point(113, 116);
            tbx_identifiant.Name = "tbx_identifiant";
            tbx_identifiant.Size = new Size(104, 23);
            tbx_identifiant.TabIndex = 6;
            // 
            // tbx_rang
            // 
            tbx_rang.Location = new Point(113, 77);
            tbx_rang.Name = "tbx_rang";
            tbx_rang.Size = new Size(104, 23);
            tbx_rang.TabIndex = 5;
            // 
            // tbx_site
            // 
            tbx_site.Location = new Point(113, 38);
            tbx_site.Name = "tbx_site";
            tbx_site.Size = new Size(104, 23);
            tbx_site.TabIndex = 4;
            // 
            // lbl_cleHMAC
            // 
            lbl_cleHMAC.AutoSize = true;
            lbl_cleHMAC.Location = new Point(25, 164);
            lbl_cleHMAC.Name = "lbl_cleHMAC";
            lbl_cleHMAC.Size = new Size(69, 15);
            lbl_cleHMAC.TabIndex = 3;
            lbl_cleHMAC.Text = "Clé HMAC :";
            // 
            // lbl_identifiant
            // 
            lbl_identifiant.AutoSize = true;
            lbl_identifiant.Location = new Point(25, 119);
            lbl_identifiant.Name = "lbl_identifiant";
            lbl_identifiant.Size = new Size(67, 15);
            lbl_identifiant.TabIndex = 2;
            lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_rang
            // 
            lbl_rang.AutoSize = true;
            lbl_rang.Location = new Point(25, 80);
            lbl_rang.Name = "lbl_rang";
            lbl_rang.Size = new Size(40, 15);
            lbl_rang.TabIndex = 1;
            lbl_rang.Text = "Rang :";
            // 
            // lbl_site
            // 
            lbl_site.AutoSize = true;
            lbl_site.Location = new Point(25, 41);
            lbl_site.Name = "lbl_site";
            lbl_site.Size = new Size(32, 15);
            lbl_site.TabIndex = 0;
            lbl_site.Text = "Site :";
            // 
            // cbx_production
            // 
            cbx_production.AutoSize = true;
            cbx_production.Location = new Point(299, 354);
            cbx_production.Name = "cbx_production";
            cbx_production.Size = new Size(101, 19);
            cbx_production.TabIndex = 1;
            cbx_production.Text = "En production";
            cbx_production.UseVisualStyleBackColor = true;
            // 
            // lbl_melSite
            // 
            lbl_melSite.AutoSize = true;
            lbl_melSite.Location = new Point(196, 414);
            lbl_melSite.Name = "lbl_melSite";
            lbl_melSite.Size = new Size(54, 15);
            lbl_melSite.TabIndex = 2;
            lbl_melSite.Text = "Mél site :";
            // 
            // tbx_melSite
            // 
            tbx_melSite.Location = new Point(256, 411);
            tbx_melSite.Name = "tbx_melSite";
            tbx_melSite.Size = new Size(147, 23);
            tbx_melSite.TabIndex = 8;
            // 
            // btn_modifier
            // 
            btn_modifier.Location = new Point(298, 460);
            btn_modifier.Name = "btn_modifier";
            btn_modifier.Size = new Size(102, 23);
            btn_modifier.TabIndex = 8;
            btn_modifier.Text = "Modifier";
            btn_modifier.UseVisualStyleBackColor = true;
            btn_modifier.Click += btn_modifier_Click;
            // 
            // FormModifParametreSite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 500);
            Controls.Add(btn_modifier);
            Controls.Add(tbx_melSite);
            Controls.Add(lbl_melSite);
            Controls.Add(cbx_production);
            Controls.Add(gbx_idPayBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormModifParametreSite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier les paramètres du site";
            Load += FormModifParametreSite_Load;
            gbx_idPayBox.ResumeLayout(false);
            gbx_idPayBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbx_idPayBox;
        private TextBox tbx_site;
        private Label lbl_cleHMAC;
        private Label lbl_identifiant;
        private Label lbl_rang;
        private Label lbl_site;
        private TextBox tbx_cleHMAC;
        private TextBox tbx_identifiant;
        private TextBox tbx_rang;
        private CheckBox cbx_production;
        private Label lbl_melSite;
        private TextBox tbx_melSite;
        private Button btn_modifier;
    }
}
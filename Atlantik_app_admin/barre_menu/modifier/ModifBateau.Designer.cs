namespace Atlantik_app_admin.barre_menu.modifier
{
    partial class ModifBateau
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
            pnl_bateau = new Panel();
            btn_ajouter = new Button();
            gbx_capacitesMaximales = new GroupBox();
            lbl_bateau = new Label();
            cmb_bateau = new ComboBox();
            pnl_bateau.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_bateau
            // 
            pnl_bateau.Controls.Add(btn_ajouter);
            pnl_bateau.Location = new Point(0, 241);
            pnl_bateau.Name = "pnl_bateau";
            pnl_bateau.Size = new Size(240, 28);
            pnl_bateau.TabIndex = 7;
            // 
            // btn_ajouter
            // 
            btn_ajouter.Location = new Point(120, 6);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(107, 23);
            btn_ajouter.TabIndex = 0;
            btn_ajouter.Text = "Modifier";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // gbx_capacitesMaximales
            // 
            gbx_capacitesMaximales.Location = new Point(246, 12);
            gbx_capacitesMaximales.Name = "gbx_capacitesMaximales";
            gbx_capacitesMaximales.Size = new Size(263, 248);
            gbx_capacitesMaximales.TabIndex = 6;
            gbx_capacitesMaximales.TabStop = false;
            gbx_capacitesMaximales.Text = "Capacités Maximales";
            // 
            // lbl_bateau
            // 
            lbl_bateau.AutoSize = true;
            lbl_bateau.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bateau.Location = new Point(12, 23);
            lbl_bateau.Name = "lbl_bateau";
            lbl_bateau.Size = new Size(102, 20);
            lbl_bateau.TabIndex = 4;
            lbl_bateau.Text = "Nom bateau :";
            // 
            // cmb_bateau
            // 
            cmb_bateau.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_bateau.FormattingEnabled = true;
            cmb_bateau.Location = new Point(119, 23);
            cmb_bateau.Name = "cmb_bateau";
            cmb_bateau.Size = new Size(121, 23);
            cmb_bateau.TabIndex = 8;
            cmb_bateau.SelectedIndexChanged += cmb_bateau_SelectedIndexChanged;
            // 
            // ModifBateau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 271);
            Controls.Add(cmb_bateau);
            Controls.Add(pnl_bateau);
            Controls.Add(gbx_capacitesMaximales);
            Controls.Add(lbl_bateau);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModifBateau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modifier un bateau";
            Load += ModifBateau_Load;
            pnl_bateau.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_bateau;
        private Button btn_ajouter;
        private GroupBox gbx_capacitesMaximales;
        private Label lbl_bateau;
        private ComboBox cmb_bateau;
    }
}
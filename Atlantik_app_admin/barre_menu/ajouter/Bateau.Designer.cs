namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class BateauGui
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
            lbl_bateau = new Label();
            tbx_bateau = new TextBox();
            gbx_capacitesMaximales = new GroupBox();
            btn_ajouter = new Button();
            pnl_bateau = new Panel();
            pnl_bateau.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_bateau
            // 
            lbl_bateau.AutoSize = true;
            lbl_bateau.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bateau.Location = new Point(12, 23);
            lbl_bateau.Name = "lbl_bateau";
            lbl_bateau.Size = new Size(102, 20);
            lbl_bateau.TabIndex = 0;
            lbl_bateau.Text = "Nom bateau :";
            // 
            // tbx_bateau
            // 
            tbx_bateau.Location = new Point(120, 23);
            tbx_bateau.Name = "tbx_bateau";
            tbx_bateau.Size = new Size(107, 23);
            tbx_bateau.TabIndex = 1;
            // 
            // gbx_capacitesMaximales
            // 
            gbx_capacitesMaximales.Location = new Point(246, 12);
            gbx_capacitesMaximales.Name = "gbx_capacitesMaximales";
            gbx_capacitesMaximales.Size = new Size(263, 248);
            gbx_capacitesMaximales.TabIndex = 2;
            gbx_capacitesMaximales.TabStop = false;
            gbx_capacitesMaximales.Text = "Capacités Maximales";
            // 
            // btn_ajouter
            // 
            btn_ajouter.Location = new Point(120, 3);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(107, 23);
            btn_ajouter.TabIndex = 0;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // pnl_bateau
            // 
            pnl_bateau.Controls.Add(btn_ajouter);
            pnl_bateau.Location = new Point(0, 241);
            pnl_bateau.Name = "pnl_bateau";
            pnl_bateau.Size = new Size(240, 28);
            pnl_bateau.TabIndex = 3;
            // 
            // BateauGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 271);
            Controls.Add(pnl_bateau);
            Controls.Add(gbx_capacitesMaximales);
            Controls.Add(tbx_bateau);
            Controls.Add(lbl_bateau);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BateauGui";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BateauGui";
            Load += BateauGui_Load;
            pnl_bateau.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_bateau;
        private TextBox tbx_bateau;
        private GroupBox gbx_capacitesMaximales;
        private Button btn_ajouter;
        private TextBox tbx_template;
        private Label lbl_template;
        private Panel pnl_bateau;
    }
}
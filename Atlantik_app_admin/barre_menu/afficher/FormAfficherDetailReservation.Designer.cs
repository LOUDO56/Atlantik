namespace Atlantik_app_admin.barre_menu.afficher
{
    partial class FormAfficherDetailReservation
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
            lbl_nom = new Label();
            cmb_nom = new ComboBox();
            lv_detail = new ListView();
            gbx_reservation = new GroupBox();
            SuspendLayout();
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nom.Location = new Point(28, 48);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(119, 21);
            lbl_nom.TabIndex = 0;
            lbl_nom.Text = "Nom, Prénom :";
            // 
            // cmb_nom
            // 
            cmb_nom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nom.FormattingEnabled = true;
            cmb_nom.Location = new Point(153, 48);
            cmb_nom.Name = "cmb_nom";
            cmb_nom.Size = new Size(121, 23);
            cmb_nom.TabIndex = 1;
            // 
            // lv_detail
            // 
            lv_detail.FullRowSelect = true;
            lv_detail.GridLines = true;
            lv_detail.Location = new Point(321, 38);
            lv_detail.Name = "lv_detail";
            lv_detail.Size = new Size(470, 87);
            lv_detail.TabIndex = 2;
            lv_detail.UseCompatibleStateImageBehavior = false;
            lv_detail.View = View.Details;
            lv_detail.SelectedIndexChanged += lv_detail_SelectedIndexChanged;
            // 
            // gbx_reservation
            // 
            gbx_reservation.Location = new Point(420, 171);
            gbx_reservation.Name = "gbx_reservation";
            gbx_reservation.Size = new Size(295, 212);
            gbx_reservation.TabIndex = 3;
            gbx_reservation.TabStop = false;
            gbx_reservation.Text = "Réservation";
            // 
            // AfficherDetailReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(gbx_reservation);
            Controls.Add(lv_detail);
            Controls.Add(cmb_nom);
            Controls.Add(lbl_nom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AfficherDetailReservation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Les détails d'une réservation pour un client";
            Load += AfficherDetailReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nom;
        private ComboBox cmb_nom;
        private ListView lv_detail;
        private GroupBox gbx_reservation;
    }
}
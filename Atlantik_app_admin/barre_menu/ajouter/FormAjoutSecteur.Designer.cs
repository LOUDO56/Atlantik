﻿namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class FormAjoutSecteur
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
            lbl_nom_secteur = new Label();
            tbx_secteur = new TextBox();
            btn_confirm = new Button();
            SuspendLayout();
            // 
            // lbl_nom_secteur
            // 
            lbl_nom_secteur.AutoSize = true;
            lbl_nom_secteur.Location = new Point(23, 76);
            lbl_nom_secteur.Name = "lbl_nom_secteur";
            lbl_nom_secteur.Size = new Size(81, 15);
            lbl_nom_secteur.TabIndex = 0;
            lbl_nom_secteur.Text = "Nom secteur :";
            // 
            // tbx_secteur
            // 
            tbx_secteur.Location = new Point(110, 73);
            tbx_secteur.Name = "tbx_secteur";
            tbx_secteur.Size = new Size(100, 23);
            tbx_secteur.TabIndex = 1;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(216, 73);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(75, 23);
            btn_confirm.TabIndex = 2;
            btn_confirm.Text = "Ajouter";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // FormAjoutSecteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 165);
            Controls.Add(btn_confirm);
            Controls.Add(tbx_secteur);
            Controls.Add(lbl_nom_secteur);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAjoutSecteur";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter un secteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nom_secteur;
        private TextBox tbx_secteur;
        private Button btn_confirm;
    }
}
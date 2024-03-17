namespace Atlantik_app_admin.barre_menu
{
    partial class FormAPropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAPropos));
            lbl_desc = new Label();
            btn_voirProjet = new Button();
            SuspendLayout();
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Location = new Point(24, 126);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(248, 150);
            lbl_desc.TabIndex = 0;
            lbl_desc.Text = resources.GetString("lbl_desc.Text");
            lbl_desc.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_voirProjet
            // 
            btn_voirProjet.Location = new Point(106, 295);
            btn_voirProjet.Name = "btn_voirProjet";
            btn_voirProjet.Size = new Size(75, 23);
            btn_voirProjet.TabIndex = 1;
            btn_voirProjet.Text = "Voir Projets";
            btn_voirProjet.UseVisualStyleBackColor = true;
            btn_voirProjet.Click += btn_voirProjet_Click;
            // 
            // FormAPropos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 401);
            Controls.Add(btn_voirProjet);
            Controls.Add(lbl_desc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAPropos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "À Propos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_desc;
        private Button btn_voirProjet;
    }
}
namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class SecteurGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecteurGui));
            nom_secteur = new Label();
            secteur_textbox = new TextBox();
            confirm_add_secteur = new Button();
            return_button = new Button();
            SuspendLayout();
            // 
            // nom_secteur
            // 
            nom_secteur.AutoSize = true;
            nom_secteur.Location = new Point(23, 76);
            nom_secteur.Name = "nom_secteur";
            nom_secteur.Size = new Size(81, 15);
            nom_secteur.TabIndex = 0;
            nom_secteur.Text = "Nom secteur :";
            // 
            // secteur_textbox
            // 
            secteur_textbox.Location = new Point(110, 73);
            secteur_textbox.Name = "secteur_textbox";
            secteur_textbox.Size = new Size(100, 23);
            secteur_textbox.TabIndex = 1;
            // 
            // confirm_add_secteur
            // 
            confirm_add_secteur.Location = new Point(216, 73);
            confirm_add_secteur.Name = "confirm_add_secteur";
            confirm_add_secteur.Size = new Size(75, 23);
            confirm_add_secteur.TabIndex = 2;
            confirm_add_secteur.Text = "Ajouter";
            confirm_add_secteur.UseVisualStyleBackColor = true;
            confirm_add_secteur.Click += confirm_add_secteur_Click;
            // 
            // return_button
            // 
            return_button.Image = (Image)resources.GetObject("return_button.Image");
            return_button.Location = new Point(12, 12);
            return_button.Name = "return_button";
            return_button.Size = new Size(30, 24);
            return_button.TabIndex = 3;
            return_button.UseVisualStyleBackColor = true;
            return_button.Click += return_button_Click;
            // 
            // SecteurGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 165);
            Controls.Add(return_button);
            Controls.Add(confirm_add_secteur);
            Controls.Add(secteur_textbox);
            Controls.Add(nom_secteur);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SecteurGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nom_secteur;
        private TextBox secteur_textbox;
        private Button confirm_add_secteur;
        private Button return_button;
    }
}
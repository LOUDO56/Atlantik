namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class PortGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortGui));
            return_button = new Button();
            confirm = new Button();
            values = new TextBox();
            nom = new Label();
            SuspendLayout();
            // 
            // return_button
            // 
            return_button.Image = (Image)resources.GetObject("return_button.Image");
            return_button.Location = new Point(13, 12);
            return_button.Name = "return_button";
            return_button.Size = new Size(30, 24);
            return_button.TabIndex = 7;
            return_button.UseVisualStyleBackColor = true;
            return_button.Click += return_button_Click;
            // 
            // confirm
            // 
            confirm.Location = new Point(217, 73);
            confirm.Name = "confirm";
            confirm.Size = new Size(75, 23);
            confirm.TabIndex = 6;
            confirm.Text = "Ajouter";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // values
            // 
            values.Location = new Point(111, 73);
            values.Name = "values";
            values.Size = new Size(100, 23);
            values.TabIndex = 5;
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Location = new Point(40, 77);
            nom.Name = "nom";
            nom.Size = new Size(65, 15);
            nom.TabIndex = 4;
            nom.Text = "Nom port :";
            // 
            // PortGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 165);
            Controls.Add(return_button);
            Controls.Add(confirm);
            Controls.Add(values);
            Controls.Add(nom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PortGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Port";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_button;
        private Button confirm;
        private TextBox values;
        private Label nom;
    }
}
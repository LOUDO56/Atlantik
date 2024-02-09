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
            confirm_add_port = new Button();
            port_textbox = new TextBox();
            nom_port = new Label();
            SuspendLayout();
            // 
            // confirm_add_port
            // 
            confirm_add_port.Location = new Point(205, 70);
            confirm_add_port.Name = "confirm_add_port";
            confirm_add_port.Size = new Size(75, 23);
            confirm_add_port.TabIndex = 5;
            confirm_add_port.Text = "Ajouter";
            confirm_add_port.UseVisualStyleBackColor = true;
            // 
            // port_textbox
            // 
            port_textbox.Location = new Point(99, 70);
            port_textbox.Name = "port_textbox";
            port_textbox.Size = new Size(100, 23);
            port_textbox.TabIndex = 4;
            // 
            // nom_port
            // 
            nom_port.AutoSize = true;
            nom_port.Location = new Point(28, 74);
            nom_port.Name = "nom_port";
            nom_port.Size = new Size(65, 15);
            nom_port.TabIndex = 3;
            nom_port.Text = "Nom port :";
            // 
            // PortGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 165);
            Controls.Add(confirm_add_port);
            Controls.Add(port_textbox);
            Controls.Add(nom_port);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PortGui";
            Text = "Port";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirm_add_port;
        private TextBox port_textbox;
        private Label nom_port;
    }
}
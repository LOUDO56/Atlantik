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
            btn_confirm = new Button();
            tbx_values = new TextBox();
            lbl_nom = new Label();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(217, 73);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(75, 23);
            btn_confirm.TabIndex = 6;
            btn_confirm.Text = "Ajouter";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // tbx_values
            // 
            tbx_values.Location = new Point(111, 73);
            tbx_values.Name = "tbx_values";
            tbx_values.Size = new Size(100, 23);
            tbx_values.TabIndex = 5;
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new Point(40, 77);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(65, 15);
            lbl_nom.TabIndex = 4;
            lbl_nom.Text = "Nom port :";
            // 
            // PortGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 165);
            Controls.Add(btn_confirm);
            Controls.Add(tbx_values);
            Controls.Add(lbl_nom);
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
        private Button btn_confirm;
        private TextBox tbx_values;
        private Label lbl_nom;
    }
}
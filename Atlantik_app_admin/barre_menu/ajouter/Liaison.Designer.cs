namespace Atlantik_app_admin.barre_menu.ajouter
{
    partial class LiaisonGui
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
            secteur_label = new Label();
            secteur_list = new ComboBox();
            depart_liste = new ComboBox();
            depart_label = new Label();
            arrivee_list = new ComboBox();
            label_arrivee = new Label();
            distance_label = new Label();
            distance_value = new TextBox();
            ajouter = new Button();
            SuspendLayout();
            // 
            // secteur_label
            // 
            secteur_label.AutoSize = true;
            secteur_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secteur_label.Location = new Point(22, 24);
            secteur_label.Name = "secteur_label";
            secteur_label.Size = new Size(81, 21);
            secteur_label.TabIndex = 0;
            secteur_label.Text = "Secteurs :";
            // 
            // secteur_list
            // 
            secteur_list.DropDownStyle = ComboBoxStyle.DropDownList;
            secteur_list.FormattingEnabled = true;
            secteur_list.Location = new Point(22, 48);
            secteur_list.Name = "secteur_list";
            secteur_list.Size = new Size(121, 23);
            secteur_list.TabIndex = 1;
            // 
            // depart_liste
            // 
            depart_liste.DropDownStyle = ComboBoxStyle.DropDownList;
            depart_liste.FormattingEnabled = true;
            depart_liste.Location = new Point(170, 48);
            depart_liste.Name = "depart_liste";
            depart_liste.Size = new Size(121, 23);
            depart_liste.TabIndex = 3;
            // 
            // depart_label
            // 
            depart_label.AutoSize = true;
            depart_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depart_label.Location = new Point(170, 24);
            depart_label.Name = "depart_label";
            depart_label.Size = new Size(68, 21);
            depart_label.TabIndex = 2;
            depart_label.Text = "Départ :";
            // 
            // arrivee_list
            // 
            arrivee_list.DropDownStyle = ComboBoxStyle.DropDownList;
            arrivee_list.FormattingEnabled = true;
            arrivee_list.Location = new Point(316, 48);
            arrivee_list.Name = "arrivee_list";
            arrivee_list.Size = new Size(121, 23);
            arrivee_list.TabIndex = 5;
            // 
            // label_arrivee
            // 
            label_arrivee.AutoSize = true;
            label_arrivee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_arrivee.Location = new Point(316, 24);
            label_arrivee.Name = "label_arrivee";
            label_arrivee.Size = new Size(71, 21);
            label_arrivee.TabIndex = 4;
            label_arrivee.Text = "Arrivée :";
            // 
            // distance_label
            // 
            distance_label.AutoSize = true;
            distance_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            distance_label.Location = new Point(183, 106);
            distance_label.Name = "distance_label";
            distance_label.Size = new Size(80, 21);
            distance_label.TabIndex = 6;
            distance_label.Text = "Distance :";
            // 
            // distance_value
            // 
            distance_value.Location = new Point(170, 130);
            distance_value.Name = "distance_value";
            distance_value.Size = new Size(100, 23);
            distance_value.TabIndex = 7;
            // 
            // ajouter
            // 
            ajouter.Location = new Point(183, 191);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(75, 31);
            ajouter.TabIndex = 8;
            ajouter.Text = "Ajouter";
            ajouter.UseVisualStyleBackColor = true;
            ajouter.Click += ajouter_Click;
            // 
            // LiaisonGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 245);
            Controls.Add(ajouter);
            Controls.Add(distance_value);
            Controls.Add(distance_label);
            Controls.Add(arrivee_list);
            Controls.Add(label_arrivee);
            Controls.Add(depart_liste);
            Controls.Add(depart_label);
            Controls.Add(secteur_list);
            Controls.Add(secteur_label);
            Name = "LiaisonGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liaison";
            Load += LiaisonGui_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label secteur_label;
        private ComboBox secteur_list;
        private ComboBox depart_liste;
        private Label depart_label;
        private ComboBox arrivee_list;
        private Label label_arrivee;
        private Label distance_label;
        private TextBox distance_value;
        private Button ajouter;
    }
}
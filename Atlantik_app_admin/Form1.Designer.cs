namespace Atlantik_app_admin
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            logo = new PictureBox();
            atlantik_textpre = new Label();
            unSecteurToolStripMenuItem = new ToolStripMenuItem();
            unPortToolStripMenuItem = new ToolStripMenuItem();
            uneLiaisonToolStripMenuItem = new ToolStripMenuItem();
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem = new ToolStripMenuItem();
            unBateauToolStripMenuItem = new ToolStripMenuItem();
            uneTraverséeToolStripMenuItem = new ToolStripMenuItem();
            barre_menu = new MenuStrip();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            unSecteurToolStripMenuItem1 = new ToolStripMenuItem();
            unPortToolStripMenuItem1 = new ToolStripMenuItem();
            uneLiaisonToolStripMenuItem1 = new ToolStripMenuItem();
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1 = new ToolStripMenuItem();
            unBateauToolStripMenuItem1 = new ToolStripMenuItem();
            uneTraverséeToolStripMenuItem1 = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            unBateauToolStripMenuItem2 = new ToolStripMenuItem();
            lesParamètresDuSiteToolStripMenuItem = new ToolStripMenuItem();
            affichierToolStripMenuItem = new ToolStripMenuItem();
            lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem = new ToolStripMenuItem();
            lesDétailsDuneRéservationPourUnClientToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            barre_menu.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(118, 93);
            logo.Name = "logo";
            logo.Size = new Size(376, 251);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // atlantik_textpre
            // 
            atlantik_textpre.AutoSize = true;
            atlantik_textpre.BackColor = SystemColors.Control;
            atlantik_textpre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atlantik_textpre.ForeColor = Color.Red;
            atlantik_textpre.Location = new Point(69, 43);
            atlantik_textpre.Name = "atlantik_textpre";
            atlantik_textpre.Size = new Size(481, 32);
            atlantik_textpre.TabIndex = 1;
            atlantik_textpre.Text = "Application administrateur pour Atlantik";
            atlantik_textpre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unSecteurToolStripMenuItem
            // 
            unSecteurToolStripMenuItem.Name = "unSecteurToolStripMenuItem";
            unSecteurToolStripMenuItem.Size = new Size(32, 19);
            // 
            // unPortToolStripMenuItem
            // 
            unPortToolStripMenuItem.Name = "unPortToolStripMenuItem";
            unPortToolStripMenuItem.Size = new Size(32, 19);
            // 
            // uneLiaisonToolStripMenuItem
            // 
            uneLiaisonToolStripMenuItem.Name = "uneLiaisonToolStripMenuItem";
            uneLiaisonToolStripMenuItem.Size = new Size(32, 19);
            // 
            // lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem
            // 
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Name = "lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem";
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Size = new Size(32, 19);
            // 
            // unBateauToolStripMenuItem
            // 
            unBateauToolStripMenuItem.Name = "unBateauToolStripMenuItem";
            unBateauToolStripMenuItem.Size = new Size(32, 19);
            // 
            // uneTraverséeToolStripMenuItem
            // 
            uneTraverséeToolStripMenuItem.Name = "uneTraverséeToolStripMenuItem";
            uneTraverséeToolStripMenuItem.Size = new Size(32, 19);
            // 
            // barre_menu
            // 
            barre_menu.BackColor = Color.White;
            barre_menu.Items.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, modifierToolStripMenuItem, affichierToolStripMenuItem, aProposToolStripMenuItem });
            barre_menu.Location = new Point(0, 0);
            barre_menu.Name = "barre_menu";
            barre_menu.Size = new Size(614, 24);
            barre_menu.TabIndex = 2;
            barre_menu.Text = "barre_menu";
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unSecteurToolStripMenuItem1, unPortToolStripMenuItem1, uneLiaisonToolStripMenuItem1, lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1, unBateauToolStripMenuItem1, uneTraverséeToolStripMenuItem1 });
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(58, 20);
            ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // unSecteurToolStripMenuItem1
            // 
            unSecteurToolStripMenuItem1.Name = "unSecteurToolStripMenuItem1";
            unSecteurToolStripMenuItem1.Size = new Size(287, 22);
            unSecteurToolStripMenuItem1.Text = "Un secteur";
            unSecteurToolStripMenuItem1.Click += unSecteurToolStripMenuItem1_Click;
            // 
            // unPortToolStripMenuItem1
            // 
            unPortToolStripMenuItem1.Name = "unPortToolStripMenuItem1";
            unPortToolStripMenuItem1.Size = new Size(287, 22);
            unPortToolStripMenuItem1.Text = "Un port";
            unPortToolStripMenuItem1.Click += unPortToolStripMenuItem1_Click;
            // 
            // uneLiaisonToolStripMenuItem1
            // 
            uneLiaisonToolStripMenuItem1.Name = "uneLiaisonToolStripMenuItem1";
            uneLiaisonToolStripMenuItem1.Size = new Size(287, 22);
            uneLiaisonToolStripMenuItem1.Text = "Une liaison";
            // 
            // lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1
            // 
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1.Name = "lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1";
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1.Size = new Size(287, 22);
            lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1.Text = "Les tarifs pour une liaison et une période";
            // 
            // unBateauToolStripMenuItem1
            // 
            unBateauToolStripMenuItem1.Name = "unBateauToolStripMenuItem1";
            unBateauToolStripMenuItem1.Size = new Size(287, 22);
            unBateauToolStripMenuItem1.Text = "Un bateau";
            // 
            // uneTraverséeToolStripMenuItem1
            // 
            uneTraverséeToolStripMenuItem1.Name = "uneTraverséeToolStripMenuItem1";
            uneTraverséeToolStripMenuItem1.Size = new Size(287, 22);
            uneTraverséeToolStripMenuItem1.Text = "Une traversée";
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unBateauToolStripMenuItem2, lesParamètresDuSiteToolStripMenuItem });
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(64, 20);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // unBateauToolStripMenuItem2
            // 
            unBateauToolStripMenuItem2.Name = "unBateauToolStripMenuItem2";
            unBateauToolStripMenuItem2.Size = new Size(191, 22);
            unBateauToolStripMenuItem2.Text = "Un bateau";
            // 
            // lesParamètresDuSiteToolStripMenuItem
            // 
            lesParamètresDuSiteToolStripMenuItem.Name = "lesParamètresDuSiteToolStripMenuItem";
            lesParamètresDuSiteToolStripMenuItem.Size = new Size(191, 22);
            lesParamètresDuSiteToolStripMenuItem.Text = "Les paramètres du site";
            // 
            // affichierToolStripMenuItem
            // 
            affichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem, lesDétailsDuneRéservationPourUnClientToolStripMenuItem });
            affichierToolStripMenuItem.Name = "affichierToolStripMenuItem";
            affichierToolStripMenuItem.Size = new Size(61, 20);
            affichierToolStripMenuItem.Text = "Afficher";
            // 
            // lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem
            // 
            lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Name = "lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem";
            lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Size = new Size(524, 22);
            lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec places restantes par catégorie";
            // 
            // lesDétailsDuneRéservationPourUnClientToolStripMenuItem
            // 
            lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Name = "lesDétailsDuneRéservationPourUnClientToolStripMenuItem";
            lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Size = new Size(524, 22);
            lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Text = "Les détails d'une réservation pour un client";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(67, 20);
            aProposToolStripMenuItem.Text = "A propos";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(105, 22);
            toolStripMenuItem1.Text = "Projet";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 385);
            Controls.Add(atlantik_textpre);
            Controls.Add(logo);
            Controls.Add(barre_menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = barre_menu;
            MaximizeBox = false;
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atlantik";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            barre_menu.ResumeLayout(false);
            barre_menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label atlantik_textpre;
        private ToolStripMenuItem unSecteurToolStripMenuItem;
        private ToolStripMenuItem unPortToolStripMenuItem;
        private ToolStripMenuItem uneLiaisonToolStripMenuItem;
        private ToolStripMenuItem lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem;
        private ToolStripMenuItem unBateauToolStripMenuItem;
        private ToolStripMenuItem uneTraverséeToolStripMenuItem;
        private MenuStrip barre_menu;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem unSecteurToolStripMenuItem1;
        private ToolStripMenuItem unPortToolStripMenuItem1;
        private ToolStripMenuItem uneLiaisonToolStripMenuItem1;
        private ToolStripMenuItem lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem1;
        private ToolStripMenuItem unBateauToolStripMenuItem1;
        private ToolStripMenuItem uneTraverséeToolStripMenuItem1;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem unBateauToolStripMenuItem2;
        private ToolStripMenuItem lesParamètresDuSiteToolStripMenuItem;
        private ToolStripMenuItem affichierToolStripMenuItem;
        private ToolStripMenuItem lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem;
        private ToolStripMenuItem lesDétailsDuneRéservationPourUnClientToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}

namespace RozpoznawanieObiektow
{
    partial class OknoGlowne
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszWynikDetekcjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończDziałanieProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryzacjaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odcienieSzarościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziomJasnościKontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramObrazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrMedianowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przekształceniaGeometyryczneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_obrazWe = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_wyszukajObiekt = new System.Windows.Forms.Button();
            this.lb_komunikatWyszObie = new System.Windows.Forms.Label();
            this.gb_narzedziaWyszObie = new System.Windows.Forms.GroupBox();
            this.cb_wyborObiektu = new System.Windows.Forms.ComboBox();
            this.gb_wybierzMetWyszObiek = new System.Windows.Forms.GroupBox();
            this.rb_WyborMetHOG = new System.Windows.Forms.RadioButton();
            this.rb_WyborMetSURF = new System.Windows.Forms.RadioButton();
            this.rb_WyborMetViolaJones = new System.Windows.Forms.RadioButton();
            this.btn_cofnijPrzekObr = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rTB_historiaOperacji = new System.Windows.Forms.RichTextBox();
            this.gb_zarzadzaniePrzeksztalceniami = new System.Windows.Forms.GroupBox();
            this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWe)).BeginInit();
            this.gb_narzedziaWyszObie.SuspendLayout();
            this.gb_wybierzMetWyszObiek.SuspendLayout();
            this.gb_zarzadzaniePrzeksztalceniami.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajObrazToolStripMenuItem,
            this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem,
            this.zapiszWynikDetekcjiToolStripMenuItem,
            this.zakończDziałanieProgramuToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajObrazToolStripMenuItem
            // 
            this.wczytajObrazToolStripMenuItem.Name = "wczytajObrazToolStripMenuItem";
            this.wczytajObrazToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.wczytajObrazToolStripMenuItem.Text = "Wczytaj obraz";
            this.wczytajObrazToolStripMenuItem.Click += new System.EventHandler(this.wczytajObrazToolStripMenuItem_Click);
            // 
            // zapiszWynikDetekcjiToolStripMenuItem
            // 
            this.zapiszWynikDetekcjiToolStripMenuItem.Name = "zapiszWynikDetekcjiToolStripMenuItem";
            this.zapiszWynikDetekcjiToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.zapiszWynikDetekcjiToolStripMenuItem.Text = "Zapisz wynik detekcji";
            this.zapiszWynikDetekcjiToolStripMenuItem.Click += new System.EventHandler(this.zapiszWynikDetekcjiToolStripMenuItem_Click);
            // 
            // zakończDziałanieProgramuToolStripMenuItem
            // 
            this.zakończDziałanieProgramuToolStripMenuItem.Name = "zakończDziałanieProgramuToolStripMenuItem";
            this.zakończDziałanieProgramuToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.zakończDziałanieProgramuToolStripMenuItem.Text = "Zakończ działanie programu";
            this.zakończDziałanieProgramuToolStripMenuItem.Click += new System.EventHandler(this.zakończDziałanieProgramuToolStripMenuItem_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryzacjaToolStripMenuItem,
            this.histogramObrazuToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.przekształceniaGeometyryczneToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.opcjeToolStripMenuItem.Text = "Poprawa jakości obrazu";
            // 
            // binaryzacjaToolStripMenuItem
            // 
            this.binaryzacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryzacjaToolStripMenuItem1,
            this.odcienieSzarościToolStripMenuItem,
            this.poziomJasnościKontrastToolStripMenuItem});
            this.binaryzacjaToolStripMenuItem.Name = "binaryzacjaToolStripMenuItem";
            this.binaryzacjaToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.binaryzacjaToolStripMenuItem.Text = "Zmiana barwy obrazu";
            // 
            // binaryzacjaToolStripMenuItem1
            // 
            this.binaryzacjaToolStripMenuItem1.Name = "binaryzacjaToolStripMenuItem1";
            this.binaryzacjaToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.binaryzacjaToolStripMenuItem1.Text = "Binaryzacja";
            this.binaryzacjaToolStripMenuItem1.Click += new System.EventHandler(this.binaryzacjaToolStripMenuItem1_Click);
            // 
            // odcienieSzarościToolStripMenuItem
            // 
            this.odcienieSzarościToolStripMenuItem.Name = "odcienieSzarościToolStripMenuItem";
            this.odcienieSzarościToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.odcienieSzarościToolStripMenuItem.Text = "Odcienie szarości";
            this.odcienieSzarościToolStripMenuItem.Click += new System.EventHandler(this.odcienieSzarościToolStripMenuItem_Click);
            // 
            // poziomJasnościKontrastToolStripMenuItem
            // 
            this.poziomJasnościKontrastToolStripMenuItem.Name = "poziomJasnościKontrastToolStripMenuItem";
            this.poziomJasnościKontrastToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.poziomJasnościKontrastToolStripMenuItem.Text = "Poziom jasności, kontrast";
            this.poziomJasnościKontrastToolStripMenuItem.Click += new System.EventHandler(this.poziomJasnościKontrastToolStripMenuItem_Click);
            // 
            // histogramObrazuToolStripMenuItem
            // 
            this.histogramObrazuToolStripMenuItem.Name = "histogramObrazuToolStripMenuItem";
            this.histogramObrazuToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.histogramObrazuToolStripMenuItem.Text = "Statystyka oraz histogram obrazu";
            this.histogramObrazuToolStripMenuItem.Click += new System.EventHandler(this.histogramObrazuToolStripMenuItem_Click);
            // 
            // filtryToolStripMenuItem
            // 
            this.filtryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrMedianowyToolStripMenuItem});
            this.filtryToolStripMenuItem.Name = "filtryToolStripMenuItem";
            this.filtryToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.filtryToolStripMenuItem.Text = "Filtry obrazu";
            // 
            // filtrMedianowyToolStripMenuItem
            // 
            this.filtrMedianowyToolStripMenuItem.Name = "filtrMedianowyToolStripMenuItem";
            this.filtrMedianowyToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.filtrMedianowyToolStripMenuItem.Text = "Filtr medianowy";
            this.filtrMedianowyToolStripMenuItem.Click += new System.EventHandler(this.filtrMedianowyToolStripMenuItem_Click);
            // 
            // przekształceniaGeometyryczneToolStripMenuItem
            // 
            this.przekształceniaGeometyryczneToolStripMenuItem.Name = "przekształceniaGeometyryczneToolStripMenuItem";
            this.przekształceniaGeometyryczneToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.przekształceniaGeometyryczneToolStripMenuItem.Text = "Przekształcenia geometryczne";
            this.przekształceniaGeometyryczneToolStripMenuItem.Click += new System.EventHandler(this.przekształceniaGeometyryczneToolStripMenuItem_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // pb_obrazWe
            // 
            this.pb_obrazWe.Location = new System.Drawing.Point(12, 39);
            this.pb_obrazWe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_obrazWe.Name = "pb_obrazWe";
            this.pb_obrazWe.Size = new System.Drawing.Size(480, 480);
            this.pb_obrazWe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_obrazWe.TabIndex = 1;
            this.pb_obrazWe.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_wyszukajObiekt
            // 
            this.btn_wyszukajObiekt.Location = new System.Drawing.Point(12, 162);
            this.btn_wyszukajObiekt.Name = "btn_wyszukajObiekt";
            this.btn_wyszukajObiekt.Size = new System.Drawing.Size(240, 49);
            this.btn_wyszukajObiekt.TabIndex = 2;
            this.btn_wyszukajObiekt.Text = "Wyszukaj obiekt";
            this.btn_wyszukajObiekt.UseVisualStyleBackColor = true;
            this.btn_wyszukajObiekt.Click += new System.EventHandler(this.btn_wyszukajObiekt_Click);
            // 
            // lb_komunikatWyszObie
            // 
            this.lb_komunikatWyszObie.Location = new System.Drawing.Point(279, 521);
            this.lb_komunikatWyszObie.Name = "lb_komunikatWyszObie";
            this.lb_komunikatWyszObie.Size = new System.Drawing.Size(503, 17);
            this.lb_komunikatWyszObie.TabIndex = 3;
            this.lb_komunikatWyszObie.Text = "Wyszukiwanie obiektow na obrazach cyfrowych jest jeszcze niedostępne";
            this.lb_komunikatWyszObie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_narzedziaWyszObie
            // 
            this.gb_narzedziaWyszObie.Controls.Add(this.cb_wyborObiektu);
            this.gb_narzedziaWyszObie.Controls.Add(this.gb_wybierzMetWyszObiek);
            this.gb_narzedziaWyszObie.Controls.Add(this.btn_wyszukajObiekt);
            this.gb_narzedziaWyszObie.Location = new System.Drawing.Point(503, 39);
            this.gb_narzedziaWyszObie.Name = "gb_narzedziaWyszObie";
            this.gb_narzedziaWyszObie.Size = new System.Drawing.Size(267, 223);
            this.gb_narzedziaWyszObie.TabIndex = 4;
            this.gb_narzedziaWyszObie.TabStop = false;
            this.gb_narzedziaWyszObie.Text = "Narzędzia wyszukiwania obiektów";
            // 
            // cb_wyborObiektu
            // 
            this.cb_wyborObiektu.FormattingEnabled = true;
            this.cb_wyborObiektu.Location = new System.Drawing.Point(12, 132);
            this.cb_wyborObiektu.Name = "cb_wyborObiektu";
            this.cb_wyborObiektu.Size = new System.Drawing.Size(240, 24);
            this.cb_wyborObiektu.TabIndex = 6;
            // 
            // gb_wybierzMetWyszObiek
            // 
            this.gb_wybierzMetWyszObiek.Controls.Add(this.rb_WyborMetHOG);
            this.gb_wybierzMetWyszObiek.Controls.Add(this.rb_WyborMetSURF);
            this.gb_wybierzMetWyszObiek.Controls.Add(this.rb_WyborMetViolaJones);
            this.gb_wybierzMetWyszObiek.Location = new System.Drawing.Point(6, 21);
            this.gb_wybierzMetWyszObiek.Name = "gb_wybierzMetWyszObiek";
            this.gb_wybierzMetWyszObiek.Size = new System.Drawing.Size(246, 105);
            this.gb_wybierzMetWyszObiek.TabIndex = 5;
            this.gb_wybierzMetWyszObiek.TabStop = false;
            this.gb_wybierzMetWyszObiek.Text = "Wybierz metodę";
            // 
            // rb_WyborMetHOG
            // 
            this.rb_WyborMetHOG.AutoSize = true;
            this.rb_WyborMetHOG.Location = new System.Drawing.Point(6, 75);
            this.rb_WyborMetHOG.Name = "rb_WyborMetHOG";
            this.rb_WyborMetHOG.Size = new System.Drawing.Size(121, 21);
            this.rb_WyborMetHOG.TabIndex = 5;
            this.rb_WyborMetHOG.TabStop = true;
            this.rb_WyborMetHOG.Text = "HOG Features";
            this.rb_WyborMetHOG.UseVisualStyleBackColor = true;
            this.rb_WyborMetHOG.Click += new System.EventHandler(this.nadzorujListeElementow_cb_wyborObiektu);
            // 
            // rb_WyborMetSURF
            // 
            this.rb_WyborMetSURF.AutoSize = true;
            this.rb_WyborMetSURF.Location = new System.Drawing.Point(6, 48);
            this.rb_WyborMetSURF.Name = "rb_WyborMetSURF";
            this.rb_WyborMetSURF.Size = new System.Drawing.Size(210, 21);
            this.rb_WyborMetSURF.TabIndex = 4;
            this.rb_WyborMetSURF.TabStop = true;
            this.rb_WyborMetSURF.Text = "Speeded Up Robust Feature";
            this.rb_WyborMetSURF.UseVisualStyleBackColor = true;
            this.rb_WyborMetSURF.Click += new System.EventHandler(this.nadzorujListeElementow_cb_wyborObiektu);
            // 
            // rb_WyborMetViolaJones
            // 
            this.rb_WyborMetViolaJones.AutoSize = true;
            this.rb_WyborMetViolaJones.Location = new System.Drawing.Point(6, 21);
            this.rb_WyborMetViolaJones.Name = "rb_WyborMetViolaJones";
            this.rb_WyborMetViolaJones.Size = new System.Drawing.Size(102, 21);
            this.rb_WyborMetViolaJones.TabIndex = 3;
            this.rb_WyborMetViolaJones.TabStop = true;
            this.rb_WyborMetViolaJones.Text = "Viola Jones";
            this.rb_WyborMetViolaJones.UseVisualStyleBackColor = true;
            this.rb_WyborMetViolaJones.Click += new System.EventHandler(this.nadzorujListeElementow_cb_wyborObiektu);
            // 
            // btn_cofnijPrzekObr
            // 
            this.btn_cofnijPrzekObr.Location = new System.Drawing.Point(12, 202);
            this.btn_cofnijPrzekObr.Name = "btn_cofnijPrzekObr";
            this.btn_cofnijPrzekObr.Size = new System.Drawing.Size(240, 42);
            this.btn_cofnijPrzekObr.TabIndex = 5;
            this.btn_cofnijPrzekObr.Text = "Cofnij przekształcenie obrazu";
            this.btn_cofnijPrzekObr.UseVisualStyleBackColor = true;
            this.btn_cofnijPrzekObr.Click += new System.EventHandler(this.btn_cofnijPrzekObr_Click);
            // 
            // rTB_historiaOperacji
            // 
            this.rTB_historiaOperacji.Location = new System.Drawing.Point(6, 21);
            this.rTB_historiaOperacji.Name = "rTB_historiaOperacji";
            this.rTB_historiaOperacji.ReadOnly = true;
            this.rTB_historiaOperacji.Size = new System.Drawing.Size(246, 175);
            this.rTB_historiaOperacji.TabIndex = 6;
            this.rTB_historiaOperacji.Text = "";
            // 
            // gb_zarzadzaniePrzeksztalceniami
            // 
            this.gb_zarzadzaniePrzeksztalceniami.Controls.Add(this.rTB_historiaOperacji);
            this.gb_zarzadzaniePrzeksztalceniami.Controls.Add(this.btn_cofnijPrzekObr);
            this.gb_zarzadzaniePrzeksztalceniami.Location = new System.Drawing.Point(503, 268);
            this.gb_zarzadzaniePrzeksztalceniami.Name = "gb_zarzadzaniePrzeksztalceniami";
            this.gb_zarzadzaniePrzeksztalceniami.Size = new System.Drawing.Size(267, 250);
            this.gb_zarzadzaniePrzeksztalceniami.TabIndex = 7;
            this.gb_zarzadzaniePrzeksztalceniami.TabStop = false;
            this.gb_zarzadzaniePrzeksztalceniami.Text = "Historia przekształceń";
            // 
            // zapiszPostaćAnalizowanegoObrazuToolStripMenuItem
            // 
            this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem.Name = "zapiszPostaćAnalizowanegoObrazuToolStripMenuItem";
            this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem.Text = "Zapisz analizowany obraz";
            this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem.Click += new System.EventHandler(this.zapiszPostaćAnalizowanegoObrazuToolStripMenuItem_Click);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 541);
            this.Controls.Add(this.gb_zarzadzaniePrzeksztalceniami);
            this.Controls.Add(this.gb_narzedziaWyszObie);
            this.Controls.Add(this.lb_komunikatWyszObie);
            this.Controls.Add(this.pb_obrazWe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OknoGlowne";
            this.Text = "Algorytmy szybkiego rozpoznawania obiektów na obrazach cyfrowych";
            this.Load += new System.EventHandler(this.OknoGlowne_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWe)).EndInit();
            this.gb_narzedziaWyszObie.ResumeLayout(false);
            this.gb_wybierzMetWyszObiek.ResumeLayout(false);
            this.gb_wybierzMetWyszObiek.PerformLayout();
            this.gb_zarzadzaniePrzeksztalceniami.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramObrazuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrMedianowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przekształceniaGeometyryczneToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pb_obrazWe;
        private System.Windows.Forms.ToolStripMenuItem binaryzacjaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odcienieSzarościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poziomJasnościKontrastToolStripMenuItem;
        private System.Windows.Forms.Button btn_wyszukajObiekt;
        private System.Windows.Forms.Label lb_komunikatWyszObie;
        private System.Windows.Forms.GroupBox gb_narzedziaWyszObie;
        private System.Windows.Forms.GroupBox gb_wybierzMetWyszObiek;
        private System.Windows.Forms.RadioButton rb_WyborMetSURF;
        private System.Windows.Forms.RadioButton rb_WyborMetViolaJones;
        private System.Windows.Forms.ComboBox cb_wyborObiektu;
        private System.Windows.Forms.RadioButton rb_WyborMetHOG;
        private System.Windows.Forms.Button btn_cofnijPrzekObr;
        private System.Windows.Forms.ToolStripMenuItem zapiszWynikDetekcjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończDziałanieProgramuToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rTB_historiaOperacji;
        private System.Windows.Forms.GroupBox gb_zarzadzaniePrzeksztalceniami;
        private System.Windows.Forms.ToolStripMenuItem zapiszPostaćAnalizowanegoObrazuToolStripMenuItem;
    }
}


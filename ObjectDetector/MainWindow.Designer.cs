namespace ObjectDetector
{
    partial class MainWindow
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
            this.saveResultOfObjectDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBinarizationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monochromeImageTransformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelOfImageBrightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramOfImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMedianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometricalTransformationOfImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_entranceImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_searchObject = new System.Windows.Forms.Button();
            this.lb_statusOfSearchingObject = new System.Windows.Forms.Label();
            this.gb_imageDetectionTools = new System.Windows.Forms.GroupBox();
            this.cb_wyborObiektu = new System.Windows.Forms.ComboBox();
            this.gb_wybierzMetWyszObiek = new System.Windows.Forms.GroupBox();
            this.rb_hogMethod = new System.Windows.Forms.RadioButton();
            this.rb_surfMethod = new System.Windows.Forms.RadioButton();
            this.rb_violaJonesMethod = new System.Windows.Forms.RadioButton();
            this.btn_undoChanges = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rTB_loggerOfImageTransformationHistory = new System.Windows.Forms.RichTextBox();
            this.gb_zarzadzaniePrzeksztalceniami = new System.Windows.Forms.GroupBox();
            this.saveFormOfAnalizedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_entranceImage)).BeginInit();
            this.gb_imageDetectionTools.SuspendLayout();
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
            this.saveFormOfAnalizedImageToolStripMenuItem,
            this.saveResultOfObjectDetectionToolStripMenuItem,
            this.applicationExitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajObrazToolStripMenuItem
            // 
            this.wczytajObrazToolStripMenuItem.Name = "wczytajObrazToolStripMenuItem";
            this.wczytajObrazToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.wczytajObrazToolStripMenuItem.Text = "Wczytaj obraz";
            this.wczytajObrazToolStripMenuItem.Click += new System.EventHandler(this.LoadImageToolStripMenuItem_Click);
            // 
            // saveResultOfObjectDetectionToolStripMenuItem
            // 
            this.saveResultOfObjectDetectionToolStripMenuItem.Name = "saveResultOfObjectDetectionToolStripMenuItem";
            this.saveResultOfObjectDetectionToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.saveResultOfObjectDetectionToolStripMenuItem.Text = "Zapisz wynik detekcji";
            this.saveResultOfObjectDetectionToolStripMenuItem.Click += new System.EventHandler(this.saveResultOfObjectDetectionToolStripMenuItem_Click);
            // 
            // applicationExitToolStripMenuItem
            // 
            this.applicationExitToolStripMenuItem.Name = "applicationExitToolStripMenuItem";
            this.applicationExitToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.applicationExitToolStripMenuItem.Text = "Zakończ działanie programu";
            this.applicationExitToolStripMenuItem.Click += new System.EventHandler(this.ApplicationExitToolStripMenuItem_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryzacjaToolStripMenuItem,
            this.histogramOfImageToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.geometricalTransformationOfImageToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.opcjeToolStripMenuItem.Text = "Poprawa jakości obrazu";
            // 
            // binaryzacjaToolStripMenuItem
            // 
            this.binaryzacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageBinarizationToolStripMenuItem1,
            this.monochromeImageTransformationToolStripMenuItem,
            this.levelOfImageBrightnessContrastToolStripMenuItem});
            this.binaryzacjaToolStripMenuItem.Name = "binaryzacjaToolStripMenuItem";
            this.binaryzacjaToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.binaryzacjaToolStripMenuItem.Text = "Zmiana barwy obrazu";
            // 
            // imageBinarizationToolStripMenuItem1
            // 
            this.imageBinarizationToolStripMenuItem1.Name = "imageBinarizationToolStripMenuItem1";
            this.imageBinarizationToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.imageBinarizationToolStripMenuItem1.Text = "Binarization";
            this.imageBinarizationToolStripMenuItem1.Click += new System.EventHandler(this.imageBinarizationToolStripMenuItem1_Click);
            // 
            // monochromeImageTransformationToolStripMenuItem
            // 
            this.monochromeImageTransformationToolStripMenuItem.Name = "monochromeImageTransformationToolStripMenuItem";
            this.monochromeImageTransformationToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.monochromeImageTransformationToolStripMenuItem.Text = "Odcienie szarości";
            this.monochromeImageTransformationToolStripMenuItem.Click += new System.EventHandler(this.monochromeImageTransformationToolStripMenuItem_Click);
            // 
            // levelOfImageBrightnessContrastToolStripMenuItem
            // 
            this.levelOfImageBrightnessContrastToolStripMenuItem.Name = "levelOfImageBrightnessContrastToolStripMenuItem";
            this.levelOfImageBrightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.levelOfImageBrightnessContrastToolStripMenuItem.Text = "Poziom jasności, kontrast";
            this.levelOfImageBrightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.levelOfImageBrightnessContrastToolStripMenuItem_Click);
            // 
            // histogramOfImageToolStripMenuItem
            // 
            this.histogramOfImageToolStripMenuItem.Name = "histogramOfImageToolStripMenuItem";
            this.histogramOfImageToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.histogramOfImageToolStripMenuItem.Text = "Statystyka oraz histogram obrazu";
            this.histogramOfImageToolStripMenuItem.Click += new System.EventHandler(this.histogramOfImageToolStripMenuItem_Click);
            // 
            // filtryToolStripMenuItem
            // 
            this.filtryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageMedianFilterToolStripMenuItem});
            this.filtryToolStripMenuItem.Name = "filtryToolStripMenuItem";
            this.filtryToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.filtryToolStripMenuItem.Text = "Filtry obrazu";
            // 
            // imageMedianFilterToolStripMenuItem
            // 
            this.imageMedianFilterToolStripMenuItem.Name = "imageMedianFilterToolStripMenuItem";
            this.imageMedianFilterToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.imageMedianFilterToolStripMenuItem.Text = "Filtr medianowy";
            this.imageMedianFilterToolStripMenuItem.Click += new System.EventHandler(this.imageMedianFilterToolStripMenuItem_Click);
            // 
            // geometricalTransformationOfImageToolStripMenuItem
            // 
            this.geometricalTransformationOfImageToolStripMenuItem.Name = "geometricalTransformationOfImageToolStripMenuItem";
            this.geometricalTransformationOfImageToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.geometricalTransformationOfImageToolStripMenuItem.Text = "Przekształcenia geometryczne";
            this.geometricalTransformationOfImageToolStripMenuItem.Click += new System.EventHandler(this.geometricalTransformationOfImageToolStripMenuItem_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // pb_entranceImage
            // 
            this.pb_entranceImage.Location = new System.Drawing.Point(12, 39);
            this.pb_entranceImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_entranceImage.Name = "pb_entranceImage";
            this.pb_entranceImage.Size = new System.Drawing.Size(480, 480);
            this.pb_entranceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_entranceImage.TabIndex = 1;
            this.pb_entranceImage.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btn_searchObject
            // 
            this.btn_searchObject.Location = new System.Drawing.Point(12, 162);
            this.btn_searchObject.Name = "btn_searchObject";
            this.btn_searchObject.Size = new System.Drawing.Size(240, 49);
            this.btn_searchObject.TabIndex = 2;
            this.btn_searchObject.Text = "Wyszukaj obiekt";
            this.btn_searchObject.UseVisualStyleBackColor = true;
            this.btn_searchObject.Click += new System.EventHandler(this.StartSearchingObject);
            // 
            // lb_statusOfSearchingObject
            // 
            this.lb_statusOfSearchingObject.Location = new System.Drawing.Point(279, 521);
            this.lb_statusOfSearchingObject.Name = "lb_statusOfSearchingObject";
            this.lb_statusOfSearchingObject.Size = new System.Drawing.Size(503, 17);
            this.lb_statusOfSearchingObject.TabIndex = 3;
            this.lb_statusOfSearchingObject.Text = "Wyszukiwanie obiektow na obrazach cyfrowych jest jeszcze niedostępne";
            this.lb_statusOfSearchingObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_imageDetectionTools
            // 
            this.gb_imageDetectionTools.Controls.Add(this.cb_wyborObiektu);
            this.gb_imageDetectionTools.Controls.Add(this.gb_wybierzMetWyszObiek);
            this.gb_imageDetectionTools.Controls.Add(this.btn_searchObject);
            this.gb_imageDetectionTools.Location = new System.Drawing.Point(503, 39);
            this.gb_imageDetectionTools.Name = "gb_imageDetectionTools";
            this.gb_imageDetectionTools.Size = new System.Drawing.Size(267, 223);
            this.gb_imageDetectionTools.TabIndex = 4;
            this.gb_imageDetectionTools.TabStop = false;
            this.gb_imageDetectionTools.Text = "Narzędzia wyszukiwania obiektów";
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
            this.gb_wybierzMetWyszObiek.Controls.Add(this.rb_hogMethod);
            this.gb_wybierzMetWyszObiek.Controls.Add(this.rb_surfMethod);
            this.gb_wybierzMetWyszObiek.Controls.Add(this.rb_violaJonesMethod);
            this.gb_wybierzMetWyszObiek.Location = new System.Drawing.Point(6, 21);
            this.gb_wybierzMetWyszObiek.Name = "gb_wybierzMetWyszObiek";
            this.gb_wybierzMetWyszObiek.Size = new System.Drawing.Size(246, 105);
            this.gb_wybierzMetWyszObiek.TabIndex = 5;
            this.gb_wybierzMetWyszObiek.TabStop = false;
            this.gb_wybierzMetWyszObiek.Text = "Wybierz metodę";
            // 
            // rb_hogMethod
            // 
            this.rb_hogMethod.AutoSize = true;
            this.rb_hogMethod.Location = new System.Drawing.Point(6, 75);
            this.rb_hogMethod.Name = "rb_hogMethod";
            this.rb_hogMethod.Size = new System.Drawing.Size(121, 21);
            this.rb_hogMethod.TabIndex = 5;
            this.rb_hogMethod.TabStop = true;
            this.rb_hogMethod.Text = "HOG Features";
            this.rb_hogMethod.UseVisualStyleBackColor = true;
            this.rb_hogMethod.Click += new System.EventHandler(this.ManagerOfComboboxElementList);
            // 
            // rb_surfMethod
            // 
            this.rb_surfMethod.AutoSize = true;
            this.rb_surfMethod.Location = new System.Drawing.Point(6, 48);
            this.rb_surfMethod.Name = "rb_surfMethod";
            this.rb_surfMethod.Size = new System.Drawing.Size(210, 21);
            this.rb_surfMethod.TabIndex = 4;
            this.rb_surfMethod.TabStop = true;
            this.rb_surfMethod.Text = "Speeded Up Robust Feature";
            this.rb_surfMethod.UseVisualStyleBackColor = true;
            this.rb_surfMethod.Click += new System.EventHandler(this.ManagerOfComboboxElementList);
            // 
            // rb_violaJonesMethod
            // 
            this.rb_violaJonesMethod.AutoSize = true;
            this.rb_violaJonesMethod.Location = new System.Drawing.Point(6, 21);
            this.rb_violaJonesMethod.Name = "rb_violaJonesMethod";
            this.rb_violaJonesMethod.Size = new System.Drawing.Size(102, 21);
            this.rb_violaJonesMethod.TabIndex = 3;
            this.rb_violaJonesMethod.TabStop = true;
            this.rb_violaJonesMethod.Text = "Viola Jones";
            this.rb_violaJonesMethod.UseVisualStyleBackColor = true;
            this.rb_violaJonesMethod.Click += new System.EventHandler(this.ManagerOfComboboxElementList);
            // 
            // btn_undoChanges
            // 
            this.btn_undoChanges.Location = new System.Drawing.Point(12, 202);
            this.btn_undoChanges.Name = "btn_undoChanges";
            this.btn_undoChanges.Size = new System.Drawing.Size(240, 42);
            this.btn_undoChanges.TabIndex = 5;
            this.btn_undoChanges.Text = "Cofnij przekształcenie obrazu";
            this.btn_undoChanges.UseVisualStyleBackColor = true;
            this.btn_undoChanges.Click += new System.EventHandler(this.UndoTransformationChanges);
            // 
            // rTB_loggerOfImageTransformationHistory
            // 
            this.rTB_loggerOfImageTransformationHistory.Location = new System.Drawing.Point(6, 21);
            this.rTB_loggerOfImageTransformationHistory.Name = "rTB_loggerOfImageTransformationHistory";
            this.rTB_loggerOfImageTransformationHistory.ReadOnly = true;
            this.rTB_loggerOfImageTransformationHistory.Size = new System.Drawing.Size(246, 175);
            this.rTB_loggerOfImageTransformationHistory.TabIndex = 6;
            this.rTB_loggerOfImageTransformationHistory.Text = "";
            // 
            // gb_zarzadzaniePrzeksztalceniami
            // 
            this.gb_zarzadzaniePrzeksztalceniami.Controls.Add(this.rTB_loggerOfImageTransformationHistory);
            this.gb_zarzadzaniePrzeksztalceniami.Controls.Add(this.btn_undoChanges);
            this.gb_zarzadzaniePrzeksztalceniami.Location = new System.Drawing.Point(503, 268);
            this.gb_zarzadzaniePrzeksztalceniami.Name = "gb_zarzadzaniePrzeksztalceniami";
            this.gb_zarzadzaniePrzeksztalceniami.Size = new System.Drawing.Size(267, 250);
            this.gb_zarzadzaniePrzeksztalceniami.TabIndex = 7;
            this.gb_zarzadzaniePrzeksztalceniami.TabStop = false;
            this.gb_zarzadzaniePrzeksztalceniami.Text = "Historia przekształceń";
            // 
            // saveFormOfAnalizedImageToolStripMenuItem
            // 
            this.saveFormOfAnalizedImageToolStripMenuItem.Name = "saveFormOfAnalizedImageToolStripMenuItem";
            this.saveFormOfAnalizedImageToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.saveFormOfAnalizedImageToolStripMenuItem.Text = "Zapisz analizowany obraz";
            this.saveFormOfAnalizedImageToolStripMenuItem.Click += new System.EventHandler(this.saveFormOfAnalizedImageToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 541);
            this.Controls.Add(this.gb_zarzadzaniePrzeksztalceniami);
            this.Controls.Add(this.gb_imageDetectionTools);
            this.Controls.Add(this.lb_statusOfSearchingObject);
            this.Controls.Add(this.pb_entranceImage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Algorytmy szybkiego rozpoznawania obiektów na obrazach cyfrowych";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_entranceImage)).EndInit();
            this.gb_imageDetectionTools.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem histogramOfImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageMedianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometricalTransformationOfImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.PictureBox pb_entranceImage;
        private System.Windows.Forms.ToolStripMenuItem imageBinarizationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monochromeImageTransformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelOfImageBrightnessContrastToolStripMenuItem;
        private System.Windows.Forms.Button btn_searchObject;
        private System.Windows.Forms.Label lb_statusOfSearchingObject;
        private System.Windows.Forms.GroupBox gb_imageDetectionTools;
        private System.Windows.Forms.GroupBox gb_wybierzMetWyszObiek;
        private System.Windows.Forms.RadioButton rb_surfMethod;
        private System.Windows.Forms.RadioButton rb_violaJonesMethod;
        private System.Windows.Forms.ComboBox cb_wyborObiektu;
        private System.Windows.Forms.RadioButton rb_hogMethod;
        private System.Windows.Forms.Button btn_undoChanges;
        private System.Windows.Forms.ToolStripMenuItem saveResultOfObjectDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationExitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rTB_loggerOfImageTransformationHistory;
        private System.Windows.Forms.GroupBox gb_zarzadzaniePrzeksztalceniami;
        private System.Windows.Forms.ToolStripMenuItem saveFormOfAnalizedImageToolStripMenuItem;
    }
}


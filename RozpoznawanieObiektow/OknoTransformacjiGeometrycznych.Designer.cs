namespace RozpoznawanieObiektow
{
    partial class OknoTransformacjiGeometrycznych
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
            this.gb_Narzedzia = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSterowania = new System.Windows.Forms.Panel();
            this.txtb_ustalKat = new System.Windows.Forms.TextBox();
            this.btn_LewyBtn = new System.Windows.Forms.Button();
            this.btn_prawyBtn = new System.Windows.Forms.Button();
            this.trackb_przyblizenieObrazu = new System.Windows.Forms.TrackBar();
            this.btn_zatwierdzOperacje = new System.Windows.Forms.Button();
            this.trackb_ustalWys = new System.Windows.Forms.TrackBar();
            this.trackb_ustalSzer = new System.Windows.Forms.TrackBar();
            this.btn_zatwierdzPrzyciecie = new System.Windows.Forms.Button();
            this.numericUD_szerPocz = new System.Windows.Forms.NumericUpDown();
            this.numericUD_wysPocz = new System.Windows.Forms.NumericUpDown();
            this.numericUD_szerPrzyc = new System.Windows.Forms.NumericUpDown();
            this.numericUD_wysPrzyc = new System.Windows.Forms.NumericUpDown();
            this.gb_przytnijObraz = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_obrazWeTransGeo = new System.Windows.Forms.PictureBox();
            this.lb_komunikatPozycjaSzer = new System.Windows.Forms.Label();
            this.lb_komunikatPozycjaWys = new System.Windows.Forms.Label();
            this.lb_komunikatSzerWycinanie = new System.Windows.Forms.Label();
            this.lb_komunikatWysWycinanie = new System.Windows.Forms.Label();
            this.gb_Narzedzia.SuspendLayout();
            this.panelSterowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_przyblizenieObrazu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_ustalWys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_ustalSzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_szerPocz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_wysPocz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_szerPrzyc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_wysPrzyc)).BeginInit();
            this.gb_przytnijObraz.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeTransGeo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Narzedzia
            // 
            this.gb_Narzedzia.Controls.Add(this.label2);
            this.gb_Narzedzia.Controls.Add(this.label1);
            this.gb_Narzedzia.Controls.Add(this.panelSterowania);
            this.gb_Narzedzia.Controls.Add(this.trackb_przyblizenieObrazu);
            this.gb_Narzedzia.Location = new System.Drawing.Point(394, 48);
            this.gb_Narzedzia.Name = "gb_Narzedzia";
            this.gb_Narzedzia.Size = new System.Drawing.Size(150, 299);
            this.gb_Narzedzia.TabIndex = 4;
            this.gb_Narzedzia.TabStop = false;
            this.gb_Narzedzia.Text = "Narzędzia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obróć obraz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Przybliż/oddal obraz";
            // 
            // panelSterowania
            // 
            this.panelSterowania.Controls.Add(this.txtb_ustalKat);
            this.panelSterowania.Controls.Add(this.btn_LewyBtn);
            this.panelSterowania.Controls.Add(this.btn_prawyBtn);
            this.panelSterowania.Location = new System.Drawing.Point(6, 249);
            this.panelSterowania.Name = "panelSterowania";
            this.panelSterowania.Size = new System.Drawing.Size(136, 44);
            this.panelSterowania.TabIndex = 8;
            // 
            // txtb_ustalKat
            // 
            this.txtb_ustalKat.Location = new System.Drawing.Point(55, 8);
            this.txtb_ustalKat.Name = "txtb_ustalKat";
            this.txtb_ustalKat.Size = new System.Drawing.Size(27, 22);
            this.txtb_ustalKat.TabIndex = 2;
            // 
            // btn_LewyBtn
            // 
            this.btn_LewyBtn.Image = global::RozpoznawanieObiektow.Properties.Resources.rotating_arrow_to_the_left;
            this.btn_LewyBtn.Location = new System.Drawing.Point(88, 4);
            this.btn_LewyBtn.Name = "btn_LewyBtn";
            this.btn_LewyBtn.Size = new System.Drawing.Size(45, 30);
            this.btn_LewyBtn.TabIndex = 0;
            this.btn_LewyBtn.UseVisualStyleBackColor = true;
            this.btn_LewyBtn.Click += new System.EventHandler(this.ObrotWLewo);
            // 
            // btn_prawyBtn
            // 
            this.btn_prawyBtn.Image = global::RozpoznawanieObiektow.Properties.Resources.rotating_arrow_to_the_right;
            this.btn_prawyBtn.Location = new System.Drawing.Point(3, 4);
            this.btn_prawyBtn.Name = "btn_prawyBtn";
            this.btn_prawyBtn.Size = new System.Drawing.Size(45, 30);
            this.btn_prawyBtn.TabIndex = 1;
            this.btn_prawyBtn.UseVisualStyleBackColor = true;
            this.btn_prawyBtn.Click += new System.EventHandler(this.ObrotWPrawo);
            // 
            // trackb_przyblizenieObrazu
            // 
            this.trackb_przyblizenieObrazu.Location = new System.Drawing.Point(23, 44);
            this.trackb_przyblizenieObrazu.Maximum = 30;
            this.trackb_przyblizenieObrazu.Minimum = -30;
            this.trackb_przyblizenieObrazu.Name = "trackb_przyblizenieObrazu";
            this.trackb_przyblizenieObrazu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackb_przyblizenieObrazu.Size = new System.Drawing.Size(56, 168);
            this.trackb_przyblizenieObrazu.TabIndex = 7;
            this.trackb_przyblizenieObrazu.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_zatwierdzOperacje
            // 
            this.btn_zatwierdzOperacje.Location = new System.Drawing.Point(394, 383);
            this.btn_zatwierdzOperacje.Name = "btn_zatwierdzOperacje";
            this.btn_zatwierdzOperacje.Size = new System.Drawing.Size(150, 134);
            this.btn_zatwierdzOperacje.TabIndex = 6;
            this.btn_zatwierdzOperacje.Text = "Zatwierdź operacje";
            this.btn_zatwierdzOperacje.UseVisualStyleBackColor = true;
            this.btn_zatwierdzOperacje.Click += new System.EventHandler(this.btn_zatwierdzOperacje_Click);
            // 
            // trackb_ustalWys
            // 
            this.trackb_ustalWys.Location = new System.Drawing.Point(12, 48);
            this.trackb_ustalWys.Maximum = 4;
            this.trackb_ustalWys.Name = "trackb_ustalWys";
            this.trackb_ustalWys.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackb_ustalWys.Size = new System.Drawing.Size(56, 317);
            this.trackb_ustalWys.TabIndex = 8;
            this.trackb_ustalWys.Value = 4;
            this.trackb_ustalWys.Scroll += new System.EventHandler(this.trackb_ustalWys_Scroll);
            // 
            // trackb_ustalSzer
            // 
            this.trackb_ustalSzer.Location = new System.Drawing.Point(50, -3);
            this.trackb_ustalSzer.Maximum = 4;
            this.trackb_ustalSzer.Name = "trackb_ustalSzer";
            this.trackb_ustalSzer.Size = new System.Drawing.Size(320, 56);
            this.trackb_ustalSzer.TabIndex = 9;
            this.trackb_ustalSzer.Value = 4;
            this.trackb_ustalSzer.Scroll += new System.EventHandler(this.trackb_ustalSzer_Scroll);
            // 
            // btn_zatwierdzPrzyciecie
            // 
            this.btn_zatwierdzPrzyciecie.Location = new System.Drawing.Point(225, 34);
            this.btn_zatwierdzPrzyciecie.Name = "btn_zatwierdzPrzyciecie";
            this.btn_zatwierdzPrzyciecie.Size = new System.Drawing.Size(89, 78);
            this.btn_zatwierdzPrzyciecie.TabIndex = 10;
            this.btn_zatwierdzPrzyciecie.Text = "OK";
            this.btn_zatwierdzPrzyciecie.UseVisualStyleBackColor = true;
            this.btn_zatwierdzPrzyciecie.Click += new System.EventHandler(this.btn_zatwierdzPrzyciecie_Click);
            // 
            // numericUD_szerPocz
            // 
            this.numericUD_szerPocz.Location = new System.Drawing.Point(99, 21);
            this.numericUD_szerPocz.Name = "numericUD_szerPocz";
            this.numericUD_szerPocz.Size = new System.Drawing.Size(120, 22);
            this.numericUD_szerPocz.TabIndex = 15;
            this.numericUD_szerPocz.ValueChanged += new System.EventHandler(this.numericUD_szerPocz_ValueChanged);
            // 
            // numericUD_wysPocz
            // 
            this.numericUD_wysPocz.Location = new System.Drawing.Point(99, 49);
            this.numericUD_wysPocz.Name = "numericUD_wysPocz";
            this.numericUD_wysPocz.Size = new System.Drawing.Size(120, 22);
            this.numericUD_wysPocz.TabIndex = 16;
            this.numericUD_wysPocz.ValueChanged += new System.EventHandler(this.numericUD_wysPocz_ValueChanged);
            // 
            // numericUD_szerPrzyc
            // 
            this.numericUD_szerPrzyc.Location = new System.Drawing.Point(99, 77);
            this.numericUD_szerPrzyc.Name = "numericUD_szerPrzyc";
            this.numericUD_szerPrzyc.Size = new System.Drawing.Size(120, 22);
            this.numericUD_szerPrzyc.TabIndex = 17;
            this.numericUD_szerPrzyc.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUD_szerPrzyc.ValueChanged += new System.EventHandler(this.numericUD_szerPrzyc_ValueChanged);
            // 
            // numericUD_wysPrzyc
            // 
            this.numericUD_wysPrzyc.Location = new System.Drawing.Point(99, 105);
            this.numericUD_wysPrzyc.Name = "numericUD_wysPrzyc";
            this.numericUD_wysPrzyc.Size = new System.Drawing.Size(120, 22);
            this.numericUD_wysPrzyc.TabIndex = 18;
            this.numericUD_wysPrzyc.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUD_wysPrzyc.ValueChanged += new System.EventHandler(this.numericUD_wysPrzyc_ValueChanged);
            // 
            // gb_przytnijObraz
            // 
            this.gb_przytnijObraz.Controls.Add(this.lb_komunikatWysWycinanie);
            this.gb_przytnijObraz.Controls.Add(this.lb_komunikatSzerWycinanie);
            this.gb_przytnijObraz.Controls.Add(this.lb_komunikatPozycjaWys);
            this.gb_przytnijObraz.Controls.Add(this.lb_komunikatPozycjaSzer);
            this.gb_przytnijObraz.Controls.Add(this.numericUD_szerPocz);
            this.gb_przytnijObraz.Controls.Add(this.btn_zatwierdzPrzyciecie);
            this.gb_przytnijObraz.Controls.Add(this.numericUD_wysPrzyc);
            this.gb_przytnijObraz.Controls.Add(this.numericUD_wysPocz);
            this.gb_przytnijObraz.Controls.Add(this.numericUD_szerPrzyc);
            this.gb_przytnijObraz.Location = new System.Drawing.Point(50, 377);
            this.gb_przytnijObraz.Name = "gb_przytnijObraz";
            this.gb_przytnijObraz.Size = new System.Drawing.Size(320, 136);
            this.gb_przytnijObraz.TabIndex = 19;
            this.gb_przytnijObraz.TabStop = false;
            this.gb_przytnijObraz.Text = "Przytnij obraz";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pb_obrazWeTransGeo);
            this.panel1.Location = new System.Drawing.Point(50, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 319);
            this.panel1.TabIndex = 20;
            // 
            // pb_obrazWeTransGeo
            // 
            this.pb_obrazWeTransGeo.Location = new System.Drawing.Point(0, 0);
            this.pb_obrazWeTransGeo.Name = "pb_obrazWeTransGeo";
            this.pb_obrazWeTransGeo.Size = new System.Drawing.Size(320, 320);
            this.pb_obrazWeTransGeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_obrazWeTransGeo.TabIndex = 5;
            this.pb_obrazWeTransGeo.TabStop = false;
            this.pb_obrazWeTransGeo.Click += new System.EventHandler(this.pb_obrazWeTransGeo_Click);
            // 
            // lb_komunikatPozycjaSzer
            // 
            this.lb_komunikatPozycjaSzer.AutoSize = true;
            this.lb_komunikatPozycjaSzer.Location = new System.Drawing.Point(6, 26);
            this.lb_komunikatPozycjaSzer.Name = "lb_komunikatPozycjaSzer";
            this.lb_komunikatPozycjaSzer.Size = new System.Drawing.Size(74, 17);
            this.lb_komunikatPozycjaSzer.TabIndex = 19;
            this.lb_komunikatPozycjaSzer.Text = "Pozycja X:";
            // 
            // lb_komunikatPozycjaWys
            // 
            this.lb_komunikatPozycjaWys.AutoSize = true;
            this.lb_komunikatPozycjaWys.Location = new System.Drawing.Point(6, 54);
            this.lb_komunikatPozycjaWys.Name = "lb_komunikatPozycjaWys";
            this.lb_komunikatPozycjaWys.Size = new System.Drawing.Size(74, 17);
            this.lb_komunikatPozycjaWys.TabIndex = 20;
            this.lb_komunikatPozycjaWys.Text = "Pozycja Y:";
            // 
            // lb_komunikatSzerWycinanie
            // 
            this.lb_komunikatSzerWycinanie.AutoSize = true;
            this.lb_komunikatSzerWycinanie.Location = new System.Drawing.Point(6, 82);
            this.lb_komunikatSzerWycinanie.Name = "lb_komunikatSzerWycinanie";
            this.lb_komunikatSzerWycinanie.Size = new System.Drawing.Size(78, 17);
            this.lb_komunikatSzerWycinanie.TabIndex = 21;
            this.lb_komunikatSzerWycinanie.Text = "Szerokość:";
            // 
            // lb_komunikatWysWycinanie
            // 
            this.lb_komunikatWysWycinanie.AutoSize = true;
            this.lb_komunikatWysWycinanie.Location = new System.Drawing.Point(6, 105);
            this.lb_komunikatWysWycinanie.Name = "lb_komunikatWysWycinanie";
            this.lb_komunikatWysWycinanie.Size = new System.Drawing.Size(76, 17);
            this.lb_komunikatWysWycinanie.TabIndex = 22;
            this.lb_komunikatWysWycinanie.Text = "Wysokość:";
            // 
            // OknoTransformacjiGeometrycznych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_przytnijObraz);
            this.Controls.Add(this.trackb_ustalSzer);
            this.Controls.Add(this.trackb_ustalWys);
            this.Controls.Add(this.btn_zatwierdzOperacje);
            this.Controls.Add(this.gb_Narzedzia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OknoTransformacjiGeometrycznych";
            this.Text = "Manipulacja geometryczna obrazem";
            this.Load += new System.EventHandler(this.OknoTransformacjiGeometrycznych_Load);
            this.gb_Narzedzia.ResumeLayout(false);
            this.gb_Narzedzia.PerformLayout();
            this.panelSterowania.ResumeLayout(false);
            this.panelSterowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_przyblizenieObrazu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_ustalWys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_ustalSzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_szerPocz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_wysPocz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_szerPrzyc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_wysPrzyc)).EndInit();
            this.gb_przytnijObraz.ResumeLayout(false);
            this.gb_przytnijObraz.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeTransGeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Narzedzia;
        private System.Windows.Forms.Button btn_prawyBtn;
        private System.Windows.Forms.Button btn_LewyBtn;
        public System.Windows.Forms.PictureBox pb_obrazWeTransGeo;
        private System.Windows.Forms.Button btn_zatwierdzOperacje;
        private System.Windows.Forms.TrackBar trackb_przyblizenieObrazu;
        private System.Windows.Forms.Panel panelSterowania;
        private System.Windows.Forms.TrackBar trackb_ustalWys;
        private System.Windows.Forms.TrackBar trackb_ustalSzer;
        private System.Windows.Forms.Button btn_zatwierdzPrzyciecie;
        private System.Windows.Forms.NumericUpDown numericUD_szerPocz;
        private System.Windows.Forms.NumericUpDown numericUD_wysPocz;
        private System.Windows.Forms.NumericUpDown numericUD_szerPrzyc;
        private System.Windows.Forms.NumericUpDown numericUD_wysPrzyc;
        private System.Windows.Forms.GroupBox gb_przytnijObraz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_ustalKat;
        private System.Windows.Forms.Label lb_komunikatWysWycinanie;
        private System.Windows.Forms.Label lb_komunikatSzerWycinanie;
        private System.Windows.Forms.Label lb_komunikatPozycjaWys;
        private System.Windows.Forms.Label lb_komunikatPozycjaSzer;
    }
}
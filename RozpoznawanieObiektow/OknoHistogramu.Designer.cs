namespace RozpoznawanieObiektow
{
    partial class OknoHistogramu
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
            this.btn_wyrownajHistogram = new System.Windows.Forms.Button();
            this.gb_operacje = new System.Windows.Forms.GroupBox();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.rb_histogramLiniowy = new System.Windows.Forms.RadioButton();
            this.rb_histogram = new System.Windows.Forms.RadioButton();
            this.gb_histogram = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_kanalHistogramu = new System.Windows.Forms.ComboBox();
            this.pb_histogramObrazu = new System.Windows.Forms.PictureBox();
            this.gb_miaryStat = new System.Windows.Forms.GroupBox();
            this.lb_wartoscAnalizKolor = new System.Windows.Forms.Label();
            this.lb_analizowanyKolor = new System.Windows.Forms.Label();
            this.lb_wartoscOdchylenie = new System.Windows.Forms.Label();
            this.lb_wartoscKontrast = new System.Windows.Forms.Label();
            this.lb_wartoscMax = new System.Windows.Forms.Label();
            this.lb_wartoscMin = new System.Windows.Forms.Label();
            this.lb_wartoscWariancja = new System.Windows.Forms.Label();
            this.lb_wartoscSrednia = new System.Windows.Forms.Label();
            this.lb_odchylenie = new System.Windows.Forms.Label();
            this.lb_kontrast = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_wariancja = new System.Windows.Forms.Label();
            this.lb_srednia = new System.Windows.Forms.Label();
            this.pb_obrazWeHistogram = new System.Windows.Forms.PictureBox();
            this.gb_operacje.SuspendLayout();
            this.gb_histogram.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramObrazu)).BeginInit();
            this.gb_miaryStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_wyrownajHistogram
            // 
            this.btn_wyrownajHistogram.Location = new System.Drawing.Point(6, 19);
            this.btn_wyrownajHistogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_wyrownajHistogram.Name = "btn_wyrownajHistogram";
            this.btn_wyrownajHistogram.Size = new System.Drawing.Size(173, 46);
            this.btn_wyrownajHistogram.TabIndex = 3;
            this.btn_wyrownajHistogram.Text = "Wyrównaj histogram";
            this.btn_wyrownajHistogram.UseVisualStyleBackColor = true;
            this.btn_wyrownajHistogram.Click += new System.EventHandler(this.btn_wyrownajHistogram_Click);
            // 
            // gb_operacje
            // 
            this.gb_operacje.Controls.Add(this.btn_zatwierdz);
            this.gb_operacje.Controls.Add(this.btn_wyrownajHistogram);
            this.gb_operacje.Location = new System.Drawing.Point(347, 335);
            this.gb_operacje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_operacje.Name = "gb_operacje";
            this.gb_operacje.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_operacje.Size = new System.Drawing.Size(393, 73);
            this.gb_operacje.TabIndex = 4;
            this.gb_operacje.TabStop = false;
            this.gb_operacje.Text = "Operacje";
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.Location = new System.Drawing.Point(210, 19);
            this.btn_zatwierdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(177, 46);
            this.btn_zatwierdz.TabIndex = 5;
            this.btn_zatwierdz.Text = "Zatwierdź operacje";
            this.btn_zatwierdz.UseVisualStyleBackColor = true;
            this.btn_zatwierdz.Click += new System.EventHandler(this.btn_zatwierdz_Click);
            // 
            // rb_histogramLiniowy
            // 
            this.rb_histogramLiniowy.AutoSize = true;
            this.rb_histogramLiniowy.Location = new System.Drawing.Point(3, 2);
            this.rb_histogramLiniowy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_histogramLiniowy.Name = "rb_histogramLiniowy";
            this.rb_histogramLiniowy.Size = new System.Drawing.Size(138, 21);
            this.rb_histogramLiniowy.TabIndex = 6;
            this.rb_histogramLiniowy.TabStop = true;
            this.rb_histogramLiniowy.Text = "Histogram liniowy";
            this.rb_histogramLiniowy.UseVisualStyleBackColor = true;
            this.rb_histogramLiniowy.CheckedChanged += new System.EventHandler(this.wybierzRodzajHistogramu);
            // 
            // rb_histogram
            // 
            this.rb_histogram.AutoSize = true;
            this.rb_histogram.Location = new System.Drawing.Point(3, 30);
            this.rb_histogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_histogram.Name = "rb_histogram";
            this.rb_histogram.Size = new System.Drawing.Size(97, 21);
            this.rb_histogram.TabIndex = 7;
            this.rb_histogram.TabStop = true;
            this.rb_histogram.Text = "Histogram ";
            this.rb_histogram.UseVisualStyleBackColor = true;
            this.rb_histogram.CheckedChanged += new System.EventHandler(this.wybierzRodzajHistogramu);
            // 
            // gb_histogram
            // 
            this.gb_histogram.Controls.Add(this.panel1);
            this.gb_histogram.Controls.Add(this.pb_histogramObrazu);
            this.gb_histogram.Location = new System.Drawing.Point(339, 2);
            this.gb_histogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_histogram.Name = "gb_histogram";
            this.gb_histogram.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_histogram.Size = new System.Drawing.Size(401, 329);
            this.gb_histogram.TabIndex = 6;
            this.gb_histogram.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_histogramLiniowy);
            this.panel1.Controls.Add(this.cb_kanalHistogramu);
            this.panel1.Controls.Add(this.rb_histogram);
            this.panel1.Location = new System.Drawing.Point(5, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 113);
            this.panel1.TabIndex = 9;
            // 
            // cb_kanalHistogramu
            // 
            this.cb_kanalHistogramu.FormattingEnabled = true;
            this.cb_kanalHistogramu.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Szary"});
            this.cb_kanalHistogramu.Location = new System.Drawing.Point(3, 57);
            this.cb_kanalHistogramu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_kanalHistogramu.Name = "cb_kanalHistogramu";
            this.cb_kanalHistogramu.Size = new System.Drawing.Size(161, 24);
            this.cb_kanalHistogramu.TabIndex = 8;
            this.cb_kanalHistogramu.SelectedIndexChanged += new System.EventHandler(this.cb_kanalHistogramu_SelectedIndexChanged);
            // 
            // pb_histogramObrazu
            // 
            this.pb_histogramObrazu.Location = new System.Drawing.Point(5, 135);
            this.pb_histogramObrazu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_histogramObrazu.Name = "pb_histogramObrazu";
            this.pb_histogramObrazu.Size = new System.Drawing.Size(381, 187);
            this.pb_histogramObrazu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_histogramObrazu.TabIndex = 1;
            this.pb_histogramObrazu.TabStop = false;
            // 
            // gb_miaryStat
            // 
            this.gb_miaryStat.Controls.Add(this.lb_wartoscAnalizKolor);
            this.gb_miaryStat.Controls.Add(this.lb_analizowanyKolor);
            this.gb_miaryStat.Controls.Add(this.lb_wartoscOdchylenie);
            this.gb_miaryStat.Controls.Add(this.lb_wartoscKontrast);
            this.gb_miaryStat.Controls.Add(this.lb_wartoscMax);
            this.gb_miaryStat.Controls.Add(this.lb_wartoscMin);
            this.gb_miaryStat.Controls.Add(this.lb_wartoscWariancja);
            this.gb_miaryStat.Controls.Add(this.lb_wartoscSrednia);
            this.gb_miaryStat.Controls.Add(this.lb_odchylenie);
            this.gb_miaryStat.Controls.Add(this.lb_kontrast);
            this.gb_miaryStat.Controls.Add(this.lb_max);
            this.gb_miaryStat.Controls.Add(this.lb_min);
            this.gb_miaryStat.Controls.Add(this.lb_wariancja);
            this.gb_miaryStat.Controls.Add(this.lb_srednia);
            this.gb_miaryStat.Location = new System.Drawing.Point(755, 12);
            this.gb_miaryStat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_miaryStat.Name = "gb_miaryStat";
            this.gb_miaryStat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_miaryStat.Size = new System.Drawing.Size(285, 314);
            this.gb_miaryStat.TabIndex = 7;
            this.gb_miaryStat.TabStop = false;
            this.gb_miaryStat.Text = "Miary statystyczne histogramu";
            // 
            // lb_wartoscAnalizKolor
            // 
            this.lb_wartoscAnalizKolor.AutoSize = true;
            this.lb_wartoscAnalizKolor.Location = new System.Drawing.Point(155, 27);
            this.lb_wartoscAnalizKolor.Name = "lb_wartoscAnalizKolor";
            this.lb_wartoscAnalizKolor.Size = new System.Drawing.Size(72, 17);
            this.lb_wartoscAnalizKolor.TabIndex = 13;
            this.lb_wartoscAnalizKolor.Text = "00000000";
            // 
            // lb_analizowanyKolor
            // 
            this.lb_analizowanyKolor.AutoSize = true;
            this.lb_analizowanyKolor.Location = new System.Drawing.Point(21, 27);
            this.lb_analizowanyKolor.Name = "lb_analizowanyKolor";
            this.lb_analizowanyKolor.Size = new System.Drawing.Size(125, 17);
            this.lb_analizowanyKolor.TabIndex = 12;
            this.lb_analizowanyKolor.Text = "Analizowany kolor:";
            // 
            // lb_wartoscOdchylenie
            // 
            this.lb_wartoscOdchylenie.AutoSize = true;
            this.lb_wartoscOdchylenie.Location = new System.Drawing.Point(107, 191);
            this.lb_wartoscOdchylenie.Name = "lb_wartoscOdchylenie";
            this.lb_wartoscOdchylenie.Size = new System.Drawing.Size(40, 17);
            this.lb_wartoscOdchylenie.TabIndex = 11;
            this.lb_wartoscOdchylenie.Text = "0000";
            // 
            // lb_wartoscKontrast
            // 
            this.lb_wartoscKontrast.AutoSize = true;
            this.lb_wartoscKontrast.Location = new System.Drawing.Point(107, 165);
            this.lb_wartoscKontrast.Name = "lb_wartoscKontrast";
            this.lb_wartoscKontrast.Size = new System.Drawing.Size(40, 17);
            this.lb_wartoscKontrast.TabIndex = 10;
            this.lb_wartoscKontrast.Text = "0000";
            // 
            // lb_wartoscMax
            // 
            this.lb_wartoscMax.AutoSize = true;
            this.lb_wartoscMax.Location = new System.Drawing.Point(107, 139);
            this.lb_wartoscMax.Name = "lb_wartoscMax";
            this.lb_wartoscMax.Size = new System.Drawing.Size(40, 17);
            this.lb_wartoscMax.TabIndex = 9;
            this.lb_wartoscMax.Text = "0000";
            // 
            // lb_wartoscMin
            // 
            this.lb_wartoscMin.AutoSize = true;
            this.lb_wartoscMin.Location = new System.Drawing.Point(107, 107);
            this.lb_wartoscMin.Name = "lb_wartoscMin";
            this.lb_wartoscMin.Size = new System.Drawing.Size(40, 17);
            this.lb_wartoscMin.TabIndex = 8;
            this.lb_wartoscMin.Text = "0000";
            // 
            // lb_wartoscWariancja
            // 
            this.lb_wartoscWariancja.AutoSize = true;
            this.lb_wartoscWariancja.Location = new System.Drawing.Point(107, 81);
            this.lb_wartoscWariancja.Name = "lb_wartoscWariancja";
            this.lb_wartoscWariancja.Size = new System.Drawing.Size(40, 17);
            this.lb_wartoscWariancja.TabIndex = 7;
            this.lb_wartoscWariancja.Text = "0000";
            // 
            // lb_wartoscSrednia
            // 
            this.lb_wartoscSrednia.AutoSize = true;
            this.lb_wartoscSrednia.Location = new System.Drawing.Point(107, 54);
            this.lb_wartoscSrednia.Name = "lb_wartoscSrednia";
            this.lb_wartoscSrednia.Size = new System.Drawing.Size(40, 17);
            this.lb_wartoscSrednia.TabIndex = 6;
            this.lb_wartoscSrednia.Text = "0000";
            // 
            // lb_odchylenie
            // 
            this.lb_odchylenie.AutoSize = true;
            this.lb_odchylenie.Location = new System.Drawing.Point(21, 191);
            this.lb_odchylenie.Name = "lb_odchylenie";
            this.lb_odchylenie.Size = new System.Drawing.Size(79, 17);
            this.lb_odchylenie.TabIndex = 5;
            this.lb_odchylenie.Text = "Odchylenie";
            // 
            // lb_kontrast
            // 
            this.lb_kontrast.AutoSize = true;
            this.lb_kontrast.Location = new System.Drawing.Point(21, 165);
            this.lb_kontrast.Name = "lb_kontrast";
            this.lb_kontrast.Size = new System.Drawing.Size(61, 17);
            this.lb_kontrast.TabIndex = 4;
            this.lb_kontrast.Text = "Kontrast";
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Location = new System.Drawing.Point(21, 139);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(33, 17);
            this.lb_max.TabIndex = 3;
            this.lb_max.Text = "Max";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Location = new System.Drawing.Point(21, 107);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(30, 17);
            this.lb_min.TabIndex = 2;
            this.lb_min.Text = "Min";
            // 
            // lb_wariancja
            // 
            this.lb_wariancja.AutoSize = true;
            this.lb_wariancja.Location = new System.Drawing.Point(21, 81);
            this.lb_wariancja.Name = "lb_wariancja";
            this.lb_wariancja.Size = new System.Drawing.Size(71, 17);
            this.lb_wariancja.TabIndex = 1;
            this.lb_wariancja.Text = "Wariancja";
            // 
            // lb_srednia
            // 
            this.lb_srednia.AutoSize = true;
            this.lb_srednia.Location = new System.Drawing.Point(21, 54);
            this.lb_srednia.Name = "lb_srednia";
            this.lb_srednia.Size = new System.Drawing.Size(57, 17);
            this.lb_srednia.TabIndex = 0;
            this.lb_srednia.Text = "Średnia";
            // 
            // pb_obrazWeHistogram
            // 
            this.pb_obrazWeHistogram.Location = new System.Drawing.Point(12, 12);
            this.pb_obrazWeHistogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_obrazWeHistogram.Name = "pb_obrazWeHistogram";
            this.pb_obrazWeHistogram.Size = new System.Drawing.Size(320, 320);
            this.pb_obrazWeHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_obrazWeHistogram.TabIndex = 0;
            this.pb_obrazWeHistogram.TabStop = false;
            // 
            // OknoHistogramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 422);
            this.Controls.Add(this.gb_miaryStat);
            this.Controls.Add(this.gb_histogram);
            this.Controls.Add(this.gb_operacje);
            this.Controls.Add(this.pb_obrazWeHistogram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OknoHistogramu";
            this.Text = "Histogram analizowanego obrazu";
            this.Load += new System.EventHandler(this.OknoHistogramu_Load);
            this.gb_operacje.ResumeLayout(false);
            this.gb_histogram.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_histogramObrazu)).EndInit();
            this.gb_miaryStat.ResumeLayout(false);
            this.gb_miaryStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_obrazWeHistogram;
        private System.Windows.Forms.PictureBox pb_histogramObrazu;
        private System.Windows.Forms.Button btn_wyrownajHistogram;
        private System.Windows.Forms.GroupBox gb_operacje;
        private System.Windows.Forms.Button btn_zatwierdz;
        private System.Windows.Forms.GroupBox gb_histogram;
        private System.Windows.Forms.RadioButton rb_histogram;
        private System.Windows.Forms.RadioButton rb_histogramLiniowy;
        private System.Windows.Forms.ComboBox cb_kanalHistogramu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_miaryStat;
        private System.Windows.Forms.Label lb_wartoscOdchylenie;
        private System.Windows.Forms.Label lb_wartoscKontrast;
        private System.Windows.Forms.Label lb_wartoscMax;
        private System.Windows.Forms.Label lb_wartoscMin;
        private System.Windows.Forms.Label lb_wartoscWariancja;
        private System.Windows.Forms.Label lb_wartoscSrednia;
        private System.Windows.Forms.Label lb_odchylenie;
        private System.Windows.Forms.Label lb_kontrast;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_wariancja;
        private System.Windows.Forms.Label lb_srednia;
        private System.Windows.Forms.Label lb_wartoscAnalizKolor;
        private System.Windows.Forms.Label lb_analizowanyKolor;
    }
}
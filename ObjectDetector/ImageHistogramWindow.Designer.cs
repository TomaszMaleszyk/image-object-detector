namespace ObjectDetector
{
    partial class ImageHistogramWindow
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
            this.btn_alignHistogram = new System.Windows.Forms.Button();
            this.gb_operationsPanel = new System.Windows.Forms.GroupBox();
            this.btn_confirmOperation = new System.Windows.Forms.Button();
            this.rb_linearHistogram = new System.Windows.Forms.RadioButton();
            this.rb_histogram = new System.Windows.Forms.RadioButton();
            this.gb_histogram = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.cb_histogramChannel = new System.Windows.Forms.ComboBox();
            this.pb_imageHistogram = new System.Windows.Forms.PictureBox();
            this.gb_statisticMeasures = new System.Windows.Forms.GroupBox();
            this.lb_analizedColorValue = new System.Windows.Forms.Label();
            this.lb_analizedColor = new System.Windows.Forms.Label();
            this.lb_abberationValue = new System.Windows.Forms.Label();
            this.lb_contrastValue = new System.Windows.Forms.Label();
            this.lb_maxColorValue = new System.Windows.Forms.Label();
            this.lb_minColorValue = new System.Windows.Forms.Label();
            this.lb_varianceValue = new System.Windows.Forms.Label();
            this.lb_averageColorValue = new System.Windows.Forms.Label();
            this.lb_aberration = new System.Windows.Forms.Label();
            this.lb_contrast = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_variance = new System.Windows.Forms.Label();
            this.lb_average = new System.Windows.Forms.Label();
            this.pb_entranceImage = new System.Windows.Forms.PictureBox();
            this.gb_operationsPanel.SuspendLayout();
            this.gb_histogram.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageHistogram)).BeginInit();
            this.gb_statisticMeasures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_entranceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alignHistogram
            // 
            this.btn_alignHistogram.Location = new System.Drawing.Point(6, 19);
            this.btn_alignHistogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alignHistogram.Name = "btn_alignHistogram";
            this.btn_alignHistogram.Size = new System.Drawing.Size(173, 46);
            this.btn_alignHistogram.TabIndex = 3;
            this.btn_alignHistogram.Text = "Wyrównaj histogram";
            this.btn_alignHistogram.UseVisualStyleBackColor = true;
            this.btn_alignHistogram.Click += new System.EventHandler(this.AlignHistogram);
            // 
            // gb_operationsPanel
            // 
            this.gb_operationsPanel.Controls.Add(this.btn_confirmOperation);
            this.gb_operationsPanel.Controls.Add(this.btn_alignHistogram);
            this.gb_operationsPanel.Location = new System.Drawing.Point(347, 335);
            this.gb_operationsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_operationsPanel.Name = "gb_operationsPanel";
            this.gb_operationsPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_operationsPanel.Size = new System.Drawing.Size(393, 73);
            this.gb_operationsPanel.TabIndex = 4;
            this.gb_operationsPanel.TabStop = false;
            this.gb_operationsPanel.Text = "Operacje";
            // 
            // btn_confirmOperation
            // 
            this.btn_confirmOperation.Location = new System.Drawing.Point(210, 19);
            this.btn_confirmOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_confirmOperation.Name = "btn_confirmOperation";
            this.btn_confirmOperation.Size = new System.Drawing.Size(177, 46);
            this.btn_confirmOperation.TabIndex = 5;
            this.btn_confirmOperation.Text = "Zatwierdź operacje";
            this.btn_confirmOperation.UseVisualStyleBackColor = true;
            this.btn_confirmOperation.Click += new System.EventHandler(this.ConfirmOperation);
            // 
            // rb_linearHistogram
            // 
            this.rb_linearHistogram.AutoSize = true;
            this.rb_linearHistogram.Location = new System.Drawing.Point(3, 2);
            this.rb_linearHistogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_linearHistogram.Name = "rb_linearHistogram";
            this.rb_linearHistogram.Size = new System.Drawing.Size(138, 21);
            this.rb_linearHistogram.TabIndex = 6;
            this.rb_linearHistogram.TabStop = true;
            this.rb_linearHistogram.Text = "Histogram liniowy";
            this.rb_linearHistogram.UseVisualStyleBackColor = true;
            this.rb_linearHistogram.CheckedChanged += new System.EventHandler(this.OnChooseKindOfHistogram);
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
            this.rb_histogram.CheckedChanged += new System.EventHandler(this.OnChooseKindOfHistogram);
            // 
            // gb_histogram
            // 
            this.gb_histogram.Controls.Add(this.panel);
            this.gb_histogram.Controls.Add(this.pb_imageHistogram);
            this.gb_histogram.Location = new System.Drawing.Point(339, 2);
            this.gb_histogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_histogram.Name = "gb_histogram";
            this.gb_histogram.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_histogram.Size = new System.Drawing.Size(401, 329);
            this.gb_histogram.TabIndex = 6;
            this.gb_histogram.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.rb_linearHistogram);
            this.panel.Controls.Add(this.cb_histogramChannel);
            this.panel.Controls.Add(this.rb_histogram);
            this.panel.Location = new System.Drawing.Point(5, 17);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(381, 113);
            this.panel.TabIndex = 9;
            // 
            // cb_histogramChannel
            // 
            this.cb_histogramChannel.FormattingEnabled = true;
            this.cb_histogramChannel.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Szary"});
            this.cb_histogramChannel.Location = new System.Drawing.Point(3, 57);
            this.cb_histogramChannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_histogramChannel.Name = "cb_histogramChannel";
            this.cb_histogramChannel.Size = new System.Drawing.Size(161, 24);
            this.cb_histogramChannel.TabIndex = 8;
            this.cb_histogramChannel.SelectedIndexChanged += new System.EventHandler(this.OnShowStatisticMeasuresValues);
            // 
            // pb_imageHistogram
            // 
            this.pb_imageHistogram.Location = new System.Drawing.Point(5, 135);
            this.pb_imageHistogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_imageHistogram.Name = "pb_imageHistogram";
            this.pb_imageHistogram.Size = new System.Drawing.Size(381, 187);
            this.pb_imageHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imageHistogram.TabIndex = 1;
            this.pb_imageHistogram.TabStop = false;
            // 
            // gb_statisticMeasures
            // 
            this.gb_statisticMeasures.Controls.Add(this.lb_analizedColorValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_analizedColor);
            this.gb_statisticMeasures.Controls.Add(this.lb_abberationValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_contrastValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_maxColorValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_minColorValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_varianceValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_averageColorValue);
            this.gb_statisticMeasures.Controls.Add(this.lb_aberration);
            this.gb_statisticMeasures.Controls.Add(this.lb_contrast);
            this.gb_statisticMeasures.Controls.Add(this.lb_max);
            this.gb_statisticMeasures.Controls.Add(this.lb_min);
            this.gb_statisticMeasures.Controls.Add(this.lb_variance);
            this.gb_statisticMeasures.Controls.Add(this.lb_average);
            this.gb_statisticMeasures.Location = new System.Drawing.Point(755, 12);
            this.gb_statisticMeasures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_statisticMeasures.Name = "gb_statisticMeasures";
            this.gb_statisticMeasures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_statisticMeasures.Size = new System.Drawing.Size(285, 314);
            this.gb_statisticMeasures.TabIndex = 7;
            this.gb_statisticMeasures.TabStop = false;
            this.gb_statisticMeasures.Text = "Miary statystyczne histogramu";
            // 
            // lb_analizedColorValue
            // 
            this.lb_analizedColorValue.AutoSize = true;
            this.lb_analizedColorValue.Location = new System.Drawing.Point(155, 27);
            this.lb_analizedColorValue.Name = "lb_analizedColorValue";
            this.lb_analizedColorValue.Size = new System.Drawing.Size(72, 17);
            this.lb_analizedColorValue.TabIndex = 13;
            this.lb_analizedColorValue.Text = "00000000";
            // 
            // lb_analizedColor
            // 
            this.lb_analizedColor.AutoSize = true;
            this.lb_analizedColor.Location = new System.Drawing.Point(21, 27);
            this.lb_analizedColor.Name = "lb_analizedColor";
            this.lb_analizedColor.Size = new System.Drawing.Size(125, 17);
            this.lb_analizedColor.TabIndex = 12;
            this.lb_analizedColor.Text = "Analizowany kolor:";
            // 
            // lb_abberationValue
            // 
            this.lb_abberationValue.AutoSize = true;
            this.lb_abberationValue.Location = new System.Drawing.Point(107, 191);
            this.lb_abberationValue.Name = "lb_abberationValue";
            this.lb_abberationValue.Size = new System.Drawing.Size(40, 17);
            this.lb_abberationValue.TabIndex = 11;
            this.lb_abberationValue.Text = "0000";
            // 
            // lb_contrastValue
            // 
            this.lb_contrastValue.AutoSize = true;
            this.lb_contrastValue.Location = new System.Drawing.Point(107, 165);
            this.lb_contrastValue.Name = "lb_contrastValue";
            this.lb_contrastValue.Size = new System.Drawing.Size(40, 17);
            this.lb_contrastValue.TabIndex = 10;
            this.lb_contrastValue.Text = "0000";
            // 
            // lb_maxColorValue
            // 
            this.lb_maxColorValue.AutoSize = true;
            this.lb_maxColorValue.Location = new System.Drawing.Point(107, 139);
            this.lb_maxColorValue.Name = "lb_maxColorValue";
            this.lb_maxColorValue.Size = new System.Drawing.Size(40, 17);
            this.lb_maxColorValue.TabIndex = 9;
            this.lb_maxColorValue.Text = "0000";
            // 
            // lb_minColorValue
            // 
            this.lb_minColorValue.AutoSize = true;
            this.lb_minColorValue.Location = new System.Drawing.Point(107, 107);
            this.lb_minColorValue.Name = "lb_minColorValue";
            this.lb_minColorValue.Size = new System.Drawing.Size(40, 17);
            this.lb_minColorValue.TabIndex = 8;
            this.lb_minColorValue.Text = "0000";
            // 
            // lb_varianceValue
            // 
            this.lb_varianceValue.AutoSize = true;
            this.lb_varianceValue.Location = new System.Drawing.Point(107, 81);
            this.lb_varianceValue.Name = "lb_varianceValue";
            this.lb_varianceValue.Size = new System.Drawing.Size(40, 17);
            this.lb_varianceValue.TabIndex = 7;
            this.lb_varianceValue.Text = "0000";
            // 
            // lb_averageColorValue
            // 
            this.lb_averageColorValue.AutoSize = true;
            this.lb_averageColorValue.Location = new System.Drawing.Point(107, 54);
            this.lb_averageColorValue.Name = "lb_averageColorValue";
            this.lb_averageColorValue.Size = new System.Drawing.Size(40, 17);
            this.lb_averageColorValue.TabIndex = 6;
            this.lb_averageColorValue.Text = "0000";
            // 
            // lb_aberration
            // 
            this.lb_aberration.AutoSize = true;
            this.lb_aberration.Location = new System.Drawing.Point(21, 191);
            this.lb_aberration.Name = "lb_aberration";
            this.lb_aberration.Size = new System.Drawing.Size(79, 17);
            this.lb_aberration.TabIndex = 5;
            this.lb_aberration.Text = "Odchylenie";
            // 
            // lb_contrast
            // 
            this.lb_contrast.AutoSize = true;
            this.lb_contrast.Location = new System.Drawing.Point(21, 165);
            this.lb_contrast.Name = "lb_contrast";
            this.lb_contrast.Size = new System.Drawing.Size(61, 17);
            this.lb_contrast.TabIndex = 4;
            this.lb_contrast.Text = "Kontrast";
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
            // lb_variance
            // 
            this.lb_variance.AutoSize = true;
            this.lb_variance.Location = new System.Drawing.Point(21, 81);
            this.lb_variance.Name = "lb_variance";
            this.lb_variance.Size = new System.Drawing.Size(71, 17);
            this.lb_variance.TabIndex = 1;
            this.lb_variance.Text = "Wariancja";
            // 
            // lb_average
            // 
            this.lb_average.AutoSize = true;
            this.lb_average.Location = new System.Drawing.Point(21, 54);
            this.lb_average.Name = "lb_average";
            this.lb_average.Size = new System.Drawing.Size(57, 17);
            this.lb_average.TabIndex = 0;
            this.lb_average.Text = "Średnia";
            // 
            // pb_entranceImage
            // 
            this.pb_entranceImage.Location = new System.Drawing.Point(12, 12);
            this.pb_entranceImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_entranceImage.Name = "pb_entranceImage";
            this.pb_entranceImage.Size = new System.Drawing.Size(320, 320);
            this.pb_entranceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_entranceImage.TabIndex = 0;
            this.pb_entranceImage.TabStop = false;
            // 
            // ImageHistogramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 422);
            this.Controls.Add(this.gb_statisticMeasures);
            this.Controls.Add(this.gb_histogram);
            this.Controls.Add(this.gb_operationsPanel);
            this.Controls.Add(this.pb_entranceImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImageHistogramWindow";
            this.Text = "Histogram analizowanego obrazu";
            this.Load += new System.EventHandler(this.OknoHistogramu_Load);
            this.gb_operationsPanel.ResumeLayout(false);
            this.gb_histogram.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageHistogram)).EndInit();
            this.gb_statisticMeasures.ResumeLayout(false);
            this.gb_statisticMeasures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_entranceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_entranceImage;
        private System.Windows.Forms.PictureBox pb_imageHistogram;
        private System.Windows.Forms.Button btn_alignHistogram;
        private System.Windows.Forms.GroupBox gb_operationsPanel;
        private System.Windows.Forms.Button btn_confirmOperation;
        private System.Windows.Forms.GroupBox gb_histogram;
        private System.Windows.Forms.RadioButton rb_histogram;
        private System.Windows.Forms.RadioButton rb_linearHistogram;
        private System.Windows.Forms.ComboBox cb_histogramChannel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox gb_statisticMeasures;
        private System.Windows.Forms.Label lb_abberationValue;
        private System.Windows.Forms.Label lb_contrastValue;
        private System.Windows.Forms.Label lb_maxColorValue;
        private System.Windows.Forms.Label lb_minColorValue;
        private System.Windows.Forms.Label lb_varianceValue;
        private System.Windows.Forms.Label lb_averageColorValue;
        private System.Windows.Forms.Label lb_aberration;
        private System.Windows.Forms.Label lb_contrast;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_variance;
        private System.Windows.Forms.Label lb_average;
        private System.Windows.Forms.Label lb_analizedColorValue;
        private System.Windows.Forms.Label lb_analizedColor;
    }
}
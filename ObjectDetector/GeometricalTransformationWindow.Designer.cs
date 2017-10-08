namespace ObjectDetector
{
    partial class GeometricalTransformationWindow
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
            this.gb_toolbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_trackBarInformation = new System.Windows.Forms.Label();
            this.panelSterowania = new System.Windows.Forms.Panel();
            this.txtb_setAngleOfImageRotation = new System.Windows.Forms.TextBox();
            this.btn_rotationToTheLeft = new System.Windows.Forms.Button();
            this.btn_rotationToTheRight = new System.Windows.Forms.Button();
            this.trackb_imageZoomManipulator = new System.Windows.Forms.TrackBar();
            this.btn_confirmOperation = new System.Windows.Forms.Button();
            this.trackb_setHeight = new System.Windows.Forms.TrackBar();
            this.trackb_setWidth = new System.Windows.Forms.TrackBar();
            this.btn_confirmCutting = new System.Windows.Forms.Button();
            this.numericUD_inputWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUD_inputHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUD_widthToCut = new System.Windows.Forms.NumericUpDown();
            this.numericUD_heightToCut = new System.Windows.Forms.NumericUpDown();
            this.gb_cutImageToolbox = new System.Windows.Forms.GroupBox();
            this.lb_komunikatWysWycinanie = new System.Windows.Forms.Label();
            this.lb_komunikatSzerWycinanie = new System.Windows.Forms.Label();
            this.lb_komunikatPozycjaWys = new System.Windows.Forms.Label();
            this.lb_komunikatPozycjaSzer = new System.Windows.Forms.Label();
            this.panel_image = new System.Windows.Forms.Panel();
            this.pb_inputImage = new System.Windows.Forms.PictureBox();
            this.gb_toolbox.SuspendLayout();
            this.panelSterowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_imageZoomManipulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_setHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_setWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_inputWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_widthToCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_heightToCut)).BeginInit();
            this.gb_cutImageToolbox.SuspendLayout();
            this.panel_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_toolbox
            // 
            this.gb_toolbox.Controls.Add(this.label2);
            this.gb_toolbox.Controls.Add(this.lb_trackBarInformation);
            this.gb_toolbox.Controls.Add(this.panelSterowania);
            this.gb_toolbox.Controls.Add(this.trackb_imageZoomManipulator);
            this.gb_toolbox.Location = new System.Drawing.Point(394, 48);
            this.gb_toolbox.Name = "gb_toolbox";
            this.gb_toolbox.Size = new System.Drawing.Size(150, 299);
            this.gb_toolbox.TabIndex = 4;
            this.gb_toolbox.TabStop = false;
            this.gb_toolbox.Text = "Narzędzia";
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
            // lb_trackBarInformation
            // 
            this.lb_trackBarInformation.AutoSize = true;
            this.lb_trackBarInformation.Location = new System.Drawing.Point(6, 24);
            this.lb_trackBarInformation.Name = "lb_trackBarInformation";
            this.lb_trackBarInformation.Size = new System.Drawing.Size(136, 17);
            this.lb_trackBarInformation.TabIndex = 9;
            this.lb_trackBarInformation.Text = "Przybliż/oddal obraz";
            // 
            // panelSterowania
            // 
            this.panelSterowania.Controls.Add(this.txtb_setAngleOfImageRotation);
            this.panelSterowania.Controls.Add(this.btn_rotationToTheLeft);
            this.panelSterowania.Controls.Add(this.btn_rotationToTheRight);
            this.panelSterowania.Location = new System.Drawing.Point(6, 249);
            this.panelSterowania.Name = "panelSterowania";
            this.panelSterowania.Size = new System.Drawing.Size(136, 44);
            this.panelSterowania.TabIndex = 8;
            // 
            // txtb_setAngleOfImageRotation
            // 
            this.txtb_setAngleOfImageRotation.Location = new System.Drawing.Point(55, 8);
            this.txtb_setAngleOfImageRotation.Name = "txtb_setAngleOfImageRotation";
            this.txtb_setAngleOfImageRotation.Size = new System.Drawing.Size(27, 22);
            this.txtb_setAngleOfImageRotation.TabIndex = 2;
            // 
            // btn_rotationToTheLeft
            // 
            this.btn_rotationToTheLeft.Image = global::ObjectDetector.Properties.Resources.rotating_arrow_to_the_left;
            this.btn_rotationToTheLeft.Location = new System.Drawing.Point(88, 4);
            this.btn_rotationToTheLeft.Name = "btn_rotationToTheLeft";
            this.btn_rotationToTheLeft.Size = new System.Drawing.Size(45, 30);
            this.btn_rotationToTheLeft.TabIndex = 0;
            this.btn_rotationToTheLeft.UseVisualStyleBackColor = true;
            this.btn_rotationToTheLeft.Click += new System.EventHandler(this.RotationToTheLeft);
            // 
            // btn_rotationToTheRight
            // 
            this.btn_rotationToTheRight.Image = global::ObjectDetector.Properties.Resources.rotating_arrow_to_the_right;
            this.btn_rotationToTheRight.Location = new System.Drawing.Point(3, 4);
            this.btn_rotationToTheRight.Name = "btn_rotationToTheRight";
            this.btn_rotationToTheRight.Size = new System.Drawing.Size(45, 30);
            this.btn_rotationToTheRight.TabIndex = 1;
            this.btn_rotationToTheRight.UseVisualStyleBackColor = true;
            this.btn_rotationToTheRight.Click += new System.EventHandler(this.RotationToTheRight);
            // 
            // trackb_imageZoomManipulator
            // 
            this.trackb_imageZoomManipulator.Location = new System.Drawing.Point(23, 44);
            this.trackb_imageZoomManipulator.Maximum = 30;
            this.trackb_imageZoomManipulator.Minimum = -30;
            this.trackb_imageZoomManipulator.Name = "trackb_imageZoomManipulator";
            this.trackb_imageZoomManipulator.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackb_imageZoomManipulator.Size = new System.Drawing.Size(56, 168);
            this.trackb_imageZoomManipulator.TabIndex = 7;
            this.trackb_imageZoomManipulator.Scroll += new System.EventHandler(this.SetZoomPosition);
            // 
            // btn_confirmOperation
            // 
            this.btn_confirmOperation.Location = new System.Drawing.Point(394, 383);
            this.btn_confirmOperation.Name = "btn_confirmOperation";
            this.btn_confirmOperation.Size = new System.Drawing.Size(150, 134);
            this.btn_confirmOperation.TabIndex = 6;
            this.btn_confirmOperation.Text = "Zatwierdź operacje";
            this.btn_confirmOperation.UseVisualStyleBackColor = true;
            this.btn_confirmOperation.Click += new System.EventHandler(this.ConfirmOperations);
            // 
            // trackb_setHeight
            // 
            this.trackb_setHeight.Location = new System.Drawing.Point(12, 48);
            this.trackb_setHeight.Maximum = 4;
            this.trackb_setHeight.Name = "trackb_setHeight";
            this.trackb_setHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackb_setHeight.Size = new System.Drawing.Size(56, 317);
            this.trackb_setHeight.TabIndex = 8;
            this.trackb_setHeight.Value = 4;
            this.trackb_setHeight.Scroll += new System.EventHandler(this.SetHeightOfInputImage);
            // 
            // trackb_setWidth
            // 
            this.trackb_setWidth.Location = new System.Drawing.Point(50, -3);
            this.trackb_setWidth.Maximum = 4;
            this.trackb_setWidth.Name = "trackb_setWidth";
            this.trackb_setWidth.Size = new System.Drawing.Size(320, 56);
            this.trackb_setWidth.TabIndex = 9;
            this.trackb_setWidth.Value = 4;
            this.trackb_setWidth.Scroll += new System.EventHandler(this.SetWidthOfInputImage);
            // 
            // btn_confirmCutting
            // 
            this.btn_confirmCutting.Location = new System.Drawing.Point(225, 34);
            this.btn_confirmCutting.Name = "btn_confirmCutting";
            this.btn_confirmCutting.Size = new System.Drawing.Size(89, 78);
            this.btn_confirmCutting.TabIndex = 10;
            this.btn_confirmCutting.Text = "OK";
            this.btn_confirmCutting.UseVisualStyleBackColor = true;
            this.btn_confirmCutting.Click += new System.EventHandler(this.ConfirmCuttingImage);
            // 
            // numericUD_inputWidth
            // 
            this.numericUD_inputWidth.Location = new System.Drawing.Point(99, 21);
            this.numericUD_inputWidth.Name = "numericUD_inputWidth";
            this.numericUD_inputWidth.Size = new System.Drawing.Size(120, 22);
            this.numericUD_inputWidth.TabIndex = 15;
            this.numericUD_inputWidth.ValueChanged += new System.EventHandler(this.numericUD_szerPocz_ValueChanged);
            // 
            // numericUD_inputHeight
            // 
            this.numericUD_inputHeight.Location = new System.Drawing.Point(99, 49);
            this.numericUD_inputHeight.Name = "numericUD_inputHeight";
            this.numericUD_inputHeight.Size = new System.Drawing.Size(120, 22);
            this.numericUD_inputHeight.TabIndex = 16;
            this.numericUD_inputHeight.ValueChanged += new System.EventHandler(this.numericUD_wysPocz_ValueChanged);
            // 
            // numericUD_widthToCut
            // 
            this.numericUD_widthToCut.Location = new System.Drawing.Point(99, 77);
            this.numericUD_widthToCut.Name = "numericUD_widthToCut";
            this.numericUD_widthToCut.Size = new System.Drawing.Size(120, 22);
            this.numericUD_widthToCut.TabIndex = 17;
            this.numericUD_widthToCut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUD_widthToCut.ValueChanged += new System.EventHandler(this.numericUD_szerPrzyc_ValueChanged);
            // 
            // numericUD_heightToCut
            // 
            this.numericUD_heightToCut.Location = new System.Drawing.Point(99, 105);
            this.numericUD_heightToCut.Name = "numericUD_heightToCut";
            this.numericUD_heightToCut.Size = new System.Drawing.Size(120, 22);
            this.numericUD_heightToCut.TabIndex = 18;
            this.numericUD_heightToCut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUD_heightToCut.ValueChanged += new System.EventHandler(this.numericUD_wysPrzyc_ValueChanged);
            // 
            // gb_cutImageToolbox
            // 
            this.gb_cutImageToolbox.Controls.Add(this.lb_komunikatWysWycinanie);
            this.gb_cutImageToolbox.Controls.Add(this.lb_komunikatSzerWycinanie);
            this.gb_cutImageToolbox.Controls.Add(this.lb_komunikatPozycjaWys);
            this.gb_cutImageToolbox.Controls.Add(this.lb_komunikatPozycjaSzer);
            this.gb_cutImageToolbox.Controls.Add(this.numericUD_inputWidth);
            this.gb_cutImageToolbox.Controls.Add(this.btn_confirmCutting);
            this.gb_cutImageToolbox.Controls.Add(this.numericUD_heightToCut);
            this.gb_cutImageToolbox.Controls.Add(this.numericUD_inputHeight);
            this.gb_cutImageToolbox.Controls.Add(this.numericUD_widthToCut);
            this.gb_cutImageToolbox.Location = new System.Drawing.Point(50, 377);
            this.gb_cutImageToolbox.Name = "gb_cutImageToolbox";
            this.gb_cutImageToolbox.Size = new System.Drawing.Size(320, 136);
            this.gb_cutImageToolbox.TabIndex = 19;
            this.gb_cutImageToolbox.TabStop = false;
            this.gb_cutImageToolbox.Text = "Przytnij obraz";
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
            // lb_komunikatSzerWycinanie
            // 
            this.lb_komunikatSzerWycinanie.AutoSize = true;
            this.lb_komunikatSzerWycinanie.Location = new System.Drawing.Point(6, 82);
            this.lb_komunikatSzerWycinanie.Name = "lb_komunikatSzerWycinanie";
            this.lb_komunikatSzerWycinanie.Size = new System.Drawing.Size(78, 17);
            this.lb_komunikatSzerWycinanie.TabIndex = 21;
            this.lb_komunikatSzerWycinanie.Text = "Szerokość:";
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
            // lb_komunikatPozycjaSzer
            // 
            this.lb_komunikatPozycjaSzer.AutoSize = true;
            this.lb_komunikatPozycjaSzer.Location = new System.Drawing.Point(6, 26);
            this.lb_komunikatPozycjaSzer.Name = "lb_komunikatPozycjaSzer";
            this.lb_komunikatPozycjaSzer.Size = new System.Drawing.Size(74, 17);
            this.lb_komunikatPozycjaSzer.TabIndex = 19;
            this.lb_komunikatPozycjaSzer.Text = "Pozycja X:";
            // 
            // panel_image
            // 
            this.panel_image.AutoScroll = true;
            this.panel_image.Controls.Add(this.pb_inputImage);
            this.panel_image.Location = new System.Drawing.Point(50, 48);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(319, 319);
            this.panel_image.TabIndex = 20;
            // 
            // pb_inputImage
            // 
            this.pb_inputImage.Location = new System.Drawing.Point(0, 0);
            this.pb_inputImage.Name = "pb_inputImage";
            this.pb_inputImage.Size = new System.Drawing.Size(320, 320);
            this.pb_inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_inputImage.TabIndex = 5;
            this.pb_inputImage.TabStop = false;
            this.pb_inputImage.Click += new System.EventHandler(this.pb_obrazWeTransGeo_Click);
            // 
            // GeometricalTransformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 525);
            this.Controls.Add(this.panel_image);
            this.Controls.Add(this.gb_cutImageToolbox);
            this.Controls.Add(this.trackb_setWidth);
            this.Controls.Add(this.trackb_setHeight);
            this.Controls.Add(this.btn_confirmOperation);
            this.Controls.Add(this.gb_toolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeometricalTransformationWindow";
            this.Text = "Manipulacja geometryczna obrazem";
            this.Load += new System.EventHandler(this.OknoTransformacjiGeometrycznych_Load);
            this.gb_toolbox.ResumeLayout(false);
            this.gb_toolbox.PerformLayout();
            this.panelSterowania.ResumeLayout(false);
            this.panelSterowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_imageZoomManipulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_setHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_setWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_inputWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_widthToCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_heightToCut)).EndInit();
            this.gb_cutImageToolbox.ResumeLayout(false);
            this.gb_cutImageToolbox.PerformLayout();
            this.panel_image.ResumeLayout(false);
            this.panel_image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_toolbox;
        private System.Windows.Forms.Button btn_rotationToTheRight;
        private System.Windows.Forms.Button btn_rotationToTheLeft;
        public System.Windows.Forms.PictureBox pb_inputImage;
        private System.Windows.Forms.Button btn_confirmOperation;
        private System.Windows.Forms.TrackBar trackb_imageZoomManipulator;
        private System.Windows.Forms.Panel panelSterowania;
        private System.Windows.Forms.TrackBar trackb_setHeight;
        private System.Windows.Forms.TrackBar trackb_setWidth;
        private System.Windows.Forms.Button btn_confirmCutting;
        private System.Windows.Forms.NumericUpDown numericUD_inputWidth;
        private System.Windows.Forms.NumericUpDown numericUD_inputHeight;
        private System.Windows.Forms.NumericUpDown numericUD_widthToCut;
        private System.Windows.Forms.NumericUpDown numericUD_heightToCut;
        private System.Windows.Forms.GroupBox gb_cutImageToolbox;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_trackBarInformation;
        private System.Windows.Forms.TextBox txtb_setAngleOfImageRotation;
        private System.Windows.Forms.Label lb_komunikatWysWycinanie;
        private System.Windows.Forms.Label lb_komunikatSzerWycinanie;
        private System.Windows.Forms.Label lb_komunikatPozycjaWys;
        private System.Windows.Forms.Label lb_komunikatPozycjaSzer;
    }
}
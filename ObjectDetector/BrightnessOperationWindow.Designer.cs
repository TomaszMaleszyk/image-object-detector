namespace ObjectDetector
{
    partial class BrightnessOperationWindow
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
            this.gb_operations = new System.Windows.Forms.GroupBox();
            this.lb_levelOfOperation = new System.Windows.Forms.Label();
            this.trackb_levelOfOperation = new System.Windows.Forms.TrackBar();
            this.rb_contrastOfImage = new System.Windows.Forms.RadioButton();
            this.rb_brightnessOfImage = new System.Windows.Forms.RadioButton();
            this.btn_confirmOperation = new System.Windows.Forms.Button();
            this.pb_inputImage = new System.Windows.Forms.PictureBox();
            this.gb_operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_levelOfOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_operations
            // 
            this.gb_operations.Controls.Add(this.lb_levelOfOperation);
            this.gb_operations.Controls.Add(this.trackb_levelOfOperation);
            this.gb_operations.Controls.Add(this.rb_contrastOfImage);
            this.gb_operations.Controls.Add(this.rb_brightnessOfImage);
            this.gb_operations.Location = new System.Drawing.Point(351, 12);
            this.gb_operations.Name = "gb_operations";
            this.gb_operations.Size = new System.Drawing.Size(228, 194);
            this.gb_operations.TabIndex = 4;
            this.gb_operations.TabStop = false;
            this.gb_operations.Text = "Operacje";
            // 
            // lb_levelOfOperation
            // 
            this.lb_levelOfOperation.AutoSize = true;
            this.lb_levelOfOperation.Location = new System.Drawing.Point(27, 160);
            this.lb_levelOfOperation.Name = "lb_levelOfOperation";
            this.lb_levelOfOperation.Size = new System.Drawing.Size(40, 17);
            this.lb_levelOfOperation.TabIndex = 4;
            this.lb_levelOfOperation.Text = "0000";
            // 
            // trackb_levelOfOperation
            // 
            this.trackb_levelOfOperation.Location = new System.Drawing.Point(20, 111);
            this.trackb_levelOfOperation.Name = "trackb_levelOfOperation";
            this.trackb_levelOfOperation.Size = new System.Drawing.Size(202, 56);
            this.trackb_levelOfOperation.TabIndex = 3;
            this.trackb_levelOfOperation.Scroll += new System.EventHandler(this.UpdateOperationChangesOnImage);
            this.trackb_levelOfOperation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PerformMainOperation);
            // 
            // rb_contrastOfImage
            // 
            this.rb_contrastOfImage.AutoSize = true;
            this.rb_contrastOfImage.Location = new System.Drawing.Point(20, 67);
            this.rb_contrastOfImage.Name = "rb_contrastOfImage";
            this.rb_contrastOfImage.Size = new System.Drawing.Size(186, 21);
            this.rb_contrastOfImage.TabIndex = 1;
            this.rb_contrastOfImage.TabStop = true;
            this.rb_contrastOfImage.Text = "Poziom kontrastu obrazu";
            this.rb_contrastOfImage.UseVisualStyleBackColor = true;
            this.rb_contrastOfImage.CheckedChanged += new System.EventHandler(this.UpdateStatementsAndInputDataOfMainOperation);
            // 
            // rb_brightnessOfImage
            // 
            this.rb_brightnessOfImage.AutoSize = true;
            this.rb_brightnessOfImage.Location = new System.Drawing.Point(20, 40);
            this.rb_brightnessOfImage.Name = "rb_brightnessOfImage";
            this.rb_brightnessOfImage.Size = new System.Drawing.Size(178, 21);
            this.rb_brightnessOfImage.TabIndex = 0;
            this.rb_brightnessOfImage.TabStop = true;
            this.rb_brightnessOfImage.Text = "Poziom jasności obrazu";
            this.rb_brightnessOfImage.UseVisualStyleBackColor = true;
            this.rb_brightnessOfImage.CheckedChanged += new System.EventHandler(this.UpdateStatementsAndInputDataOfMainOperation);
            // 
            // btn_confirmOperation
            // 
            this.btn_confirmOperation.Location = new System.Drawing.Point(351, 212);
            this.btn_confirmOperation.Name = "btn_confirmOperation";
            this.btn_confirmOperation.Size = new System.Drawing.Size(228, 45);
            this.btn_confirmOperation.TabIndex = 5;
            this.btn_confirmOperation.Text = "Zatwierdź operacje";
            this.btn_confirmOperation.UseVisualStyleBackColor = true;
            this.btn_confirmOperation.Click += new System.EventHandler(this.ConfirmOperationsChanges);
            // 
            // pb_inputImage
            // 
            this.pb_inputImage.Location = new System.Drawing.Point(12, 12);
            this.pb_inputImage.Name = "pb_inputImage";
            this.pb_inputImage.Size = new System.Drawing.Size(320, 320);
            this.pb_inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_inputImage.TabIndex = 3;
            this.pb_inputImage.TabStop = false;
            // 
            // BrightnessOperationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 358);
            this.Controls.Add(this.btn_confirmOperation);
            this.Controls.Add(this.gb_operations);
            this.Controls.Add(this.pb_inputImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BrightnessOperationWindow";
            this.Text = "Modyfikacja światła";
            this.gb_operations.ResumeLayout(false);
            this.gb_operations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_levelOfOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_inputImage;
        private System.Windows.Forms.GroupBox gb_operations;
        private System.Windows.Forms.Label lb_levelOfOperation;
        private System.Windows.Forms.TrackBar trackb_levelOfOperation;
        private System.Windows.Forms.RadioButton rb_contrastOfImage;
        private System.Windows.Forms.RadioButton rb_brightnessOfImage;
        private System.Windows.Forms.Button btn_confirmOperation;
    }
}
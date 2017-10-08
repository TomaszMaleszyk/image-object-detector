namespace ObjectDetector
{
    partial class BinarizationWindow
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
            this.trackb_binarizationThreshold = new System.Windows.Forms.TrackBar();
            this.btn_confirmOperations = new System.Windows.Forms.Button();
            this.gb_chooseKindOfOperation = new System.Windows.Forms.GroupBox();
            this.rb_otsuThreshold = new System.Windows.Forms.RadioButton();
            this.rb_userThreshold = new System.Windows.Forms.RadioButton();
            this.lb_OtsuThreshold = new System.Windows.Forms.Label();
            this.lb_userThreshold = new System.Windows.Forms.Label();
            this.panel_statement = new System.Windows.Forms.Panel();
            this.panel_changeThresholdValue = new System.Windows.Forms.Panel();
            this.pb_inputImageBinarization = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_binarizationThreshold)).BeginInit();
            this.gb_chooseKindOfOperation.SuspendLayout();
            this.panel_statement.SuspendLayout();
            this.panel_changeThresholdValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImageBinarization)).BeginInit();
            this.SuspendLayout();
            // 
            // trackb_binarizationThreshold
            // 
            this.trackb_binarizationThreshold.Location = new System.Drawing.Point(2, 1);
            this.trackb_binarizationThreshold.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.trackb_binarizationThreshold.Maximum = 255;
            this.trackb_binarizationThreshold.Name = "trackb_binarizationThreshold";
            this.trackb_binarizationThreshold.Size = new System.Drawing.Size(247, 56);
            this.trackb_binarizationThreshold.TabIndex = 3;
            this.trackb_binarizationThreshold.Value = 128;
            this.trackb_binarizationThreshold.Scroll += new System.EventHandler(this.ChangeThresholdValue);
            this.trackb_binarizationThreshold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BinarizationOfInputImage);
            // 
            // btn_confirmOperations
            // 
            this.btn_confirmOperations.Location = new System.Drawing.Point(81, 490);
            this.btn_confirmOperations.Name = "btn_confirmOperations";
            this.btn_confirmOperations.Size = new System.Drawing.Size(118, 56);
            this.btn_confirmOperations.TabIndex = 4;
            this.btn_confirmOperations.Text = "Zatwierdź";
            this.btn_confirmOperations.UseVisualStyleBackColor = true;
            this.btn_confirmOperations.Click += new System.EventHandler(this.ConfirmOperations);
            // 
            // gb_chooseKindOfOperation
            // 
            this.gb_chooseKindOfOperation.Controls.Add(this.rb_otsuThreshold);
            this.gb_chooseKindOfOperation.Controls.Add(this.rb_userThreshold);
            this.gb_chooseKindOfOperation.Location = new System.Drawing.Point(12, 273);
            this.gb_chooseKindOfOperation.Name = "gb_chooseKindOfOperation";
            this.gb_chooseKindOfOperation.Size = new System.Drawing.Size(255, 81);
            this.gb_chooseKindOfOperation.TabIndex = 5;
            this.gb_chooseKindOfOperation.TabStop = false;
            this.gb_chooseKindOfOperation.Text = "Wybierz rodzaj binaryzacji";
            // 
            // rb_otsuThreshold
            // 
            this.rb_otsuThreshold.AutoSize = true;
            this.rb_otsuThreshold.Location = new System.Drawing.Point(6, 48);
            this.rb_otsuThreshold.Name = "rb_otsuThreshold";
            this.rb_otsuThreshold.Size = new System.Drawing.Size(93, 21);
            this.rb_otsuThreshold.TabIndex = 8;
            this.rb_otsuThreshold.TabStop = true;
            this.rb_otsuThreshold.Text = "Próg Otsu";
            this.rb_otsuThreshold.UseVisualStyleBackColor = true;
            this.rb_otsuThreshold.Click += new System.EventHandler(this.ControlRadioButtonsActivity);
            // 
            // rb_userThreshold
            // 
            this.rb_userThreshold.AutoSize = true;
            this.rb_userThreshold.Location = new System.Drawing.Point(6, 21);
            this.rb_userThreshold.Name = "rb_userThreshold";
            this.rb_userThreshold.Size = new System.Drawing.Size(243, 21);
            this.rb_userThreshold.TabIndex = 7;
            this.rb_userThreshold.TabStop = true;
            this.rb_userThreshold.Text = "Próg określony przez użytkownika";
            this.rb_userThreshold.UseVisualStyleBackColor = true;
            this.rb_userThreshold.Click += new System.EventHandler(this.ControlRadioButtonsActivity);
            // 
            // lb_OtsuThreshold
            // 
            this.lb_OtsuThreshold.AutoSize = true;
            this.lb_OtsuThreshold.Location = new System.Drawing.Point(3, 1);
            this.lb_OtsuThreshold.Name = "lb_OtsuThreshold";
            this.lb_OtsuThreshold.Size = new System.Drawing.Size(199, 17);
            this.lb_OtsuThreshold.TabIndex = 6;
            this.lb_OtsuThreshold.Text = "Próg otsu wynosi:                    ";
            // 
            // lb_userThreshold
            // 
            this.lb_userThreshold.AutoSize = true;
            this.lb_userThreshold.Location = new System.Drawing.Point(107, 57);
            this.lb_userThreshold.Name = "lb_userThreshold";
            this.lb_userThreshold.Size = new System.Drawing.Size(40, 17);
            this.lb_userThreshold.TabIndex = 7;
            this.lb_userThreshold.Text = "0000";
            // 
            // panel_statement
            // 
            this.panel_statement.Controls.Add(this.lb_OtsuThreshold);
            this.panel_statement.Location = new System.Drawing.Point(12, 360);
            this.panel_statement.Name = "panel_statement";
            this.panel_statement.Size = new System.Drawing.Size(255, 31);
            this.panel_statement.TabIndex = 8;
            // 
            // panel_changeThresholdValue
            // 
            this.panel_changeThresholdValue.Controls.Add(this.trackb_binarizationThreshold);
            this.panel_changeThresholdValue.Controls.Add(this.lb_userThreshold);
            this.panel_changeThresholdValue.Location = new System.Drawing.Point(12, 397);
            this.panel_changeThresholdValue.Name = "panel_changeThresholdValue";
            this.panel_changeThresholdValue.Size = new System.Drawing.Size(255, 87);
            this.panel_changeThresholdValue.TabIndex = 9;
            // 
            // pb_inputImageBinarization
            // 
            this.pb_inputImageBinarization.Location = new System.Drawing.Point(12, 12);
            this.pb_inputImageBinarization.Name = "pb_inputImageBinarization";
            this.pb_inputImageBinarization.Size = new System.Drawing.Size(255, 255);
            this.pb_inputImageBinarization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_inputImageBinarization.TabIndex = 2;
            this.pb_inputImageBinarization.TabStop = false;
            // 
            // BinarizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 546);
            this.Controls.Add(this.panel_changeThresholdValue);
            this.Controls.Add(this.panel_statement);
            this.Controls.Add(this.gb_chooseKindOfOperation);
            this.Controls.Add(this.btn_confirmOperations);
            this.Controls.Add(this.pb_inputImageBinarization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BinarizationWindow";
            this.Text = "Binaryzacja";
            ((System.ComponentModel.ISupportInitialize)(this.trackb_binarizationThreshold)).EndInit();
            this.gb_chooseKindOfOperation.ResumeLayout(false);
            this.gb_chooseKindOfOperation.PerformLayout();
            this.panel_statement.ResumeLayout(false);
            this.panel_statement.PerformLayout();
            this.panel_changeThresholdValue.ResumeLayout(false);
            this.panel_changeThresholdValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImageBinarization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_inputImageBinarization;
        private System.Windows.Forms.TrackBar trackb_binarizationThreshold;
        private System.Windows.Forms.Button btn_confirmOperations;
        private System.Windows.Forms.GroupBox gb_chooseKindOfOperation;
        private System.Windows.Forms.Label lb_OtsuThreshold;
        private System.Windows.Forms.RadioButton rb_otsuThreshold;
        private System.Windows.Forms.RadioButton rb_userThreshold;
        private System.Windows.Forms.Label lb_userThreshold;
        private System.Windows.Forms.Panel panel_statement;
        private System.Windows.Forms.Panel panel_changeThresholdValue;
    }
}
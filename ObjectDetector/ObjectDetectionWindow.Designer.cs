namespace ObjectDetector
{
    partial class ObjectDetectionWindow
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
            this.pb_detectedObject = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_detectedObject)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_detectedObject
            // 
            this.pb_detectedObject.Location = new System.Drawing.Point(12, 12);
            this.pb_detectedObject.Name = "pb_detectedObject";
            this.pb_detectedObject.Size = new System.Drawing.Size(640, 480);
            this.pb_detectedObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_detectedObject.TabIndex = 0;
            this.pb_detectedObject.TabStop = false;
            // 
            // ObjectDetectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 504);
            this.Controls.Add(this.pb_detectedObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ObjectDetectionWindow";
            this.Text = "Detekcja obiektu";
            this.Load += new System.EventHandler(this.OknoDetekcjiObiektu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_detectedObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_detectedObject;
    }
}
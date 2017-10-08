namespace RozpoznawanieObiektow
{
    partial class OknoDetekcjiObiektu
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
            this.pb_wyszukanyObiekt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wyszukanyObiekt)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_wyszukanyObiekt
            // 
            this.pb_wyszukanyObiekt.Location = new System.Drawing.Point(12, 12);
            this.pb_wyszukanyObiekt.Name = "pb_wyszukanyObiekt";
            this.pb_wyszukanyObiekt.Size = new System.Drawing.Size(640, 480);
            this.pb_wyszukanyObiekt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_wyszukanyObiekt.TabIndex = 0;
            this.pb_wyszukanyObiekt.TabStop = false;
            // 
            // OknoDetekcjiObiektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 504);
            this.Controls.Add(this.pb_wyszukanyObiekt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OknoDetekcjiObiektu";
            this.Text = "Detekcja obiektu";
            this.Load += new System.EventHandler(this.OknoDetekcjiObiektu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_wyszukanyObiekt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_wyszukanyObiekt;
    }
}
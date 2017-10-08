namespace RozpoznawanieObiektow
{
    partial class OknoBinaryzacja
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
            this.trackb_progBinaryzacji = new System.Windows.Forms.TrackBar();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_progOtsu = new System.Windows.Forms.RadioButton();
            this.rb_progUzytkownika = new System.Windows.Forms.RadioButton();
            this.lb_progOtsu = new System.Windows.Forms.Label();
            this.lb_progUzytkownika = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_obrazWeBinaryzacja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_progBinaryzacji)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeBinaryzacja)).BeginInit();
            this.SuspendLayout();
            // 
            // trackb_progBinaryzacji
            // 
            this.trackb_progBinaryzacji.Location = new System.Drawing.Point(2, 1);
            this.trackb_progBinaryzacji.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.trackb_progBinaryzacji.Maximum = 255;
            this.trackb_progBinaryzacji.Name = "trackb_progBinaryzacji";
            this.trackb_progBinaryzacji.Size = new System.Drawing.Size(247, 56);
            this.trackb_progBinaryzacji.TabIndex = 3;
            this.trackb_progBinaryzacji.Value = 128;
            this.trackb_progBinaryzacji.Scroll += new System.EventHandler(this.tb_progBinaryzacji_Scroll);
            this.trackb_progBinaryzacji.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackb_progBinaryzacji_MouseUp);
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.Location = new System.Drawing.Point(81, 490);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(118, 56);
            this.btn_zatwierdz.TabIndex = 4;
            this.btn_zatwierdz.Text = "Zatwierdź";
            this.btn_zatwierdz.UseVisualStyleBackColor = true;
            this.btn_zatwierdz.Click += new System.EventHandler(this.btn_zatwierdz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_progOtsu);
            this.groupBox1.Controls.Add(this.rb_progUzytkownika);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz rodzaj binaryzacji";
            // 
            // rb_progOtsu
            // 
            this.rb_progOtsu.AutoSize = true;
            this.rb_progOtsu.Location = new System.Drawing.Point(6, 48);
            this.rb_progOtsu.Name = "rb_progOtsu";
            this.rb_progOtsu.Size = new System.Drawing.Size(93, 21);
            this.rb_progOtsu.TabIndex = 8;
            this.rb_progOtsu.TabStop = true;
            this.rb_progOtsu.Text = "Próg Otsu";
            this.rb_progOtsu.UseVisualStyleBackColor = true;
            this.rb_progOtsu.Click += new System.EventHandler(this.KontrolaRadioButtonow);
            // 
            // rb_progUzytkownika
            // 
            this.rb_progUzytkownika.AutoSize = true;
            this.rb_progUzytkownika.Location = new System.Drawing.Point(6, 21);
            this.rb_progUzytkownika.Name = "rb_progUzytkownika";
            this.rb_progUzytkownika.Size = new System.Drawing.Size(243, 21);
            this.rb_progUzytkownika.TabIndex = 7;
            this.rb_progUzytkownika.TabStop = true;
            this.rb_progUzytkownika.Text = "Próg określony przez użytkownika";
            this.rb_progUzytkownika.UseVisualStyleBackColor = true;
            this.rb_progUzytkownika.Click += new System.EventHandler(this.KontrolaRadioButtonow);
            // 
            // lb_progOtsu
            // 
            this.lb_progOtsu.AutoSize = true;
            this.lb_progOtsu.Location = new System.Drawing.Point(3, 1);
            this.lb_progOtsu.Name = "lb_progOtsu";
            this.lb_progOtsu.Size = new System.Drawing.Size(199, 17);
            this.lb_progOtsu.TabIndex = 6;
            this.lb_progOtsu.Text = "Próg otsu wynosi:                    ";
            // 
            // lb_progUzytkownika
            // 
            this.lb_progUzytkownika.AutoSize = true;
            this.lb_progUzytkownika.Location = new System.Drawing.Point(107, 57);
            this.lb_progUzytkownika.Name = "lb_progUzytkownika";
            this.lb_progUzytkownika.Size = new System.Drawing.Size(40, 17);
            this.lb_progUzytkownika.TabIndex = 7;
            this.lb_progUzytkownika.Text = "0000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_progOtsu);
            this.panel1.Location = new System.Drawing.Point(12, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 31);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackb_progBinaryzacji);
            this.panel2.Controls.Add(this.lb_progUzytkownika);
            this.panel2.Location = new System.Drawing.Point(12, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 87);
            this.panel2.TabIndex = 9;
            // 
            // pb_obrazWeBinaryzacja
            // 
            this.pb_obrazWeBinaryzacja.Location = new System.Drawing.Point(12, 12);
            this.pb_obrazWeBinaryzacja.Name = "pb_obrazWeBinaryzacja";
            this.pb_obrazWeBinaryzacja.Size = new System.Drawing.Size(255, 255);
            this.pb_obrazWeBinaryzacja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_obrazWeBinaryzacja.TabIndex = 2;
            this.pb_obrazWeBinaryzacja.TabStop = false;
            // 
            // OknoBinaryzacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_zatwierdz);
            this.Controls.Add(this.pb_obrazWeBinaryzacja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OknoBinaryzacja";
            this.Text = "Binaryzacja";
            ((System.ComponentModel.ISupportInitialize)(this.trackb_progBinaryzacji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeBinaryzacja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_obrazWeBinaryzacja;
        private System.Windows.Forms.TrackBar trackb_progBinaryzacji;
        private System.Windows.Forms.Button btn_zatwierdz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_progOtsu;
        private System.Windows.Forms.RadioButton rb_progOtsu;
        private System.Windows.Forms.RadioButton rb_progUzytkownika;
        private System.Windows.Forms.Label lb_progUzytkownika;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace RozpoznawanieObiektow
{
    partial class OknoJasnoscOperacje
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
            this.gb_operacje = new System.Windows.Forms.GroupBox();
            this.lb_poziom = new System.Windows.Forms.Label();
            this.trackb_poziom = new System.Windows.Forms.TrackBar();
            this.rb_kontrast = new System.Windows.Forms.RadioButton();
            this.rb_jasnoscObrazu = new System.Windows.Forms.RadioButton();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.pb_obrazWeJasnosc = new System.Windows.Forms.PictureBox();
            this.gb_operacje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_poziom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeJasnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_operacje
            // 
            this.gb_operacje.Controls.Add(this.lb_poziom);
            this.gb_operacje.Controls.Add(this.trackb_poziom);
            this.gb_operacje.Controls.Add(this.rb_kontrast);
            this.gb_operacje.Controls.Add(this.rb_jasnoscObrazu);
            this.gb_operacje.Location = new System.Drawing.Point(351, 12);
            this.gb_operacje.Name = "gb_operacje";
            this.gb_operacje.Size = new System.Drawing.Size(228, 194);
            this.gb_operacje.TabIndex = 4;
            this.gb_operacje.TabStop = false;
            this.gb_operacje.Text = "Operacje";
            // 
            // lb_poziom
            // 
            this.lb_poziom.AutoSize = true;
            this.lb_poziom.Location = new System.Drawing.Point(27, 160);
            this.lb_poziom.Name = "lb_poziom";
            this.lb_poziom.Size = new System.Drawing.Size(40, 17);
            this.lb_poziom.TabIndex = 4;
            this.lb_poziom.Text = "0000";
            // 
            // trackb_poziom
            // 
            this.trackb_poziom.Location = new System.Drawing.Point(20, 111);
            this.trackb_poziom.Name = "trackb_poziom";
            this.trackb_poziom.Size = new System.Drawing.Size(202, 56);
            this.trackb_poziom.TabIndex = 3;
            this.trackb_poziom.Scroll += new System.EventHandler(this.trackb_poziom_Scroll);
            this.trackb_poziom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackb_poziom_MouseUp);
            // 
            // rb_kontrast
            // 
            this.rb_kontrast.AutoSize = true;
            this.rb_kontrast.Location = new System.Drawing.Point(20, 67);
            this.rb_kontrast.Name = "rb_kontrast";
            this.rb_kontrast.Size = new System.Drawing.Size(186, 21);
            this.rb_kontrast.TabIndex = 1;
            this.rb_kontrast.TabStop = true;
            this.rb_kontrast.Text = "Poziom kontrastu obrazu";
            this.rb_kontrast.UseVisualStyleBackColor = true;
            this.rb_kontrast.CheckedChanged += new System.EventHandler(this.KontrolaRadioButtonow);
            // 
            // rb_jasnoscObrazu
            // 
            this.rb_jasnoscObrazu.AutoSize = true;
            this.rb_jasnoscObrazu.Location = new System.Drawing.Point(20, 40);
            this.rb_jasnoscObrazu.Name = "rb_jasnoscObrazu";
            this.rb_jasnoscObrazu.Size = new System.Drawing.Size(178, 21);
            this.rb_jasnoscObrazu.TabIndex = 0;
            this.rb_jasnoscObrazu.TabStop = true;
            this.rb_jasnoscObrazu.Text = "Poziom jasności obrazu";
            this.rb_jasnoscObrazu.UseVisualStyleBackColor = true;
            this.rb_jasnoscObrazu.CheckedChanged += new System.EventHandler(this.KontrolaRadioButtonow);
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.Location = new System.Drawing.Point(351, 212);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(228, 45);
            this.btn_zatwierdz.TabIndex = 5;
            this.btn_zatwierdz.Text = "Zatwierdź operacje";
            this.btn_zatwierdz.UseVisualStyleBackColor = true;
            this.btn_zatwierdz.Click += new System.EventHandler(this.btn_zatwierdz_Click);
            // 
            // pb_obrazWeJasnosc
            // 
            this.pb_obrazWeJasnosc.Location = new System.Drawing.Point(12, 12);
            this.pb_obrazWeJasnosc.Name = "pb_obrazWeJasnosc";
            this.pb_obrazWeJasnosc.Size = new System.Drawing.Size(320, 320);
            this.pb_obrazWeJasnosc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_obrazWeJasnosc.TabIndex = 3;
            this.pb_obrazWeJasnosc.TabStop = false;
            // 
            // OknoJasnoscOperacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 358);
            this.Controls.Add(this.btn_zatwierdz);
            this.Controls.Add(this.gb_operacje);
            this.Controls.Add(this.pb_obrazWeJasnosc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OknoJasnoscOperacje";
            this.Text = "Modyfikacja światła";
            this.gb_operacje.ResumeLayout(false);
            this.gb_operacje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackb_poziom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_obrazWeJasnosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_obrazWeJasnosc;
        private System.Windows.Forms.GroupBox gb_operacje;
        private System.Windows.Forms.Label lb_poziom;
        private System.Windows.Forms.TrackBar trackb_poziom;
        private System.Windows.Forms.RadioButton rb_kontrast;
        private System.Windows.Forms.RadioButton rb_jasnoscObrazu;
        private System.Windows.Forms.Button btn_zatwierdz;
    }
}
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MasaNoLabel = new System.Windows.Forms.Label();
            this.MusteriAdıLabel = new System.Windows.Forms.Label();
            this.MusteriSoyadıLabel = new System.Windows.Forms.Label();
            this.IstenenUrunLabel = new System.Windows.Forms.Label();
            this.UrunMıktarıLabel = new System.Windows.Forms.Label();
            this.SureLabel = new System.Windows.Forms.Label();
            this.MasaNoTextBox = new System.Windows.Forms.TextBox();
            this.MusteriAdiTextBox = new System.Windows.Forms.TextBox();
            this.MusteriSoyadıTextbox = new System.Windows.Forms.TextBox();
            this.IstekUrunTextBox = new System.Windows.Forms.TextBox();
            this.MıktarTextbox = new System.Windows.Forms.TextBox();
            this.SureTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MasaNoLabel
            // 
            this.MasaNoLabel.Location = new System.Drawing.Point(932, 118);
            this.MasaNoLabel.Name = "MasaNoLabel";
            this.MasaNoLabel.Size = new System.Drawing.Size(100, 23);
            this.MasaNoLabel.TabIndex = 0;
            this.MasaNoLabel.Text = "Masa No";
            // 
            // MusteriAdıLabel
            // 
            this.MusteriAdıLabel.Location = new System.Drawing.Point(932, 170);
            this.MusteriAdıLabel.Name = "MusteriAdıLabel";
            this.MusteriAdıLabel.Size = new System.Drawing.Size(100, 23);
            this.MusteriAdıLabel.TabIndex = 1;
            this.MusteriAdıLabel.Text = "Musteri adi";
            // 
            // MusteriSoyadıLabel
            // 
            this.MusteriSoyadıLabel.Location = new System.Drawing.Point(932, 211);
            this.MusteriSoyadıLabel.Name = "MusteriSoyadıLabel";
            this.MusteriSoyadıLabel.Size = new System.Drawing.Size(100, 23);
            this.MusteriSoyadıLabel.TabIndex = 2;
            this.MusteriSoyadıLabel.Text = "Musteri Soyadi";
            // 
            // IstenenUrunLabel
            // 
            this.IstenenUrunLabel.Location = new System.Drawing.Point(932, 261);
            this.IstenenUrunLabel.Name = "IstenenUrunLabel";
            this.IstenenUrunLabel.Size = new System.Drawing.Size(100, 23);
            this.IstenenUrunLabel.TabIndex = 3;
            this.IstenenUrunLabel.Text = "Istek Urun";
            // 
            // UrunMıktarıLabel
            // 
            this.UrunMıktarıLabel.Location = new System.Drawing.Point(932, 308);
            this.UrunMıktarıLabel.Name = "UrunMıktarıLabel";
            this.UrunMıktarıLabel.Size = new System.Drawing.Size(100, 23);
            this.UrunMıktarıLabel.TabIndex = 4;
            this.UrunMıktarıLabel.Text = "Urun Miktarı";
            // 
            // SureLabel
            // 
            this.SureLabel.Location = new System.Drawing.Point(932, 351);
            this.SureLabel.Name = "SureLabel";
            this.SureLabel.Size = new System.Drawing.Size(100, 23);
            this.SureLabel.TabIndex = 5;
            this.SureLabel.Text = "Sure";
            // 
            // MasaNoTextBox
            // 
            this.MasaNoTextBox.Location = new System.Drawing.Point(1073, 118);
            this.MasaNoTextBox.Name = "MasaNoTextBox";
            this.MasaNoTextBox.Size = new System.Drawing.Size(148, 23);
            this.MasaNoTextBox.TabIndex = 6;
            this.MasaNoTextBox.TextChanged += new System.EventHandler(this.MasaNoTextBox_TextChanged);
            // 
            // MusteriAdiTextBox
            // 
            this.MusteriAdiTextBox.Location = new System.Drawing.Point(1073, 170);
            this.MusteriAdiTextBox.Name = "MusteriAdiTextBox";
            this.MusteriAdiTextBox.Size = new System.Drawing.Size(148, 23);
            this.MusteriAdiTextBox.TabIndex = 7;
            this.MusteriAdiTextBox.TextChanged += new System.EventHandler(this.MusteriAdiTextBox_TextChanged);
            // 
            // MusteriSoyadıTextbox
            // 
            this.MusteriSoyadıTextbox.Location = new System.Drawing.Point(1073, 211);
            this.MusteriSoyadıTextbox.Name = "MusteriSoyadıTextbox";
            this.MusteriSoyadıTextbox.Size = new System.Drawing.Size(148, 23);
            this.MusteriSoyadıTextbox.TabIndex = 8;
            this.MusteriSoyadıTextbox.TextChanged += new System.EventHandler(this.MusteriSoyadıTextbox_TextChanged);
            // 
            // IstekUrunTextBox
            // 
            this.IstekUrunTextBox.Location = new System.Drawing.Point(1073, 261);
            this.IstekUrunTextBox.Name = "IstekUrunTextBox";
            this.IstekUrunTextBox.Size = new System.Drawing.Size(148, 23);
            this.IstekUrunTextBox.TabIndex = 9;
            this.IstekUrunTextBox.TextChanged += new System.EventHandler(this.IstekUrunTextBox_TextChanged);
            // 
            // MıktarTextbox
            // 
            this.MıktarTextbox.Location = new System.Drawing.Point(1073, 308);
            this.MıktarTextbox.Name = "MıktarTextbox";
            this.MıktarTextbox.Size = new System.Drawing.Size(148, 23);
            this.MıktarTextbox.TabIndex = 10;
            this.MıktarTextbox.TextChanged += new System.EventHandler(this.MıktarTextbox_TextChanged);
            // 
            // SureTextbox
            // 
            this.SureTextbox.Location = new System.Drawing.Point(1073, 351);
            this.SureTextbox.Name = "SureTextbox";
            this.SureTextbox.Size = new System.Drawing.Size(148, 23);
            this.SureTextbox.TabIndex = 11;
            this.SureTextbox.TextChanged += new System.EventHandler(this.SureTextbox_TextChanged);
            this.SureTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SureTextbox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 631);
            this.Controls.Add(this.SureTextbox);
            this.Controls.Add(this.MıktarTextbox);
            this.Controls.Add(this.IstekUrunTextBox);
            this.Controls.Add(this.MusteriSoyadıTextbox);
            this.Controls.Add(this.MusteriAdiTextBox);
            this.Controls.Add(this.MasaNoTextBox);
            this.Controls.Add(this.SureLabel);
            this.Controls.Add(this.UrunMıktarıLabel);
            this.Controls.Add(this.IstenenUrunLabel);
            this.Controls.Add(this.MusteriSoyadıLabel);
            this.Controls.Add(this.MusteriAdıLabel);
            this.Controls.Add(this.MasaNoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MasaNoLabel;
        private Label MusteriAdıLabel;
        private Label MusteriSoyadıLabel;
        private Label IstenenUrunLabel;
        private Label UrunMıktarıLabel;
        private Label SureLabel;
        private TextBox MasaNoTextBox;
        private TextBox MusteriAdiTextBox;
        private TextBox MusteriSoyadıTextbox;
        private TextBox IstekUrunTextBox;
        private TextBox MıktarTextbox;
        private TextBox SureTextbox;
    }
}
namespace NdpGiyimMagazaUygulamasi
{
    partial class FormKayıt
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
            this.AdtextBox1 = new System.Windows.Forms.TextBox();
            this.KullanıcıTextBox = new System.Windows.Forms.TextBox();
            this.SifretextBox = new System.Windows.Forms.TextBox();
            this.SifreTekrartextBox = new System.Windows.Forms.TextBox();
            this.Kayıtbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdtextBox1
            // 
            this.AdtextBox1.Location = new System.Drawing.Point(159, 51);
            this.AdtextBox1.Name = "AdtextBox1";
            this.AdtextBox1.Size = new System.Drawing.Size(139, 20);
            this.AdtextBox1.TabIndex = 0;
            // 
            // KullanıcıTextBox
            // 
            this.KullanıcıTextBox.Location = new System.Drawing.Point(159, 77);
            this.KullanıcıTextBox.Name = "KullanıcıTextBox";
            this.KullanıcıTextBox.Size = new System.Drawing.Size(139, 20);
            this.KullanıcıTextBox.TabIndex = 1;
            // 
            // SifretextBox
            // 
            this.SifretextBox.Location = new System.Drawing.Point(159, 103);
            this.SifretextBox.Name = "SifretextBox";
            this.SifretextBox.Size = new System.Drawing.Size(139, 20);
            this.SifretextBox.TabIndex = 2;
            // 
            // SifreTekrartextBox
            // 
            this.SifreTekrartextBox.Location = new System.Drawing.Point(159, 129);
            this.SifreTekrartextBox.Name = "SifreTekrartextBox";
            this.SifreTekrartextBox.Size = new System.Drawing.Size(139, 20);
            this.SifreTekrartextBox.TabIndex = 3;
            // 
            // Kayıtbutton
            // 
            this.Kayıtbutton.Location = new System.Drawing.Point(159, 155);
            this.Kayıtbutton.Name = "Kayıtbutton";
            this.Kayıtbutton.Size = new System.Drawing.Size(139, 23);
            this.Kayıtbutton.TabIndex = 4;
            this.Kayıtbutton.Text = "button1";
            this.Kayıtbutton.UseVisualStyleBackColor = true;
            this.Kayıtbutton.Click += new System.EventHandler(this.Kayıtbutton_Click);
            // 
            // FormKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.Kayıtbutton);
            this.Controls.Add(this.SifreTekrartextBox);
            this.Controls.Add(this.SifretextBox);
            this.Controls.Add(this.KullanıcıTextBox);
            this.Controls.Add(this.AdtextBox1);
            this.Name = "FormKayıt";
            this.Text = "FormKayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKayıt_FormClosed);
            this.Load += new System.EventHandler(this.FormKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdtextBox1;
        private System.Windows.Forms.TextBox KullanıcıTextBox;
        private System.Windows.Forms.TextBox SifretextBox;
        private System.Windows.Forms.TextBox SifreTekrartextBox;
        private System.Windows.Forms.Button Kayıtbutton;
    }
}
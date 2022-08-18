namespace NdpGiyimMagazaUygulamasi
{
    partial class form1
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
            this.userIdLbl = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIdLbl
            // 
            this.userIdLbl.BackColor = System.Drawing.Color.SeaShell;
            this.userIdLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userIdLbl.Location = new System.Drawing.Point(65, 96);
            this.userIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(117, 28);
            this.userIdLbl.TabIndex = 0;
            this.userIdLbl.Text = "kullanici Ismi";
            this.userIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.BackColor = System.Drawing.Color.SeaShell;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Passwordlabel.Location = new System.Drawing.Point(65, 139);
            this.Passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(117, 28);
            this.Passwordlabel.TabIndex = 1;
            this.Passwordlabel.Text = "Sifre";
            this.Passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(248, 96);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(283, 21);
            this.usertxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(248, 143);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(283, 21);
            this.passwordtxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(248, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "GİRİS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(413, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "HESAP AC";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(548, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.userIdLbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox usertxt;
        public System.Windows.Forms.TextBox passwordtxt;
    }
}


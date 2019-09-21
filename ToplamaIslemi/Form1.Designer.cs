namespace ToplamaIslemi
{
    partial class frmToplama
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
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.tabGenel = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lwLog = new System.Windows.Forms.ListView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.tabToplama.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabToplama
            // 
            this.tabToplama.Controls.Add(this.btnİleri);
            this.tabToplama.Controls.Add(this.txtSonuc);
            this.tabToplama.Controls.Add(this.lblSonuc);
            this.tabToplama.Controls.Add(this.txtSayi2);
            this.tabToplama.Controls.Add(this.txtSayi1);
            this.tabToplama.Controls.Add(this.btnToplama);
            this.tabToplama.Controls.Add(this.lblSayi2);
            this.tabToplama.Controls.Add(this.lblSayi1);
            this.tabToplama.Location = new System.Drawing.Point(4, 25);
            this.tabToplama.Margin = new System.Windows.Forms.Padding(4);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(4);
            this.tabToplama.Size = new System.Drawing.Size(728, 372);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            this.tabToplama.UseVisualStyleBackColor = true;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(216, 218);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(250, 22);
            this.txtSonuc.TabIndex = 3;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(43, 226);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(52, 17);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(209, 66);
            this.txtSayi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(259, 22);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi2_KeyPress);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(209, 31);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(259, 22);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi1_KeyPress);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(209, 113);
            this.btnToplama.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(259, 75);
            this.btnToplama.TabIndex = 2;
            this.btnToplama.Text = "Topla";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(36, 71);
            this.lblSayi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(70, 17);
            this.lblSayi2.TabIndex = 3;
            this.lblSayi2.Text = "İkinci Sayi";
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(36, 31);
            this.lblSayi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(77, 17);
            this.lblSayi1.TabIndex = 1;
            this.lblSayi1.Text = "Birinci Sayi";
            // 
            // tabGenel
            // 
            this.tabGenel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGenel.Controls.Add(this.tabToplama);
            this.tabGenel.Controls.Add(this.tabLog);
            this.tabGenel.Location = new System.Drawing.Point(5, 2);
            this.tabGenel.Margin = new System.Windows.Forms.Padding(4);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.SelectedIndex = 0;
            this.tabGenel.Size = new System.Drawing.Size(736, 401);
            this.tabGenel.TabIndex = 5;
            this.tabGenel.Tag = "";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.btnGeri);
            this.tabLog.Controls.Add(this.btnTemizle);
            this.tabLog.Controls.Add(this.lwLog);
            this.tabLog.Location = new System.Drawing.Point(4, 25);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(728, 372);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Loglama";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // lwLog
            // 
            this.lwLog.HideSelection = false;
            this.lwLog.Location = new System.Drawing.Point(3, 3);
            this.lwLog.Name = "lwLog";
            this.lwLog.Size = new System.Drawing.Size(719, 317);
            this.lwLog.TabIndex = 0;
            this.lwLog.UseCompatibleStateImageBehavior = false;
            this.lwLog.View = System.Windows.Forms.View.List;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(212, 329);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(114, 40);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(377, 326);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(103, 40);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(216, 283);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(250, 53);
            this.btnİleri.TabIndex = 6;
            this.btnİleri.Text = "Ileri";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // frmToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 457);
            this.Controls.Add(this.tabGenel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Load += new System.EventHandler(this.frmToplama_Load);
            this.Shown += new System.EventHandler(this.frmToplama_Shown);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tabGenel.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TabControl tabGenel;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ListView lwLog;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTemizle;
    }
}


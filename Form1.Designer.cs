namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screen = new System.Windows.Forms.Label();
            this.sayi1_btn = new System.Windows.Forms.Button();
            this.sayi2_btn = new System.Windows.Forms.Button();
            this.sayi3_btn = new System.Windows.Forms.Button();
            this.topla_butonu = new System.Windows.Forms.Button();
            this.cikart_butonu = new System.Windows.Forms.Button();
            this.sayi6_btn = new System.Windows.Forms.Button();
            this.sayi5_btn = new System.Windows.Forms.Button();
            this.sayi4_btn = new System.Windows.Forms.Button();
            this.bolme_butonu = new System.Windows.Forms.Button();
            this.esittir_butonu = new System.Windows.Forms.Button();
            this.sayi0_btn = new System.Windows.Forms.Button();
            this.temizle_butonu = new System.Windows.Forms.Button();
            this.carpma_butonu = new System.Windows.Forms.Button();
            this.sayi9_btn = new System.Windows.Forms.Button();
            this.sayi8_btn = new System.Windows.Forms.Button();
            this.sayi7_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.screen.Location = new System.Drawing.Point(31, 51);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(318, 100);
            this.screen.TabIndex = 0;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.screen.Click += new System.EventHandler(this.label1_Click);
            // 
            // sayi1_btn
            // 
            this.sayi1_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi1_btn.Location = new System.Drawing.Point(31, 165);
            this.sayi1_btn.Name = "sayi1_btn";
            this.sayi1_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi1_btn.TabIndex = 1;
            this.sayi1_btn.Text = "1";
            this.sayi1_btn.UseVisualStyleBackColor = false;
            this.sayi1_btn.Click += new System.EventHandler(this.sayi1_btn_Click);
            // 
            // sayi2_btn
            // 
            this.sayi2_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2_btn.Location = new System.Drawing.Point(112, 165);
            this.sayi2_btn.Name = "sayi2_btn";
            this.sayi2_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi2_btn.TabIndex = 2;
            this.sayi2_btn.Text = "2";
            this.sayi2_btn.UseVisualStyleBackColor = false;
            this.sayi2_btn.Click += new System.EventHandler(this.sayi2_btn_Click);
            // 
            // sayi3_btn
            // 
            this.sayi3_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi3_btn.Location = new System.Drawing.Point(193, 165);
            this.sayi3_btn.Name = "sayi3_btn";
            this.sayi3_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi3_btn.TabIndex = 3;
            this.sayi3_btn.Text = "3";
            this.sayi3_btn.UseVisualStyleBackColor = false;
            this.sayi3_btn.Click += new System.EventHandler(this.sayi3_btn_Click);
            // 
            // topla_butonu
            // 
            this.topla_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topla_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topla_butonu.Location = new System.Drawing.Point(274, 165);
            this.topla_butonu.Name = "topla_butonu";
            this.topla_butonu.Size = new System.Drawing.Size(75, 75);
            this.topla_butonu.TabIndex = 4;
            this.topla_butonu.Text = "+";
            this.topla_butonu.UseVisualStyleBackColor = false;
            this.topla_butonu.Click += new System.EventHandler(this.topla_butonu_Click);
            // 
            // cikart_butonu
            // 
            this.cikart_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cikart_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikart_butonu.Location = new System.Drawing.Point(274, 246);
            this.cikart_butonu.Name = "cikart_butonu";
            this.cikart_butonu.Size = new System.Drawing.Size(75, 75);
            this.cikart_butonu.TabIndex = 8;
            this.cikart_butonu.Text = "-";
            this.cikart_butonu.UseVisualStyleBackColor = false;
            this.cikart_butonu.Click += new System.EventHandler(this.cikart_butonu_Click);
            // 
            // sayi6_btn
            // 
            this.sayi6_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi6_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi6_btn.Location = new System.Drawing.Point(193, 246);
            this.sayi6_btn.Name = "sayi6_btn";
            this.sayi6_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi6_btn.TabIndex = 7;
            this.sayi6_btn.Text = "6";
            this.sayi6_btn.UseVisualStyleBackColor = false;
            this.sayi6_btn.Click += new System.EventHandler(this.sayi6_btn_Click);
            // 
            // sayi5_btn
            // 
            this.sayi5_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi5_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi5_btn.Location = new System.Drawing.Point(112, 246);
            this.sayi5_btn.Name = "sayi5_btn";
            this.sayi5_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi5_btn.TabIndex = 6;
            this.sayi5_btn.Text = "5";
            this.sayi5_btn.UseVisualStyleBackColor = false;
            this.sayi5_btn.Click += new System.EventHandler(this.sayi5_btn_Click);
            // 
            // sayi4_btn
            // 
            this.sayi4_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi4_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi4_btn.Location = new System.Drawing.Point(31, 246);
            this.sayi4_btn.Name = "sayi4_btn";
            this.sayi4_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi4_btn.TabIndex = 5;
            this.sayi4_btn.Text = "4";
            this.sayi4_btn.UseVisualStyleBackColor = false;
            this.sayi4_btn.Click += new System.EventHandler(this.sayi4_btn_Click);
            // 
            // bolme_butonu
            // 
            this.bolme_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bolme_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme_butonu.Location = new System.Drawing.Point(274, 408);
            this.bolme_butonu.Name = "bolme_butonu";
            this.bolme_butonu.Size = new System.Drawing.Size(75, 75);
            this.bolme_butonu.TabIndex = 16;
            this.bolme_butonu.Text = "/";
            this.bolme_butonu.UseVisualStyleBackColor = false;
            this.bolme_butonu.Click += new System.EventHandler(this.bolme_butonu_Click);
            // 
            // esittir_butonu
            // 
            this.esittir_butonu.BackColor = System.Drawing.Color.Silver;
            this.esittir_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittir_butonu.Location = new System.Drawing.Point(193, 408);
            this.esittir_butonu.Name = "esittir_butonu";
            this.esittir_butonu.Size = new System.Drawing.Size(75, 75);
            this.esittir_butonu.TabIndex = 15;
            this.esittir_butonu.Text = "=";
            this.esittir_butonu.UseVisualStyleBackColor = false;
            this.esittir_butonu.Click += new System.EventHandler(this.esittir_butonu_Click);
            // 
            // sayi0_btn
            // 
            this.sayi0_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi0_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi0_btn.Location = new System.Drawing.Point(112, 408);
            this.sayi0_btn.Name = "sayi0_btn";
            this.sayi0_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi0_btn.TabIndex = 14;
            this.sayi0_btn.Text = "0";
            this.sayi0_btn.UseVisualStyleBackColor = false;
            this.sayi0_btn.Click += new System.EventHandler(this.sayi0_btn_Click);
            // 
            // temizle_butonu
            // 
            this.temizle_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.temizle_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle_butonu.Location = new System.Drawing.Point(31, 408);
            this.temizle_butonu.Name = "temizle_butonu";
            this.temizle_butonu.Size = new System.Drawing.Size(75, 75);
            this.temizle_butonu.TabIndex = 13;
            this.temizle_butonu.Text = "C";
            this.temizle_butonu.UseVisualStyleBackColor = false;
            // 
            // carpma_butonu
            // 
            this.carpma_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.carpma_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma_butonu.Location = new System.Drawing.Point(274, 327);
            this.carpma_butonu.Name = "carpma_butonu";
            this.carpma_butonu.Size = new System.Drawing.Size(75, 75);
            this.carpma_butonu.TabIndex = 12;
            this.carpma_butonu.Text = "x";
            this.carpma_butonu.UseVisualStyleBackColor = false;
            this.carpma_butonu.Click += new System.EventHandler(this.carpma_butonu_Click);
            // 
            // sayi9_btn
            // 
            this.sayi9_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi9_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi9_btn.Location = new System.Drawing.Point(193, 327);
            this.sayi9_btn.Name = "sayi9_btn";
            this.sayi9_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi9_btn.TabIndex = 11;
            this.sayi9_btn.Text = "9";
            this.sayi9_btn.UseVisualStyleBackColor = false;
            this.sayi9_btn.Click += new System.EventHandler(this.sayi9_btn_Click);
            // 
            // sayi8_btn
            // 
            this.sayi8_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi8_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi8_btn.Location = new System.Drawing.Point(112, 327);
            this.sayi8_btn.Name = "sayi8_btn";
            this.sayi8_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi8_btn.TabIndex = 10;
            this.sayi8_btn.Text = "8";
            this.sayi8_btn.UseVisualStyleBackColor = false;
            // 
            // sayi7_btn
            // 
            this.sayi7_btn.BackColor = System.Drawing.Color.Gray;
            this.sayi7_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi7_btn.Location = new System.Drawing.Point(31, 327);
            this.sayi7_btn.Name = "sayi7_btn";
            this.sayi7_btn.Size = new System.Drawing.Size(75, 75);
            this.sayi7_btn.TabIndex = 9;
            this.sayi7_btn.Text = "7";
            this.sayi7_btn.UseVisualStyleBackColor = false;
            this.sayi7_btn.Click += new System.EventHandler(this.sayi7_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.bolme_butonu);
            this.Controls.Add(this.esittir_butonu);
            this.Controls.Add(this.sayi0_btn);
            this.Controls.Add(this.temizle_butonu);
            this.Controls.Add(this.carpma_butonu);
            this.Controls.Add(this.sayi9_btn);
            this.Controls.Add(this.sayi8_btn);
            this.Controls.Add(this.sayi7_btn);
            this.Controls.Add(this.cikart_butonu);
            this.Controls.Add(this.sayi6_btn);
            this.Controls.Add(this.sayi5_btn);
            this.Controls.Add(this.sayi4_btn);
            this.Controls.Add(this.topla_butonu);
            this.Controls.Add(this.sayi3_btn);
            this.Controls.Add(this.sayi2_btn);
            this.Controls.Add(this.sayi1_btn);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Button sayi1_btn;
        private System.Windows.Forms.Button sayi2_btn;
        private System.Windows.Forms.Button sayi3_btn;
        private System.Windows.Forms.Button topla_butonu;
        private System.Windows.Forms.Button cikart_butonu;
        private System.Windows.Forms.Button sayi6_btn;
        private System.Windows.Forms.Button sayi5_btn;
        private System.Windows.Forms.Button sayi4_btn;
        private System.Windows.Forms.Button bolme_butonu;
        private System.Windows.Forms.Button esittir_butonu;
        private System.Windows.Forms.Button sayi0_btn;
        private System.Windows.Forms.Button temizle_butonu;
        private System.Windows.Forms.Button carpma_butonu;
        private System.Windows.Forms.Button sayi9_btn;
        private System.Windows.Forms.Button sayi8_btn;
        private System.Windows.Forms.Button sayi7_btn;
    }
}


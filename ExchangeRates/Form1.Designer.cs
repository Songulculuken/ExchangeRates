namespace ExchangeRates
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
            this.components = new System.ComponentModel.Container();
            this.lbl_usd = new System.Windows.Forms.Label();
            this.lbl_eur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_usd
            // 
            this.lbl_usd.AutoSize = true;
            this.lbl_usd.Location = new System.Drawing.Point(230, 108);
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(47, 20);
            this.lbl_usd.TabIndex = 0;
            this.lbl_usd.Text = "Dolar";
            // 
            // lbl_eur
            // 
            this.lbl_eur.AutoSize = true;
            this.lbl_eur.Location = new System.Drawing.Point(230, 164);
            this.lbl_eur.Name = "lbl_eur";
            this.lbl_eur.Size = new System.Drawing.Size(43, 20);
            this.lbl_eur.TabIndex = 1;
            this.lbl_eur.Text = "Euro";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(101, 108);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(47, 20);
            this.lbl_dolar.TabIndex = 2;
            this.lbl_dolar.Text = "Dolar";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(105, 164);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(43, 20);
            this.lbl_euro.TabIndex = 3;
            this.lbl_euro.Text = "Euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lbl_eur);
            this.Controls.Add(this.lbl_usd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usd;
        private System.Windows.Forms.Label lbl_eur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lbl_euro;
    }
}


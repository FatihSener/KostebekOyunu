namespace Köstebek_Oyunu
{
    partial class frmKostebekOyunu
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
            this.flpOyunEkranı = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrKontrol = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flpOyunEkranı
            // 
            this.flpOyunEkranı.BackColor = System.Drawing.Color.White;
            this.flpOyunEkranı.Location = new System.Drawing.Point(1, 0);
            this.flpOyunEkranı.Name = "flpOyunEkranı";
            this.flpOyunEkranı.Size = new System.Drawing.Size(791, 348);
            this.flpOyunEkranı.TabIndex = 0;
            // 
            // tmrKontrol
            // 
            this.tmrKontrol.Interval = 1000;
            this.tmrKontrol.Tick += new System.EventHandler(this.tmrKontrol_Tick);
            // 
            // frmKostebekOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(795, 350);
            this.Controls.Add(this.flpOyunEkranı);
            this.Name = "frmKostebekOyunu";
            this.Text = "Köstebek Oyunu";
            this.Load += new System.EventHandler(this.frmKostebekOyunu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpOyunEkranı;
        private System.Windows.Forms.Timer tmrKontrol;
    }
}


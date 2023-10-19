namespace CafeProject
{
    partial class UrunlerForm
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
            label1 = new Label();
            label2 = new Label();
            txtUrunAd = new TextBox();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            nudBirimFiyat = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 14);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 28);
            label2.Name = "label2";
            label2.Size = new Size(96, 14);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(12, 45);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(179, 22);
            txtUrunAd.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(403, 28);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 37);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(14, 81);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.Size = new Size(495, 302);
            dgvUrunler.TabIndex = 4;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(214, 45);
            nudBirimFiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(151, 22);
            nudBirimFiyat.TabIndex = 6;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 395);
            Controls.Add(nudBirimFiyat);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(txtUrunAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUrunAd;
        private Button btnEkle;
        private DataGridView dgvUrunler;
        private NumericUpDown nudBirimFiyat;
    }
}
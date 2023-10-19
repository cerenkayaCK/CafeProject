namespace CafeProject
{
    partial class SiparisForm
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
            btnDetayEkle = new Button();
            btnSiparisİptal = new Button();
            btnOdemeAl = new Button();
            nudAdet = new ComboBox();
            cmoUrun = new ComboBox();
            btnAnasayfayaDon = new Button();
            btnMasaTasi = new Button();
            label3 = new Label();
            cmoMasaNo = new ComboBox();
            dgvDetaylar = new DataGridView();
            lblTutar = new Label();
            lblOdemeTutari = new Label();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(37, 14);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(193, 26);
            label2.Name = "label2";
            label2.Size = new Size(36, 14);
            label2.TabIndex = 2;
            label2.Text = "Adet";
            label2.Click += label2_Click;
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Anchor = AnchorStyles.Top;
            btnDetayEkle.Location = new Point(304, 37);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(99, 30);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "Ekle";
            btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // btnSiparisİptal
            // 
            btnSiparisİptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisİptal.BackColor = Color.Firebrick;
            btnSiparisİptal.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisİptal.ForeColor = SystemColors.ButtonHighlight;
            btnSiparisİptal.Location = new Point(423, 275);
            btnSiparisİptal.Name = "btnSiparisİptal";
            btnSiparisİptal.Size = new Size(104, 40);
            btnSiparisİptal.TabIndex = 12;
            btnSiparisİptal.Text = "Sipariş İptal";
            btnSiparisİptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.YellowGreen;
            btnOdemeAl.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = SystemColors.ButtonHighlight;
            btnOdemeAl.Location = new Point(533, 275);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(110, 40);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "Ödeme Al";
            btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // nudAdet
            // 
            nudAdet.Anchor = AnchorStyles.Top;
            nudAdet.DisplayMember = "1";
            nudAdet.FormattingEnabled = true;
            nudAdet.Items.AddRange(new object[] { "1" });
            nudAdet.Location = new Point(193, 42);
            nudAdet.MinimumSize = new Size(1, 0);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(81, 22);
            nudAdet.TabIndex = 3;
            nudAdet.ValueMember = "1";
            // 
            // cmoUrun
            // 
            cmoUrun.Anchor = AnchorStyles.Top;
            cmoUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmoUrun.FormattingEnabled = true;
            cmoUrun.Location = new Point(34, 43);
            cmoUrun.Name = "cmoUrun";
            cmoUrun.Size = new Size(117, 22);
            cmoUrun.TabIndex = 1;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.Gold;
            btnAnasayfayaDon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnasayfayaDon.ForeColor = Color.OrangeRed;
            btnAnasayfayaDon.Location = new Point(423, 320);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(221, 49);
            btnAnasayfayaDon.TabIndex = 14;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.BackColor = SystemColors.ButtonHighlight;
            btnMasaTasi.Location = new Point(557, 42);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(86, 28);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(461, 26);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 5;
            label3.Text = "Masa No:";
            // 
            // cmoMasaNo
            // 
            cmoMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmoMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmoMasaNo.FormattingEnabled = true;
            cmoMasaNo.Location = new Point(442, 45);
            cmoMasaNo.Name = "cmoMasaNo";
            cmoMasaNo.Size = new Size(98, 22);
            cmoMasaNo.TabIndex = 6;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.BackgroundColor = SystemColors.ActiveBorder;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.GridColor = SystemColors.InactiveCaption;
            dgvDetaylar.Location = new Point(30, 98);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.Size = new Size(373, 271);
            dgvDetaylar.TabIndex = 8;
            // 
            // lblTutar
            // 
            lblTutar.Anchor = AnchorStyles.Right;
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(580, 250);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(51, 14);
            lblTutar.TabIndex = 11;
            lblTutar.Text = " ₺ 0.00";
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Location = new Point(429, 250);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(99, 14);
            lblOdemeTutari.TabIndex = 10;
            lblOdemeTutari.Text = "ÖDEME TUTARI";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Orange;
            lblMasaNo.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.Location = new Point(429, 98);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(221, 143);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 402);
            Controls.Add(lblMasaNo);
            Controls.Add(lblOdemeTutari);
            Controls.Add(lblTutar);
            Controls.Add(dgvDetaylar);
            Controls.Add(cmoMasaNo);
            Controls.Add(label3);
            Controls.Add(btnMasaTasi);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(cmoUrun);
            Controls.Add(nudAdet);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisİptal);
            Controls.Add(btnDetayEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(691, 441);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDetayEkle;
        private Button btnSiparisİptal;
        private Button btnOdemeAl;
        private ComboBox nudAdet;
        private ComboBox cmoUrun;
        private Button btnAnasayfayaDon;
        private Button btnMasaTasi;
        private Label label3;
        private ComboBox cmoMasaNo;
        private DataGridView dgvDetaylar;
        private Label lblTutar;
        private Label lblOdemeTutari;
        private Label lblMasaNo;
    }
}
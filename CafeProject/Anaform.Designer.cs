namespace CafeProject
{
    partial class Anaform
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            menuStrip1 = new MenuStrip();
            tsmiUrunler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            IvwMasalar = new ListView();
            iIMasalar = new ImageList(components);
            ımageList1 = new ImageList(components);
            ımageList2 = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(603, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            tsmiUrunler.Name = "tsmiUrunler";
            tsmiUrunler.Size = new Size(58, 20);
            tsmiUrunler.Text = "Ürünler";
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(108, 20);
            tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            tsmiGecmisSiparisler.Click += tsmiGecmisSiparisler_Click;
            // 
            // IvwMasalar
            // 
            IvwMasalar.Dock = DockStyle.Fill;
            IvwMasalar.LargeImageList = iIMasalar;
            IvwMasalar.Location = new Point(0, 24);
            IvwMasalar.Name = "IvwMasalar";
            IvwMasalar.Size = new Size(603, 396);
            IvwMasalar.TabIndex = 1;
            IvwMasalar.UseCompatibleStateImageBehavior = false;
            IvwMasalar.DoubleClick += IvwMasalar_DoubleClick;
            // 
            // iIMasalar
            // 
            iIMasalar.ColorDepth = ColorDepth.Depth8Bit;
            iIMasalar.ImageStream = (ImageListStreamer)resources.GetObject("iIMasalar.ImageStream");
            iIMasalar.TransparentColor = Color.Transparent;
            iIMasalar.Images.SetKeyName(0, "dolu");
            iIMasalar.Images.SetKeyName(1, "bos");
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth8Bit;
            ımageList2.ImageSize = new Size(16, 16);
            ımageList2.TransparentColor = Color.Transparent;
            // 
            // Anaform
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 420);
            Controls.Add(IvwMasalar);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "Anaform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafe Online6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
        private ListView IvwMasalar;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private ImageList iIMasalar;
    }
}
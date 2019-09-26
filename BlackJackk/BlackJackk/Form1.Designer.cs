namespace BlackJackk
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.lbPcToplam = new System.Windows.Forms.Label();
            this.ToplamOyuncu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPcKart4 = new System.Windows.Forms.Label();
            this.lbPcKart3 = new System.Windows.Forms.Label();
            this.lbPcKart2 = new System.Windows.Forms.Label();
            this.lbPcKart1 = new System.Windows.Forms.Label();
            this.Kart4 = new System.Windows.Forms.Label();
            this.Kart3 = new System.Windows.Forms.Label();
            this.Kart2 = new System.Windows.Forms.Label();
            this.Kart1 = new System.Windows.Forms.Label();
            this.lbOyuncuSkor = new System.Windows.Forms.Label();
            this.lbBilgisayarSkor = new System.Windows.Forms.Label();
            this.picOyuncuKart4 = new System.Windows.Forms.PictureBox();
            this.picOyuncuKart3 = new System.Windows.Forms.PictureBox();
            this.picOyuncuKart2 = new System.Windows.Forms.PictureBox();
            this.picOyuncuKart1 = new System.Windows.Forms.PictureBox();
            this.picPcKart4 = new System.Windows.Forms.PictureBox();
            this.picPcKart3 = new System.Windows.Forms.PictureBox();
            this.picPcKart2 = new System.Windows.Forms.PictureBox();
            this.picPcKart1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picGoruntu = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BlackJackk.Properties.Resources.Kapat;
            this.pictureBox1.Location = new System.Drawing.Point(1093, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelHeader.Location = new System.Drawing.Point(169, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(960, 11);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbPcToplam
            // 
            this.lbPcToplam.AutoSize = true;
            this.lbPcToplam.BackColor = System.Drawing.Color.Transparent;
            this.lbPcToplam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPcToplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPcToplam.Location = new System.Drawing.Point(1080, 219);
            this.lbPcToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPcToplam.Name = "lbPcToplam";
            this.lbPcToplam.Size = new System.Drawing.Size(18, 19);
            this.lbPcToplam.TabIndex = 20;
            this.lbPcToplam.Text = "0";
            // 
            // ToplamOyuncu
            // 
            this.ToplamOyuncu.AutoSize = true;
            this.ToplamOyuncu.BackColor = System.Drawing.Color.Transparent;
            this.ToplamOyuncu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamOyuncu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToplamOyuncu.Location = new System.Drawing.Point(315, 219);
            this.ToplamOyuncu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToplamOyuncu.Name = "ToplamOyuncu";
            this.ToplamOyuncu.Size = new System.Drawing.Size(18, 19);
            this.ToplamOyuncu.TabIndex = 21;
            this.ToplamOyuncu.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(966, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kart Toplamı : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(180, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kart Toplamı : ";
            // 
            // lbPcKart4
            // 
            this.lbPcKart4.AutoSize = true;
            this.lbPcKart4.BackColor = System.Drawing.Color.Transparent;
            this.lbPcKart4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPcKart4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPcKart4.Location = new System.Drawing.Point(966, 534);
            this.lbPcKart4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPcKart4.Name = "lbPcKart4";
            this.lbPcKart4.Size = new System.Drawing.Size(51, 19);
            this.lbPcKart4.TabIndex = 18;
            this.lbPcKart4.Text = "label8";
            this.lbPcKart4.Visible = false;
            // 
            // lbPcKart3
            // 
            this.lbPcKart3.AutoSize = true;
            this.lbPcKart3.BackColor = System.Drawing.Color.Transparent;
            this.lbPcKart3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPcKart3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPcKart3.Location = new System.Drawing.Point(966, 510);
            this.lbPcKart3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPcKart3.Name = "lbPcKart3";
            this.lbPcKart3.Size = new System.Drawing.Size(51, 19);
            this.lbPcKart3.TabIndex = 17;
            this.lbPcKart3.Text = "label7";
            this.lbPcKart3.Visible = false;
            // 
            // lbPcKart2
            // 
            this.lbPcKart2.AutoSize = true;
            this.lbPcKart2.BackColor = System.Drawing.Color.Transparent;
            this.lbPcKart2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPcKart2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPcKart2.Location = new System.Drawing.Point(966, 486);
            this.lbPcKart2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPcKart2.Name = "lbPcKart2";
            this.lbPcKart2.Size = new System.Drawing.Size(51, 19);
            this.lbPcKart2.TabIndex = 16;
            this.lbPcKart2.Text = "label6";
            this.lbPcKart2.Visible = false;
            // 
            // lbPcKart1
            // 
            this.lbPcKart1.AutoSize = true;
            this.lbPcKart1.BackColor = System.Drawing.Color.Transparent;
            this.lbPcKart1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPcKart1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPcKart1.Location = new System.Drawing.Point(966, 458);
            this.lbPcKart1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPcKart1.Name = "lbPcKart1";
            this.lbPcKart1.Size = new System.Drawing.Size(51, 19);
            this.lbPcKart1.TabIndex = 15;
            this.lbPcKart1.Text = "label5";
            this.lbPcKart1.Visible = false;
            // 
            // Kart4
            // 
            this.Kart4.AutoSize = true;
            this.Kart4.BackColor = System.Drawing.Color.Transparent;
            this.Kart4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kart4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kart4.Location = new System.Drawing.Point(273, 569);
            this.Kart4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kart4.Name = "Kart4";
            this.Kart4.Size = new System.Drawing.Size(51, 19);
            this.Kart4.TabIndex = 14;
            this.Kart4.Text = "label4";
            this.Kart4.Visible = false;
            // 
            // Kart3
            // 
            this.Kart3.AutoSize = true;
            this.Kart3.BackColor = System.Drawing.Color.Transparent;
            this.Kart3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kart3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kart3.Location = new System.Drawing.Point(273, 545);
            this.Kart3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kart3.Name = "Kart3";
            this.Kart3.Size = new System.Drawing.Size(51, 19);
            this.Kart3.TabIndex = 13;
            this.Kart3.Text = "label3";
            this.Kart3.Visible = false;
            // 
            // Kart2
            // 
            this.Kart2.AutoSize = true;
            this.Kart2.BackColor = System.Drawing.Color.Transparent;
            this.Kart2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kart2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kart2.Location = new System.Drawing.Point(273, 521);
            this.Kart2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kart2.Name = "Kart2";
            this.Kart2.Size = new System.Drawing.Size(51, 19);
            this.Kart2.TabIndex = 12;
            this.Kart2.Text = "label2";
            this.Kart2.Visible = false;
            // 
            // Kart1
            // 
            this.Kart1.AutoSize = true;
            this.Kart1.BackColor = System.Drawing.Color.Transparent;
            this.Kart1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kart1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kart1.Location = new System.Drawing.Point(273, 497);
            this.Kart1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kart1.Name = "Kart1";
            this.Kart1.Size = new System.Drawing.Size(51, 19);
            this.Kart1.TabIndex = 11;
            this.Kart1.Text = "label1";
            this.Kart1.Visible = false;
            // 
            // lbOyuncuSkor
            // 
            this.lbOyuncuSkor.AutoSize = true;
            this.lbOyuncuSkor.BackColor = System.Drawing.Color.Transparent;
            this.lbOyuncuSkor.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbOyuncuSkor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbOyuncuSkor.Location = new System.Drawing.Point(238, 126);
            this.lbOyuncuSkor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOyuncuSkor.Name = "lbOyuncuSkor";
            this.lbOyuncuSkor.Size = new System.Drawing.Size(30, 33);
            this.lbOyuncuSkor.TabIndex = 27;
            this.lbOyuncuSkor.Text = "0";
            // 
            // lbBilgisayarSkor
            // 
            this.lbBilgisayarSkor.AutoSize = true;
            this.lbBilgisayarSkor.BackColor = System.Drawing.Color.Transparent;
            this.lbBilgisayarSkor.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBilgisayarSkor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBilgisayarSkor.Location = new System.Drawing.Point(1019, 126);
            this.lbBilgisayarSkor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBilgisayarSkor.Name = "lbBilgisayarSkor";
            this.lbBilgisayarSkor.Size = new System.Drawing.Size(30, 33);
            this.lbBilgisayarSkor.TabIndex = 26;
            this.lbBilgisayarSkor.Text = "0";
            // 
            // picOyuncuKart4
            // 
            this.picOyuncuKart4.Image = ((System.Drawing.Image)(resources.GetObject("picOyuncuKart4.Image")));
            this.picOyuncuKart4.Location = new System.Drawing.Point(831, 467);
            this.picOyuncuKart4.Margin = new System.Windows.Forms.Padding(4);
            this.picOyuncuKart4.Name = "picOyuncuKart4";
            this.picOyuncuKart4.Size = new System.Drawing.Size(122, 172);
            this.picOyuncuKart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOyuncuKart4.TabIndex = 29;
            this.picOyuncuKart4.TabStop = false;
            // 
            // picOyuncuKart3
            // 
            this.picOyuncuKart3.Image = ((System.Drawing.Image)(resources.GetObject("picOyuncuKart3.Image")));
            this.picOyuncuKart3.Location = new System.Drawing.Point(674, 534);
            this.picOyuncuKart3.Margin = new System.Windows.Forms.Padding(4);
            this.picOyuncuKart3.Name = "picOyuncuKart3";
            this.picOyuncuKart3.Size = new System.Drawing.Size(120, 172);
            this.picOyuncuKart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOyuncuKart3.TabIndex = 30;
            this.picOyuncuKart3.TabStop = false;
            // 
            // picOyuncuKart2
            // 
            this.picOyuncuKart2.Image = ((System.Drawing.Image)(resources.GetObject("picOyuncuKart2.Image")));
            this.picOyuncuKart2.Location = new System.Drawing.Point(505, 534);
            this.picOyuncuKart2.Margin = new System.Windows.Forms.Padding(4);
            this.picOyuncuKart2.Name = "picOyuncuKart2";
            this.picOyuncuKart2.Size = new System.Drawing.Size(120, 172);
            this.picOyuncuKart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOyuncuKart2.TabIndex = 31;
            this.picOyuncuKart2.TabStop = false;
            // 
            // picOyuncuKart1
            // 
            this.picOyuncuKart1.Image = ((System.Drawing.Image)(resources.GetObject("picOyuncuKart1.Image")));
            this.picOyuncuKart1.Location = new System.Drawing.Point(345, 468);
            this.picOyuncuKart1.Margin = new System.Windows.Forms.Padding(4);
            this.picOyuncuKart1.Name = "picOyuncuKart1";
            this.picOyuncuKart1.Size = new System.Drawing.Size(120, 171);
            this.picOyuncuKart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOyuncuKart1.TabIndex = 32;
            this.picOyuncuKart1.TabStop = false;
            // 
            // picPcKart4
            // 
            this.picPcKart4.Image = ((System.Drawing.Image)(resources.GetObject("picPcKart4.Image")));
            this.picPcKart4.Location = new System.Drawing.Point(831, 35);
            this.picPcKart4.Margin = new System.Windows.Forms.Padding(4);
            this.picPcKart4.Name = "picPcKart4";
            this.picPcKart4.Size = new System.Drawing.Size(121, 173);
            this.picPcKart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPcKart4.TabIndex = 33;
            this.picPcKart4.TabStop = false;
            // 
            // picPcKart3
            // 
            this.picPcKart3.Image = ((System.Drawing.Image)(resources.GetObject("picPcKart3.Image")));
            this.picPcKart3.Location = new System.Drawing.Point(674, 35);
            this.picPcKart3.Margin = new System.Windows.Forms.Padding(4);
            this.picPcKart3.Name = "picPcKart3";
            this.picPcKart3.Size = new System.Drawing.Size(120, 172);
            this.picPcKart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPcKart3.TabIndex = 34;
            this.picPcKart3.TabStop = false;
            // 
            // picPcKart2
            // 
            this.picPcKart2.Image = ((System.Drawing.Image)(resources.GetObject("picPcKart2.Image")));
            this.picPcKart2.Location = new System.Drawing.Point(505, 36);
            this.picPcKart2.Margin = new System.Windows.Forms.Padding(4);
            this.picPcKart2.Name = "picPcKart2";
            this.picPcKart2.Size = new System.Drawing.Size(120, 172);
            this.picPcKart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPcKart2.TabIndex = 35;
            this.picPcKart2.TabStop = false;
            // 
            // picPcKart1
            // 
            this.picPcKart1.Image = global::BlackJackk.Properties.Resources.kart_arka4;
            this.picPcKart1.Location = new System.Drawing.Point(345, 35);
            this.picPcKart1.Margin = new System.Windows.Forms.Padding(4);
            this.picPcKart1.Name = "picPcKart1";
            this.picPcKart1.Size = new System.Drawing.Size(120, 173);
            this.picPcKart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPcKart1.TabIndex = 36;
            this.picPcKart1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(93)))), ((int)(((byte)(20)))));
            this.pictureBox2.Image = global::BlackJackk.Properties.Resources.kartiste;
            this.pictureBox2.Location = new System.Drawing.Point(185, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(93)))), ((int)(((byte)(20)))));
            this.pictureBox3.Image = global::BlackJackk.Properties.Resources.Sabitle;
            this.pictureBox3.Location = new System.Drawing.Point(185, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // picGoruntu
            // 
            this.picGoruntu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGoruntu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(93)))), ((int)(((byte)(20)))));
            this.picGoruntu.Image = global::BlackJackk.Properties.Resources.kart_arka4;
            this.picGoruntu.Location = new System.Drawing.Point(983, 249);
            this.picGoruntu.Name = "picGoruntu";
            this.picGoruntu.Size = new System.Drawing.Size(120, 171);
            this.picGoruntu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoruntu.TabIndex = 39;
            this.picGoruntu.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BlackJackk.Properties.Resources.giphy__23_;
            this.pictureBox4.Location = new System.Drawing.Point(166, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(963, 757);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(93)))), ((int)(((byte)(20)))));
            this.pictureBox5.Image = global::BlackJackk.Properties.Resources.YeniOyun;
            this.pictureBox5.Location = new System.Drawing.Point(187, 329);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(138, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(93)))), ((int)(((byte)(20)))));
            this.pictureBox6.Image = global::BlackJackk.Properties.Resources.bilgi_;
            this.pictureBox6.Location = new System.Drawing.Point(1060, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BlackJackk.Properties.Resources.kural;
            this.pictureBox7.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1366, 764);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BlackJackk.Properties.Resources.masa2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picGoruntu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picPcKart4);
            this.Controls.Add(this.picPcKart3);
            this.Controls.Add(this.picPcKart2);
            this.Controls.Add(this.picPcKart1);
            this.Controls.Add(this.picOyuncuKart4);
            this.Controls.Add(this.picOyuncuKart3);
            this.Controls.Add(this.picOyuncuKart2);
            this.Controls.Add(this.picOyuncuKart1);
            this.Controls.Add(this.lbOyuncuSkor);
            this.Controls.Add(this.lbBilgisayarSkor);
            this.Controls.Add(this.lbPcToplam);
            this.Controls.Add(this.ToplamOyuncu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbPcKart4);
            this.Controls.Add(this.lbPcKart3);
            this.Controls.Add(this.lbPcKart2);
            this.Controls.Add(this.lbPcKart1);
            this.Controls.Add(this.Kart4);
            this.Controls.Add(this.Kart3);
            this.Controls.Add(this.Kart2);
            this.Controls.Add(this.Kart1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncuKart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPcKart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lbPcToplam;
        private System.Windows.Forms.Label ToplamOyuncu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPcKart4;
        private System.Windows.Forms.Label lbPcKart3;
        private System.Windows.Forms.Label lbPcKart2;
        private System.Windows.Forms.Label lbPcKart1;
        private System.Windows.Forms.Label Kart4;
        private System.Windows.Forms.Label Kart3;
        private System.Windows.Forms.Label Kart2;
        private System.Windows.Forms.Label Kart1;
        private System.Windows.Forms.Label lbOyuncuSkor;
        private System.Windows.Forms.Label lbBilgisayarSkor;
        private System.Windows.Forms.PictureBox picOyuncuKart4;
        private System.Windows.Forms.PictureBox picOyuncuKart3;
        private System.Windows.Forms.PictureBox picOyuncuKart2;
        private System.Windows.Forms.PictureBox picOyuncuKart1;
        private System.Windows.Forms.PictureBox picPcKart4;
        private System.Windows.Forms.PictureBox picPcKart3;
        private System.Windows.Forms.PictureBox picPcKart2;
        private System.Windows.Forms.PictureBox picPcKart1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picGoruntu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}


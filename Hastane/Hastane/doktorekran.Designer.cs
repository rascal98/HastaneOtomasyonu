namespace Hastane
{
    partial class doktorekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorekran));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.doktor_ismi = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DashLabel = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label10 = new System.Windows.Forms.Label();
            this.aciklama_rich = new System.Windows.Forms.RichTextBox();
            this.ilac_cmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tani_cmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.icd_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.randevutarih_txt = new System.Windows.Forms.TextBox();
            this.randevusaat_txt = new System.Windows.Forms.TextBox();
            this.hastasoyadi_txt = new System.Windows.Forms.TextBox();
            this.hastaadi_txt = new System.Windows.Forms.TextBox();
            this.hastatc_txt = new System.Windows.Forms.TextBox();
            this.printpreview_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HastaTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printpreview_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.doktor_ismi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 35);
            this.panel1.TabIndex = 5;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Hastane.Properties.Resources.cikisbtn2;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(939, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // doktor_ismi
            // 
            this.doktor_ismi.AutoSize = true;
            this.doktor_ismi.BackColor = System.Drawing.Color.Transparent;
            this.doktor_ismi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_ismi.Location = new System.Drawing.Point(37, 7);
            this.doktor_ismi.Name = "doktor_ismi";
            this.doktor_ismi.Size = new System.Drawing.Size(62, 21);
            this.doktor_ismi.TabIndex = 0;
            this.doktor_ismi.Text = "Doktor";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.DashLabel);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.label10);
            this.bunifuGradientPanel1.Controls.Add(this.aciklama_rich);
            this.bunifuGradientPanel1.Controls.Add(this.ilac_cmb);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.tani_cmb);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.icd_cmb);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.randevutarih_txt);
            this.bunifuGradientPanel1.Controls.Add(this.randevusaat_txt);
            this.bunifuGradientPanel1.Controls.Add(this.hastasoyadi_txt);
            this.bunifuGradientPanel1.Controls.Add(this.hastaadi_txt);
            this.bunifuGradientPanel1.Controls.Add(this.hastatc_txt);
            this.bunifuGradientPanel1.Controls.Add(this.printpreview_btn);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(199)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Plum;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.PaleGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(982, 456);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // DashLabel
            // 
            this.DashLabel.AutoSize = true;
            this.DashLabel.Location = new System.Drawing.Point(513, 496);
            this.DashLabel.Name = "DashLabel";
            this.DashLabel.Size = new System.Drawing.Size(418, 13);
            this.DashLabel.TabIndex = 29;
            this.DashLabel.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Hastane.Properties.Resources.print;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(678, 354);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 28;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Hastane.Properties.Resources.monitor;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(882, 354);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 27;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(646, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Açıklama:";
            // 
            // aciklama_rich
            // 
            this.aciklama_rich.BackColor = System.Drawing.Color.CornflowerBlue;
            this.aciklama_rich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aciklama_rich.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama_rich.Location = new System.Drawing.Point(745, 90);
            this.aciklama_rich.Name = "aciklama_rich";
            this.aciklama_rich.Size = new System.Drawing.Size(158, 99);
            this.aciklama_rich.TabIndex = 25;
            this.aciklama_rich.Text = "";
            // 
            // ilac_cmb
            // 
            this.ilac_cmb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ilac_cmb.FormattingEnabled = true;
            this.ilac_cmb.Location = new System.Drawing.Point(471, 171);
            this.ilac_cmb.Name = "ilac_cmb";
            this.ilac_cmb.Size = new System.Drawing.Size(121, 21);
            this.ilac_cmb.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(432, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "İLAÇ:";
            // 
            // tani_cmb
            // 
            this.tani_cmb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tani_cmb.FormattingEnabled = true;
            this.tani_cmb.Location = new System.Drawing.Point(471, 129);
            this.tani_cmb.Name = "tani_cmb";
            this.tani_cmb.Size = new System.Drawing.Size(121, 21);
            this.tani_cmb.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(432, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "TANI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(432, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "ICD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(432, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hastalık Tanımı";
            // 
            // icd_cmb
            // 
            this.icd_cmb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.icd_cmb.FormattingEnabled = true;
            this.icd_cmb.Location = new System.Drawing.Point(471, 90);
            this.icd_cmb.Name = "icd_cmb";
            this.icd_cmb.Size = new System.Drawing.Size(121, 21);
            this.icd_cmb.TabIndex = 18;
            this.icd_cmb.SelectedIndexChanged += new System.EventHandler(this.icd_cmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(166, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(166, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(166, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyadi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(166, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tc Kimlik:";
            // 
            // randevutarih_txt
            // 
            this.randevutarih_txt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.randevutarih_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randevutarih_txt.Enabled = false;
            this.randevutarih_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevutarih_txt.Location = new System.Drawing.Point(244, 207);
            this.randevutarih_txt.Name = "randevutarih_txt";
            this.randevutarih_txt.Size = new System.Drawing.Size(100, 15);
            this.randevutarih_txt.TabIndex = 12;
            // 
            // randevusaat_txt
            // 
            this.randevusaat_txt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.randevusaat_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randevusaat_txt.Enabled = false;
            this.randevusaat_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevusaat_txt.Location = new System.Drawing.Point(244, 170);
            this.randevusaat_txt.Name = "randevusaat_txt";
            this.randevusaat_txt.Size = new System.Drawing.Size(100, 15);
            this.randevusaat_txt.TabIndex = 11;
            // 
            // hastasoyadi_txt
            // 
            this.hastasoyadi_txt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.hastasoyadi_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hastasoyadi_txt.Enabled = false;
            this.hastasoyadi_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastasoyadi_txt.Location = new System.Drawing.Point(244, 133);
            this.hastasoyadi_txt.Name = "hastasoyadi_txt";
            this.hastasoyadi_txt.Size = new System.Drawing.Size(100, 15);
            this.hastasoyadi_txt.TabIndex = 10;
            // 
            // hastaadi_txt
            // 
            this.hastaadi_txt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.hastaadi_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hastaadi_txt.Enabled = false;
            this.hastaadi_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaadi_txt.Location = new System.Drawing.Point(244, 94);
            this.hastaadi_txt.Name = "hastaadi_txt";
            this.hastaadi_txt.Size = new System.Drawing.Size(100, 15);
            this.hastaadi_txt.TabIndex = 9;
            // 
            // hastatc_txt
            // 
            this.hastatc_txt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.hastatc_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hastatc_txt.Enabled = false;
            this.hastatc_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastatc_txt.Location = new System.Drawing.Point(244, 64);
            this.hastatc_txt.MaxLength = 11;
            this.hastatc_txt.Name = "hastatc_txt";
            this.hastatc_txt.Size = new System.Drawing.Size(100, 15);
            this.hastatc_txt.TabIndex = 8;
            // 
            // printpreview_btn
            // 
            this.printpreview_btn.BackColor = System.Drawing.Color.Transparent;
            this.printpreview_btn.Image = global::Hastane.Properties.Resources.Print_preview;
            this.printpreview_btn.ImageActive = null;
            this.printpreview_btn.Location = new System.Drawing.Point(781, 354);
            this.printpreview_btn.Name = "printpreview_btn";
            this.printpreview_btn.Size = new System.Drawing.Size(71, 71);
            this.printpreview_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printpreview_btn.TabIndex = 7;
            this.printpreview_btn.TabStop = false;
            this.printpreview_btn.Zoom = 10;
            this.printpreview_btn.Click += new System.EventHandler(this.printpreview_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(33, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaTc,
            this.Adi,
            this.Soyadi,
            this.RandevuSaat,
            this.RandevuTarih});
            this.dataGridView1.Location = new System.Drawing.Point(33, 275);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HastaTc
            // 
            this.HastaTc.HeaderText = "Hasta Tc Kimlik No";
            this.HastaTc.Name = "HastaTc";
            this.HastaTc.ReadOnly = true;
            this.HastaTc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Adi
            // 
            this.Adi.HeaderText = "Adi";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            this.Adi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Soyadi
            // 
            this.Soyadi.HeaderText = "Soyadi";
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.ReadOnly = true;
            this.Soyadi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RandevuSaat
            // 
            this.RandevuSaat.HeaderText = "Randevu Saati";
            this.RandevuSaat.Name = "RandevuSaat";
            this.RandevuSaat.ReadOnly = true;
            this.RandevuSaat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RandevuTarih
            // 
            this.RandevuTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RandevuTarih.HeaderText = "Randevu Tarihi";
            this.RandevuTarih.Name = "RandevuTarih";
            this.RandevuTarih.ReadOnly = true;
            this.RandevuTarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.RandevuTarih.Width = 96;
            // 
            // doktorekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 456);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doktorekran";
            this.Text = "doktorekran";
            this.Load += new System.EventHandler(this.doktorekran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printpreview_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label doktor_ismi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuTarih;
        private Bunifu.Framework.UI.BunifuImageButton printpreview_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox randevutarih_txt;
        private System.Windows.Forms.TextBox randevusaat_txt;
        private System.Windows.Forms.TextBox hastasoyadi_txt;
        private System.Windows.Forms.TextBox hastaadi_txt;
        private System.Windows.Forms.TextBox hastatc_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ilac_cmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tani_cmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox icd_cmb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox aciklama_rich;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label DashLabel;
    }
}
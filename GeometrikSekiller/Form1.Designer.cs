namespace GeometrikSekiller
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudGenislik = new System.Windows.Forms.NumericUpDown();
            this.nudYukseklik = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDikdortgens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pboDolguRenk = new System.Windows.Forms.PictureBox();
            this.cdiCizim = new System.Windows.Forms.ColorDialog();
            this.btnUcgen = new System.Windows.Forms.Button();
            this.dgvUcgens = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYukseklik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDikdortgens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDolguRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcgens)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudGenislik, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudYukseklik, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 203);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genişlik :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y :";
            // 
            // nudY
            // 
            this.nudY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudY.Location = new System.Drawing.Point(127, 59);
            this.nudY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(118, 31);
            this.nudY.TabIndex = 5;
            // 
            // nudGenislik
            // 
            this.nudGenislik.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGenislik.Location = new System.Drawing.Point(127, 109);
            this.nudGenislik.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGenislik.Name = "nudGenislik";
            this.nudGenislik.Size = new System.Drawing.Size(118, 31);
            this.nudGenislik.TabIndex = 6;
            this.nudGenislik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudYukseklik
            // 
            this.nudYukseklik.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudYukseklik.Location = new System.Drawing.Point(127, 161);
            this.nudYukseklik.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudYukseklik.Name = "nudYukseklik";
            this.nudYukseklik.Size = new System.Drawing.Size(118, 31);
            this.nudYukseklik.TabIndex = 7;
            this.nudYukseklik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // nudX
            // 
            this.nudX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudX.Location = new System.Drawing.Point(127, 9);
            this.nudX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(118, 31);
            this.nudX.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yükseklik :";
            // 
            // dgvDikdortgens
            // 
            this.dgvDikdortgens.AllowUserToAddRows = false;
            this.dgvDikdortgens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDikdortgens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDikdortgens.Location = new System.Drawing.Point(19, 221);
            this.dgvDikdortgens.Name = "dgvDikdortgens";
            this.dgvDikdortgens.RowTemplate.Height = 24;
            this.dgvDikdortgens.Size = new System.Drawing.Size(390, 123);
            this.dgvDikdortgens.TabIndex = 4;
            this.dgvDikdortgens.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDikdortgens_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "X";
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Y";
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Genislik";
            this.Column3.HeaderText = "Genişlik";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Yukseklik";
            this.Column4.HeaderText = "Yükseklik";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.Location = new System.Drawing.Point(271, 112);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(143, 37);
            this.btnDikdortgen.TabIndex = 2;
            this.btnDikdortgen.Text = "DİKDÖRTGEN";
            this.btnDikdortgen.UseVisualStyleBackColor = true;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.AutoScroll = true;
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(415, 13);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(409, 455);
            this.pnlCizim.TabIndex = 3;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            this.pnlCizim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseClick);
            this.pnlCizim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseDown);
            this.pnlCizim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseMove);
            this.pnlCizim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dolgu Rengi :";
            // 
            // pboDolguRenk
            // 
            this.pboDolguRenk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pboDolguRenk.Location = new System.Drawing.Point(284, 51);
            this.pboDolguRenk.Name = "pboDolguRenk";
            this.pboDolguRenk.Size = new System.Drawing.Size(55, 45);
            this.pboDolguRenk.TabIndex = 5;
            this.pboDolguRenk.TabStop = false;
            this.pboDolguRenk.Click += new System.EventHandler(this.pboDolguRenk_Click);
            // 
            // btnUcgen
            // 
            this.btnUcgen.Location = new System.Drawing.Point(271, 164);
            this.btnUcgen.Name = "btnUcgen";
            this.btnUcgen.Size = new System.Drawing.Size(143, 40);
            this.btnUcgen.TabIndex = 7;
            this.btnUcgen.Text = "DİK ÜÇGEN";
            this.btnUcgen.UseVisualStyleBackColor = true;
            this.btnUcgen.Click += new System.EventHandler(this.btnUcgen_Click);
            // 
            // dgvUcgens
            // 
            this.dgvUcgens.AllowUserToAddRows = false;
            this.dgvUcgens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcgens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvUcgens.Location = new System.Drawing.Point(19, 351);
            this.dgvUcgens.Name = "dgvUcgens";
            this.dgvUcgens.RowTemplate.Height = 24;
            this.dgvUcgens.Size = new System.Drawing.Size(390, 117);
            this.dgvUcgens.TabIndex = 8;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "X";
            this.Column5.HeaderText = "X";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Y";
            this.Column6.HeaderText = "Y";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Genislik";
            this.Column7.HeaderText = "Genişlik";
            this.Column7.Name = "Column7";
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Yukseklik";
            this.Column8.HeaderText = "Yükseklik";
            this.Column8.Name = "Column8";
            this.Column8.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.dgvUcgens);
            this.Controls.Add(this.btnUcgen);
            this.Controls.Add(this.pboDolguRenk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.dgvDikdortgens);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Şekil Çizdir";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYukseklik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDikdortgens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDolguRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcgens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDikdortgens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudGenislik;
        private System.Windows.Forms.NumericUpDown nudYukseklik;
        private System.Windows.Forms.Button btnDikdortgen;
        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pboDolguRenk;
        private System.Windows.Forms.ColorDialog cdiCizim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnUcgen;
        private System.Windows.Forms.DataGridView dgvUcgens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}


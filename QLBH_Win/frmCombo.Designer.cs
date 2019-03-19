namespace QLBH
{
    partial class FrmCombo
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
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTim = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoahet = new System.Windows.Forms.Button();
            this.tbxSluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDhang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.GridColor = System.Drawing.Color.Chocolate;
            this.dgvSanpham.Location = new System.Drawing.Point(23, 61);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSanpham.Size = new System.Drawing.Size(386, 328);
            this.dgvSanpham.TabIndex = 0;
            this.dgvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSanpham_CellContentClick);
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSp,
            this.TenSP,
            this.Dongia,
            this.Soluong});
            this.dgvChon.GridColor = System.Drawing.Color.Chocolate;
            this.dgvChon.Location = new System.Drawing.Point(496, 61);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.Size = new System.Drawing.Size(386, 328);
            this.dgvChon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÁC COMBO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm sản phẩm:";
            // 
            // tbxTim
            // 
            this.tbxTim.Location = new System.Drawing.Point(102, 32);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(161, 20);
            this.tbxTim.TabIndex = 4;
            this.tbxTim.TextChanged += new System.EventHandler(this.tbxTim_TextChanged);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(415, 136);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 7;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.BtnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(415, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnXoahet
            // 
            this.btnXoahet.Location = new System.Drawing.Point(415, 194);
            this.btnXoahet.Name = "btnXoahet";
            this.btnXoahet.Size = new System.Drawing.Size(75, 23);
            this.btnXoahet.TabIndex = 9;
            this.btnXoahet.Text = "Xóa hết";
            this.btnXoahet.UseVisualStyleBackColor = true;
            this.btnXoahet.Click += new System.EventHandler(this.BtnXoahet_Click);
            // 
            // tbxSluong
            // 
            this.tbxSluong.Location = new System.Drawing.Point(415, 110);
            this.tbxSluong.Name = "tbxSluong";
            this.tbxSluong.Size = new System.Drawing.Size(75, 20);
            this.tbxSluong.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng:";
            // 
            // btnDhang
            // 
            this.btnDhang.Location = new System.Drawing.Point(496, 395);
            this.btnDhang.Name = "btnDhang";
            this.btnDhang.Size = new System.Drawing.Size(82, 23);
            this.btnDhang.TabIndex = 12;
            this.btnDhang.Text = "Lập đơn hàng";
            this.btnDhang.UseVisualStyleBackColor = true;
            this.btnDhang.Click += new System.EventHandler(this.BtnDhang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(807, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(269, 32);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // MaSp
            // 
            this.MaSp.HeaderText = "MaSp";
            this.MaSp.Name = "MaSp";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "TenSp";
            this.TenSP.Name = "TenSP";
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Dongia";
            this.Dongia.Name = "Dongia";
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Soluong";
            this.Soluong.Name = "Soluong";
            // 
            // FmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 430);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSluong);
            this.Controls.Add(this.btnXoahet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.tbxTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChon);
            this.Controls.Add(this.dgvSanpham);
            this.Name = "FmCombo";
            this.Text = "FmCombo";
            this.Load += new System.EventHandler(this.FmCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanpham;
        public System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTim;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoahet;
        private System.Windows.Forms.TextBox tbxSluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDhang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}


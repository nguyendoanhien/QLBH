namespace QLBH
{
    partial class FrmHoaDon
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
            this.tbxSohd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxManv = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxThanhtien = new System.Windows.Forms.TextBox();
            this.btnLaphd = new System.Windows.Forms.Button();
            this.btnHuyhd = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxMakh = new System.Windows.Forms.TextBox();
            this.dtDH = new System.Windows.Forms.DateTimePicker();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSohd
            // 
            this.tbxSohd.Location = new System.Drawing.Point(636, 89);
            this.tbxSohd.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSohd.Name = "tbxSohd";
            this.tbxSohd.Size = new System.Drawing.Size(180, 29);
            this.tbxSohd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã nhân viên:";
            // 
            // tbxManv
            // 
            this.tbxManv.Location = new System.Drawing.Point(216, 127);
            this.tbxManv.Margin = new System.Windows.Forms.Padding(6);
            this.tbxManv.Name = "tbxManv";
            this.tbxManv.Size = new System.Drawing.Size(180, 29);
            this.tbxManv.TabIndex = 8;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.GridColor = System.Drawing.Color.Firebrick;
            this.dgvCTHD.Location = new System.Drawing.Point(59, 264);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(974, 362);
            this.dgvCTHD.TabIndex = 10;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Danh sách sản phẩm đã chọn:";
            // 
            // tbxCK
            // 
            this.tbxCK.Location = new System.Drawing.Point(686, 643);
            this.tbxCK.Margin = new System.Windows.Forms.Padding(6);
            this.tbxCK.Name = "tbxCK";
            this.tbxCK.Size = new System.Drawing.Size(180, 29);
            this.tbxCK.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 648);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Chiết khấu:";
            // 
            // tbxThanhtien
            // 
            this.tbxThanhtien.Location = new System.Drawing.Point(686, 691);
            this.tbxThanhtien.Margin = new System.Windows.Forms.Padding(6);
            this.tbxThanhtien.Name = "tbxThanhtien";
            this.tbxThanhtien.Size = new System.Drawing.Size(180, 29);
            this.tbxThanhtien.TabIndex = 19;
            // 
            // btnLaphd
            // 
            this.btnLaphd.Location = new System.Drawing.Point(878, 637);
            this.btnLaphd.Margin = new System.Windows.Forms.Padding(6);
            this.btnLaphd.Name = "btnLaphd";
            this.btnLaphd.Size = new System.Drawing.Size(154, 42);
            this.btnLaphd.TabIndex = 20;
            this.btnLaphd.Text = "Lập hóa đơn";
            this.btnLaphd.UseVisualStyleBackColor = true;
            this.btnLaphd.Click += new System.EventHandler(this.btnLaphd_Click);
            // 
            // btnHuyhd
            // 
            this.btnHuyhd.Location = new System.Drawing.Point(878, 690);
            this.btnHuyhd.Margin = new System.Windows.Forms.Padding(6);
            this.btnHuyhd.Name = "btnHuyhd";
            this.btnHuyhd.Size = new System.Drawing.Size(154, 42);
            this.btnHuyhd.TabIndex = 21;
            this.btnHuyhd.Text = "Hủy hóa đơn";
            this.btnHuyhd.UseVisualStyleBackColor = true;
            this.btnHuyhd.Click += new System.EventHandler(this.btnHuyhd_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(878, 744);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 42);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã khách hàng";
            // 
            // tbxMakh
            // 
            this.tbxMakh.Location = new System.Drawing.Point(216, 86);
            this.tbxMakh.Margin = new System.Windows.Forms.Padding(6);
            this.tbxMakh.Name = "tbxMakh";
            this.tbxMakh.Size = new System.Drawing.Size(180, 29);
            this.tbxMakh.TabIndex = 23;
            // 
            // dtDH
            // 
            this.dtDH.Location = new System.Drawing.Point(493, 165);
            this.dtDH.Margin = new System.Windows.Forms.Padding(6);
            this.dtDH.Name = "dtDH";
            this.dtDH.Size = new System.Drawing.Size(393, 29);
            this.dtDH.TabIndex = 25;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(570, 688);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(107, 37);
            this.btnTinh.TabIndex = 27;
            this.btnTinh.Text = "Tổng tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 792);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.dtDH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxMakh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuyhd);
            this.Controls.Add(this.btnLaphd);
            this.Controls.Add(this.tbxThanhtien);
            this.Controls.Add(this.tbxCK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxManv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSohd);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmHoaDon";
            this.Text = "Đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSohd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxManv;
        public System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxThanhtien;
        private System.Windows.Forms.Button btnLaphd;
        private System.Windows.Forms.Button btnHuyhd;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxMakh;
        private System.Windows.Forms.DateTimePicker dtDH;
        private System.Windows.Forms.Button btnTinh;
    }
}
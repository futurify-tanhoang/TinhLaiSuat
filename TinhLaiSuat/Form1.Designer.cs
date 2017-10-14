namespace TinhLaiSuat
{
    partial class LaiSuatForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_LaiSuat = new System.Windows.Forms.Label();
            this.txt_PhanTramVay = new System.Windows.Forms.TextBox();
            this.txt_LaiSuatUuDai1 = new System.Windows.Forms.TextBox();
            this.txt_SoThangVay = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.grid_KetQua = new System.Windows.Forms.DataGridView();
            this.btn_TinhLaiSuat = new System.Windows.Forms.Button();
            this.txt_LaiSuatThaNoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoThangUuDai1 = new System.Windows.Forms.TextBox();
            this.lbl_SoThang = new System.Windows.Forms.Label();
            this.grid_TienDoThanhToan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThemTienDo = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoTienVay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeNgayGiaiNgan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TienDoThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(401, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "% vay";
            // 
            // lbl_LaiSuat
            // 
            this.lbl_LaiSuat.AutoSize = true;
            this.lbl_LaiSuat.Location = new System.Drawing.Point(23, 90);
            this.lbl_LaiSuat.Name = "lbl_LaiSuat";
            this.lbl_LaiSuat.Size = new System.Drawing.Size(112, 20);
            this.lbl_LaiSuat.TabIndex = 8;
            this.lbl_LaiSuat.Text = "Lãi suất ưu đãi";
            // 
            // txt_PhanTramVay
            // 
            this.txt_PhanTramVay.Location = new System.Drawing.Point(523, 27);
            this.txt_PhanTramVay.Name = "txt_PhanTramVay";
            this.txt_PhanTramVay.Size = new System.Drawing.Size(189, 26);
            this.txt_PhanTramVay.TabIndex = 3;
            this.txt_PhanTramVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PhanTramVay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_PhanTramVay_KeyUp);
            // 
            // txt_LaiSuatUuDai1
            // 
            this.txt_LaiSuatUuDai1.Location = new System.Drawing.Point(174, 87);
            this.txt_LaiSuatUuDai1.Name = "txt_LaiSuatUuDai1";
            this.txt_LaiSuatUuDai1.Size = new System.Drawing.Size(189, 26);
            this.txt_LaiSuatUuDai1.TabIndex = 9;
            this.txt_LaiSuatUuDai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_LaiSuatUuDai1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_LaiSuatDau_KeyUp);
            // 
            // txt_SoThangVay
            // 
            this.txt_SoThangVay.Location = new System.Drawing.Point(899, 27);
            this.txt_SoThangVay.Name = "txt_SoThangVay";
            this.txt_SoThangVay.Size = new System.Drawing.Size(189, 26);
            this.txt_SoThangVay.TabIndex = 5;
            this.txt_SoThangVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SoThangVay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SoThangVay_KeyUp);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(748, 30);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(101, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Số tháng vay";
            // 
            // grid_KetQua
            // 
            this.grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KetQua.Location = new System.Drawing.Point(27, 798);
            this.grid_KetQua.Name = "grid_KetQua";
            this.grid_KetQua.RowTemplate.Height = 28;
            this.grid_KetQua.Size = new System.Drawing.Size(1443, 479);
            this.grid_KetQua.TabIndex = 22;
            // 
            // btn_TinhLaiSuat
            // 
            this.btn_TinhLaiSuat.Location = new System.Drawing.Point(1347, 745);
            this.btn_TinhLaiSuat.Name = "btn_TinhLaiSuat";
            this.btn_TinhLaiSuat.Size = new System.Drawing.Size(123, 36);
            this.btn_TinhLaiSuat.TabIndex = 21;
            this.btn_TinhLaiSuat.Text = "Tính lãi suất";
            this.btn_TinhLaiSuat.UseVisualStyleBackColor = true;
            this.btn_TinhLaiSuat.Click += new System.EventHandler(this.btn_TinhLaiSuat_Click);
            // 
            // txt_LaiSuatThaNoi
            // 
            this.txt_LaiSuatThaNoi.Location = new System.Drawing.Point(899, 87);
            this.txt_LaiSuatThaNoi.Name = "txt_LaiSuatThaNoi";
            this.txt_LaiSuatThaNoi.Size = new System.Drawing.Size(189, 26);
            this.txt_LaiSuatThaNoi.TabIndex = 17;
            this.txt_LaiSuatThaNoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_LaiSuatThaNoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LaiSuatSau_KeyDown);
            this.txt_LaiSuatThaNoi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_LaiSuatSau_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lãi suất thả nổi";
            // 
            // txt_SoThangUuDai1
            // 
            this.txt_SoThangUuDai1.Location = new System.Drawing.Point(525, 87);
            this.txt_SoThangUuDai1.Name = "txt_SoThangUuDai1";
            this.txt_SoThangUuDai1.Size = new System.Drawing.Size(189, 26);
            this.txt_SoThangUuDai1.TabIndex = 11;
            this.txt_SoThangUuDai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SoThangUuDai1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SoThangUuDai_KeyUp);
            // 
            // lbl_SoThang
            // 
            this.lbl_SoThang.AutoSize = true;
            this.lbl_SoThang.Location = new System.Drawing.Point(401, 90);
            this.lbl_SoThang.Name = "lbl_SoThang";
            this.lbl_SoThang.Size = new System.Drawing.Size(121, 20);
            this.lbl_SoThang.TabIndex = 10;
            this.lbl_SoThang.Text = "Số tháng ưu đãi";
            // 
            // grid_TienDoThanhToan
            // 
            this.grid_TienDoThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TienDoThanhToan.Location = new System.Drawing.Point(27, 235);
            this.grid_TienDoThanhToan.Name = "grid_TienDoThanhToan";
            this.grid_TienDoThanhToan.RowTemplate.Height = 28;
            this.grid_TienDoThanhToan.Size = new System.Drawing.Size(1443, 479);
            this.grid_TienDoThanhToan.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiến độ thanh toán";
            // 
            // btn_ThemTienDo
            // 
            this.btn_ThemTienDo.Location = new System.Drawing.Point(1347, 179);
            this.btn_ThemTienDo.Name = "btn_ThemTienDo";
            this.btn_ThemTienDo.Size = new System.Drawing.Size(123, 36);
            this.btn_ThemTienDo.TabIndex = 19;
            this.btn_ThemTienDo.Text = "Thêm tiến độ";
            this.btn_ThemTienDo.UseVisualStyleBackColor = true;
            this.btn_ThemTienDo.Click += new System.EventHandler(this.btn_ThemTienDo_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(174, 27);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(189, 26);
            this.txt_TongTien.TabIndex = 1;
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TongTien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_TongTien_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1126, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số tiền vay";
            // 
            // txt_SoTienVay
            // 
            this.txt_SoTienVay.Enabled = false;
            this.txt_SoTienVay.Location = new System.Drawing.Point(1266, 27);
            this.txt_SoTienVay.Name = "txt_SoTienVay";
            this.txt_SoTienVay.Size = new System.Drawing.Size(189, 26);
            this.txt_SoTienVay.TabIndex = 7;
            this.txt_SoTienVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1126, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày giải ngân";
            // 
            // dateTimeNgayGiaiNgan
            // 
            this.dateTimeNgayGiaiNgan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayGiaiNgan.Location = new System.Drawing.Point(1266, 87);
            this.dateTimeNgayGiaiNgan.Name = "dateTimeNgayGiaiNgan";
            this.dateTimeNgayGiaiNgan.Size = new System.Drawing.Size(189, 26);
            this.dateTimeNgayGiaiNgan.TabIndex = 24;
            // 
            // LaiSuatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1311);
            this.Controls.Add(this.dateTimeNgayGiaiNgan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_SoTienVay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ThemTienDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_TienDoThanhToan);
            this.Controls.Add(this.txt_SoThangUuDai1);
            this.Controls.Add(this.lbl_SoThang);
            this.Controls.Add(this.txt_LaiSuatThaNoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TinhLaiSuat);
            this.Controls.Add(this.grid_KetQua);
            this.Controls.Add(this.txt_SoThangVay);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt_LaiSuatUuDai1);
            this.Controls.Add(this.txt_PhanTramVay);
            this.Controls.Add(this.lbl_LaiSuat);
            this.Controls.Add(this.lbl1);
            this.Name = "LaiSuatForm";
            this.Text = "Bảng tính lãi suất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TienDoThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_LaiSuat;
        private System.Windows.Forms.TextBox txt_PhanTramVay;
        private System.Windows.Forms.TextBox txt_LaiSuatUuDai1;
        private System.Windows.Forms.TextBox txt_SoThangVay;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.DataGridView grid_KetQua;
        private System.Windows.Forms.Button btn_TinhLaiSuat;
        private System.Windows.Forms.TextBox txt_LaiSuatThaNoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoThangUuDai1;
        private System.Windows.Forms.Label lbl_SoThang;
        private System.Windows.Forms.DataGridView grid_TienDoThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThemTienDo;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SoTienVay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeNgayGiaiNgan;
    }
}


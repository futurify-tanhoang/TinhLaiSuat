using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhLaiSuat
{
    public partial class LaiSuatForm : Form
    {
        private DataTable dtTienDo = null;
        private List<TienDo> tienDos = new List<TienDo>();

        public LaiSuatForm()
        {
            InitializeComponent();

            grid_KetQua.AutoGenerateColumns = false;
            grid_KetQua.Columns.Add("STT", "STT");
            grid_KetQua.Columns.Add("KyTraNo", "Kỳ trả nợ");
            grid_KetQua.Columns.Add("SoGocConLai", "Số gốc còn lại");
            grid_KetQua.Columns.Add("Goc", "Gốc");
            grid_KetQua.Columns.Add("Lai", "Lãi (%/năm)");
            grid_KetQua.Columns.Add("TienLai", "Tiền Lãi");
            grid_KetQua.Columns.Add("Tong", "Tổng gốc + lãi");

            grid_KetQua.Columns[0].DataPropertyName = "STT";
            grid_KetQua.Columns[1].DataPropertyName = "KyTraNo";
            grid_KetQua.Columns[2].DataPropertyName = "SoGocConLai";
            grid_KetQua.Columns[3].DataPropertyName = "Goc";
            grid_KetQua.Columns[4].DataPropertyName = "Lai";
            grid_KetQua.Columns[5].DataPropertyName = "TienLai";
            grid_KetQua.Columns[6].DataPropertyName = "Tong";

            grid_KetQua.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            grid_KetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_KetQua.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid_KetQua.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            grid_TienDoThanhToan.AutoGenerateColumns = false;
            grid_TienDoThanhToan.Columns.Add("DotThanhToan", "Đợt thanh toán");
            grid_TienDoThanhToan.Columns.Add("TiLeThanhToan", "% thanh toán");
            grid_TienDoThanhToan.Columns.Add("SoTien", "Số tiền");
            grid_TienDoThanhToan.Columns.Add("ThoiHanThanhToan", "Thời hạn thanh toán");

            grid_TienDoThanhToan.Columns[0].DataPropertyName = "DotThanhToan";
            grid_TienDoThanhToan.Columns[1].DataPropertyName = "TiLeThanhToan";
            grid_TienDoThanhToan.Columns[2].DataPropertyName = "SoTien";
            grid_TienDoThanhToan.Columns[3].DataPropertyName = "ThoiHanThanhToan";

            grid_TienDoThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtTienDo = new DataTable();
            dtTienDo.Columns.Add("DotThanhToan", typeof(string));
            dtTienDo.Columns.Add("TiLeThanhToan", typeof(double));
            dtTienDo.Columns.Add("SoTien", typeof(string));
            dtTienDo.Columns.Add("ThoiHanThanhToan", typeof(string));
        }

        private void btn_TinhLaiSuat_Click(object sender, EventArgs e)
        {
            if (IsInValid())
                return;
            foreach (DataGridViewRow row in grid_TienDoThanhToan.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;
                var tienDoTruoc = tienDos.LastOrDefault();
                var tongTienTruoc = tienDoTruoc != null ? tienDoTruoc.TongTienVay : 0;
                var tienDo = new TienDo();
                tienDo.Name = row.Cells[0].Value.ToString();
                tienDo.TiLeThanhToan = row.Cells[1].Value.ToString().ParseDouble();
                tienDo.SoTien = row.Cells[2].Value.ToString().ParseDouble();
                tienDo.ThoiHanThanhToan = row.Cells[3].Value.ToString().ParseDatetime();
                tienDo.TongTienVay = tongTienTruoc + tienDo.SoTien;

                tienDos.Add(tienDo);
            }

            var tongTien = double.Parse(txt_TongTien.Text);
            var phanTramVay = double.Parse(txt_PhanTramVay.Text);
            var soTienVay = double.Parse(txt_SoTienVay.Text);
            var soThangVay = Int32.Parse(txt_SoThangVay.Text);
            var soThangConLai = soThangVay;
            var laiSuatUuDai1 = double.Parse(txt_LaiSuatUuDai1.Text) / 100;
            var sothangUuDai1 = Int32.Parse(txt_SoThangUuDai1.Text);
            var laiSuatThaNoi = double.Parse(txt_LaiSuatThaNoi.Text) / 100;
            var ngayGiaiNgan = dateTimeNgayGiaiNgan.Value;
            var ngayHetHan = ngayGiaiNgan.AddMonths(soThangVay);
            var tongTra = 0.0;

            DataRow dw;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("KyTraNo", typeof(DateTime));
            dt.Columns.Add("SoGocConLai", typeof(string));
            dt.Columns.Add("Goc", typeof(string));
            dt.Columns.Add("Lai", typeof(string));
            dt.Columns.Add("TienLai", typeof(string));
            dt.Columns.Add("Tong", typeof(string));
            
            for (int i = 1; i < soThangVay; i++)
                    {
                double lai = 0;
                double laisuat = 0;
                var kyTraNo = ngayGiaiNgan.AddMonths(i);
                var tienDo = GetTienDo(kyTraNo);
                if (tienDo != null)
                    RemoveTienDo(tienDo);
                soTienVay = tienDo != null ? tienDo.TongTienVay - tongTra : soTienVay;
                var goc = Math.Round(soTienVay / (soThangVay - i), 0);

                if (sothangUuDai1 > 0)
                {
                    lai = Math.Round(soTienVay * laiSuatUuDai1 / 12, 0);
                    laisuat = laiSuatUuDai1 * 100;
                    sothangUuDai1--;
                }
                else
                {
                    lai = Math.Round(soTienVay * laiSuatThaNoi / 12, 0);
                    laisuat = laiSuatThaNoi * 100;
                }
                soTienVay -= goc;
                tongTra += goc;

                dw = dt.NewRow();
                dw["STT"] = i;
                dw["KyTraNo"] = kyTraNo;
                dw["SoGocConLai"] = soTienVay.AddSeparator();
                dw["Goc"] = goc.AddSeparator();
                dw["Lai"] = $"{laisuat}%";
                dw["TienLai"] = lai.AddSeparator();
                dw["Tong"] = (goc + lai).AddSeparator();
                dt.Rows.Add(dw);
            }

            grid_KetQua.DataSource = dt;
        }

        private bool IsInValid()
        {
            var inValid = false;
            if (string.IsNullOrEmpty(txt_PhanTramVay.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền muốn vay");
                inValid = true;
                return inValid;
            }
            if (string.IsNullOrEmpty(txt_SoThangVay.Text))
            {
                MessageBox.Show("Vui lòng nhập vào số tháng vay");
                inValid = true;
                return inValid;
            }
            if (string.IsNullOrEmpty(txt_LaiSuatUuDai1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào lãi suất ưu đãi 1");
                inValid = true;
                return inValid;
            }
            if (string.IsNullOrEmpty(txt_SoThangUuDai1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào số tháng ưu đãi 1");
                inValid = true;
                return inValid;
            }
            if (string.IsNullOrEmpty(txt_LaiSuatThaNoi.Text))
            {
                MessageBox.Show("Vui lòng nhập vào lãi suất thả nổi");
                inValid = true;
                return inValid;
            }
            return inValid;
        }

        private TienDo GetTienDo(DateTime kyTraNo)
        {
            return tienDos.Where(t => t.ThoiHanThanhToan <= kyTraNo).OrderByDescending(s => s.ThoiHanThanhToan).FirstOrDefault();
        }

        private void RemoveTienDo(TienDo tienDo)
        {
            tienDos.Remove(tienDo);
        }

        private void txt_PhanTramVay_KeyUp(object sender, KeyEventArgs e)
        {
            txt_SoTienVay.Text = Math.Round(txt_TongTien.Text.ParseDouble() * txt_PhanTramVay.Text.ParseDouble() / 100).AddSeparator();

            txt_PhanTramVay.Text = txt_PhanTramVay.Text.AddSeparator();
            txt_PhanTramVay.SelectionStart = txt_PhanTramVay.Text.Length;
        }

        private void txt_SoThangVay_KeyUp(object sender, KeyEventArgs e)
        {
            txt_SoThangVay.Text = txt_SoThangVay.Text.AddSeparator();
            txt_SoThangVay.SelectionStart = txt_SoThangVay.Text.Length;
        }

        private void txt_LaiSuatDau_KeyUp(object sender, KeyEventArgs e)
        {
            txt_LaiSuatUuDai1.Text = txt_LaiSuatUuDai1.Text.AddSeparator();
            txt_LaiSuatUuDai1.SelectionStart = txt_LaiSuatUuDai1.Text.Length;
        }

        private void txt_SoThangUuDai_KeyUp(object sender, KeyEventArgs e)
        {
            txt_SoThangUuDai1.Text = txt_SoThangUuDai1.Text.AddSeparator();
            txt_SoThangUuDai1.SelectionStart = txt_SoThangUuDai1.Text.Length;
        }

        private void txt_LaiSuatSau_KeyUp(object sender, KeyEventArgs e)
        {
            txt_LaiSuatThaNoi.Text = txt_LaiSuatThaNoi.Text.AddSeparator();
            txt_LaiSuatThaNoi.SelectionStart = txt_LaiSuatThaNoi.Text.Length;
        }

        private void txt_LaiSuatSau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TinhLaiSuat.PerformClick();
            }
        }

        private void btn_ThemTienDo_Click(object sender, EventArgs e)
        {
            DataRow dw = dtTienDo.NewRow();

            dw["DotThanhToan"] = $"Đợt {dtTienDo.Rows.Count + 1}";
            dw["TiLeThanhToan"] = 0;
            dw["SoTien"] = 0;
            //dw["ThoiHanThanhToan"] = DateTime.Now.AddMonths(dtTienDo.Rows.Count).ToString("dd/MM/yyyy");
            dw["ThoiHanThanhToan"] = new DateTime(2017, 08, 15).AddMonths(dtTienDo.Rows.Count).ToString("dd/MM/yyyy");

            dtTienDo.Rows.Add(dw);

            grid_TienDoThanhToan.DataSource = dtTienDo;
        }

        private void txt_TongTien_KeyUp(object sender, KeyEventArgs e)
        {
            txt_TongTien.Text = txt_TongTien.Text.AddSeparator();
            txt_TongTien.SelectionStart = txt_TongTien.Text.Length;
        }
    }

    public class TienDo
    {
        public string Name { get; set; }
        public double TiLeThanhToan { get; set; }
        public double SoTien { get; set; }
        public double TongTienVay { get; set; }
        public DateTime ThoiHanThanhToan { get; set; }
    }
}

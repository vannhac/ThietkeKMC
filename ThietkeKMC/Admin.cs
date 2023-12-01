using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using ThietkeKMC.Dungtruoc;
using System.Xml.Linq;

namespace ThietkeKMC
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();


        }




        void LoadTK1()
        {
            string query = "select * from Nhanvien";

            dtaTaikhoan.DataSource = Datapro1.Instances.Xem(query);


        }
        void LoadNh()
        {
            string Nhap = "select * from PhieuNhap";

            dataNhap.DataSource = Datapro1.Instances.Xem(Nhap);
        }
        void Dthu()
        {
            string hoadon = "select * from Hoadon";
            dtadoanhthu.DataSource = Datapro1.Instances.Xem(hoadon);

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Loadhang()
        {
            string hang = "select * from Hang";



            dataHang.DataSource = Datapro1.Instances.Xem(hang);

        }
        void LoadNhct()
        {
            string hang = "select * from PhieuNhapChiTiet";



            dtaNhct.DataSource = Datapro1.Instances.Xem(hang);
        }
        void LoadHdct()
        {
            string hang = "select * from Hoadonchitiet";



            dataHDct.DataSource = Datapro1.Instances.Xem(hang);
        }
        private void btnXemHang_Click(object sender, EventArgs e)
        {
            Loadhang();
        }

        private void btnXemTk_Click(object sender, EventArgs e)
        {
            LoadTK1();
        }

        private void btnthemhang_Click(object sender, EventArgs e)
        {
            string mahang = txbMahang.Text;
            string ten = TxttenHang.Text;
            string donvi = txtdonvi.Text;
            int dongia = (int)Hanggia.Value;
            int soluong = (int)hangsl.Value;
            if (Datapro1.Instances.InsertHang(mahang, ten, donvi, dongia, soluong))
            {
                MessageBox.Show("Thêm món thành công");
                Loadhang();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }

        }

        private void TxttenHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSuahang_Click(object sender, EventArgs e)
        {
            string mahang = txbMahang.Text;
            string ten = TxttenHang.Text;
            string donvi = txtdonvi.Text;
            int dongia = (int)Hanggia.Value;
            int soluong = (int)hangsl.Value;
            if (Datapro1.Instances.UpdateHang(mahang, ten, donvi, dongia, soluong))
            {
                MessageBox.Show("Sửa món thành công");
                Loadhang();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa món");
            }
        }

        private void btnxoahang_Click(object sender, EventArgs e)
        {
            string mahang = txbMahang.Text;

            if (Datapro1.Instances.DeleteHang(mahang))
            {
                MessageBox.Show("Xoá món thành công");
                Loadhang();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá món");
            }
        }
        private void btntimHang_Click(object sender, EventArgs e)
        {

        }
        private void dataNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThemNh_Click(object sender, EventArgs e)
        {
            string mahang = manhap.Text;
            string MaNV = txtmanvnh.Text;
            string NCC = txtMaNccNh.Text;
            int Thanhtien = (int)numerNhap.Value;
            if (Datapro1.Instances.InserNhap(mahang, MaNV, NCC, Thanhtien))
            {
                MessageBox.Show("Thêm Phiếu Nhập thành công");
                LoadNh();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm Phiếu");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTHemtk_Click(object sender, EventArgs e)
        {
            string maNV = txtIDtk.Text;
            string TenNV = txtTenTk.Text;

            if (Datapro1.Instances.InsertTK(maNV, TenNV))
            {
                MessageBox.Show("Thêm Nhân viên thành công");
                LoadTK1();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm Nhân vien");
            }
        }



        private void txttimHang_TextChanged(object sender, EventArgs e)
        {
            string name = txttimHang.Text;
            if (name == "")
            {
                Loadhang();
            }
            else
            {
                string query = "select * from hang where TenHang like N'%" + name + "%'";
                dataHang.DataSource = Datapro1.Instances.Xem(query);
            }
        }

        private void btxemDt_Click(object sender, EventArgs e)
        {
            Dthu();
        }

        private void Xoanhap_Click(object sender, EventArgs e)
        {
            LoadNh();
        }

        private void btnthemdn_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            int Tongtien = (int)numerHD.Value;
            string Manv = txtMaNVHD.Text;
            if (Datapro1.Instances.InsertHD(maHD, Tongtien, Manv))
            {
                MessageBox.Show("Thêm  Hoa Đơn thành công");
                Dthu();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm hoá đơn");
            }
        }

        private void Tabadmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSuatk_Click(object sender, EventArgs e)
        {
            string maNV = txtIDtk.Text;
            string TenNV = txtTenTk.Text;

            if (Datapro1.Instances.UpdateTK(maNV, TenNV))
            {
                MessageBox.Show("Sửa Nhân viên thành công");
                LoadTK1();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa Nhân vien");
            }
        }

        private void btnXoatk_Click(object sender, EventArgs e)
        {
            string maNV = txtIDtk.Text;

            if (Datapro1.Instances.DeleteTK(maNV))
            {
                MessageBox.Show("Xoá Nhân viên thành công");
                LoadTK1();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá Nhân viên");
            }
        }

        private void txtTimtk_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimtk.Text;
            if (name == "")
            {
                LoadTK1();
            }
            else
            {
                string query = "select * from Nhanvien where TenNV like N'%" + name + "%'";
                dtaTaikhoan.DataSource = Datapro1.Instances.Xem(query);
            }
        }

        private void SuaNH_Click(object sender, EventArgs e)
        {
            string mahang = manhap.Text;
            string MaNV = txtmanvnh.Text;
            string NCC = txtMaNccNh.Text;
            int Thanhtien = (int)numerNhap.Value;
            if (Datapro1.Instances.UpdatePN(mahang, MaNV, NCC, Thanhtien))
            {
                MessageBox.Show("Thêm Sửa Nhập thành công");
                LoadNh();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa Phiếu");
            }
        }

        private void XoaNh_Click(object sender, EventArgs e)
        {
            string mahang = manhap.Text;

            if (Datapro1.Instances.DeletePN(mahang))
            {
                MessageBox.Show("Xoá Phiếu Nhập thành công");
                LoadNh();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá Phiếu Nhập ");
            }
        }

        private void txttimnh_TextChanged(object sender, EventArgs e)
        {
            string mahang = txttimnh.Text;
            if (mahang == "")
            {
                LoadNh();
            }
            else
            {
                string query = "select * from Phieunhap where MaPN like N'%" + mahang + "%'";
                dataNhap.DataSource = Datapro1.Instances.Xem(query);
            }
        }

        private void btnsuadt_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            int Tongtien = (int)numerHD.Value;
            string Manv = txtMaNVHD.Text;
            if (Datapro1.Instances.UpdateDT(maHD, Tongtien, Manv))
            {
                MessageBox.Show(" Sửa Hoá đơn thành công");
                Dthu();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa Hoá Đơn");
            }
        }

        private void btnxoadt_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;

            if (Datapro1.Instances.DeleteDT(mahd))
            {
                MessageBox.Show("Xoá Hoá đơn thành công");
                Dthu();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá Hoá đơn");
            }
        }

        private void txtTimdt_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimdt.Text;
            if (name == "")
            {
                Dthu();
            }
            else
            {
                string query = "select * from HoaDon where MaHD like N'%" + name + "%'";
                dtadoanhthu.DataSource = Datapro1.Instances.Xem(query);
            }
        }

        private void TabBill_Click(object sender, EventArgs e)
        {

        }
        void loadNCC()
        {
            string query = "select * from Nhacungcap";
            NCCdata.DataSource = Datapro1.Instances.Xem(query);
        }
        private void btxemnhct_Click(object sender, EventArgs e)
        {
            LoadNhct();
        }


        private void btnNCCxem_Click(object sender, EventArgs e)
        {
            loadNCC();

        }

        private void txtNCCtim_TextChanged(object sender, EventArgs e)
        {
            string name = txtNCCtim.Text;
            if (name == "")
            {
                loadNCC();
            }
            else
            {
                string query = "select * from HoaDon where MaNCC like N'%" + name + "%'";
                NCCdata.DataSource = Datapro1.Instances.Xem(query);
            }
        }

        private void btnNCCThem_Click(object sender, EventArgs e)
        {
            string mahang = TxtNCCid.Text;
            string ten = txtNCCten.Text;
            string diachi = txtNCCdc.Text;

            if (Datapro1.Instances.InsertNCC(mahang, ten, diachi))
            {
                MessageBox.Show("Thêm Nhà cung cấp thành công");
                loadNCC();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm Nhà cung cấp");
            }
        }
        private void btTHemnhct_Click(object sender, EventArgs e)
        {
            string maHD = TxbManhct.Text;

            string mahang = TxbMahangnhct.Text;

            int dongia = (int)nmrGianhct.Value;
            int soluong = (int)nmrSolNhct.Value;

            if (Datapro1.Instances.InsertNhct(maHD, mahang, soluong, dongia))
            {
                MessageBox.Show("Thêm Phiếu nhập chi tiết thành công");
                LoadNhct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void btnNCCsua_Click(object sender, EventArgs e)
        {
            string mahang = TxtNCCid.Text;
            string ten = txtNCCten.Text;
            string diachi = txtNCCdc.Text;
            if (Datapro1.Instances.UpdateNCC(mahang, ten, diachi))
            {
                MessageBox.Show("Sửa Nhà cung cấp thành công");
                loadNCC();

            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa Nhà cung cấp");
            }
        }
        private void btSuanhct_Click(object sender, EventArgs e)
        {
            string maHD = TxbManhct.Text;

            string mahang = TxbMahangnhct.Text;

            int dongia = (int)nmrGianhct.Value;
            int soluong = (int)nmrSolNhct.Value;
            if (Datapro1.Instances.UpdateNhct(maHD, mahang, soluong, dongia))
            {
                MessageBox.Show("Sửa chi tiết thành công");
                LoadNhct();

            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa chi tiết");
            }

        }

        private void btnNCCxoa_Click(object sender, EventArgs e)
        {
            string mahang = TxtNCCid.Text;

            if (Datapro1.Instances.DeleteNCC(mahang))
            {
                MessageBox.Show("Xoá Nhà cung cấp thành công");
                loadNCC();

            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá Nhà cung cấp");
            }
        }

        private void dataNhct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void panel49_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btXoanhct_Click(object sender, EventArgs e)
        {

            string maHD = TxbManhct.Text;

            string mahang = TxbMahangnhct.Text;


            if (Datapro1.Instances.DeleteNhct(maHD, mahang))
            {
                MessageBox.Show("Xoá chi tiết thành công");
                LoadNhct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá chi tiết");
            }
        }

        private void textTimnhct_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name1 = TxbManhct.Text;
            string name2 = TxbMahangnhct.Text;

            if ((name1 == "") & (name2 == ""))
            {
                LoadNhct();
            }
            else if (name1 == "")
            {
                string query = "select * from PhieuNhapChiTiet where MaHang like N'%" + name2 + "%'";
                dtaNhct.DataSource = Datapro1.Instances.Xem(query);
            }
            else if (name2 == "")
            {
                string query = "select * from PhieuNhapChiTiet where MaPN like N'%" + name1 + "%'";
                dtaNhct.DataSource = Datapro1.Instances.Xem(query);
            }
            else
            {
                string query = "select * from PhieuNhapChiTiet where MaHang like N'%" + name2 + "%' and MaPN like N'%" + name1 + "%'";
                dtaNhct.DataSource = Datapro1.Instances.Xem(query);
            }

        }

        private void btThemHDct_Click(object sender, EventArgs e)
        {
            string maHD = txbIDhdct.Text;

            string mahang = txbMahanghdct.Text;

            int dongia = (int)nmrGiahdct.Value;
            int soluong = (int)nmrSolhdct.Value;

            if (Datapro1.Instances.InsertHdct(maHD, mahang, soluong,dongia))
            {
                MessageBox.Show("Thêm Hoá đơn chi tiết thành công");
                LoadHdct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void btnSuaHDct_Click(object sender, EventArgs e)
        {
            string maHD = txbIDhdct.Text;

            string mahang = txbMahanghdct.Text;

            int dongia = (int)nmrGiahdct.Value;
            int soluong = (int)nmrSolhdct.Value;

            if (Datapro1.Instances.UpdateHdct(maHD, mahang, dongia, soluong))
            {
                MessageBox.Show("Sửa Hoá đơn chi tiết thành công");
                LoadHdct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void btnXoaHDct_Click(object sender, EventArgs e)
        {
            string maHD = txbIDhdct.Text;

            string mahang = txbMahanghdct.Text;


            if (Datapro1.Instances.DeleteHDct(maHD,mahang))
            {
                MessageBox.Show("Xoá chi tiết thành công");
                LoadHdct();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xoá chi tiết");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name1 = txbIDhdct.Text;
            string name2 = txbMahanghdct.Text;

            if ((name1 == "") & (name2 == ""))
            {
                LoadNhct();
            }
            else if (name1 == "")
            {
                string query = "select * from Hoadonchitiet where MaHang like N'%" + name2 + "%'";
                dataHDct.DataSource = Datapro1.Instances.Xem(query);
            }
            else if (name2 == "")
            {
                string query = "select * from Hoadonchitiet where MaHD like N'%" + name1 + "%'";
                dataHDct.DataSource = Datapro1.Instances.Xem(query);
            }
            else
            {
                string query = "select * from Hoadonchitiet where MaHang like N'%" + name2 + "%' and MaHD like N'%" + name1 + "%'";
                dataHDct.DataSource = Datapro1.Instances.Xem(query);
            }
        }

        private void btnXemHDct_Click(object sender, EventArgs e)
        {
            LoadHdct();
        }
    }
}

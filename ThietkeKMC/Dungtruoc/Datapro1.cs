using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ThietkeKMC.Dungtruoc
{
    public class Datapro1
    {
        private string ketnoi = @"Data Source=DESKTOP-KMNS09Q\;Initial Catalog=QuanLyKMC;Integrated Security=True";
        private static Datapro1 instance;

     
    public static Datapro1 Instances
    {
        get
        {
            if (instance == null)
           
                    {
                        instance = new Datapro1();
                    }
                
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    private Datapro1()
        {

        }
        public DataTable Xem(string query, object[] parameter =null )
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                connection.Close();
            }
            
            return data;
            
     }
        public int nonXem(string query, object[] parameter = null)
        {
            int data =0;

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery(); 
              
                connection.Close();
            }

            return data;

        }
        public object demXem(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;

        }
        public bool InsertHang(string mahang,string ten,  string donvi,int dongia,int soluong)
        {
            string query = string.Format("insert Hang(MaHang, TenHang, DonVi, Dongia, SoluongTK) Values (N'{0}',N'{1}',N'{2}',{3},{4})", mahang,ten,donvi,dongia,soluong);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }
        public bool InserNhap(string mahang, string MaNV, string NCC, int Thanhtien)
        {
            string query = string.Format("insert into Phieunhap values(N'{0}',N'{1}',N'{2}',{3})", mahang, MaNV, NCC, Thanhtien);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }
        public bool InsertTK(string ma, string TenNV)
        {
            string query = string.Format("insert  Nhanvien (MaNV,TenNV) values(N'{0}',N'{1}')", ma, TenNV);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }
        public bool InsertHD(string ma, int Tongtien,string Manv)
        {
            string query = string.Format("insert  HoaDon(MaHD,TongTienTT,MaNV) values(N'{0}',{1},N'{2}')", ma, Tongtien,Manv);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }
        public bool InsertNCC(string ma, string Ten, string Diachi)
        {
            string query = string.Format("insert NhaCungCap (MaNCC,TenNCC,DiaChi) values (N'{0}',N'{1}',N'{2}')", ma, Ten, Diachi);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }
        public bool InsertNhct(string mahd, string mahang, int soluong ,int tien)
        {
            string query = string.Format("insert PhieuNhapChiTiet(MaPN,MaHang,SoLuongNhap,ThanhTien) values (N'{0}',N'{1}',{2},{3})", mahd, mahang,soluong,tien);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }
        public bool InsertHdct(string mahd, string mahang, int soluong, int tien)
        {
            string query = string.Format("insert Hoadonchitiet(MaHD,Soluongban,Thanhtien,MaHang) values (N'{0}',{1},{2},N'{3}')", mahd, soluong, tien, mahang);
            int kq = Datapro1.Instances.nonXem(query);
            return kq > 0;

        }


        public bool UpdateHang(string mahang, string ten, string donvi, int dongia, int soluong)
        {
            string query = "UPDATE hang SET TenHang = @TenHang, DonVi = @DonVi, DonGia = @DonGia, SoLuongTK = @SoLuongTK WHERE MaHang = @MaHang";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenHang", ten);
                    command.Parameters.AddWithValue("@DonVi", donvi);
                    command.Parameters.AddWithValue("@DonGia", dongia);
                    command.Parameters.AddWithValue("@SoLuongTK", soluong);
                    command.Parameters.AddWithValue("@MaHang", mahang);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateTK(string ma, string TenNV)
        {
            string query = "UPDATE Nhanvien SET MaNV = @manv, TenNV = @tennv WHERE MaNV = @manv";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@manv", ma);
                    command.Parameters.AddWithValue("@tennv", TenNV);
                    

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdatePN(string mahang, string MaNV,string NCC, int Thanhtien)
        {
            string query = "UPDATE Phieunhap SET MaNV = @manv, MaNCC = @ncc, ThanhTien = @tt  WHERE MaPN = @MaPN";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@manv", MaNV);
                    command.Parameters.AddWithValue("@ncc", NCC);
                    command.Parameters.AddWithValue("@tt", Thanhtien);
                    command.Parameters.AddWithValue("@MaPN", mahang);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateNCC(string ma, string Ten, string Diachi)
        {
            string query = "UPDATE NhaCungCap SET  TenNCC = @ten, DiaChi = @dchi  WHERE MaNCC = @ma";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    command.Parameters.AddWithValue("@ten", Ten);
                    command.Parameters.AddWithValue("@dchi", Diachi);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateDT(string maHD,int Tongtien,string Manv)
        {
            string query = "UPDATE HoaDon  SET MaHD = @mahd, MaNV = @manv, TongTienTT = @tongtien WHERE MaHD = @mahd";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mahd", maHD);
                    command.Parameters.AddWithValue("@manv", Manv);
                    command.Parameters.AddWithValue("@tongtien", Tongtien);
               
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateNhct(string mahd, string mahang, int soluong, int tien)
        {
            string query = "UPDATE PhieuNhapChiTiet  SET MaPN = @maPn, MaHang = @mahang, SoLuongNhap = @sl,ThanhTien=@tt WHERE MaPN = @maPn and  MaHang = @mahang";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maPn", mahd);
                    command.Parameters.AddWithValue("@mahang", mahang);
                    command.Parameters.AddWithValue("@sl", soluong);
                    command.Parameters.AddWithValue("@tt", tien);
               

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateHdct(string mahd, string mahang, int soluong, int tien)
        {
            string query = "update Hoadonchitiet set MaHD=@mahd,Soluongban=@sl,Thanhtien=@tt,MaHang=@mahang where MaHD=@mahd and MaHang=@mahang";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mahd", mahd);
                    command.Parameters.AddWithValue("@mahang", mahang);
                    command.Parameters.AddWithValue("@sl", soluong);
                    command.Parameters.AddWithValue("@tt", tien);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        public bool DeleteHang(string mahang)
        {
            string query = "DELETE FROM Hang WHERE MaHang = @MaHang";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHang", mahang);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteTK(string manv)
        {
            string query = "DELETE FROM Nhanvien WHERE MaNV = @manv";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@manv", manv);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteDT(string mahd)
        {
            string query = "DELETE FROM Hoadon WHERE MaHD = @mahd";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mahd", mahd);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteNCC(string ma)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNCC = @mahd";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mahd", ma);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool DeletePN(string Mapn)
        {
            string query = "DELETE FROM PHieunhap WHERE MaPN = @mapn";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mapn", Mapn);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteNhct(string mahd,string mahang)
        {
            string query = "delete from PhieuNhapChiTiet where MaPN=@mapn and MaHang=@mahang";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mapn", mahd);
                    command.Parameters.AddWithValue("@mahang", mahang);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool DeleteHDct(string mahd, string mahang)
        {
            string query = "delete from Hoadonchitiet where MaHang=@mahang and MaHD=@mahd;";

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mahd", mahd);
                    command.Parameters.AddWithValue("@mahang", mahang);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}

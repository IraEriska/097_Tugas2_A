using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _097_Tugas2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ANDITAKHRH\\ANDITAKHRH;database=sewa;Integrated Security = TRUE");
                con.Open();
                SqlCommand cm = new SqlCommand(
                "insert into Penyewa (Id_Penyewa, Nama, Alamat, No_telp) values ('100', 'Anggrek', 'Lantai 1', 'Rp 15.000.000')"
                + "insert into Penyewa (Id_Penyewa, Nama, Alamat, No_telp) values ('102', 'Cempaka', 'Lantai 1', 'Rp 15.000.000')"
                + "insert into Penyewa (Id_Penyewa, Nama, Alamat, No_telp) values ('201', 'Daisy', 'Lantai 2', 'Rp 13.000.000')"
                + "insert into Penyewa (Id_Penyewa, Nama, Alamat, No_telp) values ('202', 'Rose', 'Lantai 2', 'Rp 13.000.000')"
                + "insert into Penyewa (Id_Penyewa, Nama, Alamat, No_telp) values ('301', 'Kamboja', 'Lantai 3', 'Rp 11.000.000')"
                + "insert into Ruko (Id_Ruko, Id_penyewa, Lokasi, Ukuran, Harga_Sewa, Durasi) values ('1371088574957', 'Cein Agustina', '081376847854', 'Jln jeruk no 07')"
                + "insert into Ruko (Id_Ruko, Id_penyewa, Lokasi, Ukuran, Harga_Sewa, Durasi) values ('1398764023167', 'Haru lemuel', '089913564892', 'Jln paus no 09')"
                + "insert into Ruko (Id_Ruko, Id_penyewa, Lokasi, Ukuran, Harga_Sewa, Durasi) values ('1245009352885', 'Yoongi Kivandra', '089813247642', 'Jln forever no 13')"
                + "insert into Ruko (Id_Ruko, Id_penyewa, Lokasi, Ukuran, Harga_Sewa, Durasi) values ('1456890223659', 'Jihan Minerva', '081375937823', 'Jln night no 26')"
                + "insert into Ruko (Id_Ruko, Id_penyewa, Lokasi, Ukuran, Harga_Sewa, Durasi) values ('1245903682489', 'Shakka Jaela', '081306072013', 'Jln telepaty no 20')"
                + "insert into Perusahaan (Id_Perusahaan, Alamat, No_Hp) values ('001', '101', '3 bln', '20 mar 22')"
                + "insert into Perusahaan (Id_Perusahaan, Alamat, No_Hp) values ('002', '102', '1 bln', '21 mar 22')"
                + "insert into Perusahaan (Id_Perusahaan, Alamat, No_Hp) values ('003', '201', '5 bln', '22 mar 22')"
                + "insert into Perusahaan (Id_Perusahaan, Alamat, No_Hp) values ('004', '202', '1 thn', '25 mar 22')"
                + "insert into Perusahaan (Id_Perusahaan, Alamat, No_Hp) values ('005', '301', '3 thn', '26 mar 22')"
                + "insert into Transaksi (Id_Transaksi, Id_Perusahaan, Id_Ruko, Id_Penyewa, Durasi, Jenis_Pembayaran, Pembayaran, Jenis_Pembayaran) values ('111','1371088574957','101','001','20 mar 22','3 bln','Debit', 'Lunas')"
                + "insert into Transaksi (Id_Transaksi, Id_Perusahaan, Id_Ruko, Id_Penyewa, Durasi, Jenis_Pembayaran, Pembayaran, Jenis_Pembayaran) values ('112','1398764023167','102','002','21 mar 22','1 bln','Cash', 'Lunas')"
                + "insert into Transaksi (Id_Transaksi, Id_Perusahaan, Id_Ruko, Id_Penyewa, Durasi, Jenis_Pembayaran, Pembayaran, Jenis_Pembayaran) values ('113','1245009352885','201','003','22 mar 22','5 bln','Debit', 'Lunas')"
                + "insert into Transaksi (Id_Transaksi, Id_Perusahaan, Id_Ruko, Id_Penyewa, Durasi, Jenis_Pembayaran, Pembayaran, Jenis_Pembayaran) values ('114','1456890223659','202','004','25 mar 22','1 thn','Cash', 'Lunas')"
                + "insert into Transaksi (Id_Transaksi, Id_Perusahaan, Id_Ruko, Id_Penyewa, Durasi, Jenis_Pembayaran, Pembayaran, Jenis_Pembayaran) values ('115','1245903682489','301','005','26 mar 22','3 thn','Debit', 'Lunas')", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data!" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}

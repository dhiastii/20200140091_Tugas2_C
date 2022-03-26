using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200140091_Tugas2_C
{
    class Program
    {
        public void Staff()
        {
            string id, nama, alamat, tanggal;
            int umur;

            Console.WriteLine("Input Data Staff/Karyawan PetaBakery");
            Console.WriteLine("------------------------------------");

            Console.Write("Masukkan ID Staff \t: ");
            id = Console.ReadLine();

            Console.Write("Masukkan Nama Staff \t\t: ");
            nama = Console.ReadLine();

            Console.Write("Masukkan Alamat Staff \t: ");
            alamat = Console.ReadLine();

            Console.Write("Masukkan Umur Staff \t: ");
            umur = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Tanggal Masuk Kerja \t: ");
            tanggal = Console.ReadLine();
            Console.WriteLine("----------------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Staff (Id_STaff, Nama, Alamat, Umur, Tanggal Masuk Kerja)" +
                    "values( '" + id + "' , '" + nama + "', '" + alamat + "'," + umur + ", " + tanggal + ")", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void Roti()
        {
            string idR, namaR, varian, jenis;
            int stok;

            Console.WriteLine("Input Data Roti pada PetaBakery");
            Console.WriteLine("-------------------------------");

            Console.Write("Masukkan ID Roti\t: ");
            idR = Console.ReadLine();

            Console.Write("Masukkan Nama Roti \t\t: ");
            namaR = Console.ReadLine();

            Console.Write("Masukkan Varian roti \t: ");
            varian = Console.ReadLine();

            Console.Write("Masukkan Jenis Roti (Basah/Kering) \t\t: ");
            jenis = Console.ReadLine();

            Console.Write("Masukkan Jumlah Stok Roti \t\t: ");
            stok = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Roti (Id_Roti, NamaRoti, VarianRoti, JenisRoti, StokRoti)" +
                    "values( '" + idR + "' , '" + namaR + "', '" + varian + "'," + jenis + ", '" + stok + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void Penjualan()
        {
            string idJ, idS, idR, tanggal;
            int hargaJ;

            Console.WriteLine("Input Data Penjualan PetaBakery");
            Console.WriteLine("-------------------------------");

            Console.Write("Masukkan ID Penjualan \t: ");
            idJ = Console.ReadLine();

            Console.Write("Masukkan ID Staff \t: ");
            idS = Console.ReadLine();

            Console.Write("Masukkan ID Roti \t: ");
            idR = Console.ReadLine();

            Console.Write("Masukkan Tanggal Penjualan \t\t: ");
            tanggal = Console.ReadLine();

            Console.Write("Masukkan Total Harga \t\t: Rp");
            hargaJ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Penjualan (Id_Jual, Id_Staff, Id_Roti, Tanggal_Penjualan,Total_Harga" +
                    "values( '" + idJ + "' , '" + idS + "', '" + idR + "'," + tanggal + ", '" + hargaJ + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void Customer()
        {
            string idC, namaC, alamatC;
       

            Console.WriteLine("Input Data Customer PetaBakery");
            Console.WriteLine("------------------------------");

            Console.Write("Masukkan ID Customer \t: ");
            idC = Console.ReadLine();

            Console.Write("Masukkan Nama Customer \t: ");
            namaC = Console.ReadLine();

            Console.Write("Masukkan Alamat Customer \t\t: ");
            alamatC = Console.ReadLine();

            Console.WriteLine("--------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Customer (Id_Cust, NamaCust, AlamatCust" +
                    "values( '" + idC + "' , '" + namaC + "', '" + alamatC + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void Pembelian()
        {
            string idB, idC, idR, tanggal;
            int jml,hargaB;

            Console.WriteLine("Input Data Pembelian PetaBakery");
            Console.WriteLine("-------------------------------");

            Console.Write("Masukkan ID Pembelian\t: ");
            idB = Console.ReadLine();

            Console.Write("Masukkan ID Customer\t: ");
            idC = Console.ReadLine();

            Console.Write("Masukkan ID Roti \t: ");
            idR = Console.ReadLine();

            Console.Write("Masukkan Jumlah Roti yang Dibeli \t: ");
            jml = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Tanggal Pembelian (YYYY/MM/DD) : ");
            tanggal = Console.ReadLine();

            Console.Write("Masukkan Total Harga \t\t: Rp");
            hargaB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

SqlCommand cm = new SqlCommand("insert into Pembelian (Id_Beli, Id_Cust, Id_Roti, JumlahBeli, Taggal Pembelian, Total_Harga" +
                    "values( '" + idB + "' , '" + idC + "' ,  '" + idR + "' , '" + jml + "' , " + tanggal + " ,, " + hargaB + ")", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {
            int ch;
            Program p = new Program();

            Console.WriteLine("Aplikasi Transaksi PetaBakery");
            Console.WriteLine("-----------------------------");

while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Input Data Staff/Karyawan");
                Console.WriteLine("2. Input Data Roti PetaBakery");
                Console.WriteLine("3. Input Data Penjualan PetaBakery");
                Console.WriteLine("4. Input Data Customen PetaBakery");
                Console.WriteLine("5. Input Data Pembelian PetaBakery");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter your choice (1-6): ");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        {
                            p.Staff();
                        }
                        break;
                    case 2:
                        {
                            p.Roti();
                        }
                        break;
                    case 3:
                        {
                            p.Penjualan();
                        }
                        break;
                    case 4:
                        {
                            p.Customer();
                        }
                        break;
                    case 5:
                        {
                            p.Pembelian();
                        }
                        break;
                    case 6:
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }

            }
        }
    }
}
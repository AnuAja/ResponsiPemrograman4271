using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ResponsiPemrograman4271
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawan = new karyawan(33090309, "Mutmainah", 2500000);
            karyawan karyawan2 = new karyawan(33090390,  "Ramadhan", -3000000);
            karyawan karyawan3 = new karyawan(33090949, "Mahmudin", 2000000);

            Console.WriteLine("No\t Nik\t        Nama\t        GajiBulanan");
            Console.WriteLine("===================================================");
            karyawan.Karyawan();
            karyawan2.Karyawan();
            karyawan3.Karyawan();

            Console.WriteLine("\nGAJIMU NAIK MASZEEH 10% !!\n");

            Console.WriteLine("No\t Nik\t        Nama\t        GajiBulanan");
            Console.WriteLine("===================================================");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();
            karyawan3.NaikGaji();

            Console.ReadKey();
        }
    }
}
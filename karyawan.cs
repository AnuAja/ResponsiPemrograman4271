using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4271
{
    class karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public karyawan(int Nik, string Nama, int GajiBulanan)
        {
            this.Nik = Nik;
            this.Nama = Nama;

            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }
        public void Karyawan()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", No, Nik, Nama, GajiBulanan);
        }
        public void NaikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", No, Nik, Nama, GajiBulanan);
        }
    }
}

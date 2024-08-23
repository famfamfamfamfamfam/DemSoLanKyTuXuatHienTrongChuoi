using System;
namespace SUDUNGPHUONGTHUC
{
    class DemSoLanKyTuXuatHienTrongChuoi
    {
        public static int Solankytuxuathientrongchuoi(string chuoi, char kytu)
        {
            int dem = 0;
            for (int chiso = 0; chiso < chuoi.Length; chiso++)
            {
                if (chuoi[chiso] == kytu)
                {
                    dem++;
                }
            }
            return dem;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi:");
            string chuoi = Console.ReadLine();
            Console.WriteLine("Nhap ky tu muon dem so lan no xuat hien:");
            char kytu = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{kytu} xuat hien {Solankytuxuathientrongchuoi(chuoi, kytu)} lan");
        }
    }
}
using System;
class Program
{
 static void Main()
 {
 // Minta pengguna memasukkan angka pertama
 Console.Write("Masukkan angka pertama: ");
 int angka1 = Convert.ToInt32(Console.ReadLine());
 // Minta pengguna memasukkan angka kedua
 Console.Write("Masukkan angka kedua: ");
 int angka2 = Convert.ToInt32(Console.ReadLine());
 // Hitung hasil penjumlahan
 int hasil = angka1 - angka2;
 // Tampilkan hasil penjumlahan
 Console.WriteLine("Hasil pengurangan: " + hasil);
 }
}

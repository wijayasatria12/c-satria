
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Kalkulator Sederhana");
        Console.WriteLine("====================");

        // Minta pengguna memasukkan angka pertama
        Console.Write("Masukkan angka pertama: ");
        double angka1;
        while (!double.TryParse(Console.ReadLine(), out angka1))
        {
            Console.Write("Input tidak valid. Masukkan angka pertama: ");
        }

        // Minta pengguna memasukkan operator
        Console.Write("Masukkan operator (+, -, *, /): ");
        char operasi = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Minta pengguna memasukkan angka kedua
        Console.Write("Masukkan angka kedua: ");
        double angka2;
        while (!double.TryParse(Console.ReadLine(), out angka2))
        {
            Console.Write("Input tidak valid. Masukkan angka kedua: ");
        }

        double hasil = 0;

        // Periksa operasi yang dipilih dan lakukan perhitungan
        switch (operasi)
        {
            case '+':
                hasil = angka1 + angka2;
                break;
            case '-':
                hasil = angka1 - angka2;
                break;
            case '*':
                hasil = angka1 * angka2;
                break;
            case '/':
                if (angka2 != 0)
                {
                    hasil = angka1 / angka2;
                }
                else
                {
                    Console.WriteLine("Kesalahan: Pembagian dengan nol tidak diperbolehkan.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operator tidak valid.");
                return;
        }

        // Tampilkan hasil
        Console.WriteLine("Hasil: " + hasil);
    }
}


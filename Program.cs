// Fájlműveletek
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Fájl beolvasás
        FileStream file = new FileStream("adat.txt", FileMode.Open);
        StreamReader fileBe = new StreamReader(file);
        int szam;
        int osszeg = 0;


        while (!fileBe.EndOfStream)
        {
            szam = Convert.ToInt32(fileBe.ReadLine());
            osszeg += szam;
        }

        Console.WriteLine("A számok összege={0}",osszeg);

        fileBe.Close();
        file.Close();
        Console.ReadKey();
    }
}


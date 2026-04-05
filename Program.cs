using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // ✅ Uji precondition (title valid)
            SayaMusicTrack track = new SayaMusicTrack("Lagu Panjang Tapi Masih Valid");

            // ✅ Uji normal
            track.IncreasePlayCount(5000000);
            track.PrintTrackDetails();

            // ✅ Uji precondition gagal (lebih dari batas)
            track.IncreasePlayCount(20000000);

            // ✅ Uji overflow (pakai loop biar cepat)
            for (int i = 0; i < 100; i++)
            {
                track.IncreasePlayCount(int.MaxValue);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi error: " + e.Message);
        }

        Console.ReadLine();
    }
}
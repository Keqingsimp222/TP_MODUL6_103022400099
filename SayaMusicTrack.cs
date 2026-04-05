using System;
using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        // ✅ Precondition
        Debug.Assert(title != null, "Title tidak boleh null");
        Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter");

        this.title = title;

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);

        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // ✅ Precondition
        Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000");

        try
        {
            // ✅ Cegah overflow
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow pada play count!");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("=== Track Details ===");
        Console.WriteLine("ID        : " + id);
        Console.WriteLine("Title     : " + title);
        Console.WriteLine("PlayCount : " + playCount);
    }
}
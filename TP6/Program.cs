// See https://aka.ms/new-console-template for more information
using System;
using TP6;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Uji prekondisi title yang valid
            SayaTubeVideo v1 = new SayaTubeVideo("Tutorial Design By Contract - Anan");
            v1.printVideoDetails();

            // Uji prekondisi title yang melebihi 100 karakter (akan memicu Debug.Assert)
            // SayaTubeVideo v2 = new SayaTubeVideo(new string('A', 101));

            // Uji exception handling untuk overflow integer
            for (int i = 0; i < 10; i++) // Percepat overflow
            {
                v1.increasePlayCount(1_000_000_000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}
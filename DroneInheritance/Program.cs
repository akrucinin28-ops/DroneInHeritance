using System;

class Program
{
    static void Main()
    {
        // «Форпост-Р» — разведывательный БПЛА
        ReconDrone forpost = new ReconDrone(
            "Форпост-Р", "УЗГА",
            200, 250, 18, 500,   // общие параметры
            60, 6000             // камера 60 Мп, высота 6000 м
        );

        // «Ланцет-3» — ударный БПЛА
        AttackDrone lancet = new AttackDrone(
            "Ланцет-3", "ZALA",
            110, 100, 1, 12,     // общие параметры
            5, "бронетехника"    // боевая часть 5 кг
        );

        Console.WriteLine("=== Унаследованный метод GetInfo() ===");
        Console.WriteLine(forpost.GetInfo());
        Console.WriteLine(lancet.GetInfo());

        Console.WriteLine("\n=== Собственные методы ===");
        forpost.PerformReconnaissance();
        lancet.PerformStrike();
    }
}
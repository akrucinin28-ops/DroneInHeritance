using System;

namespace DroneInheritance
{
    public class AttackReconDrone : ReconDrone
    {
        public string WeaponType { get; set; }
        public int Hardpoints { get; set; }

        public AttackReconDrone(
            string model, string manufacturer,
            double maxSpeed, double flightRange,
            double maxFlightTime, double takeoffWeight,
            double cameraResolution, double maxAltitude,
            string weaponType, int hardpoints)
            : base(model, manufacturer, maxSpeed,
                   flightRange, maxFlightTime, takeoffWeight,
                   cameraResolution, maxAltitude)
        {
            WeaponType = weaponType;
            Hardpoints = hardpoints;
        }

        public void PerformReconAndStrike()
        {
            Console.WriteLine($"Дрон: {Model}");
            Console.WriteLine("Разведка выполнена.");
            Console.WriteLine($"Вооружение: {WeaponType}");
            Console.WriteLine($"Точек подвески: {Hardpoints}");
            Console.WriteLine("Условный удар выполнен.");
        }
    }
}
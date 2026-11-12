using System;

namespace DroneInheritance
{
    public class LoiteringMunition : AttackDrone
    {
        public double LoiterTime { get; set; }
        public string SeekerType { get; set; }

        public LoiteringMunition(
            string model, string manufacturer,
            double maxSpeed, double flightRange,
            double maxFlightTime, double takeoffWeight,
            double warheadWeight, string targetType,
            double loiterTime, string seekerType)
            : base(model, manufacturer, maxSpeed,
                   flightRange, maxFlightTime,
                   takeoffWeight, warheadWeight, targetType)
        {
            LoiterTime = loiterTime;
            SeekerType = seekerType;
        }

        public void LoiterAndStrike()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Время барражирования: {LoiterTime} мин.");
            Console.WriteLine($"Система наведения: {SeekerType}");
            Console.WriteLine("Моделирование удара завершено.");
        }
    }
}

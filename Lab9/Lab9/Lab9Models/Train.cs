using System;

namespace Lab9Models
{
    public class Train : Transport
    {
        public double AverageSpeedKmH { get; }
        public double PassengerLoadPercent { get; }

        public Train(string model, double routeLengthKm,
            double averageSpeedKmH, double passengerLoadPercent)
            : base(model, routeLengthKm)
        {
            AverageSpeedKmH = averageSpeedKmH;
            PassengerLoadPercent = passengerLoadPercent;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, середня швидкість: {AverageSpeedKmH} км/год, завантаженість: {PassengerLoadPercent}%";
        }

        public override double CalculateMetric()
        {
            return RouteLengthKm / AverageSpeedKmH *
                   (1 + PassengerLoadPercent / 100.0);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Models
{
    public class Car : Transport
    {
        public double AverageSpeedKmH { get; }
        public double RestMinutes { get; }

        public Car(
        string model,
        double routeLengthKm,
        double averageSpeedKmH,
        double restMinutes)
        : base(model, routeLengthKm)
        {
            AverageSpeedKmH = averageSpeedKmH;
            RestMinutes = restMinutes;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, середня швидкість: {AverageSpeedKmH} км/год, відпочинок: {RestMinutes} хв";
        }
        public override double CalculateMetric()
        {
            return RouteLengthKm / AverageSpeedKmH + RestMinutes / 60.0;
        }
    }
}

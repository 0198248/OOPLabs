using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Models
{
    public class Bus : Transport
    {
        public double AverageSpeedKmH { get; }
        public int StopCount { get; }

        public Bus(
        string model,
        double routeLengthKm,
        double averageSpeedKmH,
        int stopCount)
        : base(model, routeLengthKm)
        {
            AverageSpeedKmH = averageSpeedKmH;
            StopCount = stopCount;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, середня швидкість: {AverageSpeedKmH} км/год, кількість зупинок: {StopCount}";
        }
        public override double CalculateMetric()
        {
            return RouteLengthKm / AverageSpeedKmH + StopCount * 3 / 60.0;
        }
    }
}

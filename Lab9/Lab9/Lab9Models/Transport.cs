using System;

namespace Lab9Models
{
    public abstract class Transport : ICalculable
    {
        public string Model { get; }
        public double RouteLengthKm { get; }

        protected Transport(
            string model,
            double routeLengthKm)
        {
            Model = model;
            RouteLengthKm = routeLengthKm;
        }

        public virtual string GetDescription()
        {
            return $"Модель: {Model}, довжина маршруту: {RouteLengthKm} км";
        }

        public abstract double CalculateMetric();
    }
}

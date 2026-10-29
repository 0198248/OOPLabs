using System;

namespace Lab8Models
{
    public sealed class Warehouse : Building
    {
        public double OccupancyPercent { get; }
        public Warehouse(string address,
            double area, double occupancyPercent) : base(address, area)
        {
            OccupancyPercent = occupancyPercent;
        }
        public string GetInfo()
        {
            return $"{base.GetCommonDescription()}, заповнення: {OccupancyPercent:F2}%";
        }
        public double CalculateUsedArea()
        {

            return Area * OccupancyPercent / 100.0;
        }
    }

}

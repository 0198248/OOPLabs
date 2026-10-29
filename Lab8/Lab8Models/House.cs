using System;

namespace Lab8Models
{
    public class House : Building
    {
        public int ResidentCount { get; }

        public House(string address,
            double area, int residentCount) : base(address, area)
        {
            ResidentCount = residentCount;
        }
        public string GetInfo()
        {
            return $"{base.GetCommonDescription()}, мешканців: {ResidentCount}";
        }
        public double CalculateAreaPerResident()
        {
            return Area / ResidentCount;
        }

    }

}

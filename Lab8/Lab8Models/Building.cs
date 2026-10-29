using System;

namespace Lab8Models
{
    public class Building
    {
        public string Address { get; }
        public double Area { get; }
        public Building(string address,
            double area)
        {
            this.Address = address;
            this.Area = area;
        }
        protected string GetCommonDescription()
        {
            return $"Адреса: {Address}, загальна площа: {Area:F2} м";
        }
        public string GetBaseInfo()
        {
            return GetCommonDescription();
        }
    }
}

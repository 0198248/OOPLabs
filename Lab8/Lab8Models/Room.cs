using System;

namespace Lab8Models
{
    public class Room : House
    {
        private int windows;
        public int Windows 
        { 
            get { return windows; } 
            set 
            { 
                if (value >= 0)
                    windows = value;
                else
                    windows = 0;
            } 
        }
        public Room(string address,
            double area, int residentCount, int windows) : base(address, area, residentCount)
        {
            this.Windows = windows;
        }
        public Room(string address,
            double area, int residentCount) : base(address, area, residentCount)
        {
            this.Windows = 0;
        }

        public double WindowsPerArea() 
        { 
            return (double)Windows / Area;
        }

        public string GetDetailedInfo()
        {
            return $"{base.GetInfo()}, вікон: {Windows}";
        }
    }
}

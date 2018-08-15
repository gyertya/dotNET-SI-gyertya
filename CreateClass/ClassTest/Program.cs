using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    //I've just made some mod for develop....
    //And add an other line...
    class Vehicle
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            Console.WriteLine(car.ToString());
            Vehicle.PressHorn();
            car.MonitorOilTemperature();
            Console.ReadLine();
            Rectangle.RectangleEntryPoint();
        }

        public static void PressHorn()
        {
            Console.WriteLine("Toot toot!");
        }

        private void MonitorOilTemperature()
        {
            Console.WriteLine("Oil temp is...");
        }
    }

    class Rectangle
    {
        private int _width;
        private int _height;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0 || value > 100) throw new OverflowException();
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0 || value > 100) throw new OverflowException();
                _height = value;
            }
        }

        public static void RectangleEntryPoint()
        {
            Rectangle rect = new Rectangle();

            rect.Height = 120;

            Console.ReadLine();
        }
    }
}

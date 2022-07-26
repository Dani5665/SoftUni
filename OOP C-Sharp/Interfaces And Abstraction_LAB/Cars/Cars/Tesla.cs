using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string colour;
        private int battery;

        public Tesla(string model, string colour, int battery)
        {
            Model = model;
            Colour = colour;
            Battery = battery;
        }

        public string Model { get => model; set => model = value; }
        public string Colour { get => colour; set => colour = value; }
        public int Battery { get => battery; set => battery = value; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.colour} Tesla {this.model} whit {this.battery} Batteries" +
                $"\nEngine start \nBreaaak!";

        }
    }
}

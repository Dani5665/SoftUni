using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string colour;

        public Seat(string model, string colour)
        {
            Model = model;
            Colour = colour;
        }

        public string Model { get => model; set => model = value; }
        public string Colour { get => colour; set => colour = value; }

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
            return $"{this.colour} Seat {this.model} \nEngine start \nBreaaak!";
                     
        }
    }
}

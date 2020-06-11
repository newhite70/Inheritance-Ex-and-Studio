using ComputersClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ComputerClasses
{
    public class Computer : AbstractEntity
    {
        public bool Power { get; set; } = false;

        public static string Size = "Large";
        public string powerState;

        public string Make { get; set; }

        public Computer (bool power, string make)
        {
            Make = make;
            Power = power;
        }

        /*

        public class Cat
        {
            public bool Tired { get; set; } = false;
            public bool Hungry { get; set; } = false;
            public double Weight { get; set; }
            public string Family { get; } = "Felidae";

            public Cat(double weight)
            {
                Weight = weight;
            }



            public class HouseCat : Cat
            {
                public string Name { get; set; }
                public string Species { get; } = "Felis catus";


                public HouseCat(string name, double weight) : base(weight)
                {
                    Name = name;
                }

                */



        public string GetPowerState()
        {
            
            if (Power == true)
            {
                powerState = "On";
            }
            else if (Power == false)
            {
                powerState = "Off";
            }

            return powerState;
        }

        public string Greeting()
        {
            return "I'm a " + Make + " Computer";
        }
       


    }
}

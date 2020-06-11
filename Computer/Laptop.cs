using ComputerClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersClasses
{
    public class Laptop : Computer
    {
        public static string SizeM = "Medium";

        public Laptop(bool power, string make) : base(power, make)
        {
            Power = power;
            Make = make;
        }

        public new virtual string Greeting()
        {
            return "I'm a " + Make + " Laptop";
        }
    }

    
}



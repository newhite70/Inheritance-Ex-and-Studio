using ComputerClasses;
using System;
using System.Collections.Generic;
using System.Text;



namespace ComputersClasses
{
    public class SmartPhone : Computer
    {
        public static string SizeS = "Smallest";
        public SmartPhone(bool power, string make) : base(power, make)
        {
            Power = power;
            Make = make;
        }

    public string Ring()
        {
            return "Ring Ring I'm a SmartPhone";
        }
    }

}


/*
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
        return "I'm a " + Make + " Smartphone";
    }
}
}

*/
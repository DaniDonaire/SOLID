using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Car : ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}

using System;
using System.Collections.;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_03.Klassen_en_Objecten_I.src
{
    public class Car : Vehicle
    {
        public string brand;
        public string model;
        public string type;

        public List<Wheel> wheels = new List<Wheel>();

        public Car(string brand, string model, string type)
        {
            this.brand = brand;
            this.model = model;
            this.type = type;

            Wheel leftFront = new Wheel();
            Wheel rightFront = new Wheel();
            Wheel leftBack = new Wheel();
            Wheel rightBack = new Wheel();

            this.wheels.Add(leftFront);
            this.wheels.Add(rightFront);
            this.wheels.Add(leftBack);
            this.wheels.Add(rightBack);
        }

        public void Drive() { }
        public void Stop() { }
        public void Start() { }
        public void Steer() { }

    }
}

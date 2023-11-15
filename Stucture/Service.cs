using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Stucture
{
    internal class Service
    {
        private String id;
        private String name;
        private double price;
        private bool state = false;
        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public bool State { get => state; set => state = value; }

        public Service(String id, String name, double price) {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public Service() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Stucture
{
    internal class CarType
    {
        private string id;
        private string name;
        private double basePrice;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double BasePrice { get => basePrice; set => basePrice = value; }
    }
}

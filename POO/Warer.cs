using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Warer:Sales //herencia
    {
        public Warer() { } //Constructor vacio


        //constructor herencia
        public Warer(string name, string customer, decimal total) : base(total, customer)
        {
            this.name = name;
        }
        public string name;


        public new string getInfo() {

            string info = "Datos de Warer :" + "Nombre: " + name + " Cliente: " + Customer + " total: " + total;

            return info;
        }

    }
}

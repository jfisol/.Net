using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Sales
    {
        public decimal total;
        public string Customer;


        public Sales() { }


        public Sales(decimal total, string customer) 
        {
            this.total = total;
            this.Customer = customer;
        
        }

        public string getInfo()
        {
            string info = "El total es " + total;

            info += " y el Cliente es: " + Customer;

            return info;
        }

    }
}

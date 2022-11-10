using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Models
{
    public class Garage:List<Coches>
    {
       public Garage()
        {

            this.Add(new Coches("1","Tesla","Roadster","Elon Musk"));
            this.Add(new Coches("2", "Toyota", "Yaris", "Domingo Garcia"));
            this.Add(new Coches("3", "Honda", "Civic", "Antonio León"));
            this.Add(new Coches("4", "Ferrari", "F40", "Roberto Cardiel"));

        }

    }
}
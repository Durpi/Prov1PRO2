using System.Collections.Generic;
using System;

namespace Prov1
{
    public class Client
    {

        //för att generera för t.ex om de äger boken eller inte, hur mycket intresse de har i olika categorier
        Random generator = new Random();
        //För att spelaren ska skapa eget namn
        public string name;
        //För att se vilken categori som kunden kommer ha interest i
        List<string> category = new List<string>() {"horror", "fantasy", "si-fi", "action", "comedy"};


        //Se vilka categorier som Client har intresse i
        public void Interest()
        {

        }

        //Se om Client har denna bok
        public bool Ownership()
        {

        }
        
    }
}

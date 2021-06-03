using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Person
    {

        public int id = 0;
        public string firstName = "";
        public string surname = "";
        public string address1 = " ";
        public string address2 = " ";
        public double locLat = 0.0;
        public double locLon = 0.0;




        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        

        public double Latitude
        {
            get { return locLat; }
            set { locLat = value; }
        }

        public double Longtitude
        {
            get { return locLon; }
            set { locLon = value; }
        }
    }
}

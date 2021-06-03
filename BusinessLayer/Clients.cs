using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Clients : Person
    {
      

        public Clients(int id, string firstName, string surname, string address1, string address2, double locLat, double locLon)
        {
            Id = id;
            Name = firstName;
            Surname = surname;
            Address1 = address1;
            Address2 = address2;
            Latitude = locLat;
            Longtitude = locLon;
        }
        public int Id
        {
            get;
            internal set;
        }
        public string Name
        {
            get;
            internal set;
        }
        public string Surname
        {
            get;
            internal set;
        }

        public string Address1
        {
            get;
            internal set;
        }

        public string Address2
        {
            get;
            internal set;
        }



        public double Latitude
        {
            get;
            internal set;
        }

        public double Longtitude
        {
            get;
            internal set;
        }
    }
}

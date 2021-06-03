using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Staff : Person
    {

        public string category = "";
        
        public Staff(int id, string firstName, string surname, string address1, string address2, string category, double baseLocLat, double baseLocLon)
        {
            Id = id;
            Name = firstName;
            Surname = surname;
            Address1 = address1;
            Address2 = address2;
            this.category = category;
            Latitude = baseLocLat;
            Longtitude = baseLocLon;
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

        public string Category
        {
            get { return category; }
            set { category = value; }
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



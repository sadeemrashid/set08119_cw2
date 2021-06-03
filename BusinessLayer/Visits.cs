using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Visits
    {
        public Visits(int[] staff, int patient, int type, string dateTime)
        {
            Staff = staff;
            Patient = patient;
            Type = type;
            DateTime = dateTime;

        }

        private int[] staff;
        private int patient = 0;
        private int type = 0;
        private string dateTime = "";

        public int[] Staff
        {
            get { return staff; }
            set { staff = value; }
        }
        public int Patient
        {
            get { return patient; }
            set { patient = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public string DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
    }
}





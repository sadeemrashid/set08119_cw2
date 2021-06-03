using BusinessLayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public static class visitTypes
    {
        public const int assessment = 0;
        public const int medication = 1;
        public const int bath = 2;
        public const int meal = 3;

    }
    public class HealthFacade
    {

        public List<Person> people = new List<Person>();
        public List<Staff> Stafflist = new List<Staff>();
        public List<Clients> Clientlist = new List<Clients>();
        public List<Visits> Visitlist = new List<Visits>();









        public Boolean addStaff(int id, string firstName, string surname, string address1, string address2, string category, double baseLocLat, double baseLocLon)
        {
            try
            {

                Staff staffm = new Staff(id, firstName, surname, address1, address2, category, baseLocLat, baseLocLon);
                if (!staffexist(id))
                {
                    Stafflist.Add(staffm);
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean addClient(int id, string firstName, string surname, string address1, string address2, double locLat, double locLon)
        {
            try
            {
                Clients Patient = new Clients(id, firstName, surname, address1, address2, locLat, locLon);
                if (!clientexist(id))
                {
                    Clientlist.Add(Patient);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }

        }
        public Boolean staffexist(int id)
        {
            foreach (Staff ite in Stafflist)
            {
                if (ite.Id == id)
                {
                    return true;
                }
            }
            return false;
        }



        public Boolean clientexist(int id)
        {
            foreach (Clients ite in Clientlist)
            {
                if (ite.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean typevalidation(int type)
        {

            if (type >= 0 && type <= 3)
            {
                return true;
            }

            else
            {
                return false;

            }
        }


        public Boolean staffvalidation(int type, int[] staffarray)
        {
            string a = "Social Worker";
            string b = "General Practitioner";
            string c = "Community Nurse";
            string d = "Care Worker";

            foreach (Staff value in Stafflist)
            {
                foreach (int id in staffarray)
                {
                    if (value.Id == id)
                    {
                        if (type == 0 && ((value.Category == a || value.Category == b) && staffarray.Length == 2))
                        {
                            return true;
                        }
                           
                        else if (type == 1 && value.Category == c && staffarray.Length == 1)
                        {
                            return true;
                        }
                        
                       else if (type == 2 && (value.Category == d && staffarray.Length == 2))
                        {
                            return true;
                        }
                        
                        else if (type == 3 && value.Category == d && staffarray.Length == 1)
                        {
                            return true;
                        }
                     

                        else
                        {
                            return false;
                        }
                    }
                }

            }


            return true;



        }





        public Boolean datevalidation(string dateStr)
        {
            // DateTime dateTimes = DateTime.Parse(dateStr);
            bool conflict = false;
            foreach (Visits value in Visitlist)
            {
                if (value.DateTime==dateStr)
                {
                    conflict = true;
                }
                
            }
            if (conflict)
            {
                return false;
            }
            return true;
        }
            
           


            public Boolean addVisit(int[] staff, int patient, int type, string dateTime)
             {
            try
            {
                Visits visit = new Visits(staff, patient, type, dateTime);
                if (typevalidation(type))
                   
                {
                    if (clientexist(patient))
                       
                    {
                        if (staffvalidation(type, staff))
                           
                        {
                            if (datevalidation(dateTime))


                            {
                                
                                Visitlist.Add(visit);
                             
                                return true;
                                throw new System.InvalidOperationException("visit not correct type\n");
                                throw new System.InvalidOperationException("Visit not valid for (Patient " + patient + " @" + dateTime + ")\n");
                                throw new System.InvalidOperationException("Visit not valid for (Patient " + patient + " @" + dateTime + ")\n");
                                throw new System.InvalidOperationException("Visit not valid for (Patient " + patient + " @" + dateTime + ")\n");
                                // return true;

                            }
                            
                            else
                            {
                                return false;
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

              
            }
            

            catch (Exception)
            {
              // throw new System.InvalidOperationException("Visit not valid for (Patient " + patient + " @" + dateTime + ")\n");
                return false;
            }
    }





        public String GetStaffList()
        {
            String result = "";
            foreach (Staff value in Stafflist)
            {

                result += value.Id.ToString() + " " + value.Name + " " + value.Surname + " " + value.Address1 + " " + value.Address2 + " " + value.Category
                    + " " + value.Latitude.ToString() + " " + value.Longtitude.ToString() + "\n";

            }
            return result;
        }

        public String getClientList()
        {
            String result = "";
            foreach (Clients value in Clientlist)
            {
                result += value.Id.ToString() + " " + value.Name + " " + value.Surname + " " + value.Address1 + " " + value.Address2
                                  + " " + value.Latitude.ToString() + " " + value.Longtitude.ToString() + "\n";
            }

            return result;
        }

        public String getVisitList()
        {
           
            String result = "";
            foreach (Visits value in Visitlist)
            {
               
                {
                    string vectorIDs = string.Join(" , ", value.Staff);
                    result += " " + vectorIDs + " " + value.Patient.ToString() + " " + value.Type.ToString() + " " + value.DateTime  + "\n";
                }
            }
            return result;
        }


        public void clear()
        {
            Stafflist.Clear();
            Clientlist.Clear();
            Visitlist.Clear();

        }


        public Boolean load()
        {
            try
            {
                
                    DataFacade.loadData();
                    return true;
               
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool save()
        {
            try
            {
                
                    DataSingleton.SaveData(Stafflist, Clientlist, Visitlist);
                    DataFacade.loadData();
                    return true;
                    
                    
                
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
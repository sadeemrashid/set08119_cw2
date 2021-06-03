using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessLayer.DataLayer
{
    class DataFacade
    {



        public static void loadData()
        {
            var fileToOpen = "D:\\40402246oop\\BusinessLayer\\DataLayer\\Stafflist.txt";
            var process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();



            var fileclient = "D:\\40402246oop\\BusinessLayer\\DataLayer\\Clientlist.txt";
            var process1 = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileclient
            };

            process.Start();


            var filevisit = "D:\\40402246oop\\BusinessLayer\\DataLayer\\Visitlist.txt";
            var process2 = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = filevisit
            };

            process.Start();
         }
        public static void SaveData(List<Staff> Stafflist, List<Clients> Clientlist, List<Visits> Visitlist)
       
        {

            TextWriter tw = new StreamWriter("D:\\40402246oop\\BusinessLayer\\DataLayer\\Stafflist.txt");

            foreach (Staff value in Stafflist)
            {
                tw.WriteLine(value.Id.ToString() + " " + value.Name + " " + value.Surname + " " + value.Address1 + " " + value.Address2 + " " + value.Category
                + " " + value.Latitude.ToString() + " " + value.Longtitude.ToString());
            }

            tw.Close();

            TextWriter tw2 = new StreamWriter("D:\\40402246oop\\BusinessLayer\\DataLayer\\Clientlist.txt");

            foreach (Clients value in Clientlist)
            {
                tw2.WriteLine(value.Id.ToString() + " " + value.Name + " " + value.Surname + " " + value.Address1 + " " + value.Address2
                                  + " " + value.Latitude.ToString() + " " + value.Longtitude.ToString());
            }

            tw2.Close();

            TextWriter tw3 = new StreamWriter("D:\\40402246oop\\BusinessLayer\\DataLayer\\Visitlist.txt");

            foreach (Visits value in Visitlist)
            {
                string vectorIDs = string.Join(" , ", value.Staff);
                tw3.WriteLine(vectorIDs + " " + value.Patient.ToString() + " " + value.Type.ToString() + " " + value.DateTime);
            }

            tw3.Close();


        }


    }

}

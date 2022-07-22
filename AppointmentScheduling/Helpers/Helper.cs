using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AppointmentScheduling.Helpers
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";

        public static List<SelectListItem> GetRolesDropDown()
        {
            return new List<SelectListItem>
           {
               new SelectListItem{ Value = Helper.Admin, Text=Helper.Admin},
               new SelectListItem{ Value = Helper.Patient, Text=Helper.Patient},
               new SelectListItem{ Value = Helper.Doctor, Text=Helper.Doctor},
           };
        }

        //Nice way to change bookings etc 
        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 0;
            var duration = new List<SelectListItem>();

            for (int counter = 1; counter <= 12; counter++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = counter + "Hr" });
                minute = minute + 30;

                duration.Add(new SelectListItem { Value = minute.ToString(), Text = counter + "hr 30 Min" });
                minute = minute + 30;

                
            }

            return duration;


        }
    }
}

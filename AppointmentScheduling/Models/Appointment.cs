using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduling.Models
{
    [Keyless]
    public class Appointment
    {
       
        public int MyProperty { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DoctorId { get; set; }

        public string PatientId { get; set; }

        public int Duration { get; set; }

        public bool IsDoctorAppoved { get; set; }


        public string AdminId { get; set; }

        public string DoctorName { get; set; }

        public string PatientName { get; set; }

        public string AdminName { get; set; } 

        public bool IsForClient { get; set; }
    }
}

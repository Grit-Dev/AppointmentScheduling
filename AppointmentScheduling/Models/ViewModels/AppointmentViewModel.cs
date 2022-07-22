using System;

namespace AppointmentScheduling.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public int? MyProperty { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DoctorId { get; set; }

        public string PatientId { get; set; }

        public bool IsDoctorAppoved { get; set; }

        public string AdminId { get; set; }
    }
}

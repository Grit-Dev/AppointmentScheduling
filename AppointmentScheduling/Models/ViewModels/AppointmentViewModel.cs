using System;

namespace AppointmentScheduling.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public int? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public int Duration { get; set; }

        public string DoctorId { get; set; }

        public string PatientId { get; set; }

        public bool IsDoctorAppoved { get; set; }

        public string AdminId { get; set; }
    }
}

using AppointmentScheduling.Models.ViewModels;
using System.Collections.Generic;

namespace AppointmentScheduling.Services
{
    //Used to implement all the methods for the appointment service
    public interface IAppointmentService
    {
        public List<DoctorViewModel> GetDoctorList();

        public List<PatientViewModel> GetPatientList();

        




    }
}

using Microsoft.AspNetCore.Mvc;
using AppointmentScheduling.Services;


namespace AppointmentScheduling.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult DoctorList()
        {
            
            var aList = _appointmentService.GetDoctorList();  

           
            return View(aList);
        }

        public IActionResult PatientList()
        {

            var aList = _appointmentService.GetPatientList();


            return View(aList);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using AppointmentScheduling.Services;
using AppointmentScheduling.Helpers;

namespace AppointmentScheduling.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult Index()
        {
            ViewBag.Duration = Helper.GetTimeDropDown();
            ViewBag.DoctorList = _appointmentService.GetDoctorList();
            ViewBag.PatientList = _appointmentService.GetPatientList();

           
            return View();
        }


    }
}

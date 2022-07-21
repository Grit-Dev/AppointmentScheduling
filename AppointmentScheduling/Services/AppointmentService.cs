using AppointmentScheduling.Data;
using AppointmentScheduling.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using AppointmentScheduling.Helpers;

namespace AppointmentScheduling.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }

        //This is something I need to learn more = The SQL Coding.
        public List<DoctorViewModel> GetDoctorList()
        {
            var doctorList = (from user in _db.Users
                              join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                              join roles in _db.Roles.Where(x => x.Name == Helper.Doctor) on userRoles.RoleId equals roles.Id
                              select new DoctorViewModel
                              {
                                  Id = user.Id,
                                  Name = user.Name
                              }).ToList();
            return doctorList;

        }

        public List<PatientViewModel> GetPatientList()
        {
            var patientList = (from user in _db.Users
                              join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                              join roles in _db.Roles.Where(x => x.Name == Helper.Patient) on userRoles.RoleId equals roles.Id
                              select new PatientViewModel
                              {
                                  Id = user.Id,
                                  Name = user.Name
                              }).ToList();

            return patientList;
        }
    }
}

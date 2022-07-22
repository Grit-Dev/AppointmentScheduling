using AppointmentScheduling.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AppointmentScheduling.Models.ViewModels;

namespace AppointmentScheduling.Data
{
    //Implements Application user model to the db with all the properties extended from Identity user thanks to inheriting in the model class user 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        //Create a table in the DB wand fill it with the class of appointment props 
        public DbSet<Appointment> Appointments { get; set; }

        //Not too sure why this is here. Commented out for now 
        /*public DbSet<AppointmentScheduling.Models.ViewModels.DoctorViewModel> DoctorViewModel { get; set; }*/
    }
}

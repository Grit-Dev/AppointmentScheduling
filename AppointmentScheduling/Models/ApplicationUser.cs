using Microsoft.AspNetCore.Identity;

namespace AppointmentScheduling.Models
{
    //Identity user: 
    //
    //This extends extends the user of identity. It will give us all the properties of Identity user
    //We can also create more properties to be added to the db
    //
    //

    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}

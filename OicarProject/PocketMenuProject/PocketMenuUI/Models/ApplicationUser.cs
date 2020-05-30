using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PocketMenuUI.Models
{
    public  class ApplicationUser : IdentityUser
    {
        //Ode dodati ako nesto pri registraciji ili u profilu.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
 
}
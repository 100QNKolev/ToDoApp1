using Microsoft.AspNetCore.Identity;

namespace ToDoApp.Data
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            this.Lists = new List<ToDoList>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public virtual List<ToDoList> Lists { get; set; }
    }
}

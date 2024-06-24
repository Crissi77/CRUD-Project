using System.ComponentModel.DataAnnotations;

namespace CRUD_Project.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Profile field is required")]
        public String Profile { get; set; }


    }
}

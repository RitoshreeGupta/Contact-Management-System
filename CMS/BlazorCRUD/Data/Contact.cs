using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(250, ErrorMessage = "Last name cannot be longer than 250 characters")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(250, ErrorMessage = "First name cannot be longer than 250 characters")]
        public String FirstName { get; set; }

        [StringLength(15, ErrorMessage = "Phone number cannot be longer than 15 characters")]
        public String PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; } = DateTime.Now;

        

    }
}

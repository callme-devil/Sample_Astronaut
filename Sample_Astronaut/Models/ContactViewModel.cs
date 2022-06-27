using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Astronaut.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "این فیلد اجباری میباشد")]
        [MinLength(3 , ErrorMessage = "حداقل طول مجاز 3 کاراکتر میباشد")]
        [MaxLength(50,ErrorMessage = "حداکثر طول مجاز 50 کاراکتر میباشد")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری میباشد")]
        [EmailAddress(ErrorMessage = "فرمت وارد شده با ایمیل همخوانی ندارد")]
        public string Email { get; set; }

        public string Description { get; set; }
    }
}

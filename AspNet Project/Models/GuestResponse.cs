using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNet_Project.Models
{
    // Класс ответа гостя
    public class GuestResponse
    {
        [Required(ErrorMessage ="Введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите электронную почту")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Введие достоверную электронную почту")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Введите свой номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Укажите, примите ли участие")]
        public bool? WillAttend { get; set; } // Может принимать true false null

    }
}

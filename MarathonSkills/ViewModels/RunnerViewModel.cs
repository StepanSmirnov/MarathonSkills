using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.Utils;

namespace MarathonSkills.ViewModels
{
    public class RunnerViewModel
    {
        [BindProperty]
        [Required(ErrorMessage ="Не указан Email")]
        [EmailAddress(ErrorMessage ="Неверный формат email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указан пароль")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указан пароль")]
        public string PasswordConfirmation { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указано имя")]
        [StringLength(80)]
        public string FirstName { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указана фамилия")]
        [StringLength(80)]
        public string LastName { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указан пол")]
        public string Gender { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указана дата рождения")]
        [TenYearsOld(ErrorMessage = "Возраст менее 10 лет")]
        public DateTime DateOfBirth { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="Не указана страна")]
        public string CountryCode { get; set; }

        public SelectList Genders { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}

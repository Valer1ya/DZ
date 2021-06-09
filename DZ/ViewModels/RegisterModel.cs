using System.ComponentModel.DataAnnotations;

namespace DZ.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан ID пользователя или указан неверно")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
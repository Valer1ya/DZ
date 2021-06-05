using System.ComponentModel.DataAnnotations;

namespace DZ.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан ID пользователя или указан неверно")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
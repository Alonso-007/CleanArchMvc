using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.WebUI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email é requerido")]
        [EmailAddress(ErrorMessage = "Formato inválido do email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é requirida")]
        [StringLength(20, ErrorMessage = "A senha {0} deve ter pelo menos {2} e no maximo {1}")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
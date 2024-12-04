using System.ComponentModel.DataAnnotations;

namespace WebPage.Models
{
    public class ContatoModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O e-mail fornecido não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O assunto é obrigatório.")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "A mensagem é obrigatória.")]
        public string Mensagem { get; set; }
    }
}

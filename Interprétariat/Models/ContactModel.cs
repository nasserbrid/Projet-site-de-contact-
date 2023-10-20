using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Interprétariat.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse e-mail valide.")]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Le numéro de téléphone doit avoir entre 10 et 15 caractères. ")]
        [DisplayName("Numéro de téléphone")]
        public string Phone { get; set; }
    }
}

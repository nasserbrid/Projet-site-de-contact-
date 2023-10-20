using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Interprétariat.Models
{
    public partial class ContactModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        [Required(ErrorMessage = "Entrez une adresse email valide !")]
        public string Email { get; set; }
        public string Message { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "numéro de téléphone non valide !")]
        [DisplayName("Numéro de téléphone")]
        public string Phone { get; set; }
    }
}

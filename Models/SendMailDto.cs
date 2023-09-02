using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace SuadiyeHairHouse.Models
{
    public class SendMailDto
    {
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Email Girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Message { get; set; }
    }
}

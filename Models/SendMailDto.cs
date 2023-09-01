using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace SuadiyeHairHouse.Models
{
    public class SendMailDto
    {
        [Required(ErrorMessage = "İsim Alanı Gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Alanı Boş Geçilemez.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Email Girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Numarası Gereklidir.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Mesaj Alanı Boş Geçilemez.")]
        public string Message { get; set; }
    }
}

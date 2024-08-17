using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebProje.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string imageURL { get; set; }
        public IFormFile image {  get; set; }   
        
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Şifreler eşleşmeli")]
        public string confirmPassword { get; set; }
    }
}

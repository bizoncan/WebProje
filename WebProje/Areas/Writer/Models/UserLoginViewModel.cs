using System.ComponentModel.DataAnnotations;

namespace WebProje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz!!!!")]
        public string username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz!!!!")]
        public string password { get; set; }
    }
}

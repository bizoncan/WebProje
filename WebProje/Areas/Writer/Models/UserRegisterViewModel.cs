using System.ComponentModel.DataAnnotations;

namespace WebProje.Areas.Writer.Models
{
    public class UserRegisterViewModel


    {
        [Required(ErrorMessage = "İsim girmek zorunludur")]
        public string name { get; set; }
        [Required(ErrorMessage = "Soyad girmek zorunludur")]
        public string surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı girmek zorunludur")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Resim adresi girmek zorunludur")]
        public string imageURL { get; set; }
        [Required(ErrorMessage = "Şifre girmek zorunludur")]
        public string password { get; set; }
        [Required(ErrorMessage = "Şifreyi tekrar girmek zorunludur")]
        [Compare("password", ErrorMessage = "Şifreler eşleşmeli")]
        public string confirmPassword { get; set; }
        [Required(ErrorMessage = "Mail adresi girmek zorunludur")]
        public string mail { get; set; }
    }
}

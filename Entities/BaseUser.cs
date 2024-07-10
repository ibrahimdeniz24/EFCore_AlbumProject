using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PlakDükkanı.Entities
{
    public class BaseUser
    {

        public int ID { get; set; }

        [Required()]
        public string KullaniciAdi { get; set; }

        //[RegularExpression(@"^(?=.*[A-Z].*[A-Z])(?=.*[a-z].*[a-z].*[a-z])(?=.*[!:+*].*[!:+*])[A-Za-z/d!:+*]{8,}$", ErrorMessage = "Şifre En az 8 karakter uzunluğunda  ")]
        public string Sifre { get; set; }

        public string? ReSifre { get; set; }

        public string? IsActive { get; set; }

        public DateTime? AddedDate { get; set; }
        
      


    }
}

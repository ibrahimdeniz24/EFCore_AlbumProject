using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_PlakDükkanı.Enums;

namespace WFA_PlakDükkanı.Entities
{
    public class Admin : BaseUser
    {

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(25, ErrorMessage = "En Fazla 50 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
        public string Adi { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(25, ErrorMessage = "En Fazla 50 karakter uzunluğunda olmalıdır.", MinimumLength = 3)]
        public string Soyadi { get; set; }

        [NotMapped]
        public string FullName => $"{Adi}+{Soyadi}";

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Dogum Tarihi Girilmemiş")]
        public DateTime DogumTarihi { get; set; }

        public string? Gender { get; set; }


        public List<Album>? Albümler { get; set; }


    }
}

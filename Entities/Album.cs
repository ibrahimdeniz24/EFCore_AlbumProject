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
    public class Album
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "En Fazla 50 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]
        public string AlbumAdi { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(25, ErrorMessage = "En Fazla 50 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]
        public string Sanatci { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Cıkış Tarihi Girilmemiş")]
        public DateTime CikisTarihi { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public decimal Fiyati { get; set; }

        public sbyte? IndirimOranı { get; set; } = null;

        public IsActive? IsActive { get; set; }

        [ForeignKey("Admin")]
        public int? EkleyenAdminID { get; set; }
        public Admin? EkleyenAdmin { get; set; }
    }
}

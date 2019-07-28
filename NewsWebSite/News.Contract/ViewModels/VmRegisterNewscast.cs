using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Contract.ViewModels
{
    public class VmRegisterNewscast
    {
        [DisplayName("Haber Başlığı")]
        [Required(ErrorMessage = "Haberin başlığını yazmak zorundasınız!")]
        [StringLength(50, ErrorMessage = "Geçerli bir haber başlığı yazınız.", MinimumLength = 5)]
        public string NewsTitle { get; set; }

        [DisplayName("Haber İçeriği")]
        [Required(ErrorMessage = "Haberin içeriğini yazmak zorundasınız!")]
        [StringLength(1000, ErrorMessage = "Geçerli haber içeriği yazınız.", MinimumLength = 100)]
        public string NewsContent { get; set; }


        [DisplayName("Haber Fotoğrafı")]
        public string NewsImage { get; set; }


        [DisplayName("Kategori Id")]
        [Required(ErrorMessage = "Kategori id'sini yazmak zorundasınız!")]
        [StringLength(100, ErrorMessage = "Geçerli kategori id'si yazınız.", MinimumLength = 1)]
        public string CategoryId { get; set; }

                               
    }
}

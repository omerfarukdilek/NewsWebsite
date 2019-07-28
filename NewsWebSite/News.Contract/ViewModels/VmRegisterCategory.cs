using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Contract.ViewModels
{
    public class VmRegisterCategory
    {
        // Bu alandaki Data Annotations yani kısıtlamalar, arayüzden yani admin panelinden bir kategori eklerken çalışan kısıtlamalardır. Uyarı mesajları orda çalışır.
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Kategori adını yazmak zorundasınız!")]
        //[StringLength(50, ErrorMessage = "Adınız 2 ile 50 karakter arasında olmalıdır..", MinimumLength = 2)]
        [StringLength(50, ErrorMessage = "Geçerli bir kategori adı yazınız.", MinimumLength = 2)]
        public string CategoryName { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [StringLength(100, ErrorMessage = "Geçerli kategori açıklaması yazınız.", MinimumLength = 2)]
        public string CategoryDescription { get; set; }


    }
}

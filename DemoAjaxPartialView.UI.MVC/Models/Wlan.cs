using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAjaxPartialView.UI.MVC.Models
{
    public class Wlan:ModelDefault
    {
        [Column(TypeName ="varchar")]
        [Display(Name ="SN")]
        [StringLength(50)]
        
        public string SN { get; set; }

        [Column(TypeName = "varchar")]
        [Display(Name = "Modelo")]
        [StringLength(50)]
        
        public string Modelo { get; set; }
    }
}
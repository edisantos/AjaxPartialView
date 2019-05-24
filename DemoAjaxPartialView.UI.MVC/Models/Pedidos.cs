using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAjaxPartialView.UI.MVC.Models
{
    public class Pedidos:ModelDefault
    {
        [Display(Name ="Produto")]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Produto { get; set; }

        [Display(Name = "Valor Unitario")]
        [Column(TypeName = "decimal")]
        public decimal ValorUnit { get; set; }

    }
}
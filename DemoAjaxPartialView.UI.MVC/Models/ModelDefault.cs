using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAjaxPartialView.UI.MVC.Models
{
    public class ModelDefault
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Column(TypeName = "datetime")]
        [Display(Name = "Data")]
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectFrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Заполните пожалуйста"), MaxLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните пожалуйста"), StringLength(500)]
        public string Description { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}

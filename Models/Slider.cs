using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConnectFrontToBack.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }

        [NotMapped]
        [Required(ErrorMessage =("Выбери фотографию!"))]
        public IFormFile Photo { get; set; }
    }
}

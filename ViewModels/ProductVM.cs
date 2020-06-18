using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.Models;

namespace ConnectFrontToBack.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public virtual Category Category { get; set; }
    }
}

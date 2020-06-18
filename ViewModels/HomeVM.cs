using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.Models;

namespace ConnectFrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public Content Content { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}

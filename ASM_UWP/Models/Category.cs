using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ASM_UWP.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IconElement Icon { get; set; }
    }
}

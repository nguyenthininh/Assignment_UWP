using ASM_UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ASM_UWP.Servecies
{
    public class CategoryService
    {
        public List<Category> GetAllCategories()
        {
            return new List<Category> {
                new Category
                {
                    Name = "Home",
                    ID = -1,
                    Icon = new SymbolIcon(Symbol.Home)
                },
                new Category
                {
                    Name = "Music",
                    ID = 1,
                    Icon = new SymbolIcon(Symbol.MusicInfo)
                },
                new Category
                {
                    Name = "Politics",
                    ID = 2,
                    Icon = new SymbolIcon(Symbol.World)
                }
            };
        }
    }
}

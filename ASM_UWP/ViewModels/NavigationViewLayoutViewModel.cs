using ASM_UWP.Models;
using ASM_UWP.Servecies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP.ViewModels
{
    public class NavigationViewLayoutViewModel
    {
        private readonly CategoryService categoryService = new CategoryService();
        public ObservableCollection<Category> Categories { get; }

        public NavigationViewLayoutViewModel()
        {
            Categories = new ObservableCollection<Category>(categoryService.GetAllCategories());
        }
    }
}

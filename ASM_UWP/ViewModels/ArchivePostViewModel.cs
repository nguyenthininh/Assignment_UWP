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
    public class ArchivePostViewModel
    {
        private readonly PostService postService = new PostService();
        public ObservableCollection<Post> Posts { get; }

        public ObservableCollection<Post> GetPostsCollection(int categoryID)
        {
            if (categoryID == -1)
            {
                return new ObservableCollection<Post>(postService.GetAllPosts());
            }
            else
            {
                return new ObservableCollection<Post>(postService.GetPostsByCategory(categoryID));
            }

        }
    }
}

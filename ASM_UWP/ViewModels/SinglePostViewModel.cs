using ASM_UWP.Models;
using ASM_UWP.Servecies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP.ViewModels
{
    public class SinglePostViewModel
    {
        private readonly PostService postService = new PostService();
        public Post Post { get; }

        public Post GetPost(int id)
        {
            return postService.GetPostByID(id);

        }
    }
}

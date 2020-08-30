using ASM_UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_UWP.Servecies
{
    public class PostService
    {
        public List<Post> GetPostsByCategory(int categoryID)
        {
            return GetAllPosts().FindAll(post => post.CategoryID == categoryID);
        }

        public Post GetPostByID(int id)
        {
            return GetAllPosts().Find(post => post.ID == id);
        }

        public List<Post> GetAllPosts()
        {
            return new List<Post>
            {
                new Post
                {
                    ID = 1,
                    Title = "SKY",
                    Content = @"Cuộc sống vốn luôn chứa đựng những muộn phiền, cũng may còn có bầu trời luôn cho ta niềm tin!",
                    Thumbnail = "/Assets/Posts/bautroi.jpg",
                    CategoryID = 1,
                    Author = "nini",
                    DateCreated = DateTime.Today
                },
                new Post
                {
                    ID = 2,
                    Title = "Strong girl",
                    Content = " Con gái là thế đấy, càng mạnh mẽ thì càng yếu đuối, càng cười nhiều thì càng thấy trống trải, càng vô tư lại càng lắm ưu phiền. Biết sao được đây, cuộc đời thì chẳng màu hồng mà con gái thì không có màu nào làm đại diện.",
                    Thumbnail =  "/Assets/Posts/cogai.jpg",
                    CategoryID = 1,
                    Author = "kiki",
                    DateCreated = DateTime.Today
                },
                new Post
                {
                    ID = 3,
                    Title = "Beautiful view",
                    Content = "Ánh nắng ban mai rọi xuống chồi non đang hé mở, giọt sương đêm còn đọng lại trên mặt lá long lanh, gió vi vu thổi nhẹ trong lành",
                    Thumbnail =  "/Assets/Posts/khungcanh.jpg",
                    CategoryID = 2,
                    Author = "nina",
                    DateCreated = DateTime.Today
                },
            };

        }

    }
}

using Socialmedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialmedia.core.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByUser(int userId);

        //Task<IEnumerable<Post>> GetPosts();

        //Task<Post> GetPost(int id);

        //Task InsertPost(Post post);

        //Task<bool> UpdatePost(Post post);
        //Task<bool> DeletePost(int id);


    }
}

using Socialmedia.core.CustomEntities;
using Socialmedia.core.QueryFilters;
using Socialmedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socialmedia.core.Interfaces
{
    public interface IPostService
    {
        //Task<IEnumerable<Post>> GetPosts();
        PagedList<Post> GetPosts(PostQueryFilter filters);

        Task<Post> GetPost(int id);

        Task InsertPost(Post post);

        //Task<bool> UpdatePost(Post post);
        Task<bool> UpdatePost(Post post);
        Task<bool> DeletePost(int id);
    }
}
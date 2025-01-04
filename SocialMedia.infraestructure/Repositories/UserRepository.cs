using Microsoft.EntityFrameworkCore;
using Socialmedia.core.Interfaces;
using Socialmedia.Core.Entities;
using SocialMedia.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialMediaContext _context;
        public UserRepository(SocialMediaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        //public async Task InsertPost(Post post)
        //{
        //    _context.Posts.Add(post);
        //    await _context.SaveChangesAsync();
        //}
        //public async Task<bool> UpdatePost(Post post)
        //{
        //    var currentPost = await GetPost(post.PostId);
        //    currentPost.Date = post.Date;
        //    currentPost.Description = post.Description;
        //    currentPost.Image = post.Image;

        //    int rows = await _context.SaveChangesAsync();
        //    return rows > 0;
        //}

        //public async Task<bool> DeletePost(int id)
        //{
        //    var currentPost = await GetPost(id);
        //    _context.Posts.Remove(currentPost);
        //    int rows = await _context.SaveChangesAsync();
        //    return rows > 0;
        //}

    }
}

﻿using Microsoft.EntityFrameworkCore;
using Socialmedia.core.Interfaces;
using Socialmedia.Core.Entities;
using SocialMedia.infraestructure.Repositories;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialmedia.Infrastructure.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(SocialMediaContext context) : base(context) {}

        public  async Task<IEnumerable<Post>> GetPostsByUser(int userId)
        {
            return await _entities.Where(x => x.UserId == userId).ToListAsync();
        }
    }


    //public class PostRepository : IPostRepository
    //{
    //    private readonly SocialMediaContext _context;
    //    public PostRepository(SocialMediaContext context)
    //    {
    //        _context = context;
    //    }

    //    public async Task<IEnumerable<Post>> GetPosts()
    //    {
    //        var posts = await _context.Posts.ToListAsync();
    //        return posts;
    //    }

    //    public async Task<Post> GetPost(int id)
    //    {
    //        var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
    //        return post;
    //    }

    //    public async Task InsertPost(Post post)
    //    {
    //        _context.Posts.Add(post);
    //        await _context.SaveChangesAsync();
    //    }
    //    public async Task<bool> UpdatePost(Post post)
    //    {
    //        var  currentPost = await GetPost(post.Id);
    //        currentPost.Date = post.Date;
    //        currentPost.Description = post.Description;
    //        currentPost.Image = post.Image;

    //        int rows = await _context.SaveChangesAsync();
    //        return rows > 0;
    //    }

    //    public async Task<bool> DeletePost(int id)
    //    {
    //        var currentPost = await GetPost(id);
    //        _context.Posts.Remove(currentPost);
    //        int rows = await _context.SaveChangesAsync();
    //        return rows > 0;
    //    }


    //}
}
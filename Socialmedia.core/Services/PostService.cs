using Microsoft.Extensions.Options;
using Socialmedia.core.CustomEntities;
using Socialmedia.core.Exceptions;
using Socialmedia.core.Interfaces;
using Socialmedia.core.QueryFilters;
using Socialmedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialmedia.core.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;

        public PostService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }



        public async Task<Post> GetPost(int id)
        {
            return await _unitOfWork.PostRepository.GetById(id);
        }

        public PagedList<Post> GetPosts(PostQueryFilter filters)
        {
            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var posts = _unitOfWork.PostRepository.GetAll();

            if (filters.UserId != null)
            {
                posts = posts.Where(x => x.UserId == filters.UserId);
            }

            if (filters.Date != null)
            {
                posts = posts.Where(x => x.Date.ToShortDateString() == filters.Date?.ToShortDateString());
            }

            if (filters.Description != null)
            {
                posts = posts.Where(x => x.Description.ToLower().Contains(filters.Description.ToLower()));
            }

            var pagedPosts = PagedList<Post>.Create(posts, filters.PageNumber, filters.PageSize);
            return pagedPosts;
        }
        public async Task InsertPost(Post post)
        {
            var user = await _unitOfWork.UseerRepository.GetById(post.UserId);

            if (user == null)
            {
                throw new BussinesException("Usuario no existe");
            }

            var userPost = await _unitOfWork.PostRepository.GetPostsByUser(post.UserId);
            if(userPost.Count() < 10)
            {
                var lastPost = userPost.OrderByDescending(x=> x.Date).FirstOrDefault();
                if ((DateTime.Now - lastPost.Date).TotalDays < 7)
                {
                    throw new BussinesException("No puedes publicar");
                }
            }

            if (post.Description.Contains("Sexo"))
            {
                throw new BussinesException("Contenido no permitido");
            }


            await _unitOfWork.PostRepository.Add(post);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdatePost(Post post)
        {
            var existPost = await _unitOfWork.PostRepository.GetById(post.Id);
            //solo estas se pueden editar
            existPost.Description = post.Description;
            existPost.Image = post.Image;
            _unitOfWork.PostRepository.Update(existPost);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeletePost(int id)
        {
            await _unitOfWork.PostRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }


    }
}

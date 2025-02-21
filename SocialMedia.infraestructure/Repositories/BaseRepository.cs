﻿using Microsoft.EntityFrameworkCore;
using Socialmedia.core.Entities;
using Socialmedia.core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.infraestructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SocialMediaContext _context;
        protected DbSet<T> _entities;
        public BaseRepository(SocialMediaContext context)
        {
            _context = context;
            _entities = context.Set<T>();

        }
        //public async Task<IEnumerable<T>> GetAll()
        //{
        //    return await _entities.ToListAsync();
        //}
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }
        public async Task Add(T entity)
        {
            _entities.AddAsync(entity);
            //await _context.SaveChangesAsync();
        }
        //public async Task Update(T entity)
        //{
        //    _entities.Update(entity);
        //    await _context.SaveChangesAsync();
        //}
        public void Update(T entity)
        {
            _entities.Update(entity);
        }
        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
        }
    }
}

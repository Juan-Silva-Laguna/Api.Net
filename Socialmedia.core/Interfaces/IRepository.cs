﻿using Socialmedia.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialmedia.core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        //Task<IEnumerable<T>> GetAll();
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        //Task Update(T entity);
        void Update(T entity);
        Task Delete(int id);
        

    }
}

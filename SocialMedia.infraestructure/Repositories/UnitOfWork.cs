using Socialmedia.core.Interfaces;
using Socialmedia.Core.Entities;
using Socialmedia.Infrastructure.Repositories;
using SocialMedia.core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.infrastructure.Repositories;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.infraestructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SocialMediaContext _context;
        private readonly IPostRepository _postRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Comment> _commentRepository;
        private readonly ISecurityRepository _securitytRepository;

        public UnitOfWork(SocialMediaContext context)
        {
            _context = context; 
        }
        public IPostRepository PostRepository => _postRepository ?? new PostRepository(_context);

        public IRepository<User> UseerRepository => _userRepository ?? new BaseRepository<User>(_context);

        public IRepository<Comment> CommentRepository => _commentRepository ?? new BaseRepository<Comment>(_context);

        public ISecurityRepository SecurityRepository => _securitytRepository ?? new SecurityRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();    
        }
    }
}

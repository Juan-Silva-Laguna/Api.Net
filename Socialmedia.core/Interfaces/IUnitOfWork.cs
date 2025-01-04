using Socialmedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Socialmedia.core.Interfaces
{
    public interface IUnitOfWork :  IDisposable
    {
        IPostRepository PostRepository { get; }
        IRepository<User> UseerRepository { get; }

        IRepository<Comment> CommentRepository { get; }
        ISecurityRepository SecurityRepository { get; }
        void SaveChanges();

        Task SaveChangesAsync();
    }
}

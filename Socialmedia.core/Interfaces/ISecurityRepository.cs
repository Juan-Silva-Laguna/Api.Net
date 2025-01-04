using Socialmedia.core.Entities;
using SocialMedia.core.Entities;
using Socialmedia.core.Interfaces;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface ISecurityRepository : IRepository<Security>
    {
        Task<Security> GetLoginByCredentials(UserLogin login);
    }
}
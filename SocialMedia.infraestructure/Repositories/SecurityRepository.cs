using Microsoft.EntityFrameworkCore;
using Socialmedia.core.Entities;
using SocialMedia.core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.infraestructure.Repositories;
using SocialMedia.Infrastructure.Data;
using System.Threading.Tasks;

namespace SocialMedia.infrastructure.Repositories
{
    public class SecurityRepository : BaseRepository<Security>, ISecurityRepository
    {
        public SecurityRepository(SocialMediaContext context) : base(context) { }

        public async Task<Security> GetLoginByCredentials(UserLogin login)
        {
            return await _entities.FirstOrDefaultAsync(x => x.User == login.User);
        }
    }
}
using Socialmedia.core.Entities;
using SocialMedia.core.Entities;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface ISecurityService
    {
        Task<Security> GetLoginByCredentials(UserLogin userLogin);
        Task RegisterUser(Security security);
    }
}
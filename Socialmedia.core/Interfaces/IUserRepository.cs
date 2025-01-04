using Socialmedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socialmedia.core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
    }
}
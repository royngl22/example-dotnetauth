using DotnetAuthExample.AuthExampleDBContext;
using DotnetAuthExample.Interfaces;
using DotnetAuthExample.Models;

namespace DotnetAuthExample.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthExampleContext _authExampleDBContext;

        public UserRepository(AuthExampleContext authExampleDBContext)
        {
            _authExampleDBContext = authExampleDBContext;
        }
        public List<UserModels> GetUser()
        {

            List<UserModels> data = (from user in _authExampleDBContext.UserTbls
                                     select new UserModels()
                                     {
                                         Email = user.Email,
                                         Password = user.Password,
                                         Role = user.Role,
                                     }
                           ).ToList();
            return data;
        }
    }
}

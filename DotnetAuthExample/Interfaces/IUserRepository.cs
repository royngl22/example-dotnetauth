using DotnetAuthExample.Models;

namespace DotnetAuthExample.Interfaces
{
    public interface IUserRepository
    {
        List<UserModels> GetUser();
    }
}

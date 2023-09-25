using DotnetAuthExample.Interfaces;
using DotnetAuthExample.Models;
using System.Net;

namespace DotnetAuthExample.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _iUserRepository;

        public UserServices(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }
        public GetUserResponse GetUserService()
        {
            GetUserResponse response = new GetUserResponse();

            try
            {
                var userData = _iUserRepository.GetUser();
                if (userData != null)
                {
                    response.Status = true;
                    response.Message = "Success";
                    response.Code = (int)HttpStatusCode.OK;
                    response.Data = userData;
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message.ToString();
                response.Code = (int)HttpStatusCode.InternalServerError;
            }

            return response;
        }
    }
}

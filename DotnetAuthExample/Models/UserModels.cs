namespace DotnetAuthExample.Models
{
    public class UserModels
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }

    public class GetUserResponse : BaseResponseModel
    {
        public List<UserModels>? Data { get; set; }
    }
}

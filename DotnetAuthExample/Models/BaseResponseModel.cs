using System.Net;

namespace DotnetAuthExample.Models
{
    public abstract class BaseResponseModel
    {
        public bool Status { get; set; } = false;
        public int Code { get; set; } = (int)HttpStatusCode.NotFound;
        public string? Message { get; set; } = "Failed";
    }
}

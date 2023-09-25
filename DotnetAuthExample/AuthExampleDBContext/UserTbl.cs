using System;
using System.Collections.Generic;

namespace DotnetAuthExample.AuthExampleDBContext
{
    public partial class UserTbl
    {
        public string Email { get; set; } = null!;
        public string? Password { get; set; }
        public string? Role { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}

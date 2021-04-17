using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Users
{
    public class RegisterViewModelInput
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }

    }
}

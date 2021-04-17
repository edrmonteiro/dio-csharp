using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Users
{
    public class LoginViewModelInput
    {
        public string User { get; set; }
        public string Pass { get; set; }
    }
}

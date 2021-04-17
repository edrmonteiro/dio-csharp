using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models
{
    public class ValidationViewModelOutput
    {
        public IEnumerable<string> Error { get; private set; }

        public ValidationViewModelOutput(IEnumerable<string> errors)
        {
            Error = errors;
        }
    }
}

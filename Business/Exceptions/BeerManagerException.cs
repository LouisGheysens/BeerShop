using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions {
    public class BeerManagerException: Exception {
        public BeerManagerException(string message) : base(message) {
        }

        public BeerManagerException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}

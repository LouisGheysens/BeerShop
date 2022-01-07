using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions {
    public class BeerException : Exception {
        public BeerException(string message) : base(message) {
        }

        public BeerException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task14APRIL
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}

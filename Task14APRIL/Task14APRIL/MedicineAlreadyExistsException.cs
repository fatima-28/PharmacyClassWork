using System;
using System.Collections.Generic;
using System.Text;

namespace Task14APRIL
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message):base(message)
        {

        }
    }
}

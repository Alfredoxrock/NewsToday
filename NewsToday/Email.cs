using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsToday
{
    class Email
    {
        public string email;

        public Email(string email_)
        {
            email = email_;
        }


        public string serlialize()
        {
            return email;
        }
    }
}

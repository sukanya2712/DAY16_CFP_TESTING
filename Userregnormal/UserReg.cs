using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Userregnormal
{
    public class UserReg
    {
        public bool FirstName(string name)
        {
            Regex Checkname = new Regex("^[A-Z][a-z]{2,}");
            Match match = Checkname.Match(name);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Email(string email)
        {
            Regex Checkemail = new Regex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$");
            Match match = Checkemail.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

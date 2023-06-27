using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    }
}

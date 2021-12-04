using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartPhonable
    {
        public string Calling(string number);

        public string Browsing(string URL);
    }
}

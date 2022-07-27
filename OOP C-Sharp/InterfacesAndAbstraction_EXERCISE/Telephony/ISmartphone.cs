using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone
    {
        public void CallingOtherPhones(string number);

        public void BrowsingTheInternet(string website);
    }
}

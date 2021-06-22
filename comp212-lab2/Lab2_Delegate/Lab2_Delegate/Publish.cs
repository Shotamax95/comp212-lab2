using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Delegate
{
    class Publish
    {
        public delegate void PublishMessageDel(string msg, string subscriber);

        public PublishMessageDel publishMsg = null;

        public void PublishMessage(string message, string subscriber)
        {
            publishMsg.Invoke(message, subscriber);
        }
    }
}

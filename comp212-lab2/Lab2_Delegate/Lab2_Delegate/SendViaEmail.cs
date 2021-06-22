using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Delegate
{
    class SendViaEmail
    {
        public String EmailAddress { get; set; }

        public SendViaEmail() { }

        public SendViaEmail(String emailAddress)
        {
            EmailAddress = emailAddress;
        }

        // Subscribe
        public int Subscribe(List<string> Subscribers)
        {
            bool checkEmail = Subscribers.Contains(EmailAddress);
            int index = 0;
            if (checkEmail)
            {
                index = 1; 
            }
            else
            {
                Subscribers.Add(EmailAddress);
            }
            return index;
        }

        // Unsubscribe
        public int Unsubscribe(List<string> Subscribers)
        {
            int index = Subscribers.IndexOf(EmailAddress);
            if (index > 0 || index == 0)
            {
                Subscribers.RemoveAt(index);
            }
            return index;
        }

    }
}

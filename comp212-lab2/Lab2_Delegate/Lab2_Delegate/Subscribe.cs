using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Delegate
{
    class Subscribe
    {
        public static List<string> Subscribers = new List<string>();
        public int returnState;
        public string warningMsg;


        public delegate string SubscribeDelegate(string value, string value2);

        // Get type email or phone
        public SubscribeDelegate GetSubscribeDelegate(string type)
        {
            SubscribeDelegate subscribeDelegate = null;

            switch (type)
            {
                case "email":
                    subscribeDelegate = SubscribeByEmail;
                    break;

                case "phone":
                    subscribeDelegate = SubscribeByPhone;
                    break;

                default:
                    break;
            }
            return subscribeDelegate;
        }

        // Subscribe By e-mail
        public string SubscribeByEmail(string emailAddress, string state)
        {
            SendViaEmail sendViaEmail = new SendViaEmail(emailAddress);

            switch (state)
            {
                case "subscribe":
                    returnState = sendViaEmail.Subscribe(Subscribers);
                    if (returnState == 1)
                    {
                        warningMsg = $"{emailAddress} is existed";
                    }
                    else
                    {
                        warningMsg = $"Subscribed: {emailAddress}. Thank you.";
                    }
                    break;

                case "unsubscribe":
                    returnState = sendViaEmail.Unsubscribe(Subscribers);
                    if (returnState < 0)
                    {
                        warningMsg = $"{emailAddress} does not exist";
                    }
                    else
                    {
                        warningMsg = $"Unsubscribed: {emailAddress}.";
                    }
                    break;

                default:
                    break;
            }
            return warningMsg;
        }

        // Subscribe by Phone
        public string SubscribeByPhone(string number, string state)
        {
            SendViaMobile sendViaMobile = new SendViaMobile(number);

            switch(state)
            {
                case "subscribe":
                    returnState = sendViaMobile.Subscribe(Subscribers);
                    if (returnState == 1)
                    {
                        warningMsg = $"{number} is existed";
                    }
                    else
                    {
                        warningMsg = $"Subscribed: {number}. Thank you.";
                    }
                    break;

                case "unsubscribe":
                    returnState = sendViaMobile.Unsubscribe(Subscribers);
                    if (returnState < 0)
                    {
                        warningMsg = $"{number} does not exist";
                    }
                    else
                    {
                        warningMsg = $"Unsubscribed: {number}.";
                    }
                    break;

                default:
                    break;
            }
            return warningMsg;
        }

    }
}

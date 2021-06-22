using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Delegate
{
    class SendViaMobile
    {
        public String Phone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            Phone = phone;
        }

        // Subscribe
        public int Subscribe(List<string> Subscribers)
        {
            bool checkPhone = Subscribers.Contains(Phone);
            int index = 0;

            if (checkPhone)
            {
                index = 0; 
            }
            else
            {
                Subscribers.Add(Phone);
            }
            return index;
        }

        // Unsubscribe
        public int Unsubscribe(List<string> Subscribers)
        {
            int index = Subscribers.IndexOf(Phone);
            if (index > 0 || index == 0)
            {
                Subscribers.RemoveAt(index);
            }
            return index;
        }
    }
}

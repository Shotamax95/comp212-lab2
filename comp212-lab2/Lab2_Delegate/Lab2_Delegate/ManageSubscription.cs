using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Delegate
{
    public partial class ManageSubscription : Form
    {
        public ManageSubscription()
        {
            InitializeComponent();
        }

        public bool checkedEmail;
        public bool checkedPhone;
        
        // E-mail check box 
        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            checkedEmail = checkBoxEmail.Checked;
            // Subscribe and Unsbscribe button are clikable if user checked
            if (checkedEmail == true)
            {
                subscribeButton.Enabled = true;
                unsubscribeButton.Enabled = true;
            }
        }

        // Phone check box
        private void checkBoxMobile_CheckedChanged(object sender, EventArgs e)
        {
            checkedPhone = checkBoxMobile.Checked;
            // Subscribe and Unsbscribe button are clikable if user checked
            if (checkedPhone == true)
            {
                subscribeButton.Enabled = true;
                unsubscribeButton.Enabled = true;
            }
        }

        // Subscribe button
        private void subscribeButton_Click(object sender, EventArgs e)
        {
            string inputEmail = txtEmail.Text;
            string inputPhoe = txtMobile.Text;
            Subscribe subscribe = new Subscribe();

            if (checkedEmail)
            {
                EmailNotification(inputEmail, "subscribe", subscribe);
            }
            else if (checkedPhone)
            {
                MobileNotification(inputPhoe, "subscribe", subscribe);
            }
            else
            {
                errorTxtEmail.Text = "Please try again";
                return;
            }
            // clear textBox
            txtEmail.Text = "";
            txtMobile.Text = "";
        }

        // Unsubscribe button
        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            string inputEmail = txtEmail.Text;
            string inputPhone = txtMobile.Text;
            Subscribe subscribe = new Subscribe();

            if (checkedEmail)
            {
                EmailNotification(inputEmail, "unsubscribe", subscribe);
            }
            else if (checkedPhone)
            {
                MobileNotification(inputPhone, "unsubscribe", subscribe);
            }
            else
            {
                errorTxtEmail.Text = "Please try again";
            }
            // clear textBox
            txtEmail.Text = "";
            txtMobile.Text = "";
        }

     
        private void EmailNotification(string inputEmail, string subscribeType, Subscribe subscribe)
        {
            // if email is not empty
            if (inputEmail != "")
            {
                // if Regex is true
                if (!InputRegex(inputEmail, "email"))
                {
                    errorTxtEmail.Text = "Please follow this formatting: example@canada.ca";
                    return;
                }
                string returnMessage = subscribe.GetSubscribeDelegate("email").Invoke(inputEmail, subscribeType);
                txtResult.Text = returnMessage;
                return;
            }
            else
            {
                txtResult.Text = "Please enter your e-mail address.";
                return;
            }
        }

        // Notification phone method
        private void MobileNotification(string inputPhone, string subscribeType, Subscribe subscribe)
        {
            // if phone num is not empty
            if (inputPhone != "")
            {
                // if Regex is true
                if (!InputRegex(inputPhone, "phone"))
                {
                    errorTxtPhone.Text = "Please follow this formatting: 123-456-789";
                    return;
                }
                string returnMessage = subscribe.GetSubscribeDelegate("phone").Invoke(inputPhone, subscribeType);
                txtResult.Text = returnMessage;
                return;
            }
            else
            {
                txtResult.Text = "Please enter your phone number.";
                return;
            }
        }

        // Regex Phone and e-mail
        private bool InputRegex(string input, string value)
        {
            bool validation = true;

            switch (value)
            {
                case "email":
                    validation = Regex.IsMatch(input,@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                    break;
                case "phone":
                    validation = Regex.IsMatch(input,"^\\d{3}-\\d{3}-\\d{2}\\d{2}$");
                    break;
            }
            return validation;
        }

        // Back to Main menu button
        private void backToWindowButton_Click(object sender, EventArgs e)
        {
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Show();
            this.Hide();
        }

        // Subscribe and Unsubscribe button are unclickable when load.
        private void ManageSubscription_Load(object sender, EventArgs e)
        {
            subscribeButton.Enabled = false;
            unsubscribeButton.Enabled = false;
        }
    }
}

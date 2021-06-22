using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Delegate
{
    public partial class NotificationManager : Form
    {
        public NotificationManager()
        {
            InitializeComponent();
        }

        // Manage Subscription button to open 
        private void manageSubscriptionButton_Click(object sender, EventArgs e)
        {
            ManageSubscription manageSubscription = new ManageSubscription();
            manageSubscription.Show();
            this.Hide();
        }

        // Publish Notification button to open
        private void publishNotificationButton_Click(object sender, EventArgs e)
        {
            PublishNotification publishNotification = new PublishNotification();
            publishNotification.Show();
            this.Hide();
        }

        // Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // As there is no subscriber when the app just launches, “Publish Notification” button is disabled.
        private void NotificationManager_Load_1(object sender, EventArgs e)
        {
            if (Subscribe.Subscribers.Count > 0)
            {
                publishNotificationButton.Enabled = true;
            }
            else
            {
                publishNotificationButton.Enabled = false;
            }
        }

    }
}

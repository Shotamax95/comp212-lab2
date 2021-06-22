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
    public partial class PublishNotification : Form
    {
        public PublishNotification()
        {
            InitializeComponent();
        }

        // Publish button
        private void publishButton_Click(object sender, EventArgs e)
        {
            string txtAllSubscribers = "";

            foreach(string subscriber in Subscribe.Subscribers)
            {
                txtAllSubscribers += $"{subscriber}" + Environment.NewLine;
            }
            txtSubscribers.AppendText(txtAllSubscribers);
        }

        // Back to Main Menu
        private void backToWindowButton_Click(object sender, EventArgs e)
        {
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Show();
            this.Hide();
        }

    }
}

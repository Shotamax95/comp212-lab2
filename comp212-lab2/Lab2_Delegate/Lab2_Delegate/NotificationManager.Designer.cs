
namespace Lab2_Delegate
{
    partial class NotificationManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manageSubscriptionButton = new System.Windows.Forms.Button();
            this.publishNotificationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manageSubscriptionButton
            // 
            this.manageSubscriptionButton.BackColor = System.Drawing.Color.Salmon;
            this.manageSubscriptionButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageSubscriptionButton.Location = new System.Drawing.Point(40, 104);
            this.manageSubscriptionButton.Name = "manageSubscriptionButton";
            this.manageSubscriptionButton.Size = new System.Drawing.Size(183, 68);
            this.manageSubscriptionButton.TabIndex = 0;
            this.manageSubscriptionButton.Text = "Manage Subscription";
            this.manageSubscriptionButton.UseVisualStyleBackColor = false;
            this.manageSubscriptionButton.Click += new System.EventHandler(this.manageSubscriptionButton_Click);
            // 
            // publishNotificationButton
            // 
            this.publishNotificationButton.BackColor = System.Drawing.Color.Salmon;
            this.publishNotificationButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publishNotificationButton.Location = new System.Drawing.Point(298, 104);
            this.publishNotificationButton.Name = "publishNotificationButton";
            this.publishNotificationButton.Size = new System.Drawing.Size(183, 68);
            this.publishNotificationButton.TabIndex = 1;
            this.publishNotificationButton.Text = "Publish Notification";
            this.publishNotificationButton.UseVisualStyleBackColor = false;
            this.publishNotificationButton.Click += new System.EventHandler(this.publishNotificationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(542, 104);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 68);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(148, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Subscribe Application";
            // 
            // NotificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publishNotificationButton);
            this.Controls.Add(this.manageSubscriptionButton);
            this.Name = "NotificationManager";
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.NotificationManager_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageSubscriptionButton;
        private System.Windows.Forms.Button publishNotificationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}
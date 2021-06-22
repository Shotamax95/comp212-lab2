
namespace Lab2_Delegate
{
    partial class PublishNotification
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
            this.txtSubscribers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotificationDetails = new System.Windows.Forms.TextBox();
            this.publishButton = new System.Windows.Forms.Button();
            this.backToWindowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSubscribers
            // 
            this.txtSubscribers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSubscribers.Location = new System.Drawing.Point(40, 301);
            this.txtSubscribers.Multiline = true;
            this.txtSubscribers.Name = "txtSubscribers";
            this.txtSubscribers.Size = new System.Drawing.Size(697, 191);
            this.txtSubscribers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notification Details:";
            // 
            // txtNotificationDetails
            // 
            this.txtNotificationDetails.Location = new System.Drawing.Point(40, 69);
            this.txtNotificationDetails.Multiline = true;
            this.txtNotificationDetails.Name = "txtNotificationDetails";
            this.txtNotificationDetails.Size = new System.Drawing.Size(697, 68);
            this.txtNotificationDetails.TabIndex = 2;
            // 
            // publishButton
            // 
            this.publishButton.BackColor = System.Drawing.Color.Salmon;
            this.publishButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publishButton.Location = new System.Drawing.Point(124, 166);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(186, 68);
            this.publishButton.TabIndex = 3;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = false;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // backToWindowButton
            // 
            this.backToWindowButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToWindowButton.Location = new System.Drawing.Point(460, 166);
            this.backToWindowButton.Name = "backToWindowButton";
            this.backToWindowButton.Size = new System.Drawing.Size(186, 68);
            this.backToWindowButton.TabIndex = 4;
            this.backToWindowButton.Text = "Back to Main Window";
            this.backToWindowButton.UseVisualStyleBackColor = true;
            this.backToWindowButton.Click += new System.EventHandler(this.backToWindowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notification has been sent to following subscribers:";
            // 
            // PublishNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backToWindowButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.txtNotificationDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubscribers);
            this.Name = "PublishNotification";
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubscribers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotificationDetails;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button backToWindowButton;
        private System.Windows.Forms.Label label2;
    }
}
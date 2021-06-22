
namespace Lab2_Delegate
{
    partial class ManageSubscription
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
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxMobile = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.backToWindowButton = new System.Windows.Forms.Button();
            this.errorTxtEmail = new System.Windows.Forms.Label();
            this.errorTxtPhone = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEmail.Location = new System.Drawing.Point(38, 64);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(227, 25);
            this.checkBoxEmail.TabIndex = 0;
            this.checkBoxEmail.Text = "E-mail Notification to: ";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            this.checkBoxEmail.CheckedChanged += new System.EventHandler(this.checkBoxEmail_CheckedChanged);
            // 
            // checkBoxMobile
            // 
            this.checkBoxMobile.AutoSize = true;
            this.checkBoxMobile.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMobile.Location = new System.Drawing.Point(38, 176);
            this.checkBoxMobile.Name = "checkBoxMobile";
            this.checkBoxMobile.Size = new System.Drawing.Size(203, 25);
            this.checkBoxMobile.TabIndex = 1;
            this.checkBoxMobile.Text = "Text Notification to:";
            this.checkBoxMobile.UseVisualStyleBackColor = true;
            this.checkBoxMobile.CheckedChanged += new System.EventHandler(this.checkBoxMobile_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(283, 64);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMobile.Location = new System.Drawing.Point(283, 176);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(357, 25);
            this.txtMobile.TabIndex = 3;
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unsubscribeButton.Location = new System.Drawing.Point(283, 362);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(183, 68);
            this.unsubscribeButton.TabIndex = 5;
            this.unsubscribeButton.Text = "Unsbscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // backToWindowButton
            // 
            this.backToWindowButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToWindowButton.Location = new System.Drawing.Point(517, 362);
            this.backToWindowButton.Name = "backToWindowButton";
            this.backToWindowButton.Size = new System.Drawing.Size(183, 68);
            this.backToWindowButton.TabIndex = 6;
            this.backToWindowButton.Text = "Back to Main Window";
            this.backToWindowButton.UseVisualStyleBackColor = true;
            this.backToWindowButton.Click += new System.EventHandler(this.backToWindowButton_Click);
            // 
            // errorTxtEmail
            // 
            this.errorTxtEmail.AutoSize = true;
            this.errorTxtEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorTxtEmail.ForeColor = System.Drawing.Color.Red;
            this.errorTxtEmail.Location = new System.Drawing.Point(283, 106);
            this.errorTxtEmail.Name = "errorTxtEmail";
            this.errorTxtEmail.Size = new System.Drawing.Size(0, 19);
            this.errorTxtEmail.TabIndex = 7;
            // 
            // errorTxtPhone
            // 
            this.errorTxtPhone.AutoSize = true;
            this.errorTxtPhone.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorTxtPhone.ForeColor = System.Drawing.Color.Red;
            this.errorTxtPhone.Location = new System.Drawing.Point(283, 221);
            this.errorTxtPhone.Name = "errorTxtPhone";
            this.errorTxtPhone.Size = new System.Drawing.Size(0, 19);
            this.errorTxtPhone.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(58, 302);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(0, 25);
            this.txtResult.TabIndex = 9;
            // 
            // subscribeButton
            // 
            this.subscribeButton.BackColor = System.Drawing.Color.Salmon;
            this.subscribeButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subscribeButton.Location = new System.Drawing.Point(58, 362);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(183, 68);
            this.subscribeButton.TabIndex = 4;
            this.subscribeButton.Text = "Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = false;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // ManageSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 464);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.errorTxtPhone);
            this.Controls.Add(this.errorTxtEmail);
            this.Controls.Add(this.backToWindowButton);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.checkBoxMobile);
            this.Controls.Add(this.checkBoxEmail);
            this.Name = "ManageSubscription";
            this.Text = "Manage Subscription";
            this.Load += new System.EventHandler(this.ManageSubscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button backToWindowButton;
        private System.Windows.Forms.Label errorTxtEmail;
        private System.Windows.Forms.Label errorTxtPhone;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button subscribeButton;
    }
}
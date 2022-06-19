namespace CorvusV2
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.updatePlayerBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration Controls";
            // 
            // updatePlayerBtn
            // 
            this.updatePlayerBtn.Location = new System.Drawing.Point(41, 130);
            this.updatePlayerBtn.Name = "updatePlayerBtn";
            this.updatePlayerBtn.Size = new System.Drawing.Size(313, 58);
            this.updatePlayerBtn.TabIndex = 1;
            this.updatePlayerBtn.Text = "Update Player";
            this.updatePlayerBtn.UseVisualStyleBackColor = true;
            this.updatePlayerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(313, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Get All Users";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(313, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(735, 130);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(250, 47);
            this.usernameText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(735, 204);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(250, 47);
            this.passwordText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(577, 207);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(143, 41);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(735, 284);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(250, 47);
            this.EmailText.TabIndex = 10;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 578);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updatePlayerBtn);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button updatePlayerBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label label2;
        private Label Password;
        private Label label3;
        private TextBox EmailText;
    }
}
namespace EuipmentRentApp
{
    partial class MemberLoginWithUsername
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
            this.gb_Login = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.gb_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Login
            // 
            this.gb_Login.Controls.Add(this.btn_Clear);
            this.gb_Login.Controls.Add(this.lbl_Username);
            this.gb_Login.Controls.Add(this.btn_Login);
            this.gb_Login.Controls.Add(this.lbl_Password);
            this.gb_Login.Controls.Add(this.txt_Password);
            this.gb_Login.Controls.Add(this.txt_Username);
            this.gb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gb_Login.Location = new System.Drawing.Point(42, 53);
            this.gb_Login.Name = "gb_Login";
            this.gb_Login.Size = new System.Drawing.Size(386, 214);
            this.gb_Login.TabIndex = 6;
            this.gb_Login.TabStop = false;
            this.gb_Login.Text = "Log in";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(251, 138);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(84, 29);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear ";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(39, 47);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(83, 16);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(150, 138);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(84, 29);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(39, 83);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(80, 16);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(150, 80);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(185, 22);
            this.txt_Password.TabIndex = 3;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(150, 47);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(185, 22);
            this.txt_Username.TabIndex = 2;
            // 
            // MemberLoginWithUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 298);
            this.Controls.Add(this.gb_Login);
            this.Name = "MemberLoginWithUsername";
            this.Text = "MemberLoginWithUsername";
            this.gb_Login.ResumeLayout(false);
            this.gb_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Login;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
    }
}
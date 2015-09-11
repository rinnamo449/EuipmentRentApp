namespace EuipmentRentApp
{
    partial class MemberLoginForm
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
            this.components = new System.ComponentModel.Container();
            this.lbl_RfidNumber = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_RfidNumber = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.gb_Login = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gb_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RfidNumber
            // 
            this.lbl_RfidNumber.AutoSize = true;
            this.lbl_RfidNumber.Location = new System.Drawing.Point(39, 47);
            this.lbl_RfidNumber.Name = "lbl_RfidNumber";
            this.lbl_RfidNumber.Size = new System.Drawing.Size(105, 16);
            this.lbl_RfidNumber.TabIndex = 0;
            this.lbl_RfidNumber.Text = "RFID Number:";
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
            // txt_RfidNumber
            // 
            this.txt_RfidNumber.Location = new System.Drawing.Point(150, 47);
            this.txt_RfidNumber.Name = "txt_RfidNumber";
            this.txt_RfidNumber.Size = new System.Drawing.Size(185, 22);
            this.txt_RfidNumber.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(150, 80);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(185, 22);
            this.txt_Password.TabIndex = 3;
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
            // gb_Login
            // 
            this.gb_Login.Controls.Add(this.btn_Clear);
            this.gb_Login.Controls.Add(this.lbl_RfidNumber);
            this.gb_Login.Controls.Add(this.btn_Login);
            this.gb_Login.Controls.Add(this.lbl_Password);
            this.gb_Login.Controls.Add(this.txt_Password);
            this.gb_Login.Controls.Add(this.txt_RfidNumber);
            this.gb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gb_Login.Location = new System.Drawing.Point(67, 66);
            this.gb_Login.Name = "gb_Login";
            this.gb_Login.Size = new System.Drawing.Size(386, 214);
            this.gb_Login.TabIndex = 5;
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
            this.btn_Clear.Click += new System.EventHandler(this.btn_ClearRfid_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MemberLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 317);
            this.Controls.Add(this.gb_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "MemberLoginForm";
            this.RightToLeftLayout = true;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.MemberLoginForm_Load);
            this.gb_Login.ResumeLayout(false);
            this.gb_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RfidNumber;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_RfidNumber;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.GroupBox gb_Login;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Clear;
    }
}
namespace EuipmentRentApp
{
    partial class SignUpForm
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
            this.lbl_Firstname = new System.Windows.Forms.Label();
            this.lbl_Lastname = new System.Windows.Forms.Label();
            this.lbl_Rfidnumber = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_Rfidnumber = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_FirstnameValidation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Firstname.Location = new System.Drawing.Point(16, 32);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(80, 16);
            this.lbl_Firstname.TabIndex = 0;
            this.lbl_Firstname.Text = "Firstname:";
            // 
            // lbl_Lastname
            // 
            this.lbl_Lastname.AutoSize = true;
            this.lbl_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Lastname.Location = new System.Drawing.Point(17, 83);
            this.lbl_Lastname.Name = "lbl_Lastname";
            this.lbl_Lastname.Size = new System.Drawing.Size(79, 16);
            this.lbl_Lastname.TabIndex = 1;
            this.lbl_Lastname.Text = "Lastname:";
            // 
            // lbl_Rfidnumber
            // 
            this.lbl_Rfidnumber.AutoSize = true;
            this.lbl_Rfidnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Rfidnumber.Location = new System.Drawing.Point(17, 133);
            this.lbl_Rfidnumber.Name = "lbl_Rfidnumber";
            this.lbl_Rfidnumber.Size = new System.Drawing.Size(102, 16);
            this.lbl_Rfidnumber.TabIndex = 2;
            this.lbl_Rfidnumber.Text = "RFID number:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Password.Location = new System.Drawing.Point(17, 179);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(80, 16);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_Firstname.Location = new System.Drawing.Point(132, 32);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(160, 22);
            this.txt_Firstname.TabIndex = 4;
            this.txt_Firstname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Firstname_Validating);
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_Lastname.Location = new System.Drawing.Point(132, 83);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(160, 22);
            this.txt_Lastname.TabIndex = 5;
            // 
            // txt_Rfidnumber
            // 
            this.txt_Rfidnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_Rfidnumber.Location = new System.Drawing.Point(132, 133);
            this.txt_Rfidnumber.Name = "txt_Rfidnumber";
            this.txt_Rfidnumber.Size = new System.Drawing.Size(160, 22);
            this.txt_Rfidnumber.TabIndex = 6;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_Password.Location = new System.Drawing.Point(132, 179);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(160, 22);
            this.txt_Password.TabIndex = 7;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(132, 242);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 8;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_FirstnameValidation);
            this.groupBox1.Controls.Add(this.btn_SignUp);
            this.groupBox1.Controls.Add(this.lbl_Firstname);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.lbl_Lastname);
            this.groupBox1.Controls.Add(this.txt_Rfidnumber);
            this.groupBox1.Controls.Add(this.lbl_Rfidnumber);
            this.groupBox1.Controls.Add(this.txt_Lastname);
            this.groupBox1.Controls.Add(this.lbl_Password);
            this.groupBox1.Controls.Add(this.txt_Firstname);
            this.groupBox1.Location = new System.Drawing.Point(23, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_FirstnameValidation
            // 
            this.lbl_FirstnameValidation.AutoSize = true;
            this.lbl_FirstnameValidation.ForeColor = System.Drawing.Color.Red;
            this.lbl_FirstnameValidation.Location = new System.Drawing.Point(316, 41);
            this.lbl_FirstnameValidation.Name = "lbl_FirstnameValidation";
            this.lbl_FirstnameValidation.Size = new System.Drawing.Size(0, 13);
            this.lbl_FirstnameValidation.TabIndex = 9;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 346);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignUpForm";
            this.Text = "Sign up ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Firstname;
        private System.Windows.Forms.Label lbl_Lastname;
        private System.Windows.Forms.Label lbl_Rfidnumber;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Rfidnumber;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_FirstnameValidation;
    }
}
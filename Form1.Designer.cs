namespace EuipmentRentApp
{
    partial class StartWindow
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
            this.btn_Member = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Member
            // 
            this.btn_Member.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Member.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Member.Location = new System.Drawing.Point(34, 69);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(99, 71);
            this.btn_Member.TabIndex = 0;
            this.btn_Member.Text = "Member";
            this.btn_Member.UseVisualStyleBackColor = true;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Admin.Location = new System.Drawing.Point(167, 69);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(99, 71);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 218);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Member);
            this.Name = "StartWindow";
            this.Text = "Start Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Member;
        private System.Windows.Forms.Button btn_Admin;
    }
}


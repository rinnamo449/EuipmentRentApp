namespace EuipmentRentApp
{
    partial class DoOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_YourItem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_YourItem = new System.Windows.Forms.Label();
            this.txt_WantedAmount = new System.Windows.Forms.TextBox();
            this.lbl_WantedAmount = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(227, 128);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_YourItem
            // 
            this.txt_YourItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_YourItem.Location = new System.Drawing.Point(364, 57);
            this.txt_YourItem.Name = "txt_YourItem";
            this.txt_YourItem.Size = new System.Drawing.Size(100, 22);
            this.txt_YourItem.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(485, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(485, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(175, 153);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(256, 210);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(137, 203);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "submit order to database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_YourItem
            // 
            this.lbl_YourItem.AutoSize = true;
            this.lbl_YourItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_YourItem.Location = new System.Drawing.Point(277, 57);
            this.lbl_YourItem.Name = "lbl_YourItem";
            this.lbl_YourItem.Size = new System.Drawing.Size(81, 16);
            this.lbl_YourItem.TabIndex = 8;
            this.lbl_YourItem.Text = "Your Item: ";
            // 
            // txt_WantedAmount
            // 
            this.txt_WantedAmount.Location = new System.Drawing.Point(604, 60);
            this.txt_WantedAmount.Name = "txt_WantedAmount";
            this.txt_WantedAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_WantedAmount.TabIndex = 10;
            // 
            // lbl_WantedAmount
            // 
            this.lbl_WantedAmount.AutoSize = true;
            this.lbl_WantedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_WantedAmount.Location = new System.Drawing.Point(482, 60);
            this.lbl_WantedAmount.Name = "lbl_WantedAmount";
            this.lbl_WantedAmount.Size = new System.Drawing.Size(116, 16);
            this.lbl_WantedAmount.TabIndex = 11;
            this.lbl_WantedAmount.Text = "Wanted Amount";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            ""});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 199);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(183, 212);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "delete check item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 490);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbl_WantedAmount);
            this.Controls.Add(this.txt_WantedAmount);
            this.Controls.Add(this.lbl_YourItem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_YourItem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoOrder";
            this.Text = "DoOrder";
            this.Load += new System.EventHandler(this.DoOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_YourItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_YourItem;
        private System.Windows.Forms.TextBox txt_WantedAmount;
        private System.Windows.Forms.Label lbl_WantedAmount;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button4;
    }
}
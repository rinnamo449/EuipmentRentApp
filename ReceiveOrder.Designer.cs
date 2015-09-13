namespace EuipmentRentApp
{
    partial class ReceiveOrder
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ShowOrder = new System.Windows.Forms.Button();
            this.btn_UpdateItemData = new System.Windows.Forms.Button();
            this.lbl_OrderIdhere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(188, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(92, 131);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_ShowOrder
            // 
            this.btn_ShowOrder.Location = new System.Drawing.Point(47, 121);
            this.btn_ShowOrder.Name = "btn_ShowOrder";
            this.btn_ShowOrder.Size = new System.Drawing.Size(100, 33);
            this.btn_ShowOrder.TabIndex = 2;
            this.btn_ShowOrder.Text = "Show Order List";
            this.btn_ShowOrder.UseVisualStyleBackColor = true;
            this.btn_ShowOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_UpdateItemData
            // 
            this.btn_UpdateItemData.Location = new System.Drawing.Point(188, 232);
            this.btn_UpdateItemData.Name = "btn_UpdateItemData";
            this.btn_UpdateItemData.Size = new System.Drawing.Size(101, 31);
            this.btn_UpdateItemData.TabIndex = 3;
            this.btn_UpdateItemData.Text = "Update ITemData";
            this.btn_UpdateItemData.UseVisualStyleBackColor = true;
            this.btn_UpdateItemData.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_OrderIdhere
            // 
            this.lbl_OrderIdhere.AutoSize = true;
            this.lbl_OrderIdhere.Location = new System.Drawing.Point(43, 50);
            this.lbl_OrderIdhere.Name = "lbl_OrderIdhere";
            this.lbl_OrderIdhere.Size = new System.Drawing.Size(104, 13);
            this.lbl_OrderIdhere.TabIndex = 4;
            this.lbl_OrderIdhere.Text = "Fill the OrderID here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order List";
            // 
            // ReceiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_OrderIdhere);
            this.Controls.Add(this.btn_UpdateItemData);
            this.Controls.Add(this.btn_ShowOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ReceiveOrder";
            this.Text = "ReceiveOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ShowOrder;
        private System.Windows.Forms.Button btn_UpdateItemData;
        private System.Windows.Forms.Label lbl_OrderIdhere;
        private System.Windows.Forms.Label label1;
    }
}
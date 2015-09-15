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
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_SubmitToDataBase = new System.Windows.Forms.Button();
            this.lbl_YourItem = new System.Windows.Forms.Label();
            this.txt_WantedAmount = new System.Windows.Forms.TextBox();
            this.lbl_WantedAmount = new System.Windows.Forms.Label();
            this.btn_deleteCheckedItem = new System.Windows.Forms.Button();
            this.dgv_OrderList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(227, 119);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_YourItem
            // 
            this.txt_YourItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_YourItem.Location = new System.Drawing.Point(364, 57);
            this.txt_YourItem.Name = "txt_YourItem";
            this.txt_YourItem.ReadOnly = true;
            this.txt_YourItem.Size = new System.Drawing.Size(100, 22);
            this.txt_YourItem.TabIndex = 1;
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_AddOrder.Location = new System.Drawing.Point(280, 153);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(100, 24);
            this.btn_AddOrder.TabIndex = 3;
            this.btn_AddOrder.Text = "Add Order";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_SubmitToDataBase
            // 
            this.btn_SubmitToDataBase.Location = new System.Drawing.Point(233, 421);
            this.btn_SubmitToDataBase.Name = "btn_SubmitToDataBase";
            this.btn_SubmitToDataBase.Size = new System.Drawing.Size(137, 41);
            this.btn_SubmitToDataBase.TabIndex = 7;
            this.btn_SubmitToDataBase.Text = "submit order to database";
            this.btn_SubmitToDataBase.UseVisualStyleBackColor = true;
            this.btn_SubmitToDataBase.Click += new System.EventHandler(this.btn_SubmitToDataBase_Click);
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
            this.txt_WantedAmount.Location = new System.Drawing.Point(399, 108);
            this.txt_WantedAmount.Name = "txt_WantedAmount";
            this.txt_WantedAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_WantedAmount.TabIndex = 10;
            // 
            // lbl_WantedAmount
            // 
            this.lbl_WantedAmount.AutoSize = true;
            this.lbl_WantedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_WantedAmount.Location = new System.Drawing.Point(277, 109);
            this.lbl_WantedAmount.Name = "lbl_WantedAmount";
            this.lbl_WantedAmount.Size = new System.Drawing.Size(116, 16);
            this.lbl_WantedAmount.TabIndex = 11;
            this.lbl_WantedAmount.Text = "Wanted Amount";
            // 
            // btn_deleteCheckedItem
            // 
            this.btn_deleteCheckedItem.Location = new System.Drawing.Point(47, 421);
            this.btn_deleteCheckedItem.Name = "btn_deleteCheckedItem";
            this.btn_deleteCheckedItem.Size = new System.Drawing.Size(128, 41);
            this.btn_deleteCheckedItem.TabIndex = 13;
            this.btn_deleteCheckedItem.Text = "Delete Checked Item";
            this.btn_deleteCheckedItem.UseVisualStyleBackColor = true;
            this.btn_deleteCheckedItem.Click += new System.EventHandler(this.btn_deleteCheckedItem_Click);
            // 
            // dgv_OrderList
            // 
            this.dgv_OrderList.AllowUserToAddRows = false;
            this.dgv_OrderList.AllowUserToResizeColumns = false;
            this.dgv_OrderList.AllowUserToResizeRows = false;
            this.dgv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderList.Location = new System.Drawing.Point(47, 199);
            this.dgv_OrderList.Name = "dgv_OrderList";
            this.dgv_OrderList.RowHeadersVisible = false;
            this.dgv_OrderList.Size = new System.Drawing.Size(150, 170);
            this.dgv_OrderList.TabIndex = 14;
            // 
            // DoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 516);
            this.Controls.Add(this.dgv_OrderList);
            this.Controls.Add(this.btn_deleteCheckedItem);
            this.Controls.Add(this.lbl_WantedAmount);
            this.Controls.Add(this.txt_WantedAmount);
            this.Controls.Add(this.lbl_YourItem);
            this.Controls.Add(this.btn_SubmitToDataBase);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.txt_YourItem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoOrder";
            this.Text = "DoOrder";
            this.Load += new System.EventHandler(this.DoOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_YourItem;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_SubmitToDataBase;
        private System.Windows.Forms.Label lbl_YourItem;
        private System.Windows.Forms.TextBox txt_WantedAmount;
        private System.Windows.Forms.Label lbl_WantedAmount;
        private System.Windows.Forms.Button btn_deleteCheckedItem;
        private System.Windows.Forms.DataGridView dgv_OrderList;
    }
}
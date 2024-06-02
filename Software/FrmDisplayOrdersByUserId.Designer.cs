namespace Evaluation_Manager
{
    partial class FrmDisplayOrdersByUserId
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(50, 30);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 26);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.Text = "User ID";
            this.txtUserId.Enter += new System.EventHandler(this.txtUserId_Enter);
            this.txtUserId.Leave += new System.EventHandler(this.txtUserId_Leave);
            // 
            // btnLoadOrders
            // 
            this.btnLoadOrders.Location = new System.Drawing.Point(50, 70);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(200, 50);
            this.btnLoadOrders.TabIndex = 1;
            this.btnLoadOrders.Text = "Load Orders";
            this.btnLoadOrders.UseVisualStyleBackColor = true;
            this.btnLoadOrders.Click += new System.EventHandler(this.btnLoadOrders_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 140);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(776, 200);
            this.dgvOrders.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(326, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmDisplayOrdersByUserId
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnLoadOrders);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmDisplayOrdersByUserId";
            this.Text = "Display Orders by User ID";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

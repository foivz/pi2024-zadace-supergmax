namespace Evaluation_Manager
{
    partial class FrmOrderMeal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMealList;
        private System.Windows.Forms.Button btnOrder;
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
            this.dgvMealList = new System.Windows.Forms.DataGridView();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMealList
            // 
            this.dgvMealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealList.Location = new System.Drawing.Point(12, 12);
            this.dgvMealList.Name = "dgvMealList";
            this.dgvMealList.RowHeadersWidth = 62;
            this.dgvMealList.RowTemplate.Height = 28;
            this.dgvMealList.Size = new System.Drawing.Size(776, 200);
            this.dgvMealList.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(326, 218);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(143, 46);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order Meal";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(326, 280);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmOrderMeal
            // 
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvMealList);
            this.Name = "FrmOrderMeal";
            this.Text = "Order Meal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

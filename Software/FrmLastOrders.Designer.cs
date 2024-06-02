namespace Evaluation_Manager
{
    partial class FrmLastOrders
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOrderedMeals;
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
            this.dgvOrderedMeals = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderedMeals
            // 
            this.dgvOrderedMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderedMeals.Location = new System.Drawing.Point(12, 12);
            this.dgvOrderedMeals.Name = "dgvOrderedMeals";
            this.dgvOrderedMeals.RowHeadersWidth = 62;
            this.dgvOrderedMeals.RowTemplate.Height = 28;
            this.dgvOrderedMeals.Size = new System.Drawing.Size(776, 200);
            this.dgvOrderedMeals.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(326, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 46);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmLastOrders
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvOrderedMeals);
            this.Name = "FrmLastOrders";
            this.Text = "Last Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedMeals)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

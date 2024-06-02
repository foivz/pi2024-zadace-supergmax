namespace Evaluation_Manager
{
    partial class FrmDisplayAllMeals
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMeals;
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
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeals
            // 
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Location = new System.Drawing.Point(12, 12);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.RowHeadersWidth = 62;
            this.dgvMeals.RowTemplate.Height = 28;
            this.dgvMeals.Size = new System.Drawing.Size(776, 200);
            this.dgvMeals.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(326, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 46);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmDisplayAllMeals
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dgvMeals);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmDisplayAllMeals";
            this.Text = "Display All Meals";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

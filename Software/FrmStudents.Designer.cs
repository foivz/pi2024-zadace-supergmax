namespace Evaluation_Manager
{
    partial class FrmStudents
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvOrderedMeals = new System.Windows.Forms.DataGridView();
            this.btnOrderMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedMeals)).BeginInit();
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
            // dgvOrderedMeals
            // 
            this.dgvOrderedMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderedMeals.Location = new System.Drawing.Point(12, 270);
            this.dgvOrderedMeals.Name = "dgvOrderedMeals";
            this.dgvOrderedMeals.RowHeadersWidth = 62;
            this.dgvOrderedMeals.RowTemplate.Height = 28;
            this.dgvOrderedMeals.Size = new System.Drawing.Size(776, 200);
            this.dgvOrderedMeals.TabIndex = 1;
            // 
            // btnOrderMeal
            // 
            this.btnOrderMeal.Location = new System.Drawing.Point(326, 218);
            this.btnOrderMeal.Name = "btnOrderMeal";
            this.btnOrderMeal.Size = new System.Drawing.Size(143, 46);
            this.btnOrderMeal.TabIndex = 2;
            this.btnOrderMeal.Text = "Order Meal";
            this.btnOrderMeal.UseVisualStyleBackColor = true;
            this.btnOrderMeal.Click += new System.EventHandler(this.btnOrderMeal_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnOrderMeal);
            this.Controls.Add(this.dgvOrderedMeals);
            this.Controls.Add(this.dgvMealList);
            this.Name = "FrmStudents";
            this.Text = "Student Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedMeals)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvMealList;
        private System.Windows.Forms.DataGridView dgvOrderedMeals;
        private System.Windows.Forms.Button btnOrderMeal;
    }
}

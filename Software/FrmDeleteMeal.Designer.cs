namespace Evaluation_Manager
{
    partial class FrmDeleteMeal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMealId;
        private System.Windows.Forms.Button btnDeleteMeal;
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
            this.txtMealId = new System.Windows.Forms.TextBox();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // txtMealId
            // 
            this.txtMealId.Location = new System.Drawing.Point(50, 30);
            this.txtMealId.Name = "txtMealId";
            this.txtMealId.Size = new System.Drawing.Size(200, 26);
            this.txtMealId.TabIndex = 0;
            this.txtMealId.Text = "Meal ID";
            this.txtMealId.Enter += new System.EventHandler(this.txtMealId_Enter);
            this.txtMealId.Leave += new System.EventHandler(this.txtMealId_Leave);
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.Location = new System.Drawing.Point(50, 70);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteMeal.TabIndex = 1;
            this.btnDeleteMeal.Text = "Delete Meal";
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            this.btnDeleteMeal.Click += new System.EventHandler(this.btnDeleteMeal_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 130);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmDeleteMeal
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.txtMealId);
            this.Controls.Add(this.btnDeleteMeal);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmDeleteMeal";
            this.Text = "Delete Meal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace Evaluation_Manager
{
    partial class FrmAddMeal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckedListBox clbFoodPreferences;
        private System.Windows.Forms.Button btnSaveMeal;
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
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.clbFoodPreferences = new System.Windows.Forms.CheckedListBox();
            this.btnSaveMeal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(50, 30);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(200, 26);
            this.txtMealName.TabIndex = 0;
            this.txtMealName.Text = "Meal Name";
            this.txtMealName.Enter += new System.EventHandler(this.txtMealName_Enter);
            this.txtMealName.Leave += new System.EventHandler(this.txtMealName_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(50, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 26);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "Description";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // clbFoodPreferences
            // 
            this.clbFoodPreferences.FormattingEnabled = true;
            this.clbFoodPreferences.Items.AddRange(new object[] { "Vegetarian", "Vegan", "Gluten-Free" });
            this.clbFoodPreferences.Location = new System.Drawing.Point(50, 110);
            this.clbFoodPreferences.Name = "clbFoodPreferences";
            this.clbFoodPreferences.Size = new System.Drawing.Size(200, 100);
            this.clbFoodPreferences.TabIndex = 2;
            // 
            // btnSaveMeal
            // 
            this.btnSaveMeal.Location = new System.Drawing.Point(50, 220);
            this.btnSaveMeal.Name = "btnSaveMeal";
            this.btnSaveMeal.Size = new System.Drawing.Size(200, 50);
            this.btnSaveMeal.TabIndex = 3;
            this.btnSaveMeal.Text = "Save Meal";
            this.btnSaveMeal.UseVisualStyleBackColor = true;
            this.btnSaveMeal.Click += new System.EventHandler(this.btnSaveMeal_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 280);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAddMeal
            // 
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.clbFoodPreferences);
            this.Controls.Add(this.btnSaveMeal);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmAddMeal";
            this.Text = "Add Meal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

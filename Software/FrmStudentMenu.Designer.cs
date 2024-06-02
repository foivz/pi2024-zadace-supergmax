namespace Evaluation_Manager
{
    partial class FrmStudentMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOrderMeal;
        private System.Windows.Forms.Button btnLastOrders;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnLogout;

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
            this.btnOrderMeal = new System.Windows.Forms.Button();
            this.btnLastOrders = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // btnOrderMeal
            // 
            this.btnOrderMeal.Location = new System.Drawing.Point(50, 50);
            this.btnOrderMeal.Name = "btnOrderMeal";
            this.btnOrderMeal.Size = new System.Drawing.Size(200, 50);
            this.btnOrderMeal.TabIndex = 0;
            this.btnOrderMeal.Text = "Order Meal";
            this.btnOrderMeal.UseVisualStyleBackColor = true;
            this.btnOrderMeal.Click += new System.EventHandler(this.btnOrderMeal_Click);
            // 
            // btnLastOrders
            // 
            this.btnLastOrders.Location = new System.Drawing.Point(50, 120);
            this.btnLastOrders.Name = "btnLastOrders";
            this.btnLastOrders.Size = new System.Drawing.Size(200, 50);
            this.btnLastOrders.TabIndex = 1;
            this.btnLastOrders.Text = "Last Orders";
            this.btnLastOrders.UseVisualStyleBackColor = true;
            this.btnLastOrders.Click += new System.EventHandler(this.btnLastOrders_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.Location = new System.Drawing.Point(50, 190);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(200, 50);
            this.btnPreferences.TabIndex = 2;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 260);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmStudentMenu
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnOrderMeal);
            this.Controls.Add(this.btnLastOrders);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnLogout);
            this.Name = "FrmStudentMenu";
            this.Text = "Student Menu";
            this.ResumeLayout(false);
        }
    }
}

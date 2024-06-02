namespace Evaluation_Manager
{
    partial class FrmAdminMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDisplayAllUsers;
        private System.Windows.Forms.Button btnDisplayOrdersByUserId;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnDeleteMeal;
        private System.Windows.Forms.Button btnDisplayUserPreferences;
        private System.Windows.Forms.Button btnDisplayAllMeals;
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDisplayAllUsers = new System.Windows.Forms.Button();
            this.btnDisplayOrdersByUserId = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            this.btnDisplayUserPreferences = new System.Windows.Forms.Button();
            this.btnDisplayAllMeals = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(50, 30);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(200, 50);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add Users to DB";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDisplayAllUsers
            // 
            this.btnDisplayAllUsers.Location = new System.Drawing.Point(50, 90);
            this.btnDisplayAllUsers.Name = "btnDisplayAllUsers";
            this.btnDisplayAllUsers.Size = new System.Drawing.Size(200, 50);
            this.btnDisplayAllUsers.TabIndex = 1;
            this.btnDisplayAllUsers.Text = "Display All Users from DB";
            this.btnDisplayAllUsers.UseVisualStyleBackColor = true;
            this.btnDisplayAllUsers.Click += new System.EventHandler(this.btnDisplayAllUsers_Click);
            // 
            // btnDisplayOrdersByUserId
            // 
            this.btnDisplayOrdersByUserId.Location = new System.Drawing.Point(50, 150);
            this.btnDisplayOrdersByUserId.Name = "btnDisplayOrdersByUserId";
            this.btnDisplayOrdersByUserId.Size = new System.Drawing.Size(200, 50);
            this.btnDisplayOrdersByUserId.TabIndex = 2;
            this.btnDisplayOrdersByUserId.Text = "Display All Orders from User ID";
            this.btnDisplayOrdersByUserId.UseVisualStyleBackColor = true;
            this.btnDisplayOrdersByUserId.Click += new System.EventHandler(this.btnDisplayOrdersByUserId_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(50, 210);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(200, 50);
            this.btnAddMeal.TabIndex = 3;
            this.btnAddMeal.Text = "Add Meal to DB";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.Location = new System.Drawing.Point(50, 270);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteMeal.TabIndex = 4;
            this.btnDeleteMeal.Text = "Delete Meal from DB";
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            this.btnDeleteMeal.Click += new System.EventHandler(this.btnDeleteMeal_Click);
            // 
            // btnDisplayUserPreferences
            // 
            this.btnDisplayUserPreferences.Location = new System.Drawing.Point(50, 330);
            this.btnDisplayUserPreferences.Name = "btnDisplayUserPreferences";
            this.btnDisplayUserPreferences.Size = new System.Drawing.Size(200, 50);
            this.btnDisplayUserPreferences.TabIndex = 5;
            this.btnDisplayUserPreferences.Text = "Display User Preferences by ID";
            this.btnDisplayUserPreferences.UseVisualStyleBackColor = true;
            this.btnDisplayUserPreferences.Click += new System.EventHandler(this.btnDisplayUserPreferences_Click);
            // 
            // btnDisplayAllMeals
            // 
            this.btnDisplayAllMeals.Location = new System.Drawing.Point(50, 390);
            this.btnDisplayAllMeals.Name = "btnDisplayAllMeals";
            this.btnDisplayAllMeals.Size = new System.Drawing.Size(200, 50);
            this.btnDisplayAllMeals.TabIndex = 6;
            this.btnDisplayAllMeals.Text = "Display All Meals";
            this.btnDisplayAllMeals.UseVisualStyleBackColor = true;
            this.btnDisplayAllMeals.Click += new System.EventHandler(this.btnDisplayAllMeals_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmAdminMenu
            // 
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnDisplayAllUsers);
            this.Controls.Add(this.btnDisplayOrdersByUserId);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.btnDeleteMeal);
            this.Controls.Add(this.btnDisplayUserPreferences);
            this.Controls.Add(this.btnDisplayAllMeals);
            this.Controls.Add(this.btnLogout);
            this.Name = "FrmAdminMenu";
            this.Text = "Admin Menu";
            this.ResumeLayout(false);
        }
    }
}

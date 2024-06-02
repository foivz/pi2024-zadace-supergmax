namespace Evaluation_Manager
{
    partial class FrmPreferences
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckedListBox clbFoodPreferences;
        private System.Windows.Forms.Button btnSavePreferences;
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
            this.clbFoodPreferences = new System.Windows.Forms.CheckedListBox();
            this.btnSavePreferences = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // clbFoodPreferences
            // 
            this.clbFoodPreferences.FormattingEnabled = true;
            this.clbFoodPreferences.Location = new System.Drawing.Point(12, 12);
            this.clbFoodPreferences.Name = "clbFoodPreferences";
            this.clbFoodPreferences.Size = new System.Drawing.Size(776, 154);
            this.clbFoodPreferences.TabIndex = 0;
            // 
            // btnSavePreferences
            // 
            this.btnSavePreferences.Location = new System.Drawing.Point(326, 180);
            this.btnSavePreferences.Name = "btnSavePreferences";
            this.btnSavePreferences.Size = new System.Drawing.Size(143, 46);
            this.btnSavePreferences.TabIndex = 1;
            this.btnSavePreferences.Text = "Save Preferences";
            this.btnSavePreferences.UseVisualStyleBackColor = true;
            this.btnSavePreferences.Click += new System.EventHandler(this.btnSavePreferences_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(326, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmPreferences
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSavePreferences);
            this.Controls.Add(this.clbFoodPreferences);
            this.Name = "FrmPreferences";
            this.Text = "Preferences";
            this.ResumeLayout(false);
        }
    }
}

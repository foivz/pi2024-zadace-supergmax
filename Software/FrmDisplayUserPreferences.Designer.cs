namespace Evaluation_Manager
{
    partial class FrmDisplayUserPreferences
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLoadPreferences;
        private System.Windows.Forms.DataGridView dgvPreferences;
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
            this.btnLoadPreferences = new System.Windows.Forms.Button();
            this.dgvPreferences = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferences)).BeginInit();
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
            // btnLoadPreferences
            // 
            this.btnLoadPreferences.Location = new System.Drawing.Point(50, 70);
            this.btnLoadPreferences.Name = "btnLoadPreferences";
            this.btnLoadPreferences.Size = new System.Drawing.Size(200, 50);
            this.btnLoadPreferences.TabIndex = 1;
            this.btnLoadPreferences.Text = "Load Preferences";
            this.btnLoadPreferences.UseVisualStyleBackColor = true;
            this.btnLoadPreferences.Click += new System.EventHandler(this.btnLoadPreferences_Click);
            // 
            // dgvPreferences
            // 
            this.dgvPreferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreferences.Location = new System.Drawing.Point(12, 140);
            this.dgvPreferences.Name = "dgvPreferences";
            this.dgvPreferences.RowHeadersWidth = 62;
            this.dgvPreferences.RowTemplate.Height = 28;
            this.dgvPreferences.Size = new System.Drawing.Size(776, 200);
            this.dgvPreferences.TabIndex = 2;
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
            // FrmDisplayUserPreferences
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnLoadPreferences);
            this.Controls.Add(this.dgvPreferences);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmDisplayUserPreferences";
            this.Text = "Display User Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

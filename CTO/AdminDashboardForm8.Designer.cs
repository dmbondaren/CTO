namespace CTO
{
    partial class AdminDashboardForm8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUserListToolStripMenuItem,
            this.miStatisticsToolStripMenuItem,
            this.miLogoutToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.adminToolStripMenuItem.Text = "admin";
            // 
            // miUserListToolStripMenuItem
            // 
            this.miUserListToolStripMenuItem.Name = "miUserListToolStripMenuItem";
            this.miUserListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miUserListToolStripMenuItem.Text = "miUserList ";
            // 
            // miStatisticsToolStripMenuItem
            // 
            this.miStatisticsToolStripMenuItem.Name = "miStatisticsToolStripMenuItem";
            this.miStatisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miStatisticsToolStripMenuItem.Text = "miStatistics ";
            // 
            // miLogoutToolStripMenuItem
            // 
            this.miLogoutToolStripMenuItem.Name = "miLogoutToolStripMenuItem";
            this.miLogoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miLogoutToolStripMenuItem.Text = "miLogout ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Переглянути статистику";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 95);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редагувати користувача";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboardForm8";
            this.Text = "AdminDashboardForm8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miUserListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLogoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
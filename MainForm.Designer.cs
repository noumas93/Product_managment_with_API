namespace lab4
{
    partial class MainForm
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
            this.CashierTab = new System.Windows.Forms.TabControl();
            this.CashierPage = new System.Windows.Forms.TabPage();
            this.WarehousePage = new System.Windows.Forms.TabPage();
            this.CashierTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashierTab
            // 
            this.CashierTab.Controls.Add(this.CashierPage);
            this.CashierTab.Controls.Add(this.WarehousePage);
            this.CashierTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashierTab.Location = new System.Drawing.Point(0, 0);
            this.CashierTab.Name = "CashierTab";
            this.CashierTab.SelectedIndex = 0;
            this.CashierTab.Size = new System.Drawing.Size(800, 450);
            this.CashierTab.TabIndex = 0;
            // 
            // CashierPage
            // 
            this.CashierPage.Location = new System.Drawing.Point(4, 22);
            this.CashierPage.Name = "CashierPage";
            this.CashierPage.Padding = new System.Windows.Forms.Padding(3);
            this.CashierPage.Size = new System.Drawing.Size(792, 424);
            this.CashierPage.TabIndex = 0;
            this.CashierPage.Text = "Kassavy";
            this.CashierPage.UseVisualStyleBackColor = true;
            this.CashierPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // WarehousePage
            // 
            this.WarehousePage.AutoScroll = true;
            this.WarehousePage.Location = new System.Drawing.Point(4, 22);
            this.WarehousePage.Name = "WarehousePage";
            this.WarehousePage.Padding = new System.Windows.Forms.Padding(3);
            this.WarehousePage.Size = new System.Drawing.Size(792, 424);
            this.WarehousePage.TabIndex = 1;
            this.WarehousePage.Text = "Lagervy";
            this.WarehousePage.UseVisualStyleBackColor = true;
            this.WarehousePage.Click += new System.EventHandler(this.WarehousePage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CashierTab);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CashierTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CashierTab;
        private System.Windows.Forms.TabPage CashierPage;
        private System.Windows.Forms.TabPage WarehousePage;
    }
}
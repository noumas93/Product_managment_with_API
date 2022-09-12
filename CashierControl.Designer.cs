namespace lab4
{
    partial class CashierControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.saveExit = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.SendDeleveryBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleveryDataGrid = new System.Windows.Forms.DataGridView();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.DeleveryBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleveryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.LoadBtn);
            this.mainContainer.Panel1.Controls.Add(this.saveExit);
            this.mainContainer.Panel1.Controls.Add(this.sellBtn);
            this.mainContainer.Panel1.Controls.Add(this.SendDeleveryBtn);
            this.mainContainer.Panel1.Controls.Add(this.label2);
            this.mainContainer.Panel1.Controls.Add(this.label1);
            this.mainContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Panel1_Paint);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.deleveryDataGrid);
            this.mainContainer.Panel2.Controls.Add(this.productDataGrid);
            this.mainContainer.Panel2.Controls.Add(this.DeleveryBtn);
            this.mainContainer.Size = new System.Drawing.Size(685, 398);
            this.mainContainer.SplitterDistance = 182;
            this.mainContainer.TabIndex = 1;
            // 
            // saveExit
            // 
            this.saveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveExit.Location = new System.Drawing.Point(544, 17);
            this.saveExit.Name = "saveExit";
            this.saveExit.Size = new System.Drawing.Size(125, 23);
            this.saveExit.TabIndex = 4;
            this.saveExit.Text = "Spara och stäng";
            this.saveExit.UseVisualStyleBackColor = true;
            this.saveExit.Click += new System.EventHandler(this.saveExit_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.Location = new System.Drawing.Point(544, 118);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(125, 23);
            this.sellBtn.TabIndex = 3;
            this.sellBtn.Text = "Sälj de valda varorna";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // SendDeleveryBtn
            // 
            this.SendDeleveryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendDeleveryBtn.Location = new System.Drawing.Point(544, 147);
            this.SendDeleveryBtn.Name = "SendDeleveryBtn";
            this.SendDeleveryBtn.Size = new System.Drawing.Size(125, 23);
            this.SendDeleveryBtn.TabIndex = 2;
            this.SendDeleveryBtn.Text = "leverera inlaga varor";
            this.SendDeleveryBtn.UseVisualStyleBackColor = true;
            this.SendDeleveryBtn.Click += new System.EventHandler(this.SendDeleveryBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "kundvagn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkter i lager";
            // 
            // deleveryDataGrid
            // 
            this.deleveryDataGrid.AllowUserToAddRows = false;
            this.deleveryDataGrid.AllowUserToDeleteRows = false;
            this.deleveryDataGrid.AllowUserToResizeColumns = false;
            this.deleveryDataGrid.AllowUserToResizeRows = false;
            this.deleveryDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleveryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deleveryDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.deleveryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleveryDataGrid.Location = new System.Drawing.Point(397, 0);
            this.deleveryDataGrid.Name = "deleveryDataGrid";
            this.deleveryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleveryDataGrid.Size = new System.Drawing.Size(285, 209);
            this.deleveryDataGrid.TabIndex = 1;
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.AllowUserToResizeColumns = false;
            this.productDataGrid.AllowUserToResizeRows = false;
            this.productDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(0, 0);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGrid.Size = new System.Drawing.Size(313, 209);
            this.productDataGrid.TabIndex = 0;
            // 
            // DeleveryBtn
            // 
            this.DeleveryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleveryBtn.Location = new System.Drawing.Point(319, 67);
            this.DeleveryBtn.Name = "DeleveryBtn";
            this.DeleveryBtn.Size = new System.Drawing.Size(72, 47);
            this.DeleveryBtn.TabIndex = 0;
            this.DeleveryBtn.Text = "lägg till till kundvagn";
            this.DeleveryBtn.UseVisualStyleBackColor = true;
            this.DeleveryBtn.Click += new System.EventHandler(this.DeleveryBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBtn.Location = new System.Drawing.Point(544, 46);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(125, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Hämta senaste data";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // CashierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "CashierControl";
            this.Size = new System.Drawing.Size(685, 398);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleveryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Button DeleveryBtn;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView deleveryDataGrid;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button SendDeleveryBtn;
        private System.Windows.Forms.Button saveExit;
        private System.Windows.Forms.Button LoadBtn;
    }
}

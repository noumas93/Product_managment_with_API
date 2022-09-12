namespace lab4
{
    partial class WareHouseControl
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
            this.addProduktBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.MovieRadioBtn = new System.Windows.Forms.RadioButton();
            this.GameRadioBtn = new System.Windows.Forms.RadioButton();
            this.BookRadioBtn = new System.Windows.Forms.RadioButton();
            this.plattfromTextBox = new System.Windows.Forms.TextBox();
            this.PlattfromLabel = new System.Windows.Forms.Label();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.FormatTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.WriterTextBox = new System.Windows.Forms.TextBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.writerLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBok = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Id_Label = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.addNewPrdktBtn = new System.Windows.Forms.Button();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
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
            this.mainContainer.Panel1.Controls.Add(this.addProduktBtn);
            this.mainContainer.Panel1.Controls.Add(this.saveBtn);
            this.mainContainer.Panel1.Controls.Add(this.LengthTextBox);
            this.mainContainer.Panel1.Controls.Add(this.lengthLabel);
            this.mainContainer.Panel1.Controls.Add(this.MovieRadioBtn);
            this.mainContainer.Panel1.Controls.Add(this.GameRadioBtn);
            this.mainContainer.Panel1.Controls.Add(this.BookRadioBtn);
            this.mainContainer.Panel1.Controls.Add(this.plattfromTextBox);
            this.mainContainer.Panel1.Controls.Add(this.PlattfromLabel);
            this.mainContainer.Panel1.Controls.Add(this.LanguageTextBox);
            this.mainContainer.Panel1.Controls.Add(this.FormatTextBox);
            this.mainContainer.Panel1.Controls.Add(this.GenreTextBox);
            this.mainContainer.Panel1.Controls.Add(this.WriterTextBox);
            this.mainContainer.Panel1.Controls.Add(this.labelLanguage);
            this.mainContainer.Panel1.Controls.Add(this.formatLabel);
            this.mainContainer.Panel1.Controls.Add(this.GenreLabel);
            this.mainContainer.Panel1.Controls.Add(this.writerLabel);
            this.mainContainer.Panel1.Controls.Add(this.priceTextBox);
            this.mainContainer.Panel1.Controls.Add(this.NameTextBox);
            this.mainContainer.Panel1.Controls.Add(this.IdTextBok);
            this.mainContainer.Panel1.Controls.Add(this.priceLabel);
            this.mainContainer.Panel1.Controls.Add(this.nameLabel);
            this.mainContainer.Panel1.Controls.Add(this.Id_Label);
            this.mainContainer.Panel1.Controls.Add(this.RemoveBtn);
            this.mainContainer.Panel1.Controls.Add(this.addNewPrdktBtn);
            this.mainContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Panel1_Paint);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.productDataGrid);
            this.mainContainer.Size = new System.Drawing.Size(631, 440);
            this.mainContainer.SplitterDistance = 183;
            this.mainContainer.TabIndex = 0;
            // 
            // addProduktBtn
            // 
            this.addProduktBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProduktBtn.Location = new System.Drawing.Point(236, 145);
            this.addProduktBtn.Name = "addProduktBtn";
            this.addProduktBtn.Size = new System.Drawing.Size(121, 23);
            this.addProduktBtn.TabIndex = 33;
            this.addProduktBtn.Text = "Lägg till antal";
            this.addProduktBtn.UseVisualStyleBackColor = true;
            this.addProduktBtn.Click += new System.EventHandler(this.addProduktBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(496, 145);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 23);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Spara och stäng";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LengthTextBox.Location = new System.Drawing.Point(367, 16);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 31;
            // 
            // lengthLabel
            // 
            this.lengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(322, 16);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(39, 13);
            this.lengthLabel.TabIndex = 30;
            this.lengthLabel.Text = "Speltid";
            // 
            // MovieRadioBtn
            // 
            this.MovieRadioBtn.AutoSize = true;
            this.MovieRadioBtn.Location = new System.Drawing.Point(17, 83);
            this.MovieRadioBtn.Name = "MovieRadioBtn";
            this.MovieRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.MovieRadioBtn.TabIndex = 29;
            this.MovieRadioBtn.TabStop = true;
            this.MovieRadioBtn.Text = "Filmer";
            this.MovieRadioBtn.UseVisualStyleBackColor = true;
            this.MovieRadioBtn.Click += new System.EventHandler(this.MovieRadioBtn_Click);
            // 
            // GameRadioBtn
            // 
            this.GameRadioBtn.AutoSize = true;
            this.GameRadioBtn.Location = new System.Drawing.Point(17, 60);
            this.GameRadioBtn.Name = "GameRadioBtn";
            this.GameRadioBtn.Size = new System.Drawing.Size(67, 17);
            this.GameRadioBtn.TabIndex = 28;
            this.GameRadioBtn.TabStop = true;
            this.GameRadioBtn.Text = "Dataspel";
            this.GameRadioBtn.UseVisualStyleBackColor = true;
            this.GameRadioBtn.Click += new System.EventHandler(this.GameRadioBtn_Click);
            // 
            // BookRadioBtn
            // 
            this.BookRadioBtn.AutoSize = true;
            this.BookRadioBtn.Location = new System.Drawing.Point(17, 37);
            this.BookRadioBtn.Name = "BookRadioBtn";
            this.BookRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.BookRadioBtn.TabIndex = 27;
            this.BookRadioBtn.TabStop = true;
            this.BookRadioBtn.Text = "Böcker";
            this.BookRadioBtn.UseVisualStyleBackColor = true;
            this.BookRadioBtn.Click += new System.EventHandler(this.BookRdaioBtn_Click);
            // 
            // plattfromTextBox
            // 
            this.plattfromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.plattfromTextBox.Location = new System.Drawing.Point(201, 100);
            this.plattfromTextBox.Name = "plattfromTextBox";
            this.plattfromTextBox.Size = new System.Drawing.Size(100, 20);
            this.plattfromTextBox.TabIndex = 26;
            // 
            // PlattfromLabel
            // 
            this.PlattfromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlattfromLabel.AutoSize = true;
            this.PlattfromLabel.Location = new System.Drawing.Point(126, 107);
            this.PlattfromLabel.Name = "PlattfromLabel";
            this.PlattfromLabel.Size = new System.Drawing.Size(48, 13);
            this.PlattfromLabel.TabIndex = 25;
            this.PlattfromLabel.Text = "Plattform";
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LanguageTextBox.Location = new System.Drawing.Point(521, 16);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(100, 20);
            this.LanguageTextBox.TabIndex = 24;
            // 
            // FormatTextBox
            // 
            this.FormatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FormatTextBox.Location = new System.Drawing.Point(367, 45);
            this.FormatTextBox.Name = "FormatTextBox";
            this.FormatTextBox.Size = new System.Drawing.Size(100, 20);
            this.FormatTextBox.TabIndex = 23;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GenreTextBox.Location = new System.Drawing.Point(367, 104);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 22;
            // 
            // WriterTextBox
            // 
            this.WriterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WriterTextBox.Location = new System.Drawing.Point(367, 74);
            this.WriterTextBox.Name = "WriterTextBox";
            this.WriterTextBox.Size = new System.Drawing.Size(100, 20);
            this.WriterTextBox.TabIndex = 21;
            // 
            // labelLanguage
            // 
            this.labelLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(475, 19);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(35, 13);
            this.labelLanguage.TabIndex = 20;
            this.labelLanguage.Text = "Språk";
            // 
            // formatLabel
            // 
            this.formatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(322, 48);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(39, 13);
            this.formatLabel.TabIndex = 19;
            this.formatLabel.Text = "Format";
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(321, 107);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 18;
            this.GenreLabel.Text = "Genre";
            // 
            // writerLabel
            // 
            this.writerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.writerLabel.AutoSize = true;
            this.writerLabel.Location = new System.Drawing.Point(309, 78);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(52, 13);
            this.writerLabel.TabIndex = 17;
            this.writerLabel.Text = "Författare";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.priceTextBox.Location = new System.Drawing.Point(201, 71);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NameTextBox.Location = new System.Drawing.Point(201, 45);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 9;
            // 
            // IdTextBok
            // 
            this.IdTextBok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IdTextBok.Location = new System.Drawing.Point(201, 16);
            this.IdTextBok.Name = "IdTextBok";
            this.IdTextBok.Size = new System.Drawing.Size(100, 20);
            this.IdTextBok.TabIndex = 8;
            this.IdTextBok.TextChanged += new System.EventHandler(this.IdTextBok_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(126, 74);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(28, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Pris*";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(126, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Namn*";
            // 
            // Id_Label
            // 
            this.Id_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Id_Label.AutoSize = true;
            this.Id_Label.Location = new System.Drawing.Point(126, 16);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(60, 13);
            this.Id_Label.TabIndex = 2;
            this.Id_Label.Text = "Produkt Id*";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveBtn.Location = new System.Drawing.Point(118, 145);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(112, 23);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Ta bort produkt";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // addNewPrdktBtn
            // 
            this.addNewPrdktBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewPrdktBtn.Location = new System.Drawing.Point(9, 145);
            this.addNewPrdktBtn.Name = "addNewPrdktBtn";
            this.addNewPrdktBtn.Size = new System.Drawing.Size(103, 23);
            this.addNewPrdktBtn.TabIndex = 0;
            this.addNewPrdktBtn.Text = "Ny prdoukt";
            this.addNewPrdktBtn.UseVisualStyleBackColor = true;
            this.addNewPrdktBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.AllowUserToResizeColumns = false;
            this.productDataGrid.AllowUserToResizeRows = false;
            this.productDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(0, 0);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGrid.Size = new System.Drawing.Size(631, 253);
            this.productDataGrid.TabIndex = 0;
            // 
            // WareHouseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "WareHouseControl";
            this.Size = new System.Drawing.Size(631, 440);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button addNewPrdktBtn;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label Id_Label;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBok;
        private System.Windows.Forms.TextBox LanguageTextBox;
        private System.Windows.Forms.TextBox FormatTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox WriterTextBox;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label writerLabel;
        private System.Windows.Forms.TextBox plattfromTextBox;
        private System.Windows.Forms.Label PlattfromLabel;
        private System.Windows.Forms.RadioButton MovieRadioBtn;
        private System.Windows.Forms.RadioButton GameRadioBtn;
        private System.Windows.Forms.RadioButton BookRadioBtn;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addProduktBtn;
    }
}

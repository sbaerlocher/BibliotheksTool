namespace LibraryManagementSystem
{
    partial class admBookSearch
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admBookExportBtn = new System.Windows.Forms.Button();
            this.admBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet18 = new LibraryManagementSystem.LibraryDBDataSet18();
            this.admBookSearchBtnBack = new System.Windows.Forms.Button();
            this.admBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.admBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.admBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet2 = new LibraryManagementSystem.LibraryDBDataSet2();
            this.booksTableAdapter = new LibraryManagementSystem.LibraryDBDataSet2TableAdapters.booksTableAdapter();
            this.booksTableAdapter1 = new LibraryManagementSystem.LibraryDBDataSet18TableAdapters.booksTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admBookExportBtn);
            this.panel1.Controls.Add(this.admBookSearchDgv);
            this.panel1.Controls.Add(this.admBookSearchBtnBack);
            this.panel1.Controls.Add(this.admBookSearchBtnLogout);
            this.panel1.Controls.Add(this.admBookSearchBtnSearch);
            this.panel1.Controls.Add(this.admBookSearchTbxQuery);
            this.panel1.Controls.Add(this.admBookSearchRbBoth);
            this.panel1.Controls.Add(this.admBookSearchRbAuthor);
            this.panel1.Controls.Add(this.admBookSearchRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Location = new System.Drawing.Point(32, -16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1752, 865);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admBookExportBtn
            // 
            this.admBookExportBtn.Location = new System.Drawing.Point(1097, 715);
            this.admBookExportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookExportBtn.Name = "admBookExportBtn";
            this.admBookExportBtn.Size = new System.Drawing.Size(193, 53);
            this.admBookExportBtn.TabIndex = 35;
            this.admBookExportBtn.Text = "Excel Export";
            this.admBookExportBtn.UseVisualStyleBackColor = true;
            this.admBookExportBtn.Click += new System.EventHandler(this.admBookExportBtn_Click);
            // 
            // admBookSearchDgv
            // 
            this.admBookSearchDgv.AutoGenerateColumns = false;
            this.admBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admBookSearchDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPubDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.lendDataGridViewTextBoxColumn});
            this.admBookSearchDgv.DataSource = this.booksBindingSource1;
            this.admBookSearchDgv.Location = new System.Drawing.Point(24, 183);
            this.admBookSearchDgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchDgv.Name = "admBookSearchDgv";
            this.admBookSearchDgv.RowHeadersWidth = 51;
            this.admBookSearchDgv.Size = new System.Drawing.Size(1267, 476);
            this.admBookSearchDgv.TabIndex = 34;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearOfPubDataGridViewTextBoxColumn
            // 
            this.yearOfPubDataGridViewTextBoxColumn.DataPropertyName = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.HeaderText = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearOfPubDataGridViewTextBoxColumn.Name = "yearOfPubDataGridViewTextBoxColumn";
            this.yearOfPubDataGridViewTextBoxColumn.Width = 125;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            this.genresDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDataGridViewTextBoxColumn
            // 
            this.lendDataGridViewTextBoxColumn.DataPropertyName = "Lend";
            this.lendDataGridViewTextBoxColumn.HeaderText = "Lend";
            this.lendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDataGridViewTextBoxColumn.Name = "lendDataGridViewTextBoxColumn";
            this.lendDataGridViewTextBoxColumn.Width = 125;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "books";
            this.booksBindingSource1.DataSource = this.libraryDBDataSet18;
            // 
            // libraryDBDataSet18
            // 
            this.libraryDBDataSet18.DataSetName = "LibraryDBDataSet18";
            this.libraryDBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admBookSearchBtnBack
            // 
            this.admBookSearchBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admBookSearchBtnBack.Location = new System.Drawing.Point(24, 27);
            this.admBookSearchBtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchBtnBack.Name = "admBookSearchBtnBack";
            this.admBookSearchBtnBack.Size = new System.Drawing.Size(100, 43);
            this.admBookSearchBtnBack.TabIndex = 33;
            this.admBookSearchBtnBack.Text = "Back";
            this.admBookSearchBtnBack.UseVisualStyleBackColor = true;
            this.admBookSearchBtnBack.Click += new System.EventHandler(this.admBookSearchBtnBack_Click);
            // 
            // admBookSearchBtnLogout
            // 
            this.admBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admBookSearchBtnLogout.Location = new System.Drawing.Point(1625, 27);
            this.admBookSearchBtnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchBtnLogout.Name = "admBookSearchBtnLogout";
            this.admBookSearchBtnLogout.Size = new System.Drawing.Size(100, 43);
            this.admBookSearchBtnLogout.TabIndex = 32;
            this.admBookSearchBtnLogout.Text = "Logout";
            this.admBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.admBookSearchBtnLogout.Click += new System.EventHandler(this.admBookSearchBtnLogout_Click);
            // 
            // admBookSearchBtnSearch
            // 
            this.admBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchBtnSearch.Location = new System.Drawing.Point(564, 119);
            this.admBookSearchBtnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchBtnSearch.Name = "admBookSearchBtnSearch";
            this.admBookSearchBtnSearch.Size = new System.Drawing.Size(117, 41);
            this.admBookSearchBtnSearch.TabIndex = 30;
            this.admBookSearchBtnSearch.Text = "Search";
            this.admBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.admBookSearchBtnSearch.Click += new System.EventHandler(this.admBookSearchBtnSearch_Click);
            // 
            // admBookSearchTbxQuery
            // 
            this.admBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchTbxQuery.Location = new System.Drawing.Point(177, 89);
            this.admBookSearchTbxQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchTbxQuery.Name = "admBookSearchTbxQuery";
            this.admBookSearchTbxQuery.Size = new System.Drawing.Size(503, 26);
            this.admBookSearchTbxQuery.TabIndex = 29;
            this.admBookSearchTbxQuery.TextChanged += new System.EventHandler(this.admBookSearchTbxQuery_TextChanged);
            // 
            // admBookSearchRbBoth
            // 
            this.admBookSearchRbBoth.AutoSize = true;
            this.admBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbBoth.Location = new System.Drawing.Point(368, 124);
            this.admBookSearchRbBoth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchRbBoth.Name = "admBookSearchRbBoth";
            this.admBookSearchRbBoth.Size = new System.Drawing.Size(73, 29);
            this.admBookSearchRbBoth.TabIndex = 28;
            this.admBookSearchRbBoth.TabStop = true;
            this.admBookSearchRbBoth.Text = "Both";
            this.admBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbAuthor
            // 
            this.admBookSearchRbAuthor.AutoSize = true;
            this.admBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbAuthor.Location = new System.Drawing.Point(260, 124);
            this.admBookSearchRbAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchRbAuthor.Name = "admBookSearchRbAuthor";
            this.admBookSearchRbAuthor.Size = new System.Drawing.Size(91, 29);
            this.admBookSearchRbAuthor.TabIndex = 27;
            this.admBookSearchRbAuthor.TabStop = true;
            this.admBookSearchRbAuthor.Text = "Author";
            this.admBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbTitle
            // 
            this.admBookSearchRbTitle.AutoSize = true;
            this.admBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbTitle.Location = new System.Drawing.Point(177, 124);
            this.admBookSearchRbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admBookSearchRbTitle.Name = "admBookSearchRbTitle";
            this.admBookSearchRbTitle.Size = new System.Drawing.Size(70, 29);
            this.admBookSearchRbTitle.TabIndex = 26;
            this.admBookSearchRbTitle.TabStop = true;
            this.admBookSearchRbTitle.Text = "Title";
            this.admBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(19, 92);
            this.admBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(141, 25);
            this.admBookSearchLblSearch.TabIndex = 25;
            this.admBookSearchLblSearch.Text = "Search Books:";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet2;
            // 
            // libraryDBDataSet2
            // 
            this.libraryDBDataSet2.DataSetName = "LibraryDBDataSet2";
            this.libraryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // admBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 863);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admBookSearch";
            this.Text = "Admin Book Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admBookSearchBtnLogout;
        private System.Windows.Forms.Button admBookSearchBtnSearch;
        private System.Windows.Forms.TextBox admBookSearchTbxQuery;
        private System.Windows.Forms.RadioButton admBookSearchRbBoth;
        private System.Windows.Forms.RadioButton admBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton admBookSearchRbTitle;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.Button admBookSearchBtnBack;
        private LibraryDBDataSet2 libraryDBDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSet2TableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridView admBookSearchDgv;
        private LibraryDBDataSet18 libraryDBDataSet18;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryDBDataSet18TableAdapters.booksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button admBookExportBtn;
    }
}
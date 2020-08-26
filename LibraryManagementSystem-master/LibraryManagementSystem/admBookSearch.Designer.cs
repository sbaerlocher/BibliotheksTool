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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admBookSearchBtnBack = new System.Windows.Forms.Button();
            this.admBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.admBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.admBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.admBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet2 = new LibraryManagementSystem.LibraryDBDataSet2();
            this.booksTableAdapter = new LibraryManagementSystem.LibraryDBDataSet2TableAdapters.booksTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDaysPasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admBookSearchBtnBack);
            this.panel1.Controls.Add(this.admBookSearchBtnLogout);
            this.panel1.Controls.Add(this.admBookSearchBtnSearch);
            this.panel1.Controls.Add(this.admBookSearchTbxQuery);
            this.panel1.Controls.Add(this.admBookSearchRbBoth);
            this.panel1.Controls.Add(this.admBookSearchRbAuthor);
            this.panel1.Controls.Add(this.admBookSearchRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(89, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 703);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admBookSearchBtnBack
            // 
            this.admBookSearchBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admBookSearchBtnBack.Location = new System.Drawing.Point(18, 22);
            this.admBookSearchBtnBack.Name = "admBookSearchBtnBack";
            this.admBookSearchBtnBack.Size = new System.Drawing.Size(75, 35);
            this.admBookSearchBtnBack.TabIndex = 33;
            this.admBookSearchBtnBack.Text = "Back";
            this.admBookSearchBtnBack.UseVisualStyleBackColor = true;
            this.admBookSearchBtnBack.Click += new System.EventHandler(this.admBookSearchBtnBack_Click);
            // 
            // admBookSearchBtnLogout
            // 
            this.admBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admBookSearchBtnLogout.Location = new System.Drawing.Point(1219, 22);
            this.admBookSearchBtnLogout.Name = "admBookSearchBtnLogout";
            this.admBookSearchBtnLogout.Size = new System.Drawing.Size(75, 35);
            this.admBookSearchBtnLogout.TabIndex = 32;
            this.admBookSearchBtnLogout.Text = "Logout";
            this.admBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.admBookSearchBtnLogout.Click += new System.EventHandler(this.admBookSearchBtnLogout_Click);
            // 
            // admBookSearchBtnSearch
            // 
            this.admBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchBtnSearch.Location = new System.Drawing.Point(423, 97);
            this.admBookSearchBtnSearch.Name = "admBookSearchBtnSearch";
            this.admBookSearchBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.admBookSearchBtnSearch.TabIndex = 30;
            this.admBookSearchBtnSearch.Text = "Search";
            this.admBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.admBookSearchBtnSearch.Click += new System.EventHandler(this.admBookSearchBtnSearch_Click);
            // 
            // admBookSearchTbxQuery
            // 
            this.admBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchTbxQuery.Location = new System.Drawing.Point(133, 72);
            this.admBookSearchTbxQuery.Name = "admBookSearchTbxQuery";
            this.admBookSearchTbxQuery.Size = new System.Drawing.Size(378, 23);
            this.admBookSearchTbxQuery.TabIndex = 29;
            this.admBookSearchTbxQuery.TextChanged += new System.EventHandler(this.admBookSearchTbxQuery_TextChanged);
            // 
            // admBookSearchRbBoth
            // 
            this.admBookSearchRbBoth.AutoSize = true;
            this.admBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbBoth.Location = new System.Drawing.Point(276, 101);
            this.admBookSearchRbBoth.Name = "admBookSearchRbBoth";
            this.admBookSearchRbBoth.Size = new System.Drawing.Size(61, 24);
            this.admBookSearchRbBoth.TabIndex = 28;
            this.admBookSearchRbBoth.TabStop = true;
            this.admBookSearchRbBoth.Text = "Both";
            this.admBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbAuthor
            // 
            this.admBookSearchRbAuthor.AutoSize = true;
            this.admBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbAuthor.Location = new System.Drawing.Point(195, 101);
            this.admBookSearchRbAuthor.Name = "admBookSearchRbAuthor";
            this.admBookSearchRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.admBookSearchRbAuthor.TabIndex = 27;
            this.admBookSearchRbAuthor.TabStop = true;
            this.admBookSearchRbAuthor.Text = "Author";
            this.admBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbTitle
            // 
            this.admBookSearchRbTitle.AutoSize = true;
            this.admBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbTitle.Location = new System.Drawing.Point(133, 101);
            this.admBookSearchRbTitle.Name = "admBookSearchRbTitle";
            this.admBookSearchRbTitle.Size = new System.Drawing.Size(56, 24);
            this.admBookSearchRbTitle.TabIndex = 26;
            this.admBookSearchRbTitle.TabStop = true;
            this.admBookSearchRbTitle.Text = "Title";
            this.admBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(14, 75);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(113, 20);
            this.admBookSearchLblSearch.TabIndex = 25;
            this.admBookSearchLblSearch.Text = "Search Books:";
            // 
            // admBookSearchDgv
            // 
            this.admBookSearchDgv.AutoGenerateColumns = false;
            this.admBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.admBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.admBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admBookSearchDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.totalDaysPasedDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPubDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.admBookSearchDgv.DataSource = this.booksBindingSource;
            this.admBookSearchDgv.Location = new System.Drawing.Point(20, 187);
            this.admBookSearchDgv.Name = "admBookSearchDgv";
            this.admBookSearchDgv.Size = new System.Drawing.Size(1274, 484);
            this.admBookSearchDgv.TabIndex = 23;
            this.admBookSearchDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admBookSearchDgv_CellContentClick);
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
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Width = 97;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 63;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 82;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 89;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 114;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 121;
            // 
            // totalDaysPasedDataGridViewTextBoxColumn
            // 
            this.totalDaysPasedDataGridViewTextBoxColumn.DataPropertyName = "Total days pased";
            this.totalDaysPasedDataGridViewTextBoxColumn.HeaderText = "Total days pased";
            this.totalDaysPasedDataGridViewTextBoxColumn.Name = "totalDaysPasedDataGridViewTextBoxColumn";
            this.totalDaysPasedDataGridViewTextBoxColumn.Width = 141;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 99;
            // 
            // yearOfPubDataGridViewTextBoxColumn
            // 
            this.yearOfPubDataGridViewTextBoxColumn.DataPropertyName = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.HeaderText = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.Name = "yearOfPubDataGridViewTextBoxColumn";
            this.yearOfPubDataGridViewTextBoxColumn.Width = 83;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            this.genresDataGridViewTextBoxColumn.Width = 87;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // admBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 815);
            this.Controls.Add(this.panel1);
            this.Name = "admBookSearch";
            this.Text = "Admin Book Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).EndInit();
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
        private System.Windows.Forms.DataGridView admBookSearchDgv;
        private System.Windows.Forms.Button admBookSearchBtnBack;
        private LibraryDBDataSet2 libraryDBDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSet2TableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDaysPasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
    }
}
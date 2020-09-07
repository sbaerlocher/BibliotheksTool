namespace LibraryManagementSystem
{
    partial class admIssue
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
            this.admIssueBooksBtnLogout = new System.Windows.Forms.Button();
            this.admIssueBooksBtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admIssueBtnSearch = new System.Windows.Forms.Button();
            this.admIssueTbxSearchQuery = new System.Windows.Forms.TextBox();
            this.admIssueRbBoth = new System.Windows.Forms.RadioButton();
            this.admIssueRbAuthor = new System.Windows.Forms.RadioButton();
            this.admIssueRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet16 = new LibraryManagementSystem.LibraryDBDataSet16();
            this.label7 = new System.Windows.Forms.Label();
            this.admIssueBtnIssue = new System.Windows.Forms.Button();
            this.admIssueTbxUserID = new System.Windows.Forms.TextBox();
            this.amdIssueTbxBookID = new System.Windows.Forms.TextBox();
            this.admIssueLblUserID = new System.Windows.Forms.Label();
            this.admIssueLblBookID = new System.Windows.Forms.Label();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet12 = new LibraryManagementSystem.LibraryDBDataSet12();
            this.issueTableAdapter = new LibraryManagementSystem.LibraryDBDataSet12TableAdapters.IssueTableAdapter();
            this.booksTableAdapter = new LibraryManagementSystem.LibraryDBDataSet16TableAdapters.booksTableAdapter();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admIssueDgvTable = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDaysPasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admIssueDgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admIssueDgvTable);
            this.panel1.Controls.Add(this.admIssueBooksBtnLogout);
            this.panel1.Controls.Add(this.admIssueBooksBtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admIssueBtnSearch);
            this.panel1.Controls.Add(this.admIssueTbxSearchQuery);
            this.panel1.Controls.Add(this.admIssueRbBoth);
            this.panel1.Controls.Add(this.admIssueRbAuthor);
            this.panel1.Controls.Add(this.admIssueRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.admIssueBtnIssue);
            this.panel1.Controls.Add(this.admIssueTbxUserID);
            this.panel1.Controls.Add(this.amdIssueTbxBookID);
            this.panel1.Controls.Add(this.admIssueLblUserID);
            this.panel1.Controls.Add(this.admIssueLblBookID);
            this.panel1.Location = new System.Drawing.Point(69, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 711);
            this.panel1.TabIndex = 0;
            // 
            // admIssueBooksBtnLogout
            // 
            this.admIssueBooksBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBooksBtnLogout.Location = new System.Drawing.Point(717, 17);
            this.admIssueBooksBtnLogout.Name = "admIssueBooksBtnLogout";
            this.admIssueBooksBtnLogout.Size = new System.Drawing.Size(77, 30);
            this.admIssueBooksBtnLogout.TabIndex = 68;
            this.admIssueBooksBtnLogout.Text = "Logout";
            this.admIssueBooksBtnLogout.UseVisualStyleBackColor = true;
            this.admIssueBooksBtnLogout.Click += new System.EventHandler(this.admIssueBooksBtnLogout_Click);
            // 
            // admIssueBooksBtnBack
            // 
            this.admIssueBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBooksBtnBack.Location = new System.Drawing.Point(25, 17);
            this.admIssueBooksBtnBack.Name = "admIssueBooksBtnBack";
            this.admIssueBooksBtnBack.Size = new System.Drawing.Size(77, 30);
            this.admIssueBooksBtnBack.TabIndex = 67;
            this.admIssueBooksBtnBack.Text = "Back";
            this.admIssueBooksBtnBack.UseVisualStyleBackColor = true;
            this.admIssueBooksBtnBack.Click += new System.EventHandler(this.admIssueBooksBtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "( Only books that are not issued )";
            // 
            // admIssueBtnSearch
            // 
            this.admIssueBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBtnSearch.Location = new System.Drawing.Point(552, 204);
            this.admIssueBtnSearch.Name = "admIssueBtnSearch";
            this.admIssueBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.admIssueBtnSearch.TabIndex = 64;
            this.admIssueBtnSearch.Text = "Search";
            this.admIssueBtnSearch.UseVisualStyleBackColor = true;
            this.admIssueBtnSearch.Click += new System.EventHandler(this.admIssueBtnSearch_Click);
            // 
            // admIssueTbxSearchQuery
            // 
            this.admIssueTbxSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueTbxSearchQuery.Location = new System.Drawing.Point(199, 175);
            this.admIssueTbxSearchQuery.Name = "admIssueTbxSearchQuery";
            this.admIssueTbxSearchQuery.Size = new System.Drawing.Size(441, 23);
            this.admIssueTbxSearchQuery.TabIndex = 63;
            // 
            // admIssueRbBoth
            // 
            this.admIssueRbBoth.AutoSize = true;
            this.admIssueRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbBoth.Location = new System.Drawing.Point(342, 204);
            this.admIssueRbBoth.Name = "admIssueRbBoth";
            this.admIssueRbBoth.Size = new System.Drawing.Size(61, 24);
            this.admIssueRbBoth.TabIndex = 62;
            this.admIssueRbBoth.TabStop = true;
            this.admIssueRbBoth.Text = "Both";
            this.admIssueRbBoth.UseVisualStyleBackColor = true;
            // 
            // admIssueRbAuthor
            // 
            this.admIssueRbAuthor.AutoSize = true;
            this.admIssueRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbAuthor.Location = new System.Drawing.Point(261, 204);
            this.admIssueRbAuthor.Name = "admIssueRbAuthor";
            this.admIssueRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.admIssueRbAuthor.TabIndex = 61;
            this.admIssueRbAuthor.TabStop = true;
            this.admIssueRbAuthor.Text = "Author";
            this.admIssueRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admIssueRbTitle
            // 
            this.admIssueRbTitle.AutoSize = true;
            this.admIssueRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbTitle.Location = new System.Drawing.Point(199, 204);
            this.admIssueRbTitle.Name = "admIssueRbTitle";
            this.admIssueRbTitle.Size = new System.Drawing.Size(56, 24);
            this.admIssueRbTitle.TabIndex = 60;
            this.admIssueRbTitle.TabStop = true;
            this.admIssueRbTitle.Text = "Title";
            this.admIssueRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(129, 178);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(64, 20);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "Search:";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet16;
            // 
            // libraryDBDataSet16
            // 
            this.libraryDBDataSet16.DataSetName = "LibraryDBDataSet16";
            this.libraryDBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(25, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(769, 2);
            this.label7.TabIndex = 57;
            // 
            // admIssueBtnIssue
            // 
            this.admIssueBtnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueBtnIssue.Location = new System.Drawing.Point(341, 102);
            this.admIssueBtnIssue.Name = "admIssueBtnIssue";
            this.admIssueBtnIssue.Size = new System.Drawing.Size(96, 33);
            this.admIssueBtnIssue.TabIndex = 19;
            this.admIssueBtnIssue.Text = "Issue";
            this.admIssueBtnIssue.UseVisualStyleBackColor = true;
            this.admIssueBtnIssue.Click += new System.EventHandler(this.admIssueBtnIssue_Click);
            // 
            // admIssueTbxUserID
            // 
            this.admIssueTbxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueTbxUserID.Location = new System.Drawing.Point(374, 65);
            this.admIssueTbxUserID.Name = "admIssueTbxUserID";
            this.admIssueTbxUserID.Size = new System.Drawing.Size(151, 31);
            this.admIssueTbxUserID.TabIndex = 18;
            // 
            // amdIssueTbxBookID
            // 
            this.amdIssueTbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amdIssueTbxBookID.Location = new System.Drawing.Point(374, 19);
            this.amdIssueTbxBookID.Name = "amdIssueTbxBookID";
            this.amdIssueTbxBookID.Size = new System.Drawing.Size(151, 31);
            this.amdIssueTbxBookID.TabIndex = 17;
            this.amdIssueTbxBookID.TextChanged += new System.EventHandler(this.amdIssueTbxBookID_TextChanged);
            // 
            // admIssueLblUserID
            // 
            this.admIssueLblUserID.AutoSize = true;
            this.admIssueLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueLblUserID.Location = new System.Drawing.Point(267, 68);
            this.admIssueLblUserID.Name = "admIssueLblUserID";
            this.admIssueLblUserID.Size = new System.Drawing.Size(95, 25);
            this.admIssueLblUserID.TabIndex = 16;
            this.admIssueLblUserID.Text = "User ID: ";
            // 
            // admIssueLblBookID
            // 
            this.admIssueLblBookID.AutoSize = true;
            this.admIssueLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueLblBookID.Location = new System.Drawing.Point(263, 22);
            this.admIssueLblBookID.Name = "admIssueLblBookID";
            this.admIssueLblBookID.Size = new System.Drawing.Size(99, 25);
            this.admIssueLblBookID.TabIndex = 15;
            this.admIssueLblBookID.Text = "Book ID: ";
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataMember = "Issue";
            this.issueBindingSource.DataSource = this.libraryDBDataSet12;
            // 
            // libraryDBDataSet12
            // 
            this.libraryDBDataSet12.DataSetName = "LibraryDBDataSet12";
            this.libraryDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueTableAdapter
            // 
            this.issueTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 82;
            // 
            // Book_ID
            // 
            this.Book_ID.DataPropertyName = "Book_ID";
            this.Book_ID.HeaderText = "Book_ID";
            this.Book_ID.Name = "Book_ID";
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 74;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            // 
            // admIssueDgvTable
            // 
            this.admIssueDgvTable.AutoGenerateColumns = false;
            this.admIssueDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admIssueDgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn1,
            this.totalDaysPasedDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPubDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.admIssueDgvTable.DataSource = this.booksBindingSource;
            this.admIssueDgvTable.Location = new System.Drawing.Point(12, 286);
            this.admIssueDgvTable.Name = "admIssueDgvTable";
            this.admIssueDgvTable.Size = new System.Drawing.Size(755, 150);
            this.admIssueDgvTable.TabIndex = 69;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // dateIssuedDataGridViewTextBoxColumn1
            // 
            this.dateIssuedDataGridViewTextBoxColumn1.DataPropertyName = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn1.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn1.Name = "dateIssuedDataGridViewTextBoxColumn1";
            // 
            // totalDaysPasedDataGridViewTextBoxColumn
            // 
            this.totalDaysPasedDataGridViewTextBoxColumn.DataPropertyName = "Total days pased";
            this.totalDaysPasedDataGridViewTextBoxColumn.HeaderText = "Total days pased";
            this.totalDaysPasedDataGridViewTextBoxColumn.Name = "totalDaysPasedDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // yearOfPubDataGridViewTextBoxColumn
            // 
            this.yearOfPubDataGridViewTextBoxColumn.DataPropertyName = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.HeaderText = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.Name = "yearOfPubDataGridViewTextBoxColumn";
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // admIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 682);
            this.Controls.Add(this.panel1);
            this.Name = "admIssue";
            this.Text = "Issue Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admIssue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admIssueDgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label admIssueLblUserID;
        private System.Windows.Forms.Label admIssueLblBookID;
        private System.Windows.Forms.TextBox admIssueTbxUserID;
        private System.Windows.Forms.TextBox amdIssueTbxBookID;
        private System.Windows.Forms.Button admIssueBtnIssue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button admIssueBtnSearch;
        private System.Windows.Forms.TextBox admIssueTbxSearchQuery;
        private System.Windows.Forms.RadioButton admIssueRbBoth;
        private System.Windows.Forms.RadioButton admIssueRbAuthor;
        private System.Windows.Forms.RadioButton admIssueRbTitle;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admIssueBooksBtnLogout;
        private System.Windows.Forms.Button admIssueBooksBtnBack;
        private LibraryDBDataSet12 libraryDBDataSet12;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private LibraryDBDataSet12TableAdapters.IssueTableAdapter issueTableAdapter;
        private LibraryDBDataSet16 libraryDBDataSet16;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSet16TableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridView admIssueDgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDaysPasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
    }
}
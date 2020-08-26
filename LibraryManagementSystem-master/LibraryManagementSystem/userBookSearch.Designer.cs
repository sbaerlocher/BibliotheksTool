namespace LibraryManagementSystem
{
    partial class userBookSearch
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usrBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.UserBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.UserBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.userBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.userBookSearchLblSearch = new System.Windows.Forms.Label();
            this.userBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bookidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibraryManagementSystem.LibraryDBDataSet();
            this.book_idTableAdapter = new LibraryManagementSystem.LibraryDBDataSetTableAdapters.book_idTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.usrBookSearchBtnLogout);
            this.panel1.Controls.Add(this.UserBookSearchBtnSearch);
            this.panel1.Controls.Add(this.UserBookSearchTbxQuery);
            this.panel1.Controls.Add(this.userBookSearchRbBoth);
            this.panel1.Controls.Add(this.userBookSearchRbAuthor);
            this.panel1.Controls.Add(this.userBookSearchRbTitle);
            this.panel1.Controls.Add(this.userBookSearchLblSearch);
            this.panel1.Controls.Add(this.userBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(43, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 722);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(980, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Issued Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.usrBookSearchBtnIssuedBooks_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(980, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.userBookSeacrhBtnChangePassword_Click);
            // 
            // usrBookSearchBtnLogout
            // 
            this.usrBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrBookSearchBtnLogout.Location = new System.Drawing.Point(1051, 85);
            this.usrBookSearchBtnLogout.Name = "usrBookSearchBtnLogout";
            this.usrBookSearchBtnLogout.Size = new System.Drawing.Size(75, 35);
            this.usrBookSearchBtnLogout.TabIndex = 21;
            this.usrBookSearchBtnLogout.Text = "Logout";
            this.usrBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.usrBookSearchBtnLogout.Click += new System.EventHandler(this.UserBookSearchBtnLogout_Click);
            // 
            // UserBookSearchBtnSearch
            // 
            this.UserBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchBtnSearch.Location = new System.Drawing.Point(460, 121);
            this.UserBookSearchBtnSearch.Name = "UserBookSearchBtnSearch";
            this.UserBookSearchBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.UserBookSearchBtnSearch.TabIndex = 19;
            this.UserBookSearchBtnSearch.Text = "Search";
            this.UserBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.UserBookSearchBtnSearch.Click += new System.EventHandler(this.UserBookSearchBtnSearch_Click);
            // 
            // UserBookSearchTbxQuery
            // 
            this.UserBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchTbxQuery.Location = new System.Drawing.Point(221, 92);
            this.UserBookSearchTbxQuery.Name = "UserBookSearchTbxQuery";
            this.UserBookSearchTbxQuery.Size = new System.Drawing.Size(327, 23);
            this.UserBookSearchTbxQuery.TabIndex = 18;
            // 
            // userBookSearchRbBoth
            // 
            this.userBookSearchRbBoth.AutoSize = true;
            this.userBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbBoth.Location = new System.Drawing.Point(364, 121);
            this.userBookSearchRbBoth.Name = "userBookSearchRbBoth";
            this.userBookSearchRbBoth.Size = new System.Drawing.Size(61, 24);
            this.userBookSearchRbBoth.TabIndex = 17;
            this.userBookSearchRbBoth.TabStop = true;
            this.userBookSearchRbBoth.Text = "Both";
            this.userBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbAuthor
            // 
            this.userBookSearchRbAuthor.AutoSize = true;
            this.userBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbAuthor.Location = new System.Drawing.Point(283, 121);
            this.userBookSearchRbAuthor.Name = "userBookSearchRbAuthor";
            this.userBookSearchRbAuthor.Size = new System.Drawing.Size(75, 24);
            this.userBookSearchRbAuthor.TabIndex = 16;
            this.userBookSearchRbAuthor.TabStop = true;
            this.userBookSearchRbAuthor.Text = "Author";
            this.userBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbTitle
            // 
            this.userBookSearchRbTitle.AutoSize = true;
            this.userBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbTitle.Location = new System.Drawing.Point(221, 121);
            this.userBookSearchRbTitle.Name = "userBookSearchRbTitle";
            this.userBookSearchRbTitle.Size = new System.Drawing.Size(56, 24);
            this.userBookSearchRbTitle.TabIndex = 15;
            this.userBookSearchRbTitle.TabStop = true;
            this.userBookSearchRbTitle.Text = "Title";
            this.userBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // userBookSearchLblSearch
            // 
            this.userBookSearchLblSearch.AutoSize = true;
            this.userBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchLblSearch.Location = new System.Drawing.Point(151, 95);
            this.userBookSearchLblSearch.Name = "userBookSearchLblSearch";
            this.userBookSearchLblSearch.Size = new System.Drawing.Size(64, 20);
            this.userBookSearchLblSearch.TabIndex = 14;
            this.userBookSearchLblSearch.Text = "Search:";
            // 
            // userBookSearchDgv
            // 
            this.userBookSearchDgv.AutoGenerateColumns = false;
            this.userBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookSearchDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.totalDaysPasedDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPubDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn});
            this.userBookSearchDgv.DataSource = this.bookidBindingSource;
            this.userBookSearchDgv.Location = new System.Drawing.Point(157, 207);
            this.userBookSearchDgv.Name = "userBookSearchDgv";
            this.userBookSearchDgv.Size = new System.Drawing.Size(969, 481);
            this.userBookSearchDgv.TabIndex = 13;
            this.userBookSearchDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userBookSearchDgv_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 51;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.Width = 85;
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
            this.userIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 111;
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
            // bookidBindingSource
            // 
            this.bookidBindingSource.DataMember = "book_id";
            this.bookidBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_idTableAdapter
            // 
            this.book_idTableAdapter.ClearBeforeFill = true;
            // 
            // userBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 781);
            this.Controls.Add(this.panel1);
            this.Name = "userBookSearch";
            this.Text = "Search Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usrBookSearchBtnLogout;
        private System.Windows.Forms.Button UserBookSearchBtnSearch;
        private System.Windows.Forms.TextBox UserBookSearchTbxQuery;
        private System.Windows.Forms.RadioButton userBookSearchRbBoth;
        private System.Windows.Forms.RadioButton userBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton userBookSearchRbTitle;
        private System.Windows.Forms.Label userBookSearchLblSearch;
        private System.Windows.Forms.DataGridView userBookSearchDgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource bookidBindingSource;
        private LibraryDBDataSetTableAdapters.book_idTableAdapter book_idTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
    }
}
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
            this.admIssueDgvTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.admIssueBtnIssue = new System.Windows.Forms.Button();
            this.admIssueTbxUserID = new System.Windows.Forms.TextBox();
            this.amdIssueTbxBookID = new System.Windows.Forms.TextBox();
            this.admIssueLblUserID = new System.Windows.Forms.Label();
            this.admIssueLblBookID = new System.Windows.Forms.Label();
            this.libraryDBDataSet12 = new LibraryManagementSystem.LibraryDBDataSet12();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueTableAdapter = new LibraryManagementSystem.LibraryDBDataSet12TableAdapters.IssueTableAdapter();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDaysPassedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPublicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admIssueDgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admIssueBooksBtnLogout);
            this.panel1.Controls.Add(this.admIssueBooksBtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admIssueBtnSearch);
            this.panel1.Controls.Add(this.admIssueTbxSearchQuery);
            this.panel1.Controls.Add(this.admIssueRbBoth);
            this.panel1.Controls.Add(this.admIssueRbAuthor);
            this.panel1.Controls.Add(this.admIssueRbTitle);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admIssueDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.admIssueBtnIssue);
            this.panel1.Controls.Add(this.admIssueTbxUserID);
            this.panel1.Controls.Add(this.amdIssueTbxBookID);
            this.panel1.Controls.Add(this.admIssueLblUserID);
            this.panel1.Controls.Add(this.admIssueLblBookID);
            this.panel1.Location = new System.Drawing.Point(104, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 1094);
            this.panel1.TabIndex = 0;
            // 
            // admIssueBooksBtnLogout
            // 
            this.admIssueBooksBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBooksBtnLogout.Location = new System.Drawing.Point(1076, 26);
            this.admIssueBooksBtnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueBooksBtnLogout.Name = "admIssueBooksBtnLogout";
            this.admIssueBooksBtnLogout.Size = new System.Drawing.Size(116, 46);
            this.admIssueBooksBtnLogout.TabIndex = 68;
            this.admIssueBooksBtnLogout.Text = "Logout";
            this.admIssueBooksBtnLogout.UseVisualStyleBackColor = true;
            this.admIssueBooksBtnLogout.Click += new System.EventHandler(this.admIssueBooksBtnLogout_Click);
            // 
            // admIssueBooksBtnBack
            // 
            this.admIssueBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBooksBtnBack.Location = new System.Drawing.Point(38, 26);
            this.admIssueBooksBtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueBooksBtnBack.Name = "admIssueBooksBtnBack";
            this.admIssueBooksBtnBack.Size = new System.Drawing.Size(116, 46);
            this.admIssueBooksBtnBack.TabIndex = 67;
            this.admIssueBooksBtnBack.Text = "Back";
            this.admIssueBooksBtnBack.UseVisualStyleBackColor = true;
            this.admIssueBooksBtnBack.Click += new System.EventHandler(this.admIssueBooksBtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "( Only books that are not issued )";
            // 
            // admIssueBtnSearch
            // 
            this.admIssueBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueBtnSearch.Location = new System.Drawing.Point(828, 314);
            this.admIssueBtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueBtnSearch.Name = "admIssueBtnSearch";
            this.admIssueBtnSearch.Size = new System.Drawing.Size(132, 51);
            this.admIssueBtnSearch.TabIndex = 64;
            this.admIssueBtnSearch.Text = "Search";
            this.admIssueBtnSearch.UseVisualStyleBackColor = true;
            this.admIssueBtnSearch.Click += new System.EventHandler(this.admIssueBtnSearch_Click);
            // 
            // admIssueTbxSearchQuery
            // 
            this.admIssueTbxSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueTbxSearchQuery.Location = new System.Drawing.Point(298, 269);
            this.admIssueTbxSearchQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueTbxSearchQuery.Name = "admIssueTbxSearchQuery";
            this.admIssueTbxSearchQuery.Size = new System.Drawing.Size(660, 30);
            this.admIssueTbxSearchQuery.TabIndex = 63;
            // 
            // admIssueRbBoth
            // 
            this.admIssueRbBoth.AutoSize = true;
            this.admIssueRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbBoth.Location = new System.Drawing.Point(513, 314);
            this.admIssueRbBoth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueRbBoth.Name = "admIssueRbBoth";
            this.admIssueRbBoth.Size = new System.Drawing.Size(87, 33);
            this.admIssueRbBoth.TabIndex = 62;
            this.admIssueRbBoth.TabStop = true;
            this.admIssueRbBoth.Text = "Both";
            this.admIssueRbBoth.UseVisualStyleBackColor = true;
            // 
            // admIssueRbAuthor
            // 
            this.admIssueRbAuthor.AutoSize = true;
            this.admIssueRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbAuthor.Location = new System.Drawing.Point(392, 314);
            this.admIssueRbAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueRbAuthor.Name = "admIssueRbAuthor";
            this.admIssueRbAuthor.Size = new System.Drawing.Size(107, 33);
            this.admIssueRbAuthor.TabIndex = 61;
            this.admIssueRbAuthor.TabStop = true;
            this.admIssueRbAuthor.Text = "Author";
            this.admIssueRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admIssueRbTitle
            // 
            this.admIssueRbTitle.AutoSize = true;
            this.admIssueRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueRbTitle.Location = new System.Drawing.Point(298, 314);
            this.admIssueRbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueRbTitle.Name = "admIssueRbTitle";
            this.admIssueRbTitle.Size = new System.Drawing.Size(86, 33);
            this.admIssueRbTitle.TabIndex = 60;
            this.admIssueRbTitle.TabStop = true;
            this.admIssueRbTitle.Text = "Title";
            this.admIssueRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(194, 274);
            this.admBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(95, 29);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "Search:";
            // 
            // admIssueDgvTable
            // 
            this.admIssueDgvTable.AutoGenerateColumns = false;
            this.admIssueDgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.admIssueDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admIssueDgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateIssuedDataGridViewTextBoxColumn,
            this.totalDaysPassedDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPublicationDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn});
            this.admIssueDgvTable.DataSource = this.issueBindingSource;
            this.admIssueDgvTable.Location = new System.Drawing.Point(38, 432);
            this.admIssueDgvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueDgvTable.Name = "admIssueDgvTable";
            this.admIssueDgvTable.RowHeadersWidth = 62;
            this.admIssueDgvTable.Size = new System.Drawing.Size(1154, 623);
            this.admIssueDgvTable.TabIndex = 58;
            this.admIssueDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admIssueDgvTable_CellClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(38, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1154, 3);
            this.label7.TabIndex = 57;
            // 
            // admIssueBtnIssue
            // 
            this.admIssueBtnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueBtnIssue.Location = new System.Drawing.Point(512, 157);
            this.admIssueBtnIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueBtnIssue.Name = "admIssueBtnIssue";
            this.admIssueBtnIssue.Size = new System.Drawing.Size(144, 51);
            this.admIssueBtnIssue.TabIndex = 19;
            this.admIssueBtnIssue.Text = "Issue";
            this.admIssueBtnIssue.UseVisualStyleBackColor = true;
            this.admIssueBtnIssue.Click += new System.EventHandler(this.admIssueBtnIssue_Click);
            // 
            // admIssueTbxUserID
            // 
            this.admIssueTbxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueTbxUserID.Location = new System.Drawing.Point(561, 100);
            this.admIssueTbxUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admIssueTbxUserID.Name = "admIssueTbxUserID";
            this.admIssueTbxUserID.Size = new System.Drawing.Size(224, 43);
            this.admIssueTbxUserID.TabIndex = 18;
            // 
            // amdIssueTbxBookID
            // 
            this.amdIssueTbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amdIssueTbxBookID.Location = new System.Drawing.Point(561, 29);
            this.amdIssueTbxBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amdIssueTbxBookID.Name = "amdIssueTbxBookID";
            this.amdIssueTbxBookID.Size = new System.Drawing.Size(224, 43);
            this.amdIssueTbxBookID.TabIndex = 17;
            this.amdIssueTbxBookID.TextChanged += new System.EventHandler(this.amdIssueTbxBookID_TextChanged);
            // 
            // admIssueLblUserID
            // 
            this.admIssueLblUserID.AutoSize = true;
            this.admIssueLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admIssueLblUserID.Location = new System.Drawing.Point(400, 105);
            this.admIssueLblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admIssueLblUserID.Name = "admIssueLblUserID";
            this.admIssueLblUserID.Size = new System.Drawing.Size(142, 37);
            this.admIssueLblUserID.TabIndex = 16;
            this.admIssueLblUserID.Text = "User ID: ";
            // 
            // admIssueLblBookID
            // 
            this.admIssueLblBookID.AutoSize = true;
            this.admIssueLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admIssueLblBookID.Location = new System.Drawing.Point(394, 34);
            this.admIssueLblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admIssueLblBookID.Name = "admIssueLblBookID";
            this.admIssueLblBookID.Size = new System.Drawing.Size(148, 37);
            this.admIssueLblBookID.TabIndex = 15;
            this.admIssueLblBookID.Text = "Book ID: ";
            // 
            // libraryDBDataSet12
            // 
            this.libraryDBDataSet12.DataSetName = "LibraryDBDataSet12";
            this.libraryDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataMember = "Issue";
            this.issueBindingSource.DataSource = this.libraryDBDataSet12;
            // 
            // issueTableAdapter
            // 
            this.issueTableAdapter.ClearBeforeFill = true;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 132;
            // 
            // totalDaysPassedDataGridViewTextBoxColumn
            // 
            this.totalDaysPassedDataGridViewTextBoxColumn.DataPropertyName = "Total days passed";
            this.totalDaysPassedDataGridViewTextBoxColumn.HeaderText = "Total days passed";
            this.totalDaysPassedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDaysPassedDataGridViewTextBoxColumn.Name = "totalDaysPassedDataGridViewTextBoxColumn";
            this.totalDaysPassedDataGridViewTextBoxColumn.Width = 159;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 74;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 93;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 110;
            // 
            // yearOfPublicationDataGridViewTextBoxColumn
            // 
            this.yearOfPublicationDataGridViewTextBoxColumn.DataPropertyName = "Year of Publication";
            this.yearOfPublicationDataGridViewTextBoxColumn.HeaderText = "Year of Publication";
            this.yearOfPublicationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearOfPublicationDataGridViewTextBoxColumn.Name = "yearOfPublicationDataGridViewTextBoxColumn";
            this.yearOfPublicationDataGridViewTextBoxColumn.Width = 163;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            this.genresDataGridViewTextBoxColumn.Width = 98;
            // 
            // admIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 1050);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admIssue";
            this.Text = "Issue Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admIssue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admIssueDgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView admIssueDgvTable;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDaysPassedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
    }
}
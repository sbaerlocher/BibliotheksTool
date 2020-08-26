namespace LibraryManagementSystem
{
    partial class admEditBookDB
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
            this.admEditBookDBBtnClear = new System.Windows.Forms.Button();
            this.editBookDBBtnAddToDB = new System.Windows.Forms.Button();
            this.editBookDBBtnDelete = new System.Windows.Forms.Button();
            this.editBookDBBtnSave = new System.Windows.Forms.Button();
            this.editBookDBBtnSearch = new System.Windows.Forms.Button();
            this.editBookDBTbxSearch = new System.Windows.Forms.TextBox();
            this.admEditBookDBRbBoth = new System.Windows.Forms.RadioButton();
            this.admEditBookDBRbAuthor = new System.Windows.Forms.RadioButton();
            this.admEditBookDBRbTitle = new System.Windows.Forms.RadioButton();
            this.editBookDBLblSearch = new System.Windows.Forms.Label();
            this.editBookDBDgvTable = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDaysPasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet4 = new LibraryManagementSystem.LibraryDBDataSet4();
            this.label7 = new System.Windows.Forms.Label();
            this.editBookDBTbxGenres = new System.Windows.Forms.TextBox();
            this.editBookDBTbxTitle = new System.Windows.Forms.TextBox();
            this.editBookDBTbxAuthor = new System.Windows.Forms.TextBox();
            this.editBookDBTbxPublisher = new System.Windows.Forms.TextBox();
            this.editBookDBTbxYop = new System.Windows.Forms.TextBox();
            this.editBookDBTbxBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admEditBookDBBtnLogout = new System.Windows.Forms.Button();
            this.admEditBookDBBtnBack = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet3 = new LibraryManagementSystem.LibraryDBDataSet3();
            this.bookidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibraryManagementSystem.LibraryDBDataSet();
            this.book_idTableAdapter = new LibraryManagementSystem.LibraryDBDataSetTableAdapters.book_idTableAdapter();
            this.booksTableAdapter = new LibraryManagementSystem.LibraryDBDataSet3TableAdapters.booksTableAdapter();
            this.booksTableAdapter1 = new LibraryManagementSystem.LibraryDBDataSet4TableAdapters.booksTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBookDBDgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admEditBookDBBtnClear);
            this.panel1.Controls.Add(this.editBookDBBtnAddToDB);
            this.panel1.Controls.Add(this.editBookDBBtnDelete);
            this.panel1.Controls.Add(this.editBookDBBtnSave);
            this.panel1.Controls.Add(this.editBookDBBtnSearch);
            this.panel1.Controls.Add(this.editBookDBTbxSearch);
            this.panel1.Controls.Add(this.admEditBookDBRbBoth);
            this.panel1.Controls.Add(this.admEditBookDBRbAuthor);
            this.panel1.Controls.Add(this.admEditBookDBRbTitle);
            this.panel1.Controls.Add(this.editBookDBLblSearch);
            this.panel1.Controls.Add(this.editBookDBDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.editBookDBTbxGenres);
            this.panel1.Controls.Add(this.editBookDBTbxTitle);
            this.panel1.Controls.Add(this.editBookDBTbxAuthor);
            this.panel1.Controls.Add(this.editBookDBTbxPublisher);
            this.panel1.Controls.Add(this.editBookDBTbxYop);
            this.panel1.Controls.Add(this.editBookDBTbxBookID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admEditBookDBBtnLogout);
            this.panel1.Controls.Add(this.admEditBookDBBtnBack);
            this.panel1.Location = new System.Drawing.Point(58, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 1186);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admEditBookDBBtnClear
            // 
            this.admEditBookDBBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBBtnClear.Location = new System.Drawing.Point(1320, 868);
            this.admEditBookDBBtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admEditBookDBBtnClear.Name = "admEditBookDBBtnClear";
            this.admEditBookDBBtnClear.Size = new System.Drawing.Size(196, 60);
            this.admEditBookDBBtnClear.TabIndex = 67;
            this.admEditBookDBBtnClear.Text = "Clear Boxes";
            this.admEditBookDBBtnClear.UseVisualStyleBackColor = true;
            this.admEditBookDBBtnClear.Click += new System.EventHandler(this.admEditBookDBBtnClear_Click);
            // 
            // editBookDBBtnAddToDB
            // 
            this.editBookDBBtnAddToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBBtnAddToDB.Location = new System.Drawing.Point(396, 1006);
            this.editBookDBBtnAddToDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBBtnAddToDB.Name = "editBookDBBtnAddToDB";
            this.editBookDBBtnAddToDB.Size = new System.Drawing.Size(224, 83);
            this.editBookDBBtnAddToDB.TabIndex = 56;
            this.editBookDBBtnAddToDB.Text = "Add to DB";
            this.editBookDBBtnAddToDB.UseVisualStyleBackColor = true;
            this.editBookDBBtnAddToDB.Click += new System.EventHandler(this.editBookDBBtnAddToDB_Click);
            // 
            // editBookDBBtnDelete
            // 
            this.editBookDBBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.editBookDBBtnDelete.Location = new System.Drawing.Point(1089, 1006);
            this.editBookDBBtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBBtnDelete.Name = "editBookDBBtnDelete";
            this.editBookDBBtnDelete.Size = new System.Drawing.Size(220, 83);
            this.editBookDBBtnDelete.TabIndex = 56;
            this.editBookDBBtnDelete.Text = "Delete";
            this.editBookDBBtnDelete.UseVisualStyleBackColor = true;
            this.editBookDBBtnDelete.Click += new System.EventHandler(this.editBookDBBtnDelete_Click);
            // 
            // editBookDBBtnSave
            // 
            this.editBookDBBtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBBtnSave.Location = new System.Drawing.Point(753, 1006);
            this.editBookDBBtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBBtnSave.Name = "editBookDBBtnSave";
            this.editBookDBBtnSave.Size = new System.Drawing.Size(213, 83);
            this.editBookDBBtnSave.TabIndex = 56;
            this.editBookDBBtnSave.Text = "Save Edit";
            this.editBookDBBtnSave.UseVisualStyleBackColor = true;
            this.editBookDBBtnSave.Click += new System.EventHandler(this.editBookDBBtnSave_Click);
            // 
            // editBookDBBtnSearch
            // 
            this.editBookDBBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBBtnSearch.Location = new System.Drawing.Point(1034, 228);
            this.editBookDBBtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBBtnSearch.Name = "editBookDBBtnSearch";
            this.editBookDBBtnSearch.Size = new System.Drawing.Size(132, 51);
            this.editBookDBBtnSearch.TabIndex = 2;
            this.editBookDBBtnSearch.Text = "Search";
            this.editBookDBBtnSearch.UseVisualStyleBackColor = true;
            this.editBookDBBtnSearch.Click += new System.EventHandler(this.editBookDBBtnSearch_Click);
            // 
            // editBookDBTbxSearch
            // 
            this.editBookDBTbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBTbxSearch.Location = new System.Drawing.Point(262, 183);
            this.editBookDBTbxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxSearch.Name = "editBookDBTbxSearch";
            this.editBookDBTbxSearch.Size = new System.Drawing.Size(901, 30);
            this.editBookDBTbxSearch.TabIndex = 1;
            this.editBookDBTbxSearch.TextChanged += new System.EventHandler(this.editBookDBTbxSearch_TextChanged);
            // 
            // admEditBookDBRbBoth
            // 
            this.admEditBookDBRbBoth.AutoSize = true;
            this.admEditBookDBRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBRbBoth.Location = new System.Drawing.Point(477, 228);
            this.admEditBookDBRbBoth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admEditBookDBRbBoth.Name = "admEditBookDBRbBoth";
            this.admEditBookDBRbBoth.Size = new System.Drawing.Size(87, 33);
            this.admEditBookDBRbBoth.TabIndex = 61;
            this.admEditBookDBRbBoth.TabStop = true;
            this.admEditBookDBRbBoth.Text = "Both";
            this.admEditBookDBRbBoth.UseVisualStyleBackColor = true;
            // 
            // admEditBookDBRbAuthor
            // 
            this.admEditBookDBRbAuthor.AutoSize = true;
            this.admEditBookDBRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBRbAuthor.Location = new System.Drawing.Point(356, 228);
            this.admEditBookDBRbAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admEditBookDBRbAuthor.Name = "admEditBookDBRbAuthor";
            this.admEditBookDBRbAuthor.Size = new System.Drawing.Size(107, 33);
            this.admEditBookDBRbAuthor.TabIndex = 60;
            this.admEditBookDBRbAuthor.TabStop = true;
            this.admEditBookDBRbAuthor.Text = "Author";
            this.admEditBookDBRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admEditBookDBRbTitle
            // 
            this.admEditBookDBRbTitle.AutoSize = true;
            this.admEditBookDBRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admEditBookDBRbTitle.Location = new System.Drawing.Point(262, 228);
            this.admEditBookDBRbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admEditBookDBRbTitle.Name = "admEditBookDBRbTitle";
            this.admEditBookDBRbTitle.Size = new System.Drawing.Size(86, 33);
            this.admEditBookDBRbTitle.TabIndex = 59;
            this.admEditBookDBRbTitle.TabStop = true;
            this.admEditBookDBRbTitle.Text = "Title";
            this.admEditBookDBRbTitle.UseVisualStyleBackColor = true;
            // 
            // editBookDBLblSearch
            // 
            this.editBookDBLblSearch.AutoSize = true;
            this.editBookDBLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookDBLblSearch.Location = new System.Drawing.Point(148, 188);
            this.editBookDBLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editBookDBLblSearch.Name = "editBookDBLblSearch";
            this.editBookDBLblSearch.Size = new System.Drawing.Size(95, 29);
            this.editBookDBLblSearch.TabIndex = 58;
            this.editBookDBLblSearch.Text = "Search:";
            // 
            // editBookDBDgvTable
            // 
            this.editBookDBDgvTable.AutoGenerateColumns = false;
            this.editBookDBDgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editBookDBDgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editBookDBDgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.editBookDBDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editBookDBDgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearOfPubDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.totalDaysPasedDataGridViewTextBoxColumn,
            this.Place});
            this.editBookDBDgvTable.DataSource = this.booksBindingSource1;
            this.editBookDBDgvTable.Location = new System.Drawing.Point(153, 311);
            this.editBookDBDgvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBDgvTable.Name = "editBookDBDgvTable";
            this.editBookDBDgvTable.RowHeadersWidth = 62;
            this.editBookDBDgvTable.Size = new System.Drawing.Size(1454, 260);
            this.editBookDBDgvTable.TabIndex = 57;
            this.editBookDBDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editBookDBDgvTable_CellClick);
            this.editBookDBDgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editBookDBDgvTable_CellContentClick);
            // 
            // Book_ID
            // 
            this.Book_ID.DataPropertyName = "Book_ID";
            this.Book_ID.HeaderText = "Book_ID";
            this.Book_ID.MinimumWidth = 8;
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            this.Book_ID.Width = 123;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 85;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 106;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 129;
            // 
            // yearOfPubDataGridViewTextBoxColumn
            // 
            this.yearOfPubDataGridViewTextBoxColumn.DataPropertyName = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.HeaderText = "Year of Pub";
            this.yearOfPubDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearOfPubDataGridViewTextBoxColumn.Name = "yearOfPubDataGridViewTextBoxColumn";
            this.yearOfPubDataGridViewTextBoxColumn.Width = 107;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            this.genresDataGridViewTextBoxColumn.Width = 112;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 134;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 140;
            // 
            // totalDaysPasedDataGridViewTextBoxColumn
            // 
            this.totalDaysPasedDataGridViewTextBoxColumn.DataPropertyName = "Total days pased";
            this.totalDaysPasedDataGridViewTextBoxColumn.HeaderText = "Total days pased";
            this.totalDaysPasedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDaysPasedDataGridViewTextBoxColumn.Name = "totalDaysPasedDataGridViewTextBoxColumn";
            this.totalDaysPasedDataGridViewTextBoxColumn.Width = 181;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "Place";
            this.Place.MinimumWidth = 8;
            this.Place.Name = "Place";
            this.Place.Width = 97;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "books";
            this.booksBindingSource1.DataSource = this.libraryDBDataSet4;
            // 
            // libraryDBDataSet4
            // 
            this.libraryDBDataSet4.DataSetName = "LibraryDBDataSet4";
            this.libraryDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(153, 640);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1454, 3);
            this.label7.TabIndex = 56;
            // 
            // editBookDBTbxGenres
            // 
            this.editBookDBTbxGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editBookDBTbxGenres.Location = new System.Drawing.Point(279, 882);
            this.editBookDBTbxGenres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxGenres.Name = "editBookDBTbxGenres";
            this.editBookDBTbxGenres.Size = new System.Drawing.Size(769, 30);
            this.editBookDBTbxGenres.TabIndex = 53;
            // 
            // editBookDBTbxTitle
            // 
            this.editBookDBTbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editBookDBTbxTitle.Location = new System.Drawing.Point(279, 757);
            this.editBookDBTbxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxTitle.Name = "editBookDBTbxTitle";
            this.editBookDBTbxTitle.Size = new System.Drawing.Size(769, 30);
            this.editBookDBTbxTitle.TabIndex = 51;
            this.editBookDBTbxTitle.TextChanged += new System.EventHandler(this.editBookDBTbxTitle_TextChanged);
            // 
            // editBookDBTbxAuthor
            // 
            this.editBookDBTbxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editBookDBTbxAuthor.Location = new System.Drawing.Point(1320, 762);
            this.editBookDBTbxAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxAuthor.Name = "editBookDBTbxAuthor";
            this.editBookDBTbxAuthor.Size = new System.Drawing.Size(298, 30);
            this.editBookDBTbxAuthor.TabIndex = 54;
            // 
            // editBookDBTbxPublisher
            // 
            this.editBookDBTbxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editBookDBTbxPublisher.Location = new System.Drawing.Point(279, 815);
            this.editBookDBTbxPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxPublisher.Name = "editBookDBTbxPublisher";
            this.editBookDBTbxPublisher.Size = new System.Drawing.Size(769, 30);
            this.editBookDBTbxPublisher.TabIndex = 52;
            // 
            // editBookDBTbxYop
            // 
            this.editBookDBTbxYop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editBookDBTbxYop.Location = new System.Drawing.Point(1448, 820);
            this.editBookDBTbxYop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxYop.Name = "editBookDBTbxYop";
            this.editBookDBTbxYop.Size = new System.Drawing.Size(170, 30);
            this.editBookDBTbxYop.TabIndex = 55;
            this.editBookDBTbxYop.TextChanged += new System.EventHandler(this.editBookDBTbxYop_TextChanged);
            // 
            // editBookDBTbxBookID
            // 
            this.editBookDBTbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editBookDBTbxBookID.Location = new System.Drawing.Point(279, 705);
            this.editBookDBTbxBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBookDBTbxBookID.Name = "editBookDBTbxBookID";
            this.editBookDBTbxBookID.Size = new System.Drawing.Size(116, 30);
            this.editBookDBTbxBookID.TabIndex = 50;
            this.editBookDBTbxBookID.TextChanged += new System.EventHandler(this.editBookDBTbxBookID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(147, 815);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Publisher :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(148, 705);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 48;
            this.label5.Text = "Book ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(147, 882);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Genres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1192, 762);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Author :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1192, 820);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Year of Publication :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(148, 762);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Title :";
            // 
            // admEditBookDBBtnLogout
            // 
            this.admEditBookDBBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admEditBookDBBtnLogout.Location = new System.Drawing.Point(1494, 123);
            this.admEditBookDBBtnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admEditBookDBBtnLogout.Name = "admEditBookDBBtnLogout";
            this.admEditBookDBBtnLogout.Size = new System.Drawing.Size(112, 54);
            this.admEditBookDBBtnLogout.TabIndex = 43;
            this.admEditBookDBBtnLogout.Text = "Logout";
            this.admEditBookDBBtnLogout.UseVisualStyleBackColor = true;
            this.admEditBookDBBtnLogout.Click += new System.EventHandler(this.admEditBookDBBtnLogout_Click);
            // 
            // admEditBookDBBtnBack
            // 
            this.admEditBookDBBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admEditBookDBBtnBack.Location = new System.Drawing.Point(148, 97);
            this.admEditBookDBBtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admEditBookDBBtnBack.Name = "admEditBookDBBtnBack";
            this.admEditBookDBBtnBack.Size = new System.Drawing.Size(123, 54);
            this.admEditBookDBBtnBack.TabIndex = 42;
            this.admEditBookDBBtnBack.Text = "Back";
            this.admEditBookDBBtnBack.UseVisualStyleBackColor = true;
            this.admEditBookDBBtnBack.Click += new System.EventHandler(this.admEditBookDBBtnBack_Click);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet3;
            // 
            // libraryDBDataSet3
            // 
            this.libraryDBDataSet3.DataSetName = "LibraryDBDataSet3";
            this.libraryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // admEditBookDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 1050);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admEditBookDB";
            this.Text = "Edit Book DB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admEditBookDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBookDBDgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBookDBBtnSearch;
        private System.Windows.Forms.TextBox editBookDBTbxSearch;
        private System.Windows.Forms.RadioButton admEditBookDBRbBoth;
        private System.Windows.Forms.RadioButton admEditBookDBRbAuthor;
        private System.Windows.Forms.RadioButton admEditBookDBRbTitle;
        private System.Windows.Forms.Label editBookDBLblSearch;
        private System.Windows.Forms.DataGridView editBookDBDgvTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editBookDBTbxGenres;
        private System.Windows.Forms.TextBox editBookDBTbxTitle;
        private System.Windows.Forms.TextBox editBookDBTbxAuthor;
        private System.Windows.Forms.TextBox editBookDBTbxPublisher;
        private System.Windows.Forms.TextBox editBookDBTbxYop;
        private System.Windows.Forms.TextBox editBookDBTbxBookID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admEditBookDBBtnLogout;
        private System.Windows.Forms.Button admEditBookDBBtnBack;
        private System.Windows.Forms.Button editBookDBBtnDelete;
        private System.Windows.Forms.Button editBookDBBtnSave;
        private System.Windows.Forms.Button editBookDBBtnAddToDB;
        private System.Windows.Forms.Button admEditBookDBBtnClear;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource bookidBindingSource;
        private LibraryDBDataSetTableAdapters.book_idTableAdapter book_idTableAdapter;
        private LibraryDBDataSet3 libraryDBDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSet3TableAdapters.booksTableAdapter booksTableAdapter;
        private LibraryDBDataSet4 libraryDBDataSet4;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryDBDataSet4TableAdapters.booksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDaysPasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
    }
}
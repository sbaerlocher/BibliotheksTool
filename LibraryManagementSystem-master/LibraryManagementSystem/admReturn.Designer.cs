namespace LibraryManagementSystem
{
    partial class admReturn
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
            this.admReturnBooksBtnLogout = new System.Windows.Forms.Button();
            this.admReturnBooksBtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admReturnBtnSearch = new System.Windows.Forms.Button();
            this.admReturnTbxSearchQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.admReturnDgvTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.admReturnBtnReturn = new System.Windows.Forms.Button();
            this.admReturnTbxUserID = new System.Windows.Forms.TextBox();
            this.amdReturnTbxBookID = new System.Windows.Forms.TextBox();
            this.admReturnLblUserID = new System.Windows.Forms.Label();
            this.admReturnLblBookID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admReturnBooksLblFine = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.libraryDBDataSet13 = new LibraryManagementSystem.LibraryDBDataSet13();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueTableAdapter = new LibraryManagementSystem.LibraryDBDataSet13TableAdapters.IssueTableAdapter();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDaysPassedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.admReturnDgvTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // admReturnBooksBtnLogout
            // 
            this.admReturnBooksBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBooksBtnLogout.Location = new System.Drawing.Point(1076, 26);
            this.admReturnBooksBtnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnBooksBtnLogout.Name = "admReturnBooksBtnLogout";
            this.admReturnBooksBtnLogout.Size = new System.Drawing.Size(116, 46);
            this.admReturnBooksBtnLogout.TabIndex = 68;
            this.admReturnBooksBtnLogout.Text = "Logout";
            this.admReturnBooksBtnLogout.UseVisualStyleBackColor = true;
            this.admReturnBooksBtnLogout.Click += new System.EventHandler(this.admReturnBooksBtnLogout_Click);
            // 
            // admReturnBooksBtnBack
            // 
            this.admReturnBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBooksBtnBack.Location = new System.Drawing.Point(38, 26);
            this.admReturnBooksBtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnBooksBtnBack.Name = "admReturnBooksBtnBack";
            this.admReturnBooksBtnBack.Size = new System.Drawing.Size(116, 46);
            this.admReturnBooksBtnBack.TabIndex = 67;
            this.admReturnBooksBtnBack.Text = "Back";
            this.admReturnBooksBtnBack.UseVisualStyleBackColor = true;
            this.admReturnBooksBtnBack.Click += new System.EventHandler(this.admReturnBooksBtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "( Only books that are issued )";
            // 
            // admReturnBtnSearch
            // 
            this.admReturnBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBtnSearch.Location = new System.Drawing.Point(828, 406);
            this.admReturnBtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnBtnSearch.Name = "admReturnBtnSearch";
            this.admReturnBtnSearch.Size = new System.Drawing.Size(132, 51);
            this.admReturnBtnSearch.TabIndex = 64;
            this.admReturnBtnSearch.Text = "Search";
            this.admReturnBtnSearch.UseVisualStyleBackColor = true;
            this.admReturnBtnSearch.Click += new System.EventHandler(this.admReturnBtnSearch_Click);
            // 
            // admReturnTbxSearchQuery
            // 
            this.admReturnTbxSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnTbxSearchQuery.Location = new System.Drawing.Point(298, 362);
            this.admReturnTbxSearchQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnTbxSearchQuery.Name = "admReturnTbxSearchQuery";
            this.admReturnTbxSearchQuery.Size = new System.Drawing.Size(660, 30);
            this.admReturnTbxSearchQuery.TabIndex = 63;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(62, 366);
            this.admBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(224, 29);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "User ID or Book ID :";
            // 
            // admReturnDgvTable
            // 
            this.admReturnDgvTable.AutoGenerateColumns = false;
            this.admReturnDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admReturnDgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateIssuedDataGridViewTextBoxColumn,
            this.totalDaysPassedDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn});
            this.admReturnDgvTable.DataSource = this.issueBindingSource;
            this.admReturnDgvTable.Location = new System.Drawing.Point(38, 523);
            this.admReturnDgvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnDgvTable.Name = "admReturnDgvTable";
            this.admReturnDgvTable.RowHeadersWidth = 62;
            this.admReturnDgvTable.Size = new System.Drawing.Size(1154, 623);
            this.admReturnDgvTable.TabIndex = 58;
            this.admReturnDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admReturnDgvTable_CellClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(38, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1154, 3);
            this.label7.TabIndex = 57;
            // 
            // admReturnBtnReturn
            // 
            this.admReturnBtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnBtnReturn.Location = new System.Drawing.Point(510, 240);
            this.admReturnBtnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnBtnReturn.Name = "admReturnBtnReturn";
            this.admReturnBtnReturn.Size = new System.Drawing.Size(144, 51);
            this.admReturnBtnReturn.TabIndex = 19;
            this.admReturnBtnReturn.Text = "Return";
            this.admReturnBtnReturn.UseVisualStyleBackColor = true;
            this.admReturnBtnReturn.Click += new System.EventHandler(this.admReturnBtnReturn_Click);
            // 
            // admReturnTbxUserID
            // 
            this.admReturnTbxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnTbxUserID.Location = new System.Drawing.Point(561, 100);
            this.admReturnTbxUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admReturnTbxUserID.Name = "admReturnTbxUserID";
            this.admReturnTbxUserID.Size = new System.Drawing.Size(224, 43);
            this.admReturnTbxUserID.TabIndex = 18;
            // 
            // amdReturnTbxBookID
            // 
            this.amdReturnTbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amdReturnTbxBookID.Location = new System.Drawing.Point(561, 29);
            this.amdReturnTbxBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amdReturnTbxBookID.Name = "amdReturnTbxBookID";
            this.amdReturnTbxBookID.Size = new System.Drawing.Size(224, 43);
            this.amdReturnTbxBookID.TabIndex = 17;
            // 
            // admReturnLblUserID
            // 
            this.admReturnLblUserID.AutoSize = true;
            this.admReturnLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnLblUserID.Location = new System.Drawing.Point(400, 105);
            this.admReturnLblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admReturnLblUserID.Name = "admReturnLblUserID";
            this.admReturnLblUserID.Size = new System.Drawing.Size(142, 37);
            this.admReturnLblUserID.TabIndex = 16;
            this.admReturnLblUserID.Text = "User ID: ";
            // 
            // admReturnLblBookID
            // 
            this.admReturnLblBookID.AutoSize = true;
            this.admReturnLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnLblBookID.Location = new System.Drawing.Point(394, 34);
            this.admReturnLblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admReturnLblBookID.Name = "admReturnLblBookID";
            this.admReturnLblBookID.Size = new System.Drawing.Size(148, 37);
            this.admReturnLblBookID.TabIndex = 15;
            this.admReturnLblBookID.Text = "Book ID: ";
            this.admReturnLblBookID.Click += new System.EventHandler(this.admReturnLblBookID_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admReturnBooksLblFine);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.admReturnBooksBtnLogout);
            this.panel1.Controls.Add(this.admReturnBooksBtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admReturnBtnSearch);
            this.panel1.Controls.Add(this.admReturnTbxSearchQuery);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admReturnDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.admReturnBtnReturn);
            this.panel1.Controls.Add(this.admReturnTbxUserID);
            this.panel1.Controls.Add(this.amdReturnTbxBookID);
            this.panel1.Controls.Add(this.admReturnLblUserID);
            this.panel1.Controls.Add(this.admReturnLblBookID);
            this.panel1.Location = new System.Drawing.Point(57, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 1180);
            this.panel1.TabIndex = 1;
            // 
            // admReturnBooksLblFine
            // 
            this.admReturnBooksLblFine.AutoSize = true;
            this.admReturnBooksLblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnBooksLblFine.Location = new System.Drawing.Point(554, 168);
            this.admReturnBooksLblFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admReturnBooksLblFine.Name = "admReturnBooksLblFine";
            this.admReturnBooksLblFine.Size = new System.Drawing.Size(0, 37);
            this.admReturnBooksLblFine.TabIndex = 70;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label.Location = new System.Drawing.Point(435, 168);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 37);
            this.label.TabIndex = 69;
            this.label.Text = "Fine : ";
            // 
            // libraryDBDataSet13
            // 
            this.libraryDBDataSet13.DataSetName = "LibraryDBDataSet13";
            this.libraryDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataMember = "Issue";
            this.issueBindingSource.DataSource = this.libraryDBDataSet13;
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
            this.dateIssuedDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDaysPassedDataGridViewTextBoxColumn
            // 
            this.totalDaysPassedDataGridViewTextBoxColumn.DataPropertyName = "Total days passed";
            this.totalDaysPassedDataGridViewTextBoxColumn.HeaderText = "Total days passed";
            this.totalDaysPassedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDaysPassedDataGridViewTextBoxColumn.Name = "totalDaysPassedDataGridViewTextBoxColumn";
            this.totalDaysPassedDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // admReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 1050);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admReturn";
            this.Text = "Return Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admReturnDgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admReturnBooksBtnLogout;
        private System.Windows.Forms.Button admReturnBooksBtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admReturnBtnSearch;
        private System.Windows.Forms.TextBox admReturnTbxSearchQuery;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.DataGridView admReturnDgvTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button admReturnBtnReturn;
        private System.Windows.Forms.TextBox admReturnTbxUserID;
        private System.Windows.Forms.TextBox amdReturnTbxBookID;
        private System.Windows.Forms.Label admReturnLblUserID;
        private System.Windows.Forms.Label admReturnLblBookID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label admReturnBooksLblFine;
        private System.Windows.Forms.Label label;
        private LibraryDBDataSet13 libraryDBDataSet13;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private LibraryDBDataSet13TableAdapters.IssueTableAdapter issueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDaysPassedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
    }
}
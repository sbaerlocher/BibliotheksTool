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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.admReturnBooksBtnLogout = new System.Windows.Forms.Button();
            this.admReturnBooksBtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admReturnBtnSearch = new System.Windows.Forms.Button();
            this.admReturnTbxSearchQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.admReturnDgvTable = new System.Windows.Forms.DataGridView();
            this.viewLendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet17 = new LibraryManagementSystem.LibraryDBDataSet17();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet13 = new LibraryManagementSystem.LibraryDBDataSet13();
            this.label7 = new System.Windows.Forms.Label();
            this.admReturnBtnReturn = new System.Windows.Forms.Button();
            this.amdReturnTbxLendID = new System.Windows.Forms.TextBox();
            this.admReturnLblBookID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admReturnBooksLblFine = new System.Windows.Forms.Label();
            this.issueTableAdapter = new LibraryManagementSystem.LibraryDBDataSet13TableAdapters.IssueTableAdapter();
            this.viewLendTableAdapter = new LibraryManagementSystem.LibraryDBDataSet17TableAdapters.ViewLendTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lend_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ablaufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.admReturnDgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet13)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admReturnBooksBtnLogout
            // 
            this.admReturnBooksBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBooksBtnLogout.Location = new System.Drawing.Point(717, 17);
            this.admReturnBooksBtnLogout.Name = "admReturnBooksBtnLogout";
            this.admReturnBooksBtnLogout.Size = new System.Drawing.Size(77, 30);
            this.admReturnBooksBtnLogout.TabIndex = 68;
            this.admReturnBooksBtnLogout.Text = "Logout";
            this.admReturnBooksBtnLogout.UseVisualStyleBackColor = true;
            this.admReturnBooksBtnLogout.Click += new System.EventHandler(this.admReturnBooksBtnLogout_Click);
            // 
            // admReturnBooksBtnBack
            // 
            this.admReturnBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBooksBtnBack.Location = new System.Drawing.Point(25, 17);
            this.admReturnBooksBtnBack.Name = "admReturnBooksBtnBack";
            this.admReturnBooksBtnBack.Size = new System.Drawing.Size(77, 30);
            this.admReturnBooksBtnBack.TabIndex = 67;
            this.admReturnBooksBtnBack.Text = "Back";
            this.admReturnBooksBtnBack.UseVisualStyleBackColor = true;
            this.admReturnBooksBtnBack.Click += new System.EventHandler(this.admReturnBooksBtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "( Only books that are issued )";
            // 
            // admReturnBtnSearch
            // 
            this.admReturnBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBtnSearch.Location = new System.Drawing.Point(552, 264);
            this.admReturnBtnSearch.Name = "admReturnBtnSearch";
            this.admReturnBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.admReturnBtnSearch.TabIndex = 64;
            this.admReturnBtnSearch.Text = "Search";
            this.admReturnBtnSearch.UseVisualStyleBackColor = true;
            this.admReturnBtnSearch.Click += new System.EventHandler(this.admReturnBtnSearch_Click);
            // 
            // admReturnTbxSearchQuery
            // 
            this.admReturnTbxSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnTbxSearchQuery.Location = new System.Drawing.Point(199, 235);
            this.admReturnTbxSearchQuery.Name = "admReturnTbxSearchQuery";
            this.admReturnTbxSearchQuery.Size = new System.Drawing.Size(441, 23);
            this.admReturnTbxSearchQuery.TabIndex = 63;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(41, 238);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(152, 20);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "User ID or Book ID :";
            // 
            // admReturnDgvTable
            // 
            this.admReturnDgvTable.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admReturnDgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.admReturnDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admReturnDgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Title,
            this.dataGridViewTextBoxColumn3,
            this.customerDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.ablaufDataGridViewTextBoxColumn});
            this.admReturnDgvTable.DataSource = this.viewLendBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admReturnDgvTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.admReturnDgvTable.Location = new System.Drawing.Point(25, 340);
            this.admReturnDgvTable.Name = "admReturnDgvTable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admReturnDgvTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.admReturnDgvTable.RowHeadersWidth = 62;
            this.admReturnDgvTable.Size = new System.Drawing.Size(769, 405);
            this.admReturnDgvTable.TabIndex = 58;
            this.admReturnDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admReturnDgvTable_CellClick);
            // 
            // viewLendBindingSource
            // 
            this.viewLendBindingSource.DataMember = "ViewLend";
            this.viewLendBindingSource.DataSource = this.libraryDBDataSet17;
            // 
            // libraryDBDataSet17
            // 
            this.libraryDBDataSet17.DataSetName = "LibraryDBDataSet17";
            this.libraryDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataMember = "Issue";
            this.issueBindingSource.DataSource = this.libraryDBDataSet13;
            // 
            // libraryDBDataSet13
            // 
            this.libraryDBDataSet13.DataSetName = "LibraryDBDataSet13";
            this.libraryDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(25, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(769, 2);
            this.label7.TabIndex = 57;
            // 
            // admReturnBtnReturn
            // 
            this.admReturnBtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnBtnReturn.Location = new System.Drawing.Point(429, 109);
            this.admReturnBtnReturn.Name = "admReturnBtnReturn";
            this.admReturnBtnReturn.Size = new System.Drawing.Size(96, 33);
            this.admReturnBtnReturn.TabIndex = 19;
            this.admReturnBtnReturn.Text = "Return";
            this.admReturnBtnReturn.UseVisualStyleBackColor = true;
            this.admReturnBtnReturn.Click += new System.EventHandler(this.admReturnBtnReturn_Click);
            // 
            // amdReturnTbxLendID
            // 
            this.amdReturnTbxLendID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amdReturnTbxLendID.Location = new System.Drawing.Point(374, 19);
            this.amdReturnTbxLendID.Name = "amdReturnTbxLendID";
            this.amdReturnTbxLendID.Size = new System.Drawing.Size(151, 31);
            this.amdReturnTbxLendID.TabIndex = 17;
            // 
            // admReturnLblBookID
            // 
            this.admReturnLblBookID.AutoSize = true;
            this.admReturnLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnLblBookID.Location = new System.Drawing.Point(263, 22);
            this.admReturnLblBookID.Name = "admReturnLblBookID";
            this.admReturnLblBookID.Size = new System.Drawing.Size(98, 25);
            this.admReturnLblBookID.TabIndex = 15;
            this.admReturnLblBookID.Text = "Lend ID: ";
            this.admReturnLblBookID.Click += new System.EventHandler(this.admReturnBtnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.admReturnBooksLblFine);
            this.panel1.Controls.Add(this.admReturnBooksBtnLogout);
            this.panel1.Controls.Add(this.admReturnBooksBtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admReturnBtnSearch);
            this.panel1.Controls.Add(this.admReturnTbxSearchQuery);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admReturnDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.admReturnBtnReturn);
            this.panel1.Controls.Add(this.amdReturnTbxLendID);
            this.panel1.Controls.Add(this.admReturnLblBookID);
            this.panel1.Location = new System.Drawing.Point(50, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 624);
            this.panel1.TabIndex = 1;
            // 
            // admReturnBooksLblFine
            // 
            this.admReturnBooksLblFine.AutoSize = true;
            this.admReturnBooksLblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnBooksLblFine.Location = new System.Drawing.Point(369, 109);
            this.admReturnBooksLblFine.Name = "admReturnBooksLblFine";
            this.admReturnBooksLblFine.Size = new System.Drawing.Size(0, 25);
            this.admReturnBooksLblFine.TabIndex = 70;
            // 
            // issueTableAdapter
            // 
            this.issueTableAdapter.ClearBeforeFill = true;
            // 
            // viewLendTableAdapter
            // 
            this.viewLendTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // Lend_ID
            // 
            this.Lend_ID.DataPropertyName = "Lend_ID";
            this.Lend_ID.HeaderText = "Lend_ID";
            this.Lend_ID.Name = "Lend_ID";
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Lend_ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // User_ID
            // 
            this.User_ID.DataPropertyName = "User_ID";
            this.User_ID.HeaderText = "User_ID";
            this.User_ID.Name = "User_ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Lend_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Lend_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "User_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "User_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // ablaufDataGridViewTextBoxColumn
            // 
            this.ablaufDataGridViewTextBoxColumn.DataPropertyName = "Ablauf";
            this.ablaufDataGridViewTextBoxColumn.HeaderText = "Ablauf";
            this.ablaufDataGridViewTextBoxColumn.Name = "ablaufDataGridViewTextBoxColumn";
            this.ablaufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // admReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 664);
            this.Controls.Add(this.panel1);
            this.Name = "admReturn";
            this.Text = "Return Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admReturnDgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox amdReturnTbxLendID;
        private System.Windows.Forms.Label admReturnLblBookID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label admReturnBooksLblFine;
        private LibraryDBDataSet13 libraryDBDataSet13;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private LibraryDBDataSet13TableAdapters.IssueTableAdapter issueTableAdapter;
        private LibraryDBDataSet17 libraryDBDataSet17;
        private System.Windows.Forms.BindingSource viewLendBindingSource;
        private LibraryDBDataSet17TableAdapters.ViewLendTableAdapter viewLendTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lend_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ablaufDataGridViewTextBoxColumn;
    }
}
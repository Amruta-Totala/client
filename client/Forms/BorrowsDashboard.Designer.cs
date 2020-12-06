﻿
namespace client.Forms
{
    partial class BorrowsDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBorrows = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.lblFilterByName = new System.Windows.Forms.Label();
            this.pbxCreditDeposit = new System.Windows.Forms.ProgressBar();
            this.pbxBorrowingBalance = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtpCreditDeposit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBorrowingBalance = new System.Windows.Forms.DateTimePicker();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvCreditDeposit = new System.Windows.Forms.DataGridView();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnClrFilter = new System.Windows.Forms.Button();
            this.lblCreditDeposit = new System.Windows.Forms.Label();
            this.lblBorrowingBalance = new System.Windows.Forms.Label();
            this.dgvBorrowingBalance = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBorrows
            // 
            this.lblBorrows.AutoSize = true;
            this.lblBorrows.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblBorrows.Location = new System.Drawing.Point(14, 27);
            this.lblBorrows.Name = "lblBorrows";
            this.lblBorrows.Size = new System.Drawing.Size(119, 32);
            this.lblBorrows.TabIndex = 1;
            this.lblBorrows.Text = "Borrows";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.btnSearchName);
            this.pnlBody.Controls.Add(this.txtFilterName);
            this.pnlBody.Controls.Add(this.lblFilterName);
            this.pnlBody.Controls.Add(this.btnSearch);
            this.pnlBody.Controls.Add(this.txtFilterByName);
            this.pnlBody.Controls.Add(this.lblFilterByName);
            this.pnlBody.Controls.Add(this.pbxCreditDeposit);
            this.pnlBody.Controls.Add(this.pbxBorrowingBalance);
            this.pnlBody.Controls.Add(this.progressBar1);
            this.pnlBody.Controls.Add(this.dtpCreditDeposit);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.dtpBorrowingBalance);
            this.pnlBody.Controls.Add(this.lblFilterBy);
            this.pnlBody.Controls.Add(this.dgvCreditDeposit);
            this.pnlBody.Controls.Add(this.btnClearFilter);
            this.pnlBody.Controls.Add(this.btnClrFilter);
            this.pnlBody.Controls.Add(this.lblCreditDeposit);
            this.pnlBody.Controls.Add(this.lblBorrowingBalance);
            this.pnlBody.Controls.Add(this.dgvBorrowingBalance);
            this.pnlBody.Location = new System.Drawing.Point(8, 80);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1102, 893);
            this.pnlBody.TabIndex = 2;
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSearchName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchName.ForeColor = System.Drawing.Color.White;
            this.btnSearchName.Location = new System.Drawing.Point(880, 116);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(94, 37);
            this.btnSearchName.TabIndex = 20;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtFilterName
            // 
            this.txtFilterName.BackColor = System.Drawing.Color.White;
            this.txtFilterName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFilterName.ForeColor = System.Drawing.Color.Black;
            this.txtFilterName.Location = new System.Drawing.Point(698, 117);
            this.txtFilterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(174, 29);
            this.txtFilterName.TabIndex = 19;
            // 
            // lblFilterName
            // 
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterName.ForeColor = System.Drawing.Color.Black;
            this.lblFilterName.Location = new System.Drawing.Point(568, 123);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(135, 22);
            this.lblFilterName.TabIndex = 18;
            this.lblFilterName.Text = "Filter by name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(326, 116);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 37);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.BackColor = System.Drawing.Color.White;
            this.txtFilterByName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFilterByName.ForeColor = System.Drawing.Color.Black;
            this.txtFilterByName.Location = new System.Drawing.Point(144, 116);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(174, 29);
            this.txtFilterByName.TabIndex = 16;
            // 
            // lblFilterByName
            // 
            this.lblFilterByName.AutoSize = true;
            this.lblFilterByName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterByName.ForeColor = System.Drawing.Color.Black;
            this.lblFilterByName.Location = new System.Drawing.Point(15, 123);
            this.lblFilterByName.Name = "lblFilterByName";
            this.lblFilterByName.Size = new System.Drawing.Size(135, 22);
            this.lblFilterByName.TabIndex = 15;
            this.lblFilterByName.Text = "Filter by name";
            // 
            // pbxCreditDeposit
            // 
            this.pbxCreditDeposit.Location = new System.Drawing.Point(742, 448);
            this.pbxCreditDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxCreditDeposit.Name = "pbxCreditDeposit";
            this.pbxCreditDeposit.Size = new System.Drawing.Size(183, 27);
            this.pbxCreditDeposit.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbxCreditDeposit.TabIndex = 14;
            // 
            // pbxBorrowingBalance
            // 
            this.pbxBorrowingBalance.Location = new System.Drawing.Point(183, 448);
            this.pbxBorrowingBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxBorrowingBalance.Name = "pbxBorrowingBalance";
            this.pbxBorrowingBalance.Size = new System.Drawing.Size(183, 27);
            this.pbxBorrowingBalance.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbxBorrowingBalance.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-166, 169);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(114, 31);
            this.progressBar1.TabIndex = 12;
            // 
            // dtpCreditDeposit
            // 
            this.dtpCreditDeposit.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpCreditDeposit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpCreditDeposit.Location = new System.Drawing.Point(701, 155);
            this.dtpCreditDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpCreditDeposit.Name = "dtpCreditDeposit";
            this.dtpCreditDeposit.Size = new System.Drawing.Size(273, 29);
            this.dtpCreditDeposit.TabIndex = 11;
            this.dtpCreditDeposit.ValueChanged += new System.EventHandler(this.dtpCreditDeposit_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(568, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter by date";
            // 
            // dtpBorrowingBalance
            // 
            this.dtpBorrowingBalance.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpBorrowingBalance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpBorrowingBalance.Location = new System.Drawing.Point(144, 155);
            this.dtpBorrowingBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBorrowingBalance.Name = "dtpBorrowingBalance";
            this.dtpBorrowingBalance.Size = new System.Drawing.Size(275, 29);
            this.dtpBorrowingBalance.TabIndex = 9;
            this.dtpBorrowingBalance.ValueChanged += new System.EventHandler(this.dtpBorrowingBalance_ValueChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(15, 163);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(125, 22);
            this.lblFilterBy.TabIndex = 8;
            this.lblFilterBy.Text = "Filter by date";
            // 
            // dgvCreditDeposit
            // 
            this.dgvCreditDeposit.AllowUserToAddRows = false;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCreditDeposit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCreditDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditDeposit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCreditDeposit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditDeposit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCreditDeposit.ColumnHeadersHeight = 50;
            this.dgvCreditDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditDeposit.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCreditDeposit.GridColor = System.Drawing.Color.LightGray;
            this.dgvCreditDeposit.Location = new System.Drawing.Point(568, 204);
            this.dgvCreditDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCreditDeposit.Name = "dgvCreditDeposit";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditDeposit.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCreditDeposit.RowHeadersVisible = false;
            this.dgvCreditDeposit.RowHeadersWidth = 51;
            this.dgvCreditDeposit.RowTemplate.Height = 40;
            this.dgvCreditDeposit.Size = new System.Drawing.Size(522, 604);
            this.dgvCreditDeposit.TabIndex = 7;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(965, 816);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(126, 48);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnClrFilter
            // 
            this.btnClrFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnClrFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClrFilter.ForeColor = System.Drawing.Color.White;
            this.btnClrFilter.Location = new System.Drawing.Point(395, 816);
            this.btnClrFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClrFilter.Name = "btnClrFilter";
            this.btnClrFilter.Size = new System.Drawing.Size(126, 48);
            this.btnClrFilter.TabIndex = 4;
            this.btnClrFilter.Text = "Clear Filter";
            this.btnClrFilter.UseVisualStyleBackColor = false;
            this.btnClrFilter.Click += new System.EventHandler(this.btnClrFilter_Click);
            // 
            // lblCreditDeposit
            // 
            this.lblCreditDeposit.AutoSize = true;
            this.lblCreditDeposit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreditDeposit.ForeColor = System.Drawing.Color.Black;
            this.lblCreditDeposit.Location = new System.Drawing.Point(742, 33);
            this.lblCreditDeposit.Name = "lblCreditDeposit";
            this.lblCreditDeposit.Size = new System.Drawing.Size(189, 28);
            this.lblCreditDeposit.TabIndex = 3;
            this.lblCreditDeposit.Text = "Credit Deposit\'s";
            // 
            // lblBorrowingBalance
            // 
            this.lblBorrowingBalance.AutoSize = true;
            this.lblBorrowingBalance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrowingBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowingBalance.Location = new System.Drawing.Point(150, 33);
            this.lblBorrowingBalance.Name = "lblBorrowingBalance";
            this.lblBorrowingBalance.Size = new System.Drawing.Size(238, 28);
            this.lblBorrowingBalance.TabIndex = 2;
            this.lblBorrowingBalance.Text = "Borrowing Balance\'s";
            // 
            // dgvBorrowingBalance
            // 
            this.dgvBorrowingBalance.AllowUserToAddRows = false;
            this.dgvBorrowingBalance.AllowUserToResizeColumns = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBorrowingBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvBorrowingBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowingBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBorrowingBalance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowingBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvBorrowingBalance.ColumnHeadersHeight = 50;
            this.dgvBorrowingBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowingBalance.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvBorrowingBalance.GridColor = System.Drawing.Color.LightGray;
            this.dgvBorrowingBalance.Location = new System.Drawing.Point(15, 204);
            this.dgvBorrowingBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBorrowingBalance.Name = "dgvBorrowingBalance";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowingBalance.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvBorrowingBalance.RowHeadersVisible = false;
            this.dgvBorrowingBalance.RowHeadersWidth = 51;
            this.dgvBorrowingBalance.RowTemplate.Height = 40;
            this.dgvBorrowingBalance.Size = new System.Drawing.Size(506, 604);
            this.dgvBorrowingBalance.TabIndex = 0;
            this.dgvBorrowingBalance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowingBalance_CellContentClick);
            this.dgvBorrowingBalance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowingBalance_CellDoubleClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(749, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear Filter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear Filter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(592, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit Deposit\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(116, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrowing Balance\'s";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeight = 29;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.Size = new System.Drawing.Size(240, 150);
            this.dataGridView5.TabIndex = 0;
            // 
            // BorrowsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 989);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblBorrows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BorrowsDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowsDashboard";
            this.Load += new System.EventHandler(this.BorrowsDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorrowsDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorrowsDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorrowsDashboard_MouseUp);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBorrows;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnClrFilter;
        private System.Windows.Forms.Label lblCreditDeposit;
        private System.Windows.Forms.Label lblBorrowingBalance;
        private System.Windows.Forms.DataGridView dgvBorrowingBalance;
        private System.Windows.Forms.DataGridView dgvCreditDeposit;
        //////private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DateTimePicker dtpCreditDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBorrowingBalance;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ProgressBar pbxBorrowingBalance;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar pbxCreditDeposit;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Label lblFilterName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label lblFilterByName;
    }
}
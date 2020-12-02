﻿
namespace client.Forms
{
    partial class SaleReturnDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSaleReturn = new System.Windows.Forms.Label();
            this.dgvSaleReturn = new System.Windows.Forms.DataGridView();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dtpSaleReturn = new System.Windows.Forms.DateTimePicker();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.pbxSaleReturn = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaleReturn
            // 
            this.lblSaleReturn.AutoSize = true;
            this.lblSaleReturn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaleReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblSaleReturn.Location = new System.Drawing.Point(40, 31);
            this.lblSaleReturn.Name = "lblSaleReturn";
            this.lblSaleReturn.Size = new System.Drawing.Size(125, 25);
            this.lblSaleReturn.TabIndex = 0;
            this.lblSaleReturn.Text = "Sale Return";
            // 
            // dgvSaleReturn
            // 
            this.dgvSaleReturn.AllowUserToAddRows = false;
            this.dgvSaleReturn.AllowUserToResizeColumns = false;
            this.dgvSaleReturn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSaleReturn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaleReturn.ColumnHeadersHeight = 55;
            this.dgvSaleReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleReturn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleReturn.GridColor = System.Drawing.Color.LightGray;
            this.dgvSaleReturn.Location = new System.Drawing.Point(-1, 140);
            this.dgvSaleReturn.Name = "dgvSaleReturn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleReturn.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSaleReturn.RowHeadersVisible = false;
            this.dgvSaleReturn.RowHeadersWidth = 50;
            this.dgvSaleReturn.RowTemplate.Height = 30;
            this.dgvSaleReturn.Size = new System.Drawing.Size(983, 486);
            this.dgvSaleReturn.TabIndex = 1;
            this.dgvSaleReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleReturn_CellContentClick);
            this.dgvSaleReturn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleReturn_CellDoubleClick);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(40, 102);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(70, 19);
            this.lblFilterBy.TabIndex = 2;
            this.lblFilterBy.Text = "Filter by";
            // 
            // dtpSaleReturn
            // 
            this.dtpSaleReturn.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpSaleReturn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpSaleReturn.Location = new System.Drawing.Point(116, 99);
            this.dtpSaleReturn.Name = "dtpSaleReturn";
            this.dtpSaleReturn.Size = new System.Drawing.Size(254, 26);
            this.dtpSaleReturn.TabIndex = 3;
            this.dtpSaleReturn.ValueChanged += new System.EventHandler(this.dtpSaleReturn_ValueChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(810, 649);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(144, 43);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // pbxSaleReturn
            // 
            this.pbxSaleReturn.Location = new System.Drawing.Point(380, 327);
            this.pbxSaleReturn.Name = "pbxSaleReturn";
            this.pbxSaleReturn.Size = new System.Drawing.Size(217, 24);
            this.pbxSaleReturn.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbxSaleReturn.TabIndex = 5;
            // 
            // SaleReturnDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 742);
            this.Controls.Add(this.pbxSaleReturn);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.dtpSaleReturn);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.dgvSaleReturn);
            this.Controls.Add(this.lblSaleReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleReturnDashboard";
            this.Text = "SaleReturnDashboard";
            this.Activated += new System.EventHandler(this.SaleReturnDashboard_Activated);
            this.Load += new System.EventHandler(this.SaleReturnDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleReturn;
        private System.Windows.Forms.DataGridView dgvSaleReturn;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.DateTimePicker dtpSaleReturn;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ProgressBar pbxSaleReturn;
    }
}
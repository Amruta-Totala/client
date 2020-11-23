﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using client.Data;
namespace client.Forms
{
    public partial class Dashboard : Form
    {
        TransactionRepository  _transactionRepository;

        public Dashboard()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
        }

        private void btnRecords_MouseEnter(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnRecords_MouseLeave(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnDailySale_MouseEnter(object sender, EventArgs e)
        {
            btnDailySale.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnDailySale_MouseLeave(object sender, EventArgs e)
        {
            btnDailySale.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnCredentials_MouseEnter(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnCredentials_MouseLeave(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 0, 53, 92);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
             var source = new BindingSource();
            source.DataSource = _transactionRepository.GetAll().ToList();
            dgvRecords.AutoGenerateColumns = true;
            dgvRecords.DataSource = source;

        }

        private void btnAddRecords_Click(object sender, EventArgs e)
        {
            AddNewRecordsForm frm = new AddNewRecordsForm();
            frm.Show();

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;

namespace client.Forms
{
    public partial class EditBorrowForm : Form
    {
        
        BorrowRepository _borrowRepository;
        Borrow _borrow;
        bool flag = false;
        public static event LoadData OnLoadData;
        public EditBorrowForm(Borrow borrow)
        {
            InitializeComponent();
            _borrowRepository = new BorrowRepository();
            _borrow = borrow;
           
        }

        private void EditBorrowForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = _borrow.Amount.ToString();
                txtName.Text = _borrow.CustomerName.ToString();
                cbxIsDeposited.Checked = _borrow.IsReturned;
                if (_borrow.IsReturned)
                {
                    cbxIsDeposited.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete??", "Confirm Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _borrowRepository.Remove(_borrow);
                    OnLoadData();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty || txtAmount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("All fields required...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^[a-zA-Z]"))
                {
                    MessageBox.Show("Invaild Name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.Text.Remove(txtName.Text.Length - 1);
                    return;
                }
                _borrow.Amount = (decimal)Convert.ToDouble(txtAmount.Text);
                _borrow.CustomerName = Convert.ToString(txtName.Text);
                _borrow.IsReturned = cbxIsDeposited.Checked;

                await _borrowRepository.Update(_borrow);
                OnLoadData();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlBody.ClientRectangle, Color.DarkSlateBlue, ButtonBorderStyle.None);
            if (_borrow.IsReturned == true)
                cbxIsDeposited.Enabled = false;
        }

        private void pnlBody_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void pnlBody_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlBody_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

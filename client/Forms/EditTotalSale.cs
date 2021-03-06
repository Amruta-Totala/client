﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;

namespace client.Forms
{
    public partial class EditTotalSale : Form
    {
        TotalSaleRepository _totalsalerepository;
        TotalSale _totalsale;
        bool flag = false;
        public static event LoadData OnLoadData;
        public EditTotalSale(TotalSale totalSale)
        {
            InitializeComponent();
            _totalsalerepository = new TotalSaleRepository();
            _totalsale = totalSale;
            progessBar.Visible = false;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete??", "Confirm Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _totalsalerepository.Remove(_totalsale);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            try
            {
                progessBar.Visible = true;
                string path = await _totalsalerepository.GeneratePdf(_totalsale);
                MessageBox.Show("PDF Generated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progessBar.Visible = false;
                path = path.Replace("\\", "/");
                path = @"file:///" + path;
                Process.Start(new ProcessStartInfo("cmd", $"/c start {path}") { CreateNoWindow = true });
            }
            catch (Exception ex)
            {
                progessBar.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlBody.ClientRectangle, Color.DarkSlateBlue, ButtonBorderStyle.None);
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

        private void EditTotalSale_Load(object sender, EventArgs e)
        {
            try
            {
                this.IsMdiContainer = true;
                txtCashAmount.Text = _totalsale.CashAmount.ToString();
                txtCardAmount.Text = _totalsale.CardAmount.ToString();
                txtUpiAmount.Text = _totalsale.OnlineAmount.ToString();
                txtSaleReturnAmount.Text = _totalsale.SaleReturnAmount.ToString();
                txtTotalSale.Text = _totalsale.TotalSaleAmount.ToString();
                txtExtraAmount.Text = _totalsale.ExtraAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

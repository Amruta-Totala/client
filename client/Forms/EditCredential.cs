﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Data;

namespace client.Forms
{
    public partial class EditCredential : Form
    {
        bool flag = false;
        UserRepository _userRepository;
        User _user;
        public static event LoadData OnLoadData;
        public EditCredential()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailAddress.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Email Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();
                    return;
                }
                if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Password and Confirm Password should br match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmailAddress.Text, @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Invaild Email...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();
                    return;
                }
                _user.Email = Convert.ToString(txtEmailAddress.Text);
                _user.Password = Convert.ToString(txtPassword.Text);
                await _userRepository.Update(_user);
                OnLoadData();
                this.Dispose();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void EditCredential_Load(object sender, EventArgs e)
        {
            try
            {
                this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
                _user = await _userRepository.GetUser();
                txtEmailAddress.Text = _user.Email.ToString();
                txtPassword.Text = _user.Password.ToString();
                txtConfirmPassword.Text = _user.Password.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPassword.TextLength < 8)
            {
                this.errorProvider1.SetError(this.txtPassword, "Password must be at least 8 character");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtConfirmPassword.Text != this.txtPassword.Text)
            {
                this.errorProvider1.SetError(this.txtConfirmPassword, "Password and Confirm must be the same");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtConfirmPassword, "");
            }
        }

        private void cbVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVisibility.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtConfirmPassword.PasswordChar = '●';
            }
        }
    }
}

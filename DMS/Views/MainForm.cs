using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DMS.Services;

namespace DMS
{
    internal partial class MainForm : Form
    {
        private readonly AuthService _authService;
        internal MainForm(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String pass = txtPassword.Text;
			string test =
		System.Configuration.ConfigurationManager
			.AppSettings["ApiBaseUrl"];

			MessageBox.Show(
				test ?? "ApiBaseUrl = NULL");
			//await _authService.LoginAsync(username, pass);
			var result = await _authService.LoginAsync(
				   username,
				   pass);

			if (result == null)
			{
				MessageBox.Show("Błędne dane logowania!");
				return;
			}

			MessageBox.Show("Zalogowano poprawnie!");

			Hide();

			Dashboard dashboard = new Dashboard();
			dashboard.Show();
		}
    }
}

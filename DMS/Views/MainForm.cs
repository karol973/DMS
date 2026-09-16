using DMS.Models.Auth;
using DMS.Services;
using DMS.Views.Shared;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace DMS
{
   internal partial class MainForm : MaterialForm
   {
      private readonly AuthService _authService;
      private readonly PatientService _patientService;

      internal MainForm(
         AuthService authService,
         PatientService patientService)
      {
         InitializeComponent();

         _authService = authService;
         _patientService = patientService;

         MaterialTheme.Apply(this);

         StartPosition = FormStartPosition.CenterScreen;

         PrepareLoginLayout();

         Resize += MainForm_Resize;
      }

      private void MainForm_Resize(object sender, EventArgs e)
      {
         PrepareLoginLayout();
      }

      private void PrepareLoginLayout()
      {
         const int materialHeaderHeight = 64;

         int availableHeight =
            ClientSize.Height - materialHeaderHeight;

         // wyśrodkowanie calej karty
         materialCard1.Left =
            (ClientSize.Width - materialCard1.Width) / 2;

         materialCard1.Top =
            materialHeaderHeight +
            (availableHeight - materialCard1.Height) / 2;

         materialLabel1.Left =
            (materialCard1.ClientSize.Width -
             materialLabel1.Width) / 2;

         materialLabel2.Left =
            (materialCard1.ClientSize.Width -
             materialLabel2.Width) / 2;

         txtUserName.Left =
            (materialCard1.ClientSize.Width -
             txtUserName.Width) / 2;

         txtPassword.Left =
            (materialCard1.ClientSize.Width -
             txtPassword.Width) / 2;

         materialLabel3.Left = txtUserName.Left;
         materialLabel4.Left = txtPassword.Left;

         btnLogin.Left =
            (materialCard1.ClientSize.Width -
             btnLogin.Width) / 2;
      }

      private async void btnLogin_Click(
         object sender,
         EventArgs e)
      {
         string username = txtUserName.Text.Trim();
         string password = txtPassword.Text;

         if (string.IsNullOrWhiteSpace(username) ||
             string.IsNullOrWhiteSpace(password))
         {
            MessageBox.Show(
               "Podaj nazwę użytkownika i hasło.",
               "Logowanie",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            return;
         }

         btnLogin.Enabled = false;

         try
         {
            LoginResult result =
               await _authService.LoginAsync(
                  username,
                  password);

            if (result == null)
            {
               MessageBox.Show(
                  "Błędne dane logowania!",
                  "Logowanie",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

               return;
            }

            // Aplikacja desktopowa tylko dla Admin i Doctor
            if (result.UserRole != "Admin" &&
                result.UserRole != "Doctor")
            {
               MessageBox.Show(
                  "Nie masz uprawnień do aplikacji desktopowej.\n" +
                  "Dla pacjentów przeznaczony jest portal internetowy.",
                  "Brak uprawnień",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

               _authService.Logout();

               return;
            }

            Hide();

            Dashboard dashboard = new Dashboard(_patientService);

            dashboard.FormClosed += Dashboard_FormClosed;

            dashboard.Show();
         }
         catch (Exception ex)
         {
            MessageBox.Show(
               "Wystąpił błąd podczas logowania:\n" +
               ex.Message,
               "Błąd",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
         }
         finally
         {
            btnLogin.Enabled = true;
         }
      }

      private void Dashboard_FormClosed(
         object sender,
         FormClosedEventArgs e)
      {
         Show();
      }
   }
}
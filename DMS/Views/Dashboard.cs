using DMS.Services;
using DMS.Views.Shared;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace DMS
{
   internal partial class Dashboard : MaterialForm
   {
      private readonly PatientService _patientService;

      internal Dashboard(PatientService patientService)
      {
         InitializeComponent();

         _patientService = patientService;

         MaterialTheme.Apply(this);

         StartPosition = FormStartPosition.CenterScreen;
      }

      private async void Dashboard_Load(
         object sender,
         EventArgs e)
      {
         ShowPatientsView();

         try
         {
            var patients =
               await _patientService.GetPatientsAsync();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = patients;
         }
         catch (Exception ex)
         {
            MessageBox.Show(
               "Nie udało się pobrać listy pacjentów.\n" +
               ex.Message,
               "Błąd",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
         }
      }

      private void ShowPatientsView()
      {
         patientListCard.Visible = true;
         addPatientCard.Visible = false;

         patientListCard.BringToFront();
      }

      private void ShowAddPatientView()
      {
         patientListCard.Visible = false;
         addPatientCard.Visible = true;

         addPatientCard.BringToFront();
      }

      private void btnPatients_Click(
         object sender,
         EventArgs e)
      {
         ShowPatientsView();
      }

      private void btnAddPatient_Click(
         object sender,
         EventArgs e)
      {
         ShowAddPatientView();
      }

      private void btnAddDiagnosis_Click(
         object sender,
         EventArgs e)
      {
         MessageBox.Show(
            "Moduł diagnoz zostanie dodany w kolejnym etapie.",
            "Diagnozy",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
      }

      private void btnFullHistory_Click(
         object sender,
         EventArgs e)
      {
         MessageBox.Show(
            "Moduł historii leczenia zostanie dodany w kolejnym etapie.",
            "Historia leczenia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
      }

      private void btnDental_Click(
         object sender,
         EventArgs e)
      {
         MessageBox.Show(
            "Moduł informacji o gabinecie zostanie dodany w kolejnym etapie.",
            "Gabinet",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
      }

      private void btnSave_Click(
         object sender,
         EventArgs e)
      {
         // TODO:
         // tutaj później podepniemy CreatePatientCommand/API

         MessageBox.Show(
            "Zapisywanie pacjenta podepniemy do API.",
            "Dodaj pacjenta",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
      }

      private void btnCancelAddPatient_Click(
         object sender,
         EventArgs e)
      {
         ShowPatientsView();
      }

      private void btnExit_Click(
         object sender,
         EventArgs e)
      {
         Close();
      }
   }
}
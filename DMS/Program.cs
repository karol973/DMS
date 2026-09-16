using DMS.Services;
using DMS.Session;
using System;
using System.Windows.Forms;

namespace DMS
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ApiClient apiClient = new ApiClient();
			UserSession userSession = new UserSession();
			AuthService authService = new AuthService(apiClient, userSession);
			PatientService patientService = new PatientService(apiClient);

			Application.Run(new MainForm(authService, patientService));
		}
	}
}
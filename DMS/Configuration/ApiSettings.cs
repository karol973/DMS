using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Configuration
{
	internal static class ApiSettings
	{
		internal static string BaseUrl
		{
			get
			{
				string value =
					ConfigurationManager.AppSettings["ApiBaseUrl"];

				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ConfigurationErrorsException(
						"Brak Url w config");
				}

				return value;
			}
		}
	}
}

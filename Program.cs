using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace Quadro.UI
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			CultureInfo culture = CultureInfo.CreateSpecificCulture(ConfigurationManager.AppSettings["cultura"]);

			Application.CurrentCulture = culture;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Quadro());
		}
	}
}

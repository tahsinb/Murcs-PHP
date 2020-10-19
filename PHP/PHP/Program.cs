using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP.Database;

namespace PHP
{
	static class Program
	{

		[STAThread]
		static void Main()
		{
			AppSettings appSettings = new AppSettings()
			{
				URL = "database-1.cwocrrmlsxcx.us-east-1.rds.amazonaws.com",
				Port = "5432",
				UserName = " masterUser",
				Password = "7YhStMgcLH2VbZLtNNtw",
				DatabaseName = "test1"
			};
			PHPConext pHPConext = new PHPConext(appSettings);
			try
			{
				pHPConext.Database.EnsureCreated();
				pHPConext.SaveChanges();
				Console.WriteLine("DB Created");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			PHPRepo pHPRepo = new PHPRepo(pHPConext);




			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SalesPrediction(pHPRepo));
		}
	}
	public class AppSettings : IDatabaseAppSettings
	{
		public string URL { get; set; }
		public string Port { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string DatabaseName { get; set; }
	}
}

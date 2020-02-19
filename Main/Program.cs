using System;
using System.Windows.Forms;

namespace GMod_Server_Launcher_Console
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainForm() );
			Properties.Settings.Default.Save();
		}
	}
}

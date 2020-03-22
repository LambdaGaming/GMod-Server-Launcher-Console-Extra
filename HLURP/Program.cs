using System;
using System.Windows.Forms;

namespace HLURP_Server_Launcher
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

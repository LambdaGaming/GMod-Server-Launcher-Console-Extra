using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CityRP_Server_Launcher_UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string console = "";
		private string lan = "";
		private string map = "";

		private void LanCheck( object sender, EventArgs e )
		{
			if( lancheck.Checked )
			{
				lan = "+sv_lan 1";
				return;
			}
			lan = "";
		}

		private void ConsoleCheck( object sender, EventArgs e )
		{
			if( consolecheck.Checked )
			{
				console = "-console ";
			}
			else
			{
				console = "";
				map = "";
				mapselect.Text = "";
			}
			mapselect.Enabled = consolecheck.Checked;
		}

		private void MaxPlayersChanged( object sender, EventArgs e ){} // Unused for now

		private void MapChanged( object sender, EventArgs e )
		{
			map = "+map " + mapselect.SelectedItem.ToString();
		}

		private void StartButtonClick( object sender, EventArgs e )
		{
			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = @"E:\lambda_cityrp",
				FileName = @"E:\lambda_cityrp\srcds.exe",
				Arguments = "+gamemode darkrp " + console + lan + map + " +maxplayers " + maxplayers.Value + " +r_hunkalloclightmaps 0",
				WindowStyle = ProcessWindowStyle.Maximized
			};

			try
			{
				Process.Start( proc );
				Close();
			}
			catch ( Exception )
			{
				DialogResult launcherror = MessageBox.Show( "Failed to launch. Invalid file path.", "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				if ( launcherror == DialogResult.OK ) Close();
			}
		}
	}
}

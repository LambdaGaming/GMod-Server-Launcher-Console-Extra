using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CityRP_Server_Launcher_UI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			lancheck.Checked = Properties.Settings.Default.Lan;
			consolecheck.Checked = Properties.Settings.Default.Console;
			maxplayers.Value = Properties.Settings.Default.MaxPlayers;
			mapselect.Text = Properties.Settings.Default.Map;

			mapselect.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
		}

		public string ConsoleEnabled = "";
		public string LANEnabled = "";

		private void LanCheck( object sender, EventArgs e )
		{
			if ( lancheck.Checked )
			{
				LANEnabled = " +sv_lan 1 ";
				Properties.Settings.Default.Lan = lancheck.Checked;
				return;
			}
			LANEnabled = "";
			Properties.Settings.Default.Lan = lancheck.Checked;
		}

		private void ConsoleCheck( object sender, EventArgs e )
		{
			if ( consolecheck.Checked )
			{
				ConsoleEnabled = " -console ";
			}
			else
			{
				ConsoleEnabled = "";
				mapselect.Text = "";
			}
			mapselect.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
			Properties.Settings.Default.Console = consolecheck.Checked;
		}

		private void MaxPlayersChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.MaxPlayers = Convert.ToInt32( maxplayers.Value );
		}

		private void MapChanged( object sender, EventArgs e )
		{
			Properties.Settings.Default.Map = mapselect.SelectedItem.ToString();
		}

		private void StartButtonClick( object sender, EventArgs e )
		{
			string Token = System.IO.File.ReadAllText( @"E:\lambda_cityrp\token.txt" );
			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = @"E:\lambda_cityrp",
				FileName = @"E:\lambda_cityrp\srcds.exe",
				Arguments = "+gamemode darkrp " + ConsoleEnabled + LANEnabled + "+map " + mapselect.SelectedItem.ToString() + " +maxplayers " + maxplayers.Value + " +r_hunkalloclightmaps 0 +sv_setsteamaccount " + Token,
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

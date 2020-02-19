using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GMod_Server_Launcher_Console
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			lancheck.Checked = Properties.Settings.Default.Lan;
			consolecheck.Checked = Properties.Settings.Default.Console;
			maxplayers.Value = Properties.Settings.Default.MaxPlayers;
			gameselect.Text = Properties.Settings.Default.Gamemode;
			mapselect.Text = Properties.Settings.Default.Map;

			mapselect.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			gameselect.Enabled = consolecheck.Checked;

			if ( gameselect.Text == "cascade" ) mapselect.Enabled = false;
		}

		public string ConsoleEnabled = "";
		public string LANEnabled = "";

		public string CascadeMaps = "rp_bmrf";
		public string[] BMRPMaps = {
			"rp_sectorc_beta",
			"rp_blackmesa_laboratory",
			"rp_blackmesa_complex_fixed"
		};
		public string[] City17RPMaps = {
			"rp_city17_build210",
			"rp_city17_district47",
			"rp_city24_v2"
		};
		public string[] OutlandRPMaps = {
			"rp_ineu_valley2_v1a",
			"gm_boreas"
		};

		private void LanCheck( object sender, EventArgs e )
		{
			if( lancheck.Checked )
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
			if( consolecheck.Checked )
			{
				ConsoleEnabled = " -console ";
			}
			else
			{
				ConsoleEnabled = "";
				mapselect.Text = "";
				gameselect.Text = "";
			}
			mapselect.Enabled = consolecheck.Checked;
			lancheck.Enabled = consolecheck.Checked;
			maxplayers.Enabled = consolecheck.Checked;
			gameselect.Enabled = consolecheck.Checked;
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

		private void GamemodeChanged( object sender, EventArgs e )
		{
			if ( gameselect.Text == "cascade" )
			{
				mapselect.Enabled = false;
				mapselect.Items.Clear();
				mapselect.Items.Add( CascadeMaps );
				mapselect.SelectedItem = CascadeMaps;
			}
			else if ( gameselect.Text == "bmrphlu" )
			{
				mapselect.Enabled = true;
				mapselect.Items.Clear();

				foreach ( string map in BMRPMaps )
				{
					mapselect.Items.Add( map );
				}

				mapselect.SelectedItem = BMRPMaps[0];
			}
			else if ( gameselect.Text == "city17rp" )
			{
				mapselect.Enabled = true;
				mapselect.Items.Clear();

				foreach ( string map in City17RPMaps )
				{
					mapselect.Items.Add( map );
				}

				mapselect.SelectedItem = City17RPMaps[0];
			}
			else if ( gameselect.Text == "outlandrp" )
			{
				mapselect.Enabled = true;
				mapselect.Items.Clear();

				foreach ( string map in OutlandRPMaps )
				{
					mapselect.Items.Add( map );
				}

				mapselect.SelectedItem = OutlandRPMaps[0];
			}
			Properties.Settings.Default.Gamemode = gameselect.SelectedItem.ToString();
		}

		private void StartButtonClick( object sender, EventArgs e )
		{
			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = @"C:\lambdarp",
				FileName = @"C:\lambdarp\srcds.exe",
				Arguments = "+gamemode " + gameselect.SelectedItem.ToString() + ConsoleEnabled + LANEnabled + "+map " + mapselect.SelectedItem.ToString() + " +maxplayers " + maxplayers.Value + " +r_hunkalloclightmaps 0",
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}

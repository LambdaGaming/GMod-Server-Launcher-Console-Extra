using System;
using System.Diagnostics;

namespace ServerLauncher
{
	class Program
	{
		static void Main()
		{
			// Config starts here
			string Dir = @"E:\gmodserver"; // File path of the server exe, don't include the actual file
			string[] Maps = { // List of map names to get randomly chosen
                "fightspace3b",
				"gm_balkans",
				"gm_bigcity",
				"gm_bigisland",
				"gm_blackmesa_sigma",
				"gm_bluehills_test3",
				"gm_boreas",
				"gm_botmap_v3",
				"gm_construct",
				"gm_construct_flagrass_v6-2",
				"gm_dddustbowl2",
				"gm_drivingmap_workshop",
				"gm_flatgrass",
				"gm_flatgrass_abs_v3c",
				"gm_fork",
				"gm_freespace_09_extended",
				"gm_functional_flatgrass3",
				"gm_genesis",
				"gm_highway14800",
				"gm_lunarbase",
				"gm_mobenix_v3_final",
				"gm_mountainlake2",
				"gm_range_f4",
				"gm_secretconstruct_v3",
				"gm_tornadoflatgrass",
				"gm_tornadohighway_final",
				"gm_tornadonightfall",
				"gm_tornadovillage_final",
				"gm_underground_iv",
				"gm_valley",
				"gm_warmap_v5",
				"rp_rockford_open",
				"gm_atomic",
				"rp_bmrf",
				"rp_city17_build210",
				"rp_ineu_valley2_v1a",
				"rp_sectorc_beta",
				"rp_southside"
			};
			string Gamemode = "sandbox"; // Name of the gamemode folder
			int MaxPlayers = 24; // Number of players allowed on the server
			// End Config

			Random randstr = new Random();
			int randmap = randstr.Next( 0, Maps.Length );
			string Token = System.IO.File.ReadAllText( Dir + @"\token.txt" );

			var proc = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = Dir,
				FileName = Dir + @"\srcds.exe",
				Arguments = "+gamemode " + Gamemode + " -console +map " + Maps[randmap] + " +maxplayers " + MaxPlayers + " +r_hunkalloclightmaps 0 +sv_setsteamaccount " + Token,
				WindowStyle = ProcessWindowStyle.Maximized
			};

			try
			{
				Process.Start( proc );
			}
			catch ( Exception )
			{
				Console.WriteLine( "Failed to launch. Make sure the file path is correct." );
				Console.ReadLine();
				Environment.Exit( 3 );
			}
		}
	}
}

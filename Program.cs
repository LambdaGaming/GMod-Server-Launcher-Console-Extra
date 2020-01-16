using System;
using System.Diagnostics;

namespace CityRP_Server_Launcher
{
	class Program
	{
        static void Main()
        {
            // Config, might move to a separate file at some point so it doesn't need recompiled
            string Dir = @"E:\lambda_cityrp"; // File path of the server exe, don't include the actual file
            string[] Maps = new[] { // List of map names to print out
                "rp_rockford_v2b",
                "rp_chaos_city_v33x_03",
                "rp_evocity2_v5p",
                "rp_florida_v2",
                "rp_truenorth_v1a",
                "rp_newexton2_v4h"
            };
            string Gamemode = "darkrp"; // Name of the gamemode folder
            int MaxPlayers = 24; // Number of players allowed on the server
            // End Config

            StartSelect:
            Console.Clear();
            Console.Write( "Select Map: {0}\n", string.Join( ", ", Maps ) );

            bool success = Int32.TryParse( Console.ReadLine(), out int select );

            if( !success )
            {
                Console.WriteLine( "ERROR: Input must be a number. Press any key to continue." );
                Console.ReadLine();
                goto StartSelect;
            }

            if( select > Maps.Length )
            {
                Console.WriteLine( "ERROR: Picked a number that exceeds the number of maps. Press any key to continue." );
                Console.ReadLine();
                goto StartSelect;
            }

            var proc = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Dir,
                FileName = Dir + @"\srcds.exe",
                Arguments = "+gamemode " + Gamemode + " -console +map " + Maps[select] + " +maxplayers " + MaxPlayers + " +r_hunkalloclightmaps 0",
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

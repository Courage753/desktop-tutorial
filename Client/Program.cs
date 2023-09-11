using Npgsql;
using System.Runtime.CompilerServices;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectstr = "Server=192.168.7.198;Port=5432;Database=postgres;Username=joe;Password=Joe@6666";
            try 
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectstr);
                conn.Open();
                
            }
            catch (Exception ex)
            {

            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}
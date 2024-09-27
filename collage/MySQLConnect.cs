using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace collage
{
    public class MySQLConnect
    {
        internal static MySqlConnection myConnection;
        internal static MySqlCommandBuilder mySqlCommandBuilder;
        public static void Connect(string log, string pas)
        {
            string myConnectionString = $"Database=collage;Data Source=localhost;User Id={log};Password={pas}";
            myConnection = new MySqlConnection(myConnectionString);
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }
     
    }
}

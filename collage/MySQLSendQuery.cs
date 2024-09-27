using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Management;

namespace collage
{
    public class MySQLSendQuery : MySQLConnect
    {
        private static MySqlDataAdapter adapter;
        internal static DataSet ds { get; set; }
        public static DataSet SendQuery(string query_string)
        {
            
            if (myConnection.State == ConnectionState.Open)
            {
                adapter = new MySqlDataAdapter(query_string, myConnection);               
                DataSet data = new DataSet();
                adapter.Fill(data);
                ds = data;
                return ds;
            }
            else if(myConnection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Подключение разорвано");
                return new DataSet();
            }
            else
            {
                MessageBox.Show("Ошибка работы");
                return new DataSet();
            }

        }
        public static DataSet GetTable(string table_name)
        {
            return SendQuery("select * from " + table_name + ";");
        }
        public static void UpdateTable(DataSet dataTable,string name)
        {
           foreach(TablesandAtrributes t in MySQLFieldInfo.tb)
            {
                if(name ==t.nametable ) {


             adapter = new MySqlDataAdapter("UPDATE OR INSERT INTO"+t.nametable+$"VALUES({})", myConnection);
            adapter.Update(dataTable);
            }
                }
         
          
        }
    }
}

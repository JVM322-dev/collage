using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Management;
using System.Data;
namespace collage
{
    internal class Table
    {
        private static List<string> TbParameter(DataTable table)
        {
            List<string> list = new List<string>();
            DataColumnCollection data = table.Columns;
           foreach (DataColumn dt in data)
            {
                list.Add(dt.ColumnName);
            }
           return list;
        }
        public static string[] TableParams(DataTable tb)
        {
            return TbParameter(tb).ToArray();
        }
    }
}

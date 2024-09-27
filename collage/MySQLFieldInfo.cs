using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace collage
{
    public class MySQLFieldInfo : MySQLSendQuery
    {
       public static  List<TablesandAtrributes> tb  = new List<TablesandAtrributes>();
        public static DataTable GetStudentView()
        {
            DataTable table = MySQLSendQuery.GetTable("students").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("student",Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код студента";
            table.Columns[1].ColumnName = "Имя";
            table.Columns[2].ColumnName = "Фамилия";
            table.Columns[3].ColumnName = "Возраст";
            table.Columns[4].ColumnName = "Группа";
            table.Columns[5].ColumnName = "Код консультанта";
            return table;
        }
        public static DataTable GetTeacherView()
        {
            DataTable table = MySQLSendQuery.GetTable("teacher").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("teacher", Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код преподавателя";
            table.Columns[1].ColumnName = "Имя";
            table.Columns[2].ColumnName = "Фамилия";
            table.Columns[3].ColumnName = "Возраст";
            table.Columns[4].ColumnName = "Код студента";
            return table;
        }
        public static DataTable GetConsultantView()
        {
            DataTable table = MySQLSendQuery.GetTable("consultant").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("consultant", Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код консультатна";
            table.Columns[1].ColumnName = "Имя";
            table.Columns[2].ColumnName = "Фамилия";
            table.Columns[3].ColumnName = "Возраст";
            table.Columns[4].ColumnName = "Предмет";
            return table;
        }
        public static DataTable GetGroupView()
        {
            DataTable table = MySQLSendQuery.GetTable("groupsed").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("group", Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код группы";
            table.Columns[1].ColumnName = "Название";
            table.Columns[2].ColumnName = "Кол-во студентов";
            table.Columns[3].ColumnName = "Код специализации";
            table.Columns[4].ColumnName = "Код преподавателя";
            return table;
        }
        public static DataTable GetSpecializationView()
        {
            DataTable table = MySQLSendQuery.GetTable("specialitions").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("specialitions", Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код специализации";
            table.Columns[1].ColumnName = "Название";
            table.Columns[2].ColumnName = "Кол-во групп";
            return table;
        }
        public static DataTable GetVkrResultView()
        {
            DataTable table = MySQLSendQuery.GetTable("vkr_finaly_result").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("vkr_finaly_result", Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код работы";
            table.Columns[1].ColumnName = "Код специализации";
            table.Columns[2].ColumnName = "Код студента";
            table.Columns[3].ColumnName = "Код группы";
            table.Columns[4].ColumnName = "Имя консультанта";
            table.Columns[5].ColumnName = "Копия отзывов";
            table.Columns[6].ColumnName = "Рецензия";
            table.Columns[7].ColumnName = "Титульный лист";
            table.Columns[8].ColumnName = "PDF документ";
            table.Columns[9].ColumnName = "Текст работы";
            table.Columns[10].ColumnName = "Процент плагиата";

            return table;
        }
        public static DataTable GetVkrTopicView()
        {
            DataTable table = MySQLSendQuery.GetTable("vkr_topics").Tables[0];
            TablesandAtrributes tablesand = new TablesandAtrributes("vkr_topics", Table.TableParams(table));
            tb.Add(tablesand);
            table.Columns[0].ColumnName = "Код темы";
            table.Columns[1].ColumnName = "Название";
            table.Columns[2].ColumnName = "Сложность";
            return table;
        }
    }
}

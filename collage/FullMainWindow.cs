using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collage
{
    public partial class FullMainWindow : Form
    {
        public FullMainWindow()
        {
            InitializeComponent();          
            dGVMainWindow.DataSource = MySQLFieldInfo.GetStudentView();
            data.Add(dGVMainWindow);
            dGVConsult.DataSource = MySQLFieldInfo.GetConsultantView();
            data.Add(dGVConsult);
            dGVGroup.DataSource = MySQLFieldInfo.GetGroupView();
            data.Add(dGVGroup);
            dGVSpecialization.DataSource = MySQLFieldInfo.GetSpecializationView();
            data.Add(dGVSpecialization);
            dGVTeacher.DataSource = MySQLFieldInfo.GetTeacherView();
            data.Add(dGVTeacher);
            dGVVkr_Titles.DataSource = MySQLFieldInfo.GetVkrTopicView();
            data.Add(dGVVkr_Titles);
            dGV_VKR_JOBS.DataSource = MySQLFieldInfo.GetVkrResultView();  
            data.Add(dGV_VKR_JOBS);
           
        }
        private List<DataGridView> data = new List<DataGridView>();
       

        private void dGVMainWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tpFinalyVKR_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchStudent_TextChanged(object sender, EventArgs e)
        {
            dGVMainWindow.DataSource = MySQLFieldInfo.GetStudentView();
            if (tbSearchStudent.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGVMainWindow.Rows.Count; i++)
            {
                if (dGVMainWindow.Rows[i].Cells[2].Value != null)
                {
                    if (!dGVMainWindow.Rows[i].Cells[2].Value.ToString().ToLower().Contains(tbSearchStudent.Text.ToLower()))
                    {
                        dGVMainWindow.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void tbTeacherSearch_TextChanged(object sender, EventArgs e)
        {
            dGVTeacher.DataSource = MySQLFieldInfo.GetTeacherView();
            if (tbTeacherSearch.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGVTeacher.Rows.Count; i++)
            {
                if (dGVTeacher.Rows[i].Cells[2].Value != null)
                {
                    if (!dGVTeacher.Rows[i].Cells[2].Value.ToString().ToLower().Contains(tbTeacherSearch.Text.ToLower()))
                    {
                        dGVTeacher.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void tbGroupSearch_TextChanged(object sender, EventArgs e)
        {
            dGVGroup.DataSource = MySQLFieldInfo.GetGroupView();
            if (tbGroupSearch.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGVGroup.Rows.Count; i++)
            {
                if (dGVGroup.Rows[i].Cells[1].Value != null)
                {
                    if (!dGVGroup.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbGroupSearch.Text.ToLower()))
                    {
                        dGVGroup.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void tbConsult_TextChanged(object sender, EventArgs e)
        {
            dGVConsult.DataSource = MySQLFieldInfo.GetConsultantView();
            if (tbConsult.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGVConsult.Rows.Count; i++)
            {
                if (dGVConsult.Rows[i].Cells[2].Value != null)
                {
                    if (!dGVConsult.Rows[i].Cells[2].Value.ToString().ToLower().Contains(tbConsult.Text.ToLower()))
                    {
                        dGVConsult.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void tbSpecSearch_TextChanged(object sender, EventArgs e)
        {
            dGVSpecialization.DataSource = MySQLFieldInfo.GetSpecializationView();
            if (tbSpecSearch.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGVSpecialization.Rows.Count; i++)
            {
                if (dGVSpecialization.Rows[i].Cells[1].Value != null)
                {
                    if (!dGVSpecialization.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbSpecSearch.Text.ToLower()))
                    {
                        dGVSpecialization.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void tbVrkTitleSearch_TextChanged(object sender, EventArgs e)
        {
            dGVVkr_Titles.DataSource = MySQLFieldInfo.GetVkrTopicView();
            if (tbVrkTitleSearch.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGVVkr_Titles.Rows.Count; i++)
            {
                if (dGVVkr_Titles.Rows[i].Cells[1].Value != null)
                {
                    if (!dGVVkr_Titles.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbVrkTitleSearch.Text.ToLower()))
                    {
                        dGVVkr_Titles.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void tbJobVKRSearch_TextChanged(object sender, EventArgs e)
        {
            dGV_VKR_JOBS.DataSource = MySQLFieldInfo.GetVkrResultView();
            if (tbJobVKRSearch.Text.Length == 0)
            {
                return;
            }
            for (int i = 0; i < dGV_VKR_JOBS.Rows.Count; i++)
            {
                if (dGV_VKR_JOBS.Rows[i].Cells[4].Value != null)
                {
                    if (!dGV_VKR_JOBS.Rows[i].Cells[4].Value.ToString().ToLower().Contains(tbJobVKRSearch.Text.ToLower()))
                    {
                        dGV_VKR_JOBS.Rows.RemoveAt(i);
                        i--;
                    }
                }

            }
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            //if()
        }

        private void dGVMainWindow_KeyDown(object sender, KeyEventArgs e)
        {

        }
       
        internal DataSet DataSourceRebuild(string name)
        {
         DataSet source1 = new DataSet();
            foreach(DataGridView i  in data)
            {
                 source1.Tables.Add( BuildData(i));
            }
            return source1;
        }
        internal DataTable BuildData(DataGridView obs)
        {
           BindingSource source = (BindingSource)obs.DataSource;
            DataTable set  = (DataTable)source.DataSource;
            return set;
        }
        public 
        private void dGVTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGVTeacher_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void dGVTeacher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FullMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

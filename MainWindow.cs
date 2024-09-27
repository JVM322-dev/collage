using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace collage
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            MySQLConnect.Connect(tbLogin.Text, tbPassword.Text);
           // Captcha.Show(5);
            FullMainWindow fullMainWindow = new FullMainWindow();
            fullMainWindow.Show();
            
        }
    }
}

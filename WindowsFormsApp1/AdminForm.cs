using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public DataBase DB = new DataBase();
        public SuperUser admin = new SuperUser();

        /// <summary>
        /// \brief Конструктор для запуска экранной формы администратора 
        /// </summary>
        /// <param name="admin"></param>
        public AdminForm(SuperUser admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void Registration_button_click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm1 regform = new RegForm1(admin);
            regform.Show();
        }

        private void zapros_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                string script = "SELECT * FROM ";
                
                DB.connection.Open();

                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, DB.connection);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dgv.DataSource = table;
                
                DB.connection.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost");
            }*/
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                dgv.DataSource = table;
                table.Clear();
            }
            catch
            {
                MessageBox.Show("Connection lost");
            }
        }

        private void Device_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeviceForm devform = new DeviceForm(admin);
            devform.Show();
        }
    }
}

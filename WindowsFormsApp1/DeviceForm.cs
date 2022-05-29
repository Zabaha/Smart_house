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
    public partial class DeviceForm : Form
    {
        public SuperUser admin = new SuperUser();

        /// <summary>
        /// \brief Конструктор для инициализации экранной формы добавления устройства
        /// </summary>
        /// <param name="admin"></param>
        public DeviceForm(SuperUser admin)
        {
            InitializeComponent();
            devfield.Text = "Введите название устройства";
            devfield.ForeColor = Color.Gray;
            this.admin = admin;
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (devfield.Text == "Введите название устройства")
            {
                devfield.Text = "";
                devfield.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (devfield.Text == "")
            {
                devfield.Text = "Введите название устройства";
                devfield.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            Devices newDevice = new Devices();

            newDevice.SetStartInfo(devfield.Text, checkBox1.Checked);

            if (admin.AddNewDevice(newDevice, DB))
            {
                this.Hide();
                AdminForm adminform = new AdminForm(admin);
                adminform.Show();
            }
            else 
            {
                MessageBox.Show("Не получилось добавить дивайс");
            }
        }
    }
}

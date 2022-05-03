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
    public partial class UserForm : Form
    {
        public DataBase DB = new DataBase();
        public Devices device = new Devices();
        public User user = new User();

        /// <summary>
        /// \brief Конструктор для запуска пользовательской экранной формы
        /// </summary>
        /// <param name="user"></param>
        public UserForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void zapros_Click_1(object sender, EventArgs e)
        {
            try
            {
                Request request = new Request("запрос сформирован", "стандартный");
                string helpVar = "";

                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if (richTextBox1.Text[i] == ':')
                    {
                        device = DB.findeDevice(helpVar);
                        helpVar = "";
                    }
                    else
                    {
                        helpVar += richTextBox1.Text[i];
                    }
                }
                request.setDevice(device.getID());
                request.setUser(user.GetID());
                request.setName(helpVar);
                request.uploadToDB(DB);

                device.DataDevice(request, DB);
            }
            catch
            {
                MessageBox.Show("Запрос не обработан");
            }
        }

        private void Device_maneg_button_click(object sender, EventArgs e)
        {
            try
            {
                string helpVar = "";

                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if (richTextBox1.Text[i] == ':')
                    {
                        device.setID(Convert.ToInt32(helpVar));
                        helpVar = "";
                    }
                    else 
                    {
                        helpVar += richTextBox1.Text[i];
                    }
                }

                if (helpVar == "on")
                {
                    device.setON_OFF(true);
                }
                else if (helpVar == "off")
                {
                    device.setON_OFF(false);
                }

                device.UpdateDeviceInfo(DB);
            }
            catch
            {
                MessageBox.Show("Не получилось обновить данные");
            }
        }

        private void Show_devices_button_click(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = DB.getDevicesInfo();
            }
            catch
            {
                MessageBox.Show("Connection lost");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}

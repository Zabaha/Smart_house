using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class DataBase
    {
        public MySqlConnection connection;
        public MySqlCommand command;
        public MySqlCommand command2;
        public MySqlCommand command3;

        /// <summary>
        /// \brief Конструктор с подключением к базе данных
        /// </summary>
        public DataBase()
        {
            connection = new MySqlConnection("server=localhost;port=3307;" +
                "username=root;password=A23sv33s;database=Smart_House");
        }

        /// <summary>
        /// \brief Метод проверки на существования пользователя в базе данных
        /// </summary>
        /// <param name="NewUser"></param>
        /// <returns></returns>
        public bool isUserExist(User NewUser)
        {

            string script = "SELECT * FROM Authorization WHERE login = @UL;";

            connection.Open();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(script, connection);

            command = new MySqlCommand(script, connection);
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = NewUser.GetLoginAcc();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }

        /// <summary>
        /// \brief Метод проверки на существование аккаунта
        /// </summary>
        /// <returns></returns>
        public bool isNotEmpty()
        {
            string script = "SELECT * FROM Authorization;";

            connection.Open();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(script, connection);
            command = new MySqlCommand(script, connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        /// <summary>
        /// \brief Метод для проверки роли администратора или пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string AdminOrUser(string login, string password) 
        {
            string get_role_script = "select Users.role FROM Users JOIN Authorization " +
                "ON Authorization.account_id = Users.account " +
                "WHERE Authorization.login = @log AND Authorization.password = @pass;";

            connection.Open();

            DataTable role_table = new DataTable();
            MySqlDataAdapter role_adapter = new MySqlDataAdapter(get_role_script, connection);
            command = new MySqlCommand(get_role_script, connection);
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            role_adapter.SelectCommand = command;
            role_adapter.Fill(role_table);

            if (role_table.Rows.Count > 0)
            {
                connection.Close();
                return Convert.ToString(role_table.Rows[0][0]);
            }
            else
            {
                connection.Close();
                return "NULL";
            }
        }

        /// <summary>
        /// \brief Метод вывода информации об устройствах
        /// </summary>
        /// <returns></returns>
        public DataTable getDevicesInfo()
        {
            string script = "SELECT * FROM Device;";

            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connection.Close();

            return table;
        }

        /// <summary>
        /// \brief Метод получения информации из устройства по его наименованию
        /// </summary>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        public Devices findeDevice(string deviceName)
        {
            Devices findedDevice = new Devices();

            string script = "SELECT * FROM Device WHERE name = @name;";

            connection.Open();

            command = new MySqlCommand(script, connection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = deviceName;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(script, connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            findedDevice.setID(Convert.ToInt32(table.Rows[0][0]));
            findedDevice.setName(Convert.ToString(table.Rows[0][1]));
            findedDevice.setON_OFF(Convert.ToBoolean(table.Rows[0][4]));

            connection.Close();


            return findedDevice;
        }
    }
}

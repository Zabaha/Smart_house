using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class Request
    {
        private int ID;
        private string name;
        private string status;
        private string priority;
        private int device;
        private int user;

        /// <summary>
        /// \brief Конструктор класса Request, задает данные параметрам status и pryority
        /// </summary>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        public Request(string status, string priority) 
        {
            this.status = status;
            this.priority = priority;
        }

        /// <summary>
        /// \brief Метод для получения значения переменной status
        /// </summary>
        /// <returns></returns>
        public string getStatus()
        {
            return status;
        }

        /// <summary>
        /// \brief Метод для получения значения переменной ID
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return ID;
        }

        /// <summary>
        /// \brief Метод для получения значения переменной name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// \brief Метод установки занчения параметру name
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// \brief Метод установки занчения параметру deviceID
        /// </summary>
        /// <param name="deviceID"></param>
        public void setDevice(int deviceID)
        {
            device = deviceID;
        }

        /// <summary>
        /// \brief Метод установки занчения параметру userID
        /// </summary>
        /// <param name="userID"></param>
        public void setUser(int userID)
        {
            user = userID;
        }

        /// <summary>
        /// \brief Метод установки занчения параметру status
        /// </summary>
        /// <param name="status"></param>
        public void setStatus(string status)
        {
            this.status = status;
        }

        /// <summary>
        /// \brief Метод загружающий в базу данных всю информацию о запросе
        /// </summary>
        /// <returns></returns>
        public bool uploadToDB()
        {
            DataBase DB = new DataBase();
            string script = "INSERT INTO Info_Request (name, status, priority, device, user)" +
                " VALUES (@n, @s, @p, @d, @u);";
            DB.connection.Open();

            DB.command = new MySqlCommand(script, DB.connection);
            DB.command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            DB.command.Parameters.Add("@s", MySqlDbType.VarChar).Value = status;
            DB.command.Parameters.Add("@p", MySqlDbType.VarChar).Value = priority;
            DB.command.Parameters.Add("@d", MySqlDbType.Int32).Value = device;
            DB.command.Parameters.Add("@u", MySqlDbType.Int32).Value = user;

            if (DB.command.ExecuteNonQuery() != 1)
            {
                DB.connection.Close();
                return false;
            }

            string Get_ID_script = "SELECT request_id FROM Info_Request;";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Get_ID_script, DB.connection);
            DB.command = new MySqlCommand(Get_ID_script, DB.connection);
            adapter.SelectCommand = DB.command;
            adapter.Fill(table);

            ID = Convert.ToInt32(table.Rows[0][0]);

            DB.connection.Close();
            return true;
        }

        /// <summary>
        /// \brief Метод удаляющий запрос из базы данных, после окончания его обработке
        /// </summary>
        public void DelFinishedRequest() 
        {
            DataBase DB = new DataBase();
            string del_Req_script = "DELETE FROM Info_Request WHERE status = @stat;";
            DB.connection.Open();

            DB.command = new MySqlCommand(del_Req_script, DB.connection);
            DB.command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = "запрос обработан";

            if (DB.command.ExecuteNonQuery() == 1)
            {
                DB.connection.Close();
                return;
            }
            else
            {
                DB.connection.Close();
                MessageBox.Show("Не получилось удалить запрос");
                return;
            }
        }
    }
}

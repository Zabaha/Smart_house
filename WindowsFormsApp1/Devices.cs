using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class Devices
    {
        private int ID;
        private string name;
        private string data;
        private string status;
        private bool ON_OFF;


        /// <summary>
        /// \brief Метод получения имени
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// \brief Метод получения ID
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return ID;
        }

        /// <summary>
        /// \brief Метод получения состояния устройства
        /// </summary>
        /// <returns></returns>
        public bool getON_OFF()
        {
            return ON_OFF;
        }

        /// <summary>
        /// \brief Метод установки ID
        /// </summary>
        /// <param name="ID"></param>
        public void setID(int ID)
        {
            this.ID = ID;
        }

        /// <summary>
        /// \brief Метод установки состояния устройства
        /// </summary>
        /// <param name="ON_OFF"></param>
        public void setON_OFF(bool ON_OFF)
        {
            this.ON_OFF = ON_OFF;
        }

        /// <summary>
        /// \brief Метод установки наименования устройства
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// \brief Метод установки начальной информации
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ON_OFF"></param>
        public void SetStartInfo(string name, bool ON_OFF) 
        {
            this.name = name;
            this.ON_OFF = ON_OFF;
        }

        /// <summary>
        /// \brief Метод для обработки запроса на получение информации от устройства
        /// </summary>
        /// <param name="request"></param>
        /// <param name="DB"></param>
        public void DataDevice(Request request, DataBase DB) 
        {
            Random rnd = new Random();

            DB.connection.Open();

            string Starus_update_script = "UPDATE Info_Request SET status = @s WHERE request_id = @ID;";

            request.setStatus("запрос принят");

            DB.command = new MySqlCommand(Starus_update_script, DB.connection);
            DB.command.Parameters.Add("@s", MySqlDbType.VarChar).Value = request.getStatus();
            DB.command.Parameters.Add("@ID", MySqlDbType.Int32).Value = request.getID();

            if (DB.command.ExecuteNonQuery() != 1)
            {
                DB.connection.Close();
                return;
            }

            switch (request.getName()) 
            {
                case "узнать температуру":
                    data = Convert.ToString(rnd.Next(15, 36));
                    status = "отправка данных";
                    break;
                case "узнать напряжение":
                    data = Convert.ToString(rnd.Next(0, 1001));
                    status = "отправка данных";
                    break;
                case "узнать статус протечки":
                    data = Convert.ToString(rnd.Next(0, 2));
                    status = "отправка данных";
                    break;
                default:
                    MessageBox.Show("Такой команды нет");
                    break;


            }

            string data_set_script = "UPDATE Device SET data = @data, status = @stat" +
                " WHERE device_id = @ID;";

            DB.command2 = new MySqlCommand(data_set_script, DB.connection);
            DB.command2.Parameters.Add("@data", MySqlDbType.VarChar).Value = data;
            DB.command2.Parameters.Add("@stat", MySqlDbType.VarChar).Value = status;
            DB.command2.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

            if (DB.command2.ExecuteNonQuery() != 1)
            {
                DB.connection.Close();
                return;
            }

            string Starus_update_script2 = "UPDATE Info_Request SET status = @s WHERE request_id = @ID;";

            request.setStatus("запрос обработан");

            DB.command3 = new MySqlCommand(Starus_update_script2, DB.connection);
            DB.command3.Parameters.Add("@s", MySqlDbType.VarChar).Value = request.getStatus();
            DB.command3.Parameters.Add("@ID", MySqlDbType.Int32).Value = request.getID();

            if (DB.command3.ExecuteNonQuery() == 1)
            {
                DB.connection.Close();
            }
            else 
            {
                DB.connection.Close();
                return;
            }
        }

        /// <summary>
        /// \brief Метод изменения состояния устройства по его наименованию
        /// </summary>
        /// <param name="DB"></param>
        public void UpdateDeviceInfo(DataBase DB)
        {

            string script = "UPDATE Device SET ON_OFF = @ON_OFF WHERE device_id = @ID;";

            DB.connection.Open();

            DB.command = new MySqlCommand(script, DB.connection);
            DB.command.Parameters.Add("@ID", MySqlDbType.Int32).Value = this.ID;
            DB.command.Parameters.Add("@ON_OFF", MySqlDbType.Int16).Value = this.ON_OFF;

            DB.command.ExecuteNonQuery();

            DB.connection.Close();
        }
    }
}

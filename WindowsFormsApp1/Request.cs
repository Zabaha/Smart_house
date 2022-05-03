using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
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

        public Request(string status, string priority) 
        {
            this.status = status;
            this.priority = priority;
        }

        public string getStatus()
        {
            return status;
        }

        public int getID()
        {
            return ID;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public void setDevice(int deviceID)
        {
            device = deviceID;
        }
        public void setUser(int userID)
        {
            user = userID;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public bool uploadToDB(DataBase DB)
        {
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
            DB.command2 = new MySqlCommand(Get_ID_script, DB.connection);
            adapter.SelectCommand = DB.command2;
            adapter.Fill(table);

            ID = Convert.ToInt32(table.Rows[0][0]);

            if (DB.command2.ExecuteNonQuery() == 1)
            {
                DB.connection.Close();
                return true;
            }
            else
            {
                DB.connection.Close();
                return false;
            }
        }
    }
}

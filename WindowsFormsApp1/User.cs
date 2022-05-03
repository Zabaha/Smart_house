using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class User
    {
        protected int ID;
        protected string name;
        protected string surname;
        protected string patronymic;
        protected string role;
        protected string password;
        protected string loginAcc;

        public User() 
        {
        }

        public void authorization(string login, string password)
        {
            string script = "SELECT * FROM Authorization WHERE login = @log AND password = @pass;";

            DataBase DB = new DataBase();
            DB.connection.Open();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(script, DB.connection);
            DB.command = new MySqlCommand(script, DB.connection);
            DB.command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            DB.command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = DB.command;
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                DB.connection.Close();
                MessageBox.Show("Ошибка");
            }

            string Authorization_script = "SELECT * FROM Users WHERE user_id = @ID;";

            DataTable Authorize_table = new DataTable();
            MySqlDataAdapter Authorize_adapter = new MySqlDataAdapter(Authorization_script, DB.connection);
            DB.command2 = new MySqlCommand(Authorization_script, DB.connection);
            DB.command2.Parameters.Add("@ID", MySqlDbType.Int32).Value = Convert.ToInt32(table.Rows[0][0]);

            Authorize_adapter.SelectCommand = DB.command2;
            Authorize_adapter.Fill(Authorize_table);

            this.ID = Convert.ToInt32(Authorize_table.Rows[0][0]);
            this.loginAcc = login;
            this.password = password;
            this.surname = Convert.ToString(Authorize_table.Rows[0][2]);
            this.name = Convert.ToString(Authorize_table.Rows[0][3]);
            this.patronymic = Convert.ToString(Authorize_table.Rows[0][4]);
            this.role = Convert.ToString(Authorize_table.Rows[0][5]);
        }

        public void setID(int ID) 
        {
            this.ID = ID;
        }

        public void setRegFormInfo1(string loginAcc, string password) 
        {
            this.loginAcc = loginAcc;
            this.password = password;
        }

        public void setRegFormInfo2(string name, string surname, string patronymic, string role) 
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.role = role;
        }

        public int GetID()
        {
            return this.ID;
        }

        public string GetLoginAcc()
        {
            return this.loginAcc;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetPatronymic()
        {
            return this.patronymic;
        }

        public string GetRole()
        {
            return this.role;
        }
    }
}

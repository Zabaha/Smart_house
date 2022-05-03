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
    public partial class RegForm1 : Form
    {
        SuperUser admin = new SuperUser();

        /// <summary>
        /// \brief Конструктор для запуска первой экранной формы регистрации 
        /// </summary>
        public RegForm1()
        {
            InitializeComponent();
            loginfield.Text = "Введите логин";
            loginfield.ForeColor = Color.Gray;
            passfield.Text = "Введите пароль";
            passfield.ForeColor = Color.Gray;
            passfield.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// \brief Конструктор для переопределения
        /// </summary>
        /// <param name="admin"></param>
        public RegForm1(SuperUser admin)
        {
            InitializeComponent();
            loginfield.Text = "Введите логин";
            loginfield.ForeColor = Color.Gray;
            passfield.Text = "Введите пароль";
            passfield.ForeColor = Color.Gray;
            passfield.UseSystemPasswordChar = false;
            this.admin = admin;
        }


        private void loginfield_Enter(object sender, EventArgs e)
        {
            if (loginfield.Text == "Введите логин")
            {
                loginfield.Text = "";
                loginfield.ForeColor = Color.Black;
            }
        }

        private void loginfield_Leave(object sender, EventArgs e)
        {
            if (loginfield.Text == "")
            {
                loginfield.Text = "Введите логин";
                loginfield.ForeColor = Color.Gray;
            }
        }

        private void passfield_Enter(object sender, EventArgs e)
        {
            if (passfield.Text == "Введите пароль")
            {
                passfield.Text = "";
                passfield.ForeColor = Color.Black;
                passfield.UseSystemPasswordChar = true;
            }
        }

        private void passfield_Leave(object sender, EventArgs e)
        {
            if (passfield.Text == "")
            {
                passfield.Text = "Введите пароль";
                passfield.ForeColor = Color.Gray;
                passfield.UseSystemPasswordChar = false;
            }
        }
       

        private void login_button_Click(object sender, EventArgs e)
        {

            if (loginfield.Text == "Введите логин")
            {
                MessageBox.Show("Логин не может быть пустым"); 
                return;
            }

            if (passfield.Text == "Введите пароль")
            {
                MessageBox.Show("Пароль не может быть пустым"); 
                return;
            }

            User newUser = new User();
            newUser.setRegFormInfo1(loginfield.Text, passfield.Text);
            DataBase DB = new DataBase();

            if (DB.isUserExist(newUser))
                return;

            if (admin.RegistrationForm1(newUser, DB))
            {
                this.Hide();
                RegForm2 regform = new RegForm2(newUser, DB, admin);
                regform.Show();
            }
            else
                MessageBox.Show("Аккаунт не был создан");
        }
    }
}
